import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HatcheryImportOrdersComponent } from './hatchery-import-orders.component';

describe('HatcheryImportOrdersComponent', () => {
  let component: HatcheryImportOrdersComponent;
  let fixture: ComponentFixture<HatcheryImportOrdersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HatcheryImportOrdersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HatcheryImportOrdersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
