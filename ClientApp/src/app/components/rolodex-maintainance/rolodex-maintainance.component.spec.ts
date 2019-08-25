import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RolodexMaintainanceComponent } from './rolodex-maintainance.component';

describe('RolodexMaintainanceComponent', () => {
  let component: RolodexMaintainanceComponent;
  let fixture: ComponentFixture<RolodexMaintainanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RolodexMaintainanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RolodexMaintainanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
