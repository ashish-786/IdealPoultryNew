import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RolodexSearchComponent } from './rolodex-search.component';

describe('RolodexSearchComponent', () => {
  let component: RolodexSearchComponent;
  let fixture: ComponentFixture<RolodexSearchComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RolodexSearchComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RolodexSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
