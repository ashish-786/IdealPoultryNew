import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

import { AuthenticationService } from '../services';
import { MockerService } from '../services/mocker.service';
import { Settings } from '../models';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
  constructor(private authenticationService: AuthenticationService, private mocker: MockerService) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (Settings.isMockEnable) {
      request = this.mocker.getMockFor(request);
    }
    // add authorization header with jwt token if available
    let currentUser = this.authenticationService.currentUserValue;
    if (currentUser && currentUser.token) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${currentUser.token}`
        }
      });
    }
    setTimeout(function () {
      window.localStorage.setItem('currenttimestamp', new Date().getTime().toString());
    }, 1000);
    return next.handle(request);
  }

  private getMockFor(url: string) {
    var mockResourcePath = "/assets/mockdata";
    var resourceURL = "";
    try {
      var relativePath = new URL(url);
      resourceURL = relativePath.pathname;
      var path = `${mockResourcePath}${resourceURL}.json`;
      return path;
    }
    catch (exc) {
      return url;
    }

  }
}
