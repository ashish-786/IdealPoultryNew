import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExportsCustomerHistoryComponent } from './exports-customer-history.component';

describe('ExportsCustomerHistoryComponent', () => {
  let component: ExportsCustomerHistoryComponent;
  let fixture: ComponentFixture<ExportsCustomerHistoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExportsCustomerHistoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExportsCustomerHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
