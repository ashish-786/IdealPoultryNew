import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { User, Settings, Userhierarchy, loginstatus, } from '../models';

@Injectable({ providedIn: 'root' })
export class UserService {
  constructor(private http: HttpClient) {
  }

  
}
