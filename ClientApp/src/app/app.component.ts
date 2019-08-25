import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { AuthenticationService, UserService, AlertService, UtilityService } from './services';
import { Userinformation, Settings, AlertNotification, } from './models';
import { PanelMenuModule } from 'primeng/panelmenu';
import { MenuItem } from 'primeng/api';
import { UserIdleService } from 'angular-user-idle';
import { Subscription } from 'rxjs';

@Component({ selector: 'app', templateUrl: 'app.component.html' })
export class AppComponent implements OnInit, OnDestroy {
  currentUser: Userinformation = new Userinformation();
  items: MenuItem[];
  workingStatus: boolean=true;
  labelWidth: number = 40;
  offText: string = "On Break";
  onText: string = "Working";
  expandMenu: boolean = true;
  //isProgress: boolean = false;
  userSubscribe: Subscription;

  constructor(
    private router: Router,
    private authenticationService: AuthenticationService,
    private userService: UserService,
    private alertService: AlertService,
    private utilityService: UtilityService,
    private userIdle: UserIdleService,
  ) {
    this.setCurrentUser();
  }

  //onProgressStarted() {
  //  this.isProgress = true;
  //}

  //onProgressCompleted() {
  //  this.isProgress = false;
  //}


  setCurrentUser() {
    this.userSubscribe = this.authenticationService.currentUserInfo.subscribe(x => {
      this.currentUser = x != null && x.length > 0 ? x[0] : null;
      if (this.currentUser != null) {
        this.workingStatus = Settings.loginStatus.LoggedIn;
        /**
         * timed follow up has been disabled because we are having agent queue in the system and
         * this has been done by below task: (Remove Follow-Up Alert from LMS [https://app.clickup.com/t/vhqya])
         * 
         **/
        //this.initiatefollowups();
        this.userIdle.onTimeout().subscribe(() => {
          this.manualLogoutUser();         
        });
      }
    });
  }

 

  toggleMenu() {
    this.expandMenu = !this.expandMenu; 
  }

  menuOperations(event: any) {
    this.expandMenu = !event;
  }

   ngOnInit() {
    this.setMenuCollapse();
    this.router.events.subscribe((evt) => {
      if (!(evt instanceof NavigationEnd)) {
        return;
      }
      window.scrollTo(0, 0)
    });  
  }

 
  setMenuCollapse() {
    if (window.innerWidth <= 1366) {
      this.expandMenu = false;
    }
  }

  ngOnDestroy() {
    this.userSubscribe.unsubscribe();
  }

  manualLogoutUser() {
    
  }

  logout() {
    this.authenticationService.logout();
    this.userIdle.stopTimer();
    this.userIdle.stopWatching();
    this.router.navigate(['/login']);     
  }
  onValueChange(event: any) {
   
  }

  getUpdatedUserInfo() {
   
  }

 

  toggleNotifications() {
   
  }
    
}
