import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MurrayImportOrdersComponent } from './murray-import-orders.component';

describe('MurrayImportOrdersComponent', () => {
  let component: MurrayImportOrdersComponent;
  let fixture: ComponentFixture<MurrayImportOrdersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MurrayImportOrdersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MurrayImportOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
