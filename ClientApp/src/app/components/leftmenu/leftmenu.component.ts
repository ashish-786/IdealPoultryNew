import { Component, OnInit, Input, Output, EventEmitter, OnDestroy } from '@angular/core';
import { AuthenticationService, UtilityService } from '../../services';
import { Router, ActivatedRoute } from '@angular/router';
import { Userinformation } from '../../models';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-leftmenu',
  templateUrl: './leftmenu.component.html',
  styleUrls: ['./leftmenu.component.css']
})
export class LeftmenuComponent implements OnInit, OnDestroy {
  currentUser: Userinformation;
  expandMenu: boolean = true;
  @Output() menuStatus = new EventEmitter<boolean>();
  susbscription: Subscription;
  showFiles: boolean = false;
  showProducts: boolean = false;
  showBreeds: boolean = false;
  showOrders: boolean = false;
  showEDIDocuments: boolean = false;
  showHatcheryNetwork: boolean = false;
  showTractorSupply: boolean = false;
  showMurrayMcMurrayEDI: boolean = false;
  showExport: boolean = false;
  showAccounting: boolean = false;
  showPrintStatements: boolean = false;
  showReports: boolean = false;
  showCreditCards: boolean = false;
  showAllReports: boolean = false;
  showItemReports: boolean = false;
  showOrderReports: boolean = false;
  showDateProcesses: boolean = false;
  showAvailability: boolean = false;
  showMaintenance: boolean = false;
  showCustomer: boolean = false;
  showDropShip: boolean = false;
  showPricesheet: boolean = false;
  showCallLists: boolean = false;
  showMaintenanceTypes: boolean = false;
  showDeveloperMaintenance: boolean = false;
  showWebSite: boolean = false;
  showWebAvailability: boolean = false;
  showWaitList: boolean = false;


  constructor(private authenticationService: AuthenticationService, private utility: UtilityService, private route: ActivatedRoute, private router: Router) {
    this.susbscription = this.authenticationService.currentUserInfo.subscribe(x => {
      this.currentUser = x != null && x.length > 0 ? x[0] : null;
      if (this.currentUser != null) {
        this.assignPermissions();
      }
      console.log('current user in leftmenu: ' + JSON.stringify(this.currentUser));
    }
    );
  }
  ngOnDestroy() {
    this.susbscription.unsubscribe();
  }
  toggleMenu() {
    this.expandMenu = !this.expandMenu;
    this.menuStatus.emit(this.expandMenu);
  }

  assignPermissions() {

  }

  navigate() {

  }

  ngOnInit() {

  }

  toggleFile() {
    this.showFiles = !this.showFiles;
  }

  toggleProducts() {
    this.showProducts = !this.showProducts;
  }

  toggleBreeds() {
    this.showBreeds = !this.showBreeds;
  }

  toggleOrders() {
    this.showOrders = !this.showOrders;
  }

  toggleEDIDocuments() {
    this.showEDIDocuments = !this.showEDIDocuments;
  }

  toggleHatcheryNetwork() {
    this.showHatcheryNetwork = !this.showHatcheryNetwork;
  }

  toggleTractorSupply() {
    this.showTractorSupply = !this.showTractorSupply;
  }

  toggleMurrayMcMurrayEDI() {
    this.showMurrayMcMurrayEDI = !this.showMurrayMcMurrayEDI;
  }

  toggleExport() {
    this.showExport = !this.showExport;
  }

  toggleAccounting() {
    this.showAccounting = !this.showAccounting;
  }
  togglePrintStatements() {
    this.showPrintStatements = !this.showPrintStatements;
  }
  toggleReports() {
    this.showReports = !this.showReports;
  }

  toggleCreditCards() {
    this.showCreditCards = !this.showCreditCards;
  }

  toggleAllReports() {
    this.showAllReports = !this.showAllReports;
  }
  toggleItemReports() {
    this.showItemReports = !this.showItemReports;

  }
  toggleOrderReports() {
    this.showOrderReports = !this.showOrderReports;
  }

  toggleDateProcesses() {
    this.showDateProcesses = !this.showDateProcesses;
  }
  toggleAvailability() {
    this.showAvailability = !this.showAvailability;
  }

  toggleMaintenance() {
    this.showMaintenance = !this.showMaintenance
  }

  toggleCustomer() {
    this.showCustomer = !this.showCustomer
  }

  toggleDropShip() {
    this.showDropShip = !this.showDropShip
  }

  togglePricesheet() {
    this.showPricesheet = !this.showPricesheet
  }
  toggleCallLists() {
    this.showCallLists = !this.showCallLists
  }

  toggleMaintenanceTypes() {
    this.showMaintenanceTypes = !this.showMaintenanceTypes
  }

  toggleDeveloperMaintenance() {
    this.showDeveloperMaintenance = !this.showDeveloperMaintenance
  }

  toggleWebSite() {
    this.showWebSite = !this.showWebSite
  }

  toggleWebAvailability() {
    this.showWebAvailability = !this.showWebAvailability
  }
  toggleWaitList() {
    this.showWaitList = !this.showWaitList
  }

}
