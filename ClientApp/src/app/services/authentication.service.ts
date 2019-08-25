import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, from } from 'rxjs';
import { map } from 'rxjs/operators';

import { User, Settings } from '../models';
import { Userinformation } from '../models/userinformation';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
  private currentUserSubject: BehaviorSubject<User>;
  private currentUserInfoSubject: BehaviorSubject<Userinformation[]>;
  public currentUser: Observable<User>;
  public currentUserInfo: Observable<Userinformation[]>;

    constructor(private http: HttpClient) {
      this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
      this.currentUserInfoSubject = new BehaviorSubject<Userinformation[]>(JSON.parse(localStorage.getItem('currentUserInfo')));
      this.currentUser = this.currentUserSubject.asObservable();
      this.currentUserInfo = this.currentUserInfoSubject.asObservable();
    }

    public get currentUserValue(): User {
        return this.currentUserSubject.value;
  }

  public get currentUserInfoValue(): Userinformation[] {
    return this.currentUserInfoSubject.value;
  }

  login(username: string, password: string) {
    var model = {      
      "Username": username,
      "Password": password
    };
    return this.http.post<any>('users/authenticate', model)
            .pipe(map(user => {
                // login successful if there's a jwt token in the response
                if (user && user.token) {
                    // store user details and jwt token in local storage to keep user logged in between page refreshes
                    localStorage.setItem('currentUser', JSON.stringify(user));
                    this.currentUserSubject.next(user);
                }
                return user;
            }));
  }

  userinformation(userid: number) {
    return this.http.get<Userinformation[]>(`users/GetUserInfo?userid=` + userid)
      .pipe(map(user => {
        localStorage.setItem('currentUserInfo', JSON.stringify(user));
        this.currentUserInfoSubject.next(user);
        return user;
      }));
  }



    logout() {
        // remove user from local storage to log user out
      localStorage.removeItem('currentUser');
      localStorage.removeItem('currentUserInfo');      
      this.currentUserSubject.next(null);
      this.currentUserInfoSubject.next(null);
    }
}
