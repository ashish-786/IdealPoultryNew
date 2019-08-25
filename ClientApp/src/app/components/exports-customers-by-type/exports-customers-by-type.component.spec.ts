import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExportsCustomersByTypeComponent } from './exports-customers-by-type.component';

describe('ExportsCustomersByTypeComponent', () => {
  let component: ExportsCustomersByTypeComponent;
  let fixture: ComponentFixture<ExportsCustomersByTypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExportsCustomersByTypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExportsCustomersByTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
