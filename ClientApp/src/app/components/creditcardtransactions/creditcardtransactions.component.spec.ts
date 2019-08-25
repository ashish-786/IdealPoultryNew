import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreditcardtransactionsComponent } from './creditcardtransactions.component';

describe('CreditcardtransactionsComponent', () => {
  let component: CreditcardtransactionsComponent;
  let fixture: ComponentFixture<CreditcardtransactionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreditcardtransactionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreditcardtransactionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
