import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportsTrialBalanceComponent } from './reports-trial-balance.component';

describe('ReportsTrialBalanceComponent', () => {
  let component: ReportsTrialBalanceComponent;
  let fixture: ComponentFixture<ReportsTrialBalanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReportsTrialBalanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportsTrialBalanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
