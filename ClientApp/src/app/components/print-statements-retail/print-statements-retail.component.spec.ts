import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrintStatementsRetailComponent } from './print-statements-retail.component';

describe('PrintStatementsRetailComponent', () => {
  let component: PrintStatementsRetailComponent;
  let fixture: ComponentFixture<PrintStatementsRetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrintStatementsRetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrintStatementsRetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
