import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MtHealthyExportComponent } from './mt-healthy-export.component';

describe('MtHealthyExportComponent', () => {
  let component: MtHealthyExportComponent;
  let fixture: ComponentFixture<MtHealthyExportComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MtHealthyExportComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MtHealthyExportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
