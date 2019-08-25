import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule }    from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { PanelMenuModule } from 'primeng/panelmenu';
import { DialogModule } from 'primeng/dialog';
import { TabViewModule } from 'primeng/tabview';
import { GridModule, PageService, SortService, FilterService, GroupService, SearchService, ToolbarService } from '@syncfusion/ej2-angular-grids';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { InputSwitchModule } from 'primeng/inputswitch';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { PickListModule } from 'primeng/picklist';
import { DropdownModule } from 'primeng/dropdown';
import { DataViewModule } from 'primeng/dataview';
import { routing } from './app.routing';
import { CalendarModule } from 'primeng/calendar';
import { TableModule } from 'primeng/table';
import { UiSwitchModule } from 'ngx-ui-switch';
import { UserIdleModule } from 'angular-user-idle';
//import { NgProgressModule, NgProgressInterceptor } from 'ngx-progressbar';
import { NgxUiLoaderModule } from 'ngx-ui-loader';
import { JwBootstrapSwitchNg2Module } from 'jw-bootstrap-switch-ng2';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { AlertComponent } from './components/alert';
import { JwtInterceptor, ErrorInterceptor } from './helpers';
import { HomeComponent } from './components/home';
import { LoginComponent } from './components/login';
import { LeftmenuComponent } from './components/leftmenu/leftmenu.component';
import { INRCurrencyPipe } from './pipes/currency.pipe';
import { INRCurrencyDirective } from './directives/currency.directive';
import { NumberDirective } from './directives/numbers-only.directive';
import { DatePipe } from '@angular/common';
import { ConfirmationService } from 'primeng/components/common/api';
import { enableProdMode } from '@angular/core';
import { environment } from './models/settings';
import { LoaderInterceptorService } from './services/loader-interceptor-service.service';
import { from } from 'rxjs';
import { NgxMaskModule } from 'ngx-mask';
import { DialogComponent } from './components/dialog/dialog.component';
import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
import { ToastrModule } from 'ngx-toastr';
import { CustomerSearchComponent } from './components/customer-search/customer-search.component';
import { NewCustomerComponent } from './components/new-customer/new-customer.component';
import { ProductSearchComponent } from './components/product-search/product-search.component';
import { NewProductComponent } from './components/new-product/new-product.component';
import { ProductSearchOrderComponent } from './components/product-search-order/product-search-order.component';
import { SearchProductBreedsComponent } from './components/search-product-breeds/search-product-breeds.component';
import { BreedMaintainanceComponent } from './components/breed-maintainance/breed-maintainance.component';
import { BreedSortOrderComponent } from './components/breed-sort-order/breed-sort-order.component';
import { OrderSearchComponent } from './components/order-search/order-search.component';
import { OrderEntryComponent } from './components/order-entry/order-entry.component';
import { OrderDatesComponent } from './components/order-dates/order-dates.component';
import { RolodexSearchComponent } from './components/rolodex-search/rolodex-search.component';
import { RolodexMaintainanceComponent } from './components/rolodex-maintainance/rolodex-maintainance.component';
import { HatcheryImportOrdersComponent } from './components/hatchery-import-orders/hatchery-import-orders.component';
import { PrivettHatcheryExportComponent } from './components/privett-hatchery-export/privett-hatchery-export.component';
import { MtHealthyExportComponent } from './components/mt-healthy-export/mt-healthy-export.component';
import { TractorSupplyImportPOComponent } from './components/tractor-supply-import-po/tractor-supply-import-po.component';
import { TractorSupplyExportInvoiceComponent } from './components/tractor-supply-export-invoice/tractor-supply-export-invoice.component';
import { MurrayImportOrdersComponent } from './components/murray-import-orders/murray-import-orders.component';
import { MurrayExportShippingDocComponent } from './components/murray-export-shipping-doc/murray-export-shipping-doc.component';
import { MoyerExportComponent } from './components/moyer-export/moyer-export.component';
import { WebOrdersComponent } from './components/web-orders/web-orders.component';
import { ExportsCustomersByTypeComponent } from './components/exports-customers-by-type/exports-customers-by-type.component';
import { ExportsCustomersByPricesheetComponent } from './components/exports-customers-by-pricesheet/exports-customers-by-pricesheet.component';
import { ExportsCustomerHistoryComponent } from './components/exports-customer-history/exports-customer-history.component';
import { SendGlobalMessageComponent } from './components/send-global-message/send-global-message.component';
import { ActivitySessionsComponent } from './components/activity-sessions/activity-sessions.component';
import { BrowseLocateInvoicesComponent } from './components/browse-locate-invoices/browse-locate-invoices.component';
import { CalculateFinanceChargesComponent } from './components/calculate-finance-charges/calculate-finance-charges.component';
import { PrintStatementsAllComponent } from './components/print-statements-all/print-statements-all.component';
import { PrintStatementsNonRetailComponent } from './components/print-statements-non-retail/print-statements-non-retail.component';
import { PrintStatementsRetailComponent } from './components/print-statements-retail/print-statements-retail.component';
import { ReportsTrialBalanceComponent } from './components/reports-trial-balance/reports-trial-balance.component';
import { ReportsSFTrialBalanceComponent } from './components/reports-sftrial-balance/reports-sftrial-balance.component';
import { DetailedTrialBalanceComponent } from './components/detailed-trial-balance/detailed-trial-balance.component';
import { DistributionComponent } from './components/distribution/distribution.component';
import { DollarSalesSummaryComponent } from './components/dollar-sales-summary/dollar-sales-summary.component';
import { DelinquincyComponent } from './components/delinquincy/delinquincy.component';
import { CreditcardtransactionsComponent } from './components/creditcardtransactions/creditcardtransactions.component';

