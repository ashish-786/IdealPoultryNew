import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrivettHatcheryExportComponent } from './privett-hatchery-export.component';

describe('PrivettHatcheryExportComponent', () => {
  let component: PrivettHatcheryExportComponent;
  let fixture: ComponentFixture<PrivettHatcheryExportComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrivettHatcheryExportComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrivettHatcheryExportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
