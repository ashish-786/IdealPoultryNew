import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchProductBreedsComponent } from './search-product-breeds.component';

describe('SearchProductBreedsComponent', () => {
  let component: SearchProductBreedsComponent;
  let fixture: ComponentFixture<SearchProductBreedsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SearchProductBreedsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchProductBreedsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
