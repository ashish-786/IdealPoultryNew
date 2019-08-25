import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BreedSortOrderComponent } from './breed-sort-order.component';

describe('BreedSortOrderComponent', () => {
  let component: BreedSortOrderComponent;
  let fixture: ComponentFixture<BreedSortOrderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BreedSortOrderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BreedSortOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
