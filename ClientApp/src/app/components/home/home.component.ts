import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { first } from 'rxjs/operators';
import { Userinformation, AlertNotification } from '../../models';
import { UserService, AuthenticationService, UtilityService } from '../../services';

@Component({ selector: 'home', templateUrl: 'home.component.html' })
export class HomeComponent implements OnInit, OnDestroy {
    currentUser: Userinformation;
  currentUserSubscription: Subscription;
  users: Userinformation[] = [];

    constructor(
      private authenticationService: AuthenticationService,
      private router: Router,
      private userService: UserService,
      private utility: UtilityService
    ) {
      this.currentUserSubscription = this.authenticationService.currentUserInfo.subscribe(user => {
        this.currentUser = user != null && user.length > 0 ? user[0] : null;
        if (this.currentUser != null) {
          this.NavigateToLandingPage();
        }
        else {
          this.logOut();
        }
        console.log('current user in home: ' + JSON.stringify(this.currentUser)); 
        });
    }

  

    ngOnInit() {
      // this.loadAllUsers();
    }

    ngOnDestroy() {
        // unsubscribe to ensure no memory leaks
        this.currentUserSubscription.unsubscribe();
    }

    deleteUser(id: number) {        
  }
  logOut() {
    this.authenticationService.logout();
    this.router.navigate(['/login']);
  }

  NavigateToLandingPage() {   
      
  }

  

    
}
