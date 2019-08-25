import { TestBed } from '@angular/core/testing';

import { LoaderInterceptorService } from './loader-interceptor-service.service';

describe('LoaderInterceptorServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LoaderInterceptorService = TestBed.get(LoaderInterceptorService);
    expect(service).toBeTruthy();
  });
});
