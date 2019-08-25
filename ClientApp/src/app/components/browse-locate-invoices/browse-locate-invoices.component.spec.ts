import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BrowseLocateInvoicesComponent } from './browse-locate-invoices.component';

describe('BrowseLocateInvoicesComponent', () => {
  let component: BrowseLocateInvoicesComponent;
  let fixture: ComponentFixture<BrowseLocateInvoicesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BrowseLocateInvoicesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BrowseLocateInvoicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
