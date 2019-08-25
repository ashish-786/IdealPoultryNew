import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BreedMaintainanceComponent } from './breed-maintainance.component';

describe('BreedMaintainanceComponent', () => {
  let component: BreedMaintainanceComponent;
  let fixture: ComponentFixture<BreedMaintainanceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BreedMaintainanceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BreedMaintainanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