if (environment.production) {
  enableProdMode();
}
 
@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    PanelMenuModule,
    DialogModule,
    TabViewModule,
    GridModule,
    RouterModule,
    InputSwitchModule,
    FormsModule,
    NgMultiSelectDropDownModule.forRoot(),
    AutoCompleteModule,
    PickListModule,
    TableModule,
    DropdownModule,
    DataViewModule,
    NgxMaskModule.forRoot(),
    routing,
    CalendarModule,
    JwBootstrapSwitchNg2Module,
    //NgProgressModule,
    NgxUiLoaderModule,
    UiSwitchModule,
    ConfirmDialogModule,
    UserIdleModule.forRoot({ idle: 3600, timeout: 300, ping: 120 }),
    ToastrModule.forRoot()
  ],
  declarations: [
    AppComponent,
    AlertComponent,
    HomeComponent,
    LoginComponent,
    LeftmenuComponent,
    INRCurrencyDirective,
    NumberDirective,
    INRCurrencyPipe,
    DialogComponent,
    CustomerSearchComponent,
    NewCustomerComponent,
    ProductSearchComponent,
    NewProductComponent,
    ProductSearchOrderComponent,
    SearchProductBreedsComponent,
    BreedMaintainanceComponent,
    BreedSortOrderComponent,
    OrderSearchComponent,
    OrderEntryComponent,
    OrderDatesComponent,
    RolodexSearchComponent,
    RolodexMaintainanceComponent,
    HatcheryImportOrdersComponent,
    PrivettHatcheryExportComponent,
    MtHealthyExportComponent,
    TractorSupplyImportPOComponent,
    TractorSupplyExportInvoiceComponent,
    MurrayImportOrdersComponent,
    MurrayExportShippingDocComponent,
    MoyerExportComponent,
    WebOrdersComponent,
    ExportsCustomersByTypeComponent,
    ExportsCustomersByPricesheetComponent,
    ExportsCustomerHistoryComponent,
    SendGlobalMessageComponent,
    ActivitySessionsComponent,
    BrowseLocateInvoicesComponent,
    CalculateFinanceChargesComponent,
    PrintStatementsAllComponent,
    PrintStatementsNonRetailComponent,
    PrintStatementsRetailComponent,
    ReportsTrialBalanceComponent,
    ReportsSFTrialBalanceComponent,
    DetailedTrialBalanceComponent,
    DistributionComponent,
    DollarSalesSummaryComponent,
    DelinquincyComponent,
    CreditcardtransactionsComponent
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: LoaderInterceptorService,
      multi: true
    },
    //{ provide: HTTP_INTERCEPTORS, useClass: NgProgressInterceptor, multi: true },
    PageService, SortService, FilterService, GroupService, SearchService, ToolbarService,
    INRCurrencyPipe, DatePipe, ConfirmationService
  ],
  bootstrap: [AppComponent]

})

export class AppModule { }
