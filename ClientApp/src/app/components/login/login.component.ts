import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first, window } from 'rxjs/operators';
import { AlertService, AuthenticationService, UserService } from '../../services';
import { Userinformation, Settings } from '../../models';
import { UserIdleService } from 'angular-user-idle';
import { Subscription } from 'rxjs';

@Component({
  templateUrl: 'login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {
  loginForm: FormGroup;
  loading = false;
  submitted = false;
  returnUrl: string;
  loginStatus: boolean = false;
  currentUser: Userinformation = new Userinformation();
  userSubscribe: Subscription;
  multipleLogin: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService,
    private alertService: AlertService,
    private userService: UserService,
    private userIdle: UserIdleService,
  ) {
    // redirect to home if already logged in
    if (this.authenticationService.currentUserValue && authenticationService.currentUserInfoValue && authenticationService.currentUserInfoValue.length>0) {
      this.router.navigate(['/']);
    }
  }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
      rememberme: [],
    });

    // get return url from route parameters or default to '/'
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  }

  ngOnDestroy() {
  }

  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }

  manualLogoutUser() {

  }

  onSubmit() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.loginForm.invalid) {
      return;
    }

    this.loading = true;
    this.authenticationService.login(this.f.username.value, this.f.password.value)
      .pipe(first())
      .subscribe(
      data => {
        if (data != null) {
          let service = this;
          service.getUserInfo(11);
        
        }       
        else {
          this.loginStatus = true;
          this.loading = false;
        }
        },
        error => {
          this.loginStatus = true;
          this.loading = false;
        });
  }

  getUserInfo(userid: number) {
    this.authenticationService.userinformation(userid)
      .pipe(first())
      .subscribe(
      u => {
        this.userIdle.startWatching();
        this.userIdle.onTimerStart().subscribe(c => console.log(c));       
        this.NavigateToLandingPage();
        this.loading = false;
      },
      error => {
       // this.alertService.error(error);
        this.loading = false;
      }
    )
   
  }
 

  NavigateToLandingPage() {
    this.router.navigate(['/home']);
  }
}
