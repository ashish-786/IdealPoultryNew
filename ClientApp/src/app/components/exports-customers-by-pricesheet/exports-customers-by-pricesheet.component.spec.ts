import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExportsCustomersByPricesheetComponent } from './exports-customers-by-pricesheet.component';

describe('ExportsCustomersByPricesheetComponent', () => {
  let component: ExportsCustomersByPricesheetComponent;
  let fixture: ComponentFixture<ExportsCustomersByPricesheetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExportsCustomersByPricesheetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExportsCustomersByPricesheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
