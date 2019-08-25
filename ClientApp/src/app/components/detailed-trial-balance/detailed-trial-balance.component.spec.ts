import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailedTrialBalanceComponent } from './detailed-trial-balance.component';

describe('DetailedTrialBalanceComponent', () => {
  let component: DetailedTrialBalanceComponent;
  let fixture: ComponentFixture<DetailedTrialBalanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetailedTrialBalanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailedTrialBalanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
