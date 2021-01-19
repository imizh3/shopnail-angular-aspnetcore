import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { filter, map } from "rxjs/operators";
import { Observable, of, pipe } from "rxjs";
import { List } from "immutable";
import { LIB } from "../utils";

@Injectable({
  providedIn: "root",
})
export class DataService {
  dmPtnx: any;
  dmVat: any;
  dmKhachhang: any;
  thamsohethong: any;
  ctKhuyenMai: any;
  imageUrls: any;
  constructor(private http: HttpClient, private lib: LIB) {
    this.LoadData();
  }

  LoadData() {
    this.http
      .get(this.lib.baseUrl + "api/getdata/dmptnx", this.lib.httpOption())
      .subscribe((d) => {
        this.dmPtnx = d;
      });
    this.http
      .get(this.lib.baseUrl + "api/getdata/dmvat", this.lib.httpOption())
      .subscribe((d) => {
        this.dmVat = d;
      });
    this.http
      .get(this.lib.baseUrl + "api/getdata/khachhangs", this.lib.httpOption())
      .subscribe((d) => {
        this.dmKhachhang = d;
      });
    this.http
      .get(
        this.lib.baseUrl + "api/getdata/thamsohethong",
        this.lib.httpOption()
      )
      .subscribe((d) => {
        this.thamsohethong = d;
      });
    this.http
      .get(this.lib.baseUrl + "api/Order/khuyenmai", this.lib.httpOption())
      .subscribe((d) => {
        this.ctKhuyenMai = d;
      });
    this.http
      .get(this.lib.baseUrl + "api/getdata/getImages", this.lib.httpOption())
      .subscribe((d) => {
        this.imageUrls = d;
      });
  }

  LoadKhachhang() {
    // return this.http.get(this.lib.baseUrl + 'api/getdata/khachhangs', this.lib.httpOption()).pipe(d => d);
    return of(this.dmKhachhang);
  }
}
