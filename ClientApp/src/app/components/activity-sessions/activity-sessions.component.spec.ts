import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActivitySessionsComponent } from './activity-sessions.component';

describe('ActivitySessionsComponent', () => {
  let component: ActivitySessionsComponent;
  let fixture: ComponentFixture<ActivitySessionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActivitySessionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActivitySessionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
