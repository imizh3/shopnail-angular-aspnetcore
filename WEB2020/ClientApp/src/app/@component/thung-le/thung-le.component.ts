import { Component, ElementRef, Input, OnInit, Output, EventEmitter, ViewChild } from '@angular/core';

@Component({
  selector: 'app-thung-le',
  templateUrl: './thung-le.component.html',
  styleUrls: ['./thung-le.component.scss']
})
export class ThungLeComponent implements OnInit {
  @Input() value: string;
  @Output() onEditThungLe = new EventEmitter();
  @ViewChild('thung') thung: ElementRef;
  @ViewChild('le') le: ElementRef;
  constructor() { }

  ngOnInit() {
  }

  onThungLe(even) {
    this.onEditThungLe.emit(this.thung.nativeElement.value + '/' + this.le.nativeElement.value);
  }

}
