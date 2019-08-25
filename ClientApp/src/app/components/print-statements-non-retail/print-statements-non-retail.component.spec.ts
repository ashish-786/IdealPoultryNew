import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrintStatementsNonRetailComponent } from './print-statements-non-retail.component';

describe('PrintStatementsNonRetailComponent', () => {
  let component: PrintStatementsNonRetailComponent;
  let fixture: ComponentFixture<PrintStatementsNonRetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrintStatementsNonRetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrintStatementsNonRetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
