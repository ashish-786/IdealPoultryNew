import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TractorSupplyExportInvoiceComponent } from './tractor-supply-export-invoice.component';

describe('TractorSupplyExportInvoiceComponent', () => {
  let component: TractorSupplyExportInvoiceComponent;
  let fixture: ComponentFixture<TractorSupplyExportInvoiceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TractorSupplyExportInvoiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TractorSupplyExportInvoiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
