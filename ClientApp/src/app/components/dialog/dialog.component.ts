import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { ConfirmationService } from 'primeng/components/common/api';


@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css'],
  providers: [ConfirmationService]
})
export class DialogComponent implements OnInit {
  @Input() submitted: boolean;
  @Input() dirty: boolean;
  @Input() confirmLabel: string;
  @Input() denyLabel: string;
  @Output() response = new EventEmitter<string>();


  constructor(private confirmationService: ConfirmationService) { }

  ngOnInit() {
    
  }
  confirmation(message: string) {
    if (this.dirty) {
      this.confirmationService.confirm({
        message: message,
        key: 'ConfirmAction',
        accept: () => {
          this.response.emit("accept");
        },
        reject: () => {
          this.response.emit("reject");
        }
      });
    }
    else {
      this.response.emit("notDirty");
    }

  }
}
