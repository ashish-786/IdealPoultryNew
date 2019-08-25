import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home';
import { LoginComponent } from './components/login';
import { AuthGuard } from './guards';
import { CustomerSearchComponent } from './components/customer-search/customer-search.component';
import { NewCustomerComponent } from './components/new-customer/new-customer.component';
import { ProductSearchComponent } from './components/product-search/product-search.component';
import { NewProductComponent } from './components/new-product/new-product.component';
import { SearchProductBreedsComponent } from './components/search-product-breeds/search-product-breeds.component';
import { BreedMaintainanceComponent } from './components/breed-maintainance/breed-maintainance.component';
import { OrderSearchComponent } from './components/order-search/order-search.component';
import { RolodexSearchComponent } from './components/rolodex-search/rolodex-search.component';
import { RolodexMaintainanceComponent } from './components/rolodex-maintainance/rolodex-maintainance.component';
 
const appRoutes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'customersearch', component: CustomerSearchComponent },
  { path: 'newcustomer', component: NewCustomerComponent },
  { path: 'productsearch', component: ProductSearchComponent },
  { path: 'newproduct', component: NewProductComponent },
  { path: 'searchproductbreed', component: SearchProductBreedsComponent },
  { path: 'newproductbreed', component: BreedMaintainanceComponent },
  { path: 'ordersearch', component: OrderSearchComponent },
  { path: 'rolodexsearch', component: RolodexSearchComponent },
  { path: 'rolodexmaintainance', component: RolodexMaintainanceComponent }
];

export const routing = RouterModule.forRoot(appRoutes);
