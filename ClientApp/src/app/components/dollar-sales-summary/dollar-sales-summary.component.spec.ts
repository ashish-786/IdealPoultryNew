import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DollarSalesSummaryComponent } from './dollar-sales-summary.component';

describe('DollarSalesSummaryComponent', () => {
  let component: DollarSalesSummaryComponent;
  let fixture: ComponentFixture<DollarSalesSummaryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DollarSalesSummaryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DollarSalesSummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
