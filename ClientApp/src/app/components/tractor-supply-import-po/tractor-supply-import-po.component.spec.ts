import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TractorSupplyImportPOComponent } from './tractor-supply-import-po.component';

describe('TractorSupplyImportPOComponent', () => {
  let component: TractorSupplyImportPOComponent;
  let fixture: ComponentFixture<TractorSupplyImportPOComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TractorSupplyImportPOComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TractorSupplyImportPOComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
