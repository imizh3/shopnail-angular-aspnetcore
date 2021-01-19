import { routes } from "./../../../auth/auth-routing.module";
import { CartService } from "./../../../@core/mock/cart.service";
import { ThemDonHangCtComponent } from "./../them-don-hang-ct/them-don-hang-ct.component";
import { FormControl } from "@angular/forms";
import {
  NbGlobalPhysicalPosition,
  NbToastrService,
  NbWindowRef,
  NbWindowService,
} from "@nebular/theme";
import { DataService } from "./../../../@core/mock/data.service";
import { Khachhang } from "./../../../@core/data/khachhang";
import { DataSourceService } from "./../../../services/data.service";

import { ProductService } from "./../../../@core/mock/product.service";
import { GiaoDichRequest } from "./../../../@core/data/giaodichRequest";
import { Observable } from "rxjs";
import { Giaodichct } from "./../../../@core/data/giaodichct";
import { OrderService } from "./../../../@core/mock/order.service";
import { Component, ElementRef, OnInit, ViewChild } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { filter, map } from "rxjs/operators";
import { Product } from "../../../@core/data/product";
import { Giaodich } from "../../../@core/data/giaodich";
import { TinhTien } from "../../../@core/utils/tinhTien";

@Component({
  selector: "ngx-don-hang-ct",
  templateUrl: "./don-hang-ct.component.html",
  styleUrls: ["./don-hang-ct.component.scss"],
})
export class DonHangCtComponent implements OnInit {
  isLoading = false;
  magiaodichpk: string;
  giaoDichRequest: GiaoDichRequest;
  giaodichcts$: Observable<any>;
  giaodichcts: Giaodichct[];
  products: Product[];
  giaoDich: Giaodich;
  khachHangs: Khachhang[];
  khachHang: Khachhang;
  isLuuThuc: boolean;
  txtGhichu: FormControl;
  txtDiachi: FormControl;
  txtDiachigiaohang: FormControl;
  @ViewChild("thung") thung: ElementRef;
  @ViewChild("le") le: ElementRef;
  constructor(
    private orderService: OrderService,
    private activatedRoute: ActivatedRoute,
    private productService: ProductService,
    private data: DataSourceService,
    private dataService: DataService,
    private windowService: NbWindowService,
    private toastrService: NbToastrService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.activatedRoute.queryParams
      .pipe(filter((params) => params.query))
      .subscribe((params) => {
        if (params.query) {
          this.magiaodichpk = params.query;
        }
      });
    this.products = this.productService.products;
    this.data.currentGiaoDich.subscribe((e) => {
      if (!e || e.makhachhang === "" || !e.makhachhang) {
        this.router.navigate(["/Don-hang"]);
      }
      this.giaoDich = e;
      if (this.giaoDich.trangthai === 1) {
        this.isLuuThuc = false;
      } else this.isLuuThuc = true;
      if (this.giaoDich.giaodichct && this.giaoDich.giaodichct.length > 0) {
        this.giaodichcts = this.giaoDich.giaodichct;
      }
    }); // lấy data Giao dịch hiện tại

    this.loadChiTietDonHang();
    this.loadKhachHang();
    this.txtGhichu = new FormControl();
    this.txtDiachi = new FormControl();
    this.txtDiachigiaohang = new FormControl();
    this.txtGhichu.setValue(this.giaoDich.ghichu);
    this.txtDiachi.setValue(this.khachHang.diachi);
    this.txtDiachigiaohang.setValue(this.khachHang.diachigiaohang);
  }

  loadChiTietDonHang() {
    this.isLoading = true;
    this.giaoDichRequest = new GiaoDichRequest();
    this.giaoDichRequest.magiaodichpk = this.magiaodichpk;
    this.giaodichcts$ = this.orderService.getOrderDetails(this.giaoDichRequest);

    this.giaodichcts$.subscribe((d: Giaodichct[]) => {
      this.giaodichcts = d.map((giaodichct) => {
        if (giaodichct.dongiacovat === 0) {
          return { ...giaodichct, iskhuyenmai: true };
        } else {
          return { ...giaodichct, iskhuyenmai: false };
        }
      });
      this.loadThungLe();
      this.giaoDich.giaodichct = this.giaodichcts;
      this.isLoading = false;
    });
  }
  loadProductName(masieuthi: string) {
    const product = this.products.find((d) => d.masieuthi === masieuthi);
    return product.tendaydu;
  }
  loadThungLe() {
    //this.giaodichcts = this.giaodichcts.filter((d) => d.dongiacovat !== 0);
    this.giaodichcts.forEach((element) => {
      const product = this.products.find(
        (d) => d.masieuthi === element.masieuthi
      );
      element.quycach = product.quycach;
      element.soluong = parseFloat(element.soluong.toString());
      element.sothung = TinhTien.ConverThungByLe(
        element.soluong,
        element.quycach
      );
      // console.log(element.sothung.indexOf("/"));
    });
  }
  onEditThungLe(giaodichct, value) {
    let editedGiaoDich = new Giaodich();
    editedGiaoDich = this.orderService.updateOrderDetail(
      giaodichct,
      "sothung",
      value,
      this.giaoDich
    );
  }

  loadKhachHang() {
    this.khachHangs = this.dataService.dmKhachhang;
    this.khachHang = this.khachHangs.find(
      (d) => d.makhachhang === this.giaoDich.makhachhang
    );

    if (
      this.khachHang.makhachhang === undefined ||
      this.khachHang.makhachhang === null
    ) {
      this.khachHang = new Khachhang();
    }
  }
  onEditConfirm(data: any, soluong: any) {
    const product = this.products.find((d) => d.masieuthi === data.masieuthi);
    const newData = { ...data, quycach: product.quycach };
    let editedGiaoDich = new Giaodich();
    editedGiaoDich = this.orderService.updateOrderDetail(
      newData,
      "soluong",
      soluong.target.value,
      this.giaoDich
    );
  }
  onDeleteConfirm(giaodichct: any) {
    const newGiaoDich = this.orderService.removeOrderDetail(
      giaodichct,
      this.giaoDich
    );
    this.data.changeGiaoDich(newGiaoDich);
    this.giaodichcts = this.giaoDich.giaodichct;
  }
  btnMuaThemClicked() {
    this.windowService.open(ThemDonHangCtComponent, {
      title: "Thêm mặt hàng mua",
    });
  }
  onEditTyleck(data: any, field: string, ck: any): void {
    const product = this.products.find((d) => d.masieuthi === data.masieuthi);
    const newData = { ...data, quycach: product.quycach };
    let editedGiaoDich = new Giaodich();
    editedGiaoDich = this.orderService.updateOrderDetail(
      newData,
      field,
      ck.target.value,
      this.giaoDich
    );
  }
  btnLuuDonClicked() {
    this.orderService
      .updateOrder({
        ...this.giaoDich,
        ghichu: this.txtGhichu.value,
        khachhang: {
          ...this.khachHang,
          diachi: this.txtDiachi.value,
          diachigiaohang: this.txtDiachigiaohang.value,
        },
      })
      .subscribe(
        (data) => {
          if (data.status === 200) {
            this.toastrService.show("Thành công!", "Lưu dữ liệu!", {
              position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
              status: "success",
            });
          } else {
            this.toastrService.show("Thất bại!", "Lưu dữ liệu!", {
              position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
              status: "danger",
            });
          }
        },
        // tslint:disable-next-line: no-console
        (error) => console.log(error)
      );
  }
  btnLuuThuc() {}
  btnDuyenKMClicked() {
    this.orderService.duyetKM(this.giaoDich);
    console.log(this.giaoDich);
  }
}
