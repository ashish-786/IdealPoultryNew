import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MurrayExportShippingDocComponent } from './murray-export-shipping-doc.component';

describe('MurrayExportShippingDocComponent', () => {
  let component: MurrayExportShippingDocComponent;
  let fixture: ComponentFixture<MurrayExportShippingDocComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MurrayExportShippingDocComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MurrayExportShippingDocComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
