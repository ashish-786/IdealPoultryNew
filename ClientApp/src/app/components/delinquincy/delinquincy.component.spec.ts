import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DelinquincyComponent } from './delinquincy.component';

describe('DelinquincyComponent', () => {
  let component: DelinquincyComponent;
  let fixture: ComponentFixture<DelinquincyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DelinquincyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DelinquincyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
