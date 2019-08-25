import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrintStatementsAllComponent } from './print-statements-all.component';

describe('PrintStatementsAllComponent', () => {
  let component: PrintStatementsAllComponent;
  let fixture: ComponentFixture<PrintStatementsAllComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrintStatementsAllComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrintStatementsAllComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
