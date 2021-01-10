import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'ngx-quantity',
  templateUrl: './quantity.component.html',
  styleUrls: ['./quantity.component.scss']
})
export class QuantityComponent implements OnInit {

  constructor() { }
  rowData: any;

  @Output() save: EventEmitter<any> = new EventEmitter();

  onModelChange(table) {
    this.save.emit({ data: this.rowData, value: table });

  }
  ngOnInit(): void {
  }
  giamSoluong() {
    this.save.emit({ data: this.rowData, value: this.rowData.soluong - 1 });
  }
  tangSoluong() {
    this.save.emit({ data: this.rowData, value: this.rowData.soluong + 1 });
  }
}
