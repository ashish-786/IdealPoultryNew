import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
//import { Leadschema } from '../models/leadschema';


@Injectable({
  providedIn: 'root'
})
export class MockerService {
  private mockResourcePath: string;
  constructor(private http: HttpClient) {
    this.mockResourcePath = "/assets/mockdata";
  }

  getMockFor(request: HttpRequest<any>): HttpRequest<any>
  {
    return request.clone({ url: this.getMockURL(request.url), method: 'GET' });
  }

  private getMockURL(url: string) {
    var mockResourcePath = "/assets/mockdata";
    var resourceURL = "";
    try {     
      if (url.indexOf('GetUserInfo?userid') > -1) {
        url = 'users/GetUserInfo';
      }
      else if (url.indexOf('getuserhierarchy?userid') > -1) {
        url = 'users/getuserhierarchy';
      }
    
      
      var path = `${mockResourcePath}/${url}.json`;
      return path;
    }
    catch (exc) {
      return url;
    }
  }
}
