import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SendGlobalMessageComponent } from './send-global-message.component';

describe('SendGlobalMessageComponent', () => {
  let component: SendGlobalMessageComponent;
  let fixture: ComponentFixture<SendGlobalMessageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SendGlobalMessageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SendGlobalMessageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
