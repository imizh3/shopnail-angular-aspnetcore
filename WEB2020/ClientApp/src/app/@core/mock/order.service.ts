import { DataSourceService } from './../../services/data.service';
import { map } from 'rxjs/operators';
import { GiaoDichRequest } from './../data/giaodichRequest';
import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Giaodichct, giaodichctFields } from '../data/giaodichct';
import { Giaodich } from '../data/giaodich';
import { CartService } from './cart.service';
import { NbGlobalPhysicalPosition, NbToastrService } from '@nebular/theme';
import { LIB } from '../utils';

@Injectable({
  providedIn: 'root',
})
export class OrderService {
  baseUrl: string;
  responseStatus: number;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private cartService: CartService,
    private toastService: NbToastrService,
    private lib: LIB,
    private data: DataSourceService,
  ) {
    this.baseUrl = baseUrl;
  }

  getOrders(giaoDichRequest: GiaoDichRequest) {
    return this.http.post(
      this.baseUrl + 'api/Order/orders',
      giaoDichRequest,
      this.lib.httpOption(),
    );
  }
  // getOrderDetails(magiaodichpk: string) {
  // let params = new HttpParams();
  // params = params.append("magiaodichpk", magiaodichpk);
  // const query =' magiaodichpk = '+magiaodichpk;
  // const options = {
  //   headers: new HttpHeaders({
  //     "Content-Type": "application/json",
  //     Authorization: "my-auth-token",
  //   }),
  //   params: new HttpParams({
  //     fromString: query
  //   }),
  // };
  // const params = new HttpParams({
  //   fromString: "magiaodichpk = magiaodichpk",
  // });
  //   const giaoDichCts = this.http.get<Giaodichct[]>(
  //     this.baseUrl + "api/Order/orderDetails/"+ magiaodichpk
  //   );
  //   return giaoDichCts;
  // }
  getOrderDetails(giaoDichRequest: GiaoDichRequest) {
    const giaoDichCts$ = this.http.post(
      this.baseUrl + 'api/Order/orderDetails',
      giaoDichRequest,
      this.lib.httpOption(),
    );
    return giaoDichCts$;
  }

  updateOrder(giaoDich: Giaodich) {
    if (giaoDich == null) {
      giaoDich = new Giaodich();
    }
    return this.http.post(this.baseUrl + 'api/Order/Update', giaoDich, {
      ...this.lib.httpOption(),
      observe: 'response',
    });
  }
  // updateOrder(giaoDich: Giaodich) {
  //   if (giaoDich == null) {
  //     giaoDich = new Giaodich();
  //   }
  //   return this.http.post(
  //     this.baseUrl + "api/Order/Update",
  //     giaoDich,
  //     httpOptions
  //   );
  // }
  addOrderDetail(item: any, giaodich: Giaodich) {
    const giaodichct = new Giaodichct();
    this.cartService.loadThongTinHangHoa(giaodichct, item, 'masieuthi');
    this.cartService.LoadThongTinTaiKhoan(giaodichct);
    this.cartService.tinhToanTienHang(
      giaodichct,
      'soluong',
      giaodichct.soluong,
    );
    if (item.iskhuyenmai) {
      this.cartService.tinhToanTienHang(giaodichct, giaodichctFields.dongiachuavat, 0);
    }
    giaodichct.magiaodichpk = item.magiaodichpk;

    if (giaodich.giaodichct && giaodich.giaodichct.length > 0) {
      let isNew = true;
      // tslint:disable-next-line: comment-format
      //neu la mat hang da co trong don thi tang so luong mat hang do
      giaodich.giaodichct.forEach((element) => {
        if (
          element.masieuthi === giaodichct.masieuthi &&
          element.iskhuyenmai === item.iskhuyenmai
        ) {
          this.cartService.loadThongTinHangHoa(element, item, 'soluong');
          this.cartService.tinhToanTienHang(element, 'soluong', item.soluong);
          if (item.iskhuyenmai) {
            this.cartService.tinhToanTienHang(element, giaodichctFields.dongiachuavat, 0);
          }
          isNew = false;
        }
      });

      if (isNew) {
        giaodich.giaodichct.push(giaodichct);
      }
    } else {
      giaodich.giaodichct = [];
      giaodich.giaodichct.push(giaodichct);
    }

    this.toastService.show('Thành công!', 'Thêm sản phẩm!', {
      position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
      status: 'success',
    });

    return giaodich;
  }

  removeOrderDetail(gdChiTiet, giaoDich: Giaodich) {
    if (giaoDich == null) {
      giaoDich = new Giaodich();
    }
    if (giaoDich.giaodichct && giaoDich.giaodichct.length > 0) {
      giaoDich.giaodichct = giaoDich.giaodichct.filter(
        (item) => JSON.stringify(item) !== JSON.stringify(gdChiTiet),
      );
    }
    this.toastService.show('Thành công!', 'xoá sản phẩm!', {
      position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
      status: 'success',
    });
    return giaoDich;
  }

  updateOrderDetail(
    _item: Giaodichct,
    fields: string,
    value: any,
    giaodich: Giaodich,
  ) {
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    if (giaodich.giaodichct && giaodich.giaodichct.length > 0) {
      giaodich.giaodichct.forEach((element) => {
        if (
          element.masieuthi === _item.masieuthi &&
          element.iskhuyenmai === _item.iskhuyenmai
        ) {
          element.quycach = _item.quycach;
          this.cartService.tinhToanTienHang(element, fields, value);
          if (_item.iskhuyenmai) {
            this.cartService.tinhToanTienHang(element, giaodichctFields.dongiachuavat, 0);
          }
        }
      });
    } else {
      giaodich.giaodichct = [];
      giaodich.giaodichct.push(_item);
    }
    return giaodich;
  }

  duyetKM(giaodich: Giaodich) {
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    this.http
      .post(
        this.lib.baseUrl + 'api/Order/Duyetkm',
        giaodich,
        this.lib.httpOption(),
      )
      .subscribe((d: Giaodich) => {
        this.data.changeGiaoDich(d);
      });
  }
  deleteOrder(magiaodichpk: string) {
    let giaodich = new Giaodich();
    giaodich.magiaodichpk = magiaodichpk;
    return this.http
      .post(
        this.lib.baseUrl + 'api/Order/Delete',
        giaodich,
        this.lib.httpOption(),
      ).pipe(d => d);
  }
}
