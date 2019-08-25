import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductSearchOrderComponent } from './product-search-order.component';

describe('ProductSearchOrderComponent', () => {
  let component: ProductSearchOrderComponent;
  let fixture: ComponentFixture<ProductSearchOrderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductSearchOrderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductSearchOrderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
