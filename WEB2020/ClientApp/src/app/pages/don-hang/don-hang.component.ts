import { NbToastrService } from "@nebular/theme";
import { Khachhang } from "./../../@core/data/khachhang";
import { DataService } from "./../../@core/mock/data.service";
import { DataSourceService } from "./../../services/data.service";
import { GiaoDichRequest } from "./../../@core/data/giaodichRequest";
import { Router } from "@angular/router";
import { NbAuthJWTToken, NbAuthService } from "@nebular/auth";
import { Component, OnInit, ViewChild } from "@angular/core";
import { OrderService } from "../../@core/mock/order.service";
import { DatePipe } from "@angular/common";
import { Giaodich } from "../../@core/data/giaodich";
import { Giaodichct } from "../../@core/data/giaodichct";
import { NbGlobalPhysicalPosition, NbPopoverDirective } from "@nebular/theme";

@Component({
  selector: "ngx-don-hang",
  templateUrl: "./don-hang.component.html",
  styleUrls: ["./don-hang.component.scss"],
})
export class DonHangComponent implements OnInit {
  user: any;
  trangThai = "1";
  tuNgayDate = this.datePipe.transform(new Date(Date.now()), "yyyy-MM-dd");
  denNgayDate = this.datePipe.transform(new Date(Date.now()), "yyyy-MM-dd");
  giaodichRequest: GiaoDichRequest;
  giaodichs$: any;
  giaodichcts: Giaodichct[];
  tongTienCK: number = 0;
  tongTienHang: number = 0;
  tongThanhTien: number = 0;

  isLoading = false;
  khachHangs: Khachhang[];
  @ViewChild(NbPopoverDirective) popover;
  constructor(
    private authService: NbAuthService,
    private router: Router,
    private orderService: OrderService,
    private datePipe: DatePipe,
    private data: DataSourceService,
    private dataService: DataService,
    private dataSourceService: DataSourceService,
    private toastrService: NbToastrService
  ) {}

  ngOnInit(): void {
    this.authService.getToken().subscribe((token: NbAuthJWTToken) => {
      if (token.isValid()) {
        this.user = token.getPayload(); // here we receive a payload from the token and assigns it to our `user` variable
        //console.log(this.user.unique_name)
        //console.log(this.user);
      } else {
        this.router.navigate(["/auth/login"]);
      }
    });
    this.giaodichRequest = new GiaoDichRequest();
    this.load();
  }
  load() {
    this.dataSourceService.currentNgayFilter.subscribe((d) => {
      this.tuNgayDate = d[0];
      this.denNgayDate = d[1];
    });
    this.isLoading = true;
    // this.tongThanhTien = 0;
    // this.tongTienCK = 0;
    // this.tongTienHang = 0;

    this.giaodichRequest.tuNgay = this.tuNgayDate.toString();
    this.giaodichRequest.denNgay = this.denNgayDate.toString();
    this.giaodichRequest.trangThai = this.trangThai;
    this.giaodichRequest.maNhanVien = "";
    const orders = this.orderService.getOrders(this.giaodichRequest);
    orders.subscribe((d) => {
      this.giaodichs$ = d;
      this.isLoading = false;
      this.giaodichs$.forEach((element) => {
        this.tongThanhTien = this.tongThanhTien + parseFloat(element.thanhtien);
        this.tongTienCK = this.tongTienCK + parseFloat(element.tienck);
        this.tongTienHang = this.tongTienHang + parseFloat(element.tienhang);
      });
    });
  }
  btnLocClicked() {
    this.isLoading = true;
    // this.tongThanhTien = 0;
    // this.tongTienCK = 0;
    // this.tongTienHang = 0;

    this.giaodichRequest.tuNgay = this.tuNgayDate.toString();
    this.giaodichRequest.denNgay = this.denNgayDate.toString();
    this.giaodichRequest.trangThai = this.trangThai;
    this.giaodichRequest.maNhanVien = "";
    const orders = this.orderService.getOrders(this.giaodichRequest);
    orders.subscribe((d) => {
      this.tongThanhTien = 0;
      this.tongTienHang = 0;
      this.tongTienCK = 0;
      this.giaodichs$ = d;
      this.isLoading = false;
      this.giaodichs$.forEach((element) => {
        this.tongThanhTien = this.tongThanhTien + parseFloat(element.thanhtien);
        this.tongTienCK = this.tongTienCK + parseFloat(element.tienck);
        this.tongTienHang = this.tongTienHang + parseFloat(element.tienhang);
      });
    });
    this.dataSourceService.changeNgayFilter(
      this.tuNgayDate.toString(),
      this.denNgayDate.toString()
    );
    this.popover.hide();
  }
  btnChiTietDonHangClicked(magiaodichpk) {
    if (magiaodichpk) {
      this.luuGiaoDichTrongService(magiaodichpk);
      this.router.navigate(["/chi-tiet-don-hang"], {
        queryParams: { query: magiaodichpk },
      });
    }
  }

  luuGiaoDichTrongService(magiaodichpk) {
    const giaoDich = this.giaodichs$.find(
      (d) => d.magiaodichpk === magiaodichpk
    );
    this.data.changeGiaoDich(giaoDich);
  }
  loadTenKhachHang(makhachhang) {
    try {
      this.khachHangs = this.dataService.dmKhachhang;
      return this.khachHangs.find((d) => d.makhachhang === makhachhang)
        .tenkhachhang;
    } catch (error) {}
  }

  onDeleteConfirm(magiaodichpk) {
    const xoa = window.confirm(
      "Bạn có xoá đơn hàng: " + magiaodichpk + " không?"
    );
    if (xoa) {
      this.orderService.deleteOrder(magiaodichpk).subscribe((d: any) => {
        if (d.iSsuccess === true)
          this.toastrService.show(
            "Thành công!",
            "Xoá đơn hàng! " + magiaodichpk,
            {
              position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
              status: "success",
            }
          );
        else {
          this.toastrService.show("Không thành công!", "Lỗi " + d.message, {
            position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
            status: "warning",
          });
        }
        this.load();
      });
    }
  }
}
