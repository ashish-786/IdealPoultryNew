import { Injectable } from '@angular/core';
import { Router, CanActivate, CanDeactivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { ConfirmationService } from 'primeng/components/common/api';
import { AuthenticationService } from '../services';
import { Observable } from 'rxjs/Observable';
import { Observer } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
      private authenticationService: AuthenticationService,
      private confirmationService: ConfirmationService
    ) {}

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        const currentUser = this.authenticationService.currentUserValue;
        if (currentUser) {
            // authorised so return true
            return true;
        }

        // not logged in so redirect to login page with the return url
        this.router.navigate(['/login'], { queryParams: { returnUrl: state.url }});
        return false;
    }

  canDeactivate(): boolean {
    return false;
  }
}
