import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportsSFTrialBalanceComponent } from './reports-sftrial-balance.component';

describe('ReportsSFTrialBalanceComponent', () => {
  let component: ReportsSFTrialBalanceComponent;
  let fixture: ComponentFixture<ReportsSFTrialBalanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReportsSFTrialBalanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportsSFTrialBalanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
