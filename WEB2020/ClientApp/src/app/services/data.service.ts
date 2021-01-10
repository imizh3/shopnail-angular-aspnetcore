import { DatePipe } from "@angular/common";
import { Giaodich } from "./../@core/data/giaodich";
import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class DataSourceService {
  giaoDichSource = new BehaviorSubject<Giaodich>(new Giaodich());
  ngayFilter = new BehaviorSubject<any>([
    this.datePipe.transform(new Date(Date.now()), "yyyy-MM-dd"),
    this.datePipe.transform(new Date(Date.now()), "yyyy-MM-dd"),
  ]);
  currentGiaoDich = this.giaoDichSource.asObservable();
  currentNgayFilter = this.ngayFilter.asObservable();
  constructor(private datePipe: DatePipe) {}
  changeGiaoDich(giaoDich) {
    this.giaoDichSource.next(giaoDich);
  }
  changeNgayFilter(tuNgay, denNgay) {
    this.ngayFilter.next([tuNgay, denNgay]);
  }
}
