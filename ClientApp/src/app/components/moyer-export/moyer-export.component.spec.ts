import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MoyerExportComponent } from './moyer-export.component';

describe('MoyerExportComponent', () => {
  let component: MoyerExportComponent;
  let fixture: ComponentFixture<MoyerExportComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MoyerExportComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MoyerExportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
