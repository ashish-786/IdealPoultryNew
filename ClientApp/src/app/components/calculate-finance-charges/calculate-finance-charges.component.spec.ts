import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculateFinanceChargesComponent } from './calculate-finance-charges.component';

describe('CalculateFinanceChargesComponent', () => {
  let component: CalculateFinanceChargesComponent;
  let fixture: ComponentFixture<CalculateFinanceChargesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CalculateFinanceChargesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CalculateFinanceChargesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
