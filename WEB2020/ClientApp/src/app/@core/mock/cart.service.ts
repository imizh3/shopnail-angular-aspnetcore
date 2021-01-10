import { Chuongtrinhkm } from './../data/chuongtrinhkm';
import { NbAuthJWTToken, NbAuthService } from '@nebular/auth';
import { AppState } from './../../@store/app-state';
import { Store } from '@ngrx/store';
import { TinhTien } from './../utils/tinhTien';
import { ProductService } from './product.service';
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Giaodich, giaodichFields } from '../data/giaodich';
import { Giaodichct, giaodichctFields } from '../data/giaodichct';
import { DataService } from './data.service';
import { CartActions } from './../../@store/actions/cart-actions';
import { Router } from '@angular/router';
import { Khuyenmaict } from '../data/khuyenmaict';
import { Product } from '../data/product';
import { NbGlobalPhysicalPosition, NbToastrService } from '@nebular/theme';
import { LIB } from '../utils';
import { Khachhang } from '../data/khachhang';
@Injectable({
  providedIn: 'root',
})
export class CartService {
  orderR: any;
  user: any;
  ctKhuyenmai: Chuongtrinhkm;
  constructor(
    private http: HttpClient,
    private lib: LIB,
    private productService: ProductService,
    private dataService: DataService,
    private stord: Store<AppState>,
    private cartAction: CartActions,
    private authService: NbAuthService,
    private router: Router,
    private toastrService: NbToastrService,
  ) {
    let order1 = JSON.parse(localStorage.getItem("order"));
    if (order1 === null) {
      this.stord.dispatch(
        this.cartAction.addItemSuccess({
          order: {},
        })
      );
    } else {
      this.stord.dispatch(
        this.cartAction.addItemSuccess({
          order: order1,
        })
      );
    }
    this.loadCtKhuyenMai();
  }

  loadCtKhuyenMai() {
    this.http.get<Chuongtrinhkm>(this.lib.baseUrl + 'api/Order/khuyenmai', this.lib.httpOption()).subscribe(
      (d) => this.ctKhuyenmai = d);
  }
  addItemToCart(_item: any) {
    // tslint:disable-next-line: no-console
    console.log(this.ctKhuyenmai);
    let giaodich = new Giaodich();
    const giaodichct = new Giaodichct();
    this.loadThongTinHangHoa(giaodichct, _item, 'masieuthi');
    this.LoadThongTinTaiKhoan(giaodichct);
    this.tinhToanTienHang(giaodichct, 'soluong', giaodichct.soluong);

    if (_item.iskhuyenmai) {
      this.tinhToanTienHang(giaodichct, giaodichctFields.dongiachuavat, 0);
    }

    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    if (giaodich.giaodichct && giaodich.giaodichct.length > 0) {
      let isNew = true;
      // tslint:disable-next-line: comment-format
      //update so luong
      giaodich.giaodichct.forEach(element => {
        if (element.masieuthi === giaodichct.masieuthi && element.iskhuyenmai === _item.iskhuyenmai) {
          this.loadThongTinHangHoa(element, _item, 'soluong');
          this.tinhToanTienHang(element, 'soluong', _item.soluong);
          if (_item.iskhuyenmai) {
            this.tinhToanTienHang(giaodichct, giaodichctFields.dongiachuavat, 0);
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

    // this.KMMOTSOSANPHAM(giaodich);

    this.authService.getToken().subscribe((token: NbAuthJWTToken) => {
      if (token.isValid()) {
        this.user = token.getPayload(); // here we receive a payload from the token and assigns it to our `user` variable
        giaodich.tendangnhap = this.user.unique_name;
        giaodich.tendangnhapsua = this.user.unique_name;
        giaodich.manhanviendathang = this.user.Manhanvien;
        giaodich.madonvi = this.user.Madonvi;
      } else {
        this.router.navigate(['/auth/login']);
      }
    });

    this.toastrService.show('Thành công!', 'Thêm sản phẩm!', { position: NbGlobalPhysicalPosition.BOTTOM_RIGHT, status: 'success' });

    localStorage.setItem('order', JSON.stringify(giaodich));

    return [giaodich];
  }

  duyetKM() {
    let giaodich = new Giaodich();
    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    this.http.post(this.lib.baseUrl + 'api/Order/Duyetkm', giaodich, this.lib.httpOption()).subscribe(
      (d: Giaodich) => {
        localStorage.setItem('order', JSON.stringify(d));
        this.stord.dispatch(this.cartAction.addItemSuccess({ order: d }));
      }
    );
  }

  updateItem(_item: Giaodichct, fields: string, value: any) {
    let giaodich = new Giaodich();
    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    if (giaodich.giaodichct && giaodich.giaodichct.length > 0) {
      giaodich.giaodichct.forEach(element => {
        if (element.masieuthi === _item.masieuthi && element.iskhuyenmai === _item.iskhuyenmai) {
          this.tinhToanTienHang(element, fields, value);
          if (_item.iskhuyenmai) {
            this.tinhToanTienHang(element, giaodichctFields.dongiachuavat, 0);
          }
        }
      });
    } else {
      giaodich.giaodichct = [];
      giaodich.giaodichct.push(_item);
    }

    localStorage.setItem('order', JSON.stringify(giaodich));

    return [giaodich];
  }

  updateCktrendon(fields: string, value: any) {
    let giaodich = new Giaodich();
    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    if (giaodich.giaodichct && giaodich.giaodichct.length > 0) {
      giaodich.giaodichct.forEach(element => {
        this.tinhToanTienHang(element, fields, value);
      });
    } else {
      giaodich.giaodichct = [];
    }

    localStorage.setItem('order', JSON.stringify(giaodich));
    this.stord.dispatch(this.cartAction.addItemSuccess({ order: giaodich }));
  }

  updateCart(fields: string, value: any) {
    let giaodich = new Giaodich();
    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }

    if (fields === giaodichFields.khachhang) {
      giaodich.diachigiaohang = value.diachigiaohang;
      giaodich.makhachhang = value?.tenkhachhang.makhachhang;
      giaodich.khachhang = {
        ...value?.tenkhachhang,
        dienthoai: value.dienthoai.toString(),
      };
      // giaodich.khachhang = value?.tenkhachhang;
      // giaodich.khachhang.dienthoai = value.dienthoai;
      giaodich.ghichu = value?.ghichu;
    }
    giaodich.trangthai = 1;
    giaodich.ngayhoadon = new Date(Date.now());
    giaodich.ngayphatsinh = new Date(Date.now());
    giaodich.ngaythanhtoan = new Date(Date.now());

    this.authService.getToken().subscribe((token: NbAuthJWTToken) => {
      if (token.isValid()) {
        this.user = token.getPayload(); // here we receive a payload from the token and assigns it to our `user` variable
        giaodich.tendangnhap = this.user.Tendangnhap;
        giaodich.tendangnhapsua = this.user.Tendangnhap;
        giaodich.manhanviendathang = this.user.Manhanvien;
        giaodich.madonvi = this.user.Madonvi;
      } else {
        this.router.navigate(['/auth/login']);
      }
    });
    localStorage.setItem('order', JSON.stringify(giaodich));
    return [giaodich];
  }

  getOrder() {
    this.orderR = [JSON.parse(localStorage.getItem('order'))];
    return this.orderR;
  }

  removeCartItem(gdChiTiet: Giaodichct) {
    let giaodich = new Giaodich();
    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    if (giaodich.giaodichct && giaodich.giaodichct.length > 0) {
      giaodich.giaodichct = giaodich.giaodichct.filter(
        item => JSON.stringify(item) !== JSON.stringify(gdChiTiet),
      );
    }
    // if (!gdChiTiet.iskhuyenmai)
    //   this.KMMOTSOSANPHAM(giaodich);
    localStorage.setItem('order', JSON.stringify(giaodich));
    this.toastrService.show('Thành công!', 'xoá sản phẩm!', { position: NbGlobalPhysicalPosition.BOTTOM_RIGHT, status: 'success' });
    return [giaodich];
  }

  createOrder() {
    let giaodich = new Giaodich();
    giaodich = JSON.parse(localStorage.getItem('order'));
    if (giaodich == null) {
      giaodich = new Giaodich();
    }
    return this.http.post(this.lib.baseUrl + 'api/Order/Create', giaodich, this.lib.httpOption());
  }

  loadThongTinHangHoa(gdChitiet: Giaodichct, item: any, fields: any) {
    if (fields === 'masieuthi') {
      gdChitiet.masieuthi = item.masieuthi;
      gdChitiet.mahangcuancc = item.mahangcuancc;
      gdChitiet.soluong = item.soluong;
      gdChitiet.tendaydu = item.tendaydu;
      gdChitiet.tenviettat = item.tenviettat;
      gdChitiet.dongiacovat = item.giabanbuoncovat;
      gdChitiet.dongiachuavat = item.giabanbuonchuavat;
      gdChitiet.dongiachuavatnt = item.giabanbuonchuavat;
      gdChitiet.dongiacovatnt = item.giabanbuoncovat;
      gdChitiet.quycach = item.quycach;
      gdChitiet.mavat = item.mavatban;
      gdChitiet.manganh = item.manganh;
      gdChitiet.iskhuyenmai = item.iskhuyenmai;
      gdChitiet.manhomhang = item.manhomhang;
      gdChitiet.tygia = 1;
      gdChitiet.mangoaite = 'VND';
      // tslint:disable-next-line: radix
      gdChitiet.giathungchuavat = parseInt(item.quycach) * gdChitiet.dongiachuavat;
    } else if (fields === 'soluong') {
      gdChitiet.soluong = item.soluong;
    }

  }

  tinhToanTienHang(gdChitiet: Giaodichct, fields: string, value: any) {
    if (fields === giaodichctFields.dongiachuavat) {
      const Dongiachuavat = parseFloat(value);
      const Giathungchuavat = Dongiachuavat * gdChitiet.quycach;
      gdChitiet.giathungchuavat = Giathungchuavat;
      gdChitiet.dongiachuavat = Dongiachuavat;
      gdChitiet.dongiacovat = Dongiachuavat;
      gdChitiet.dongiachuavatnt = gdChitiet.dongiachuavat;
      gdChitiet.dongiacovatnt = gdChitiet.dongiacovat;
    }
    if (fields === 'soluong') {
      gdChitiet.soluong = parseFloat(value);
      gdChitiet.sothung = TinhTien.ConverThungByLe(gdChitiet.soluong, gdChitiet.quycach);
    }
    if (fields === 'sothung') {
      gdChitiet.sothung = value;
      gdChitiet.soluong = TinhTien.ConverLeByThung(value, gdChitiet.quycach);
    }
    if (fields === 'tyleck') {
      gdChitiet.tyleck = value ? parseFloat(value) : 0;
      gdChitiet.tienck = TinhTien.TienChietKhauByGiaKhongVat(gdChitiet.dongiachuavat, gdChitiet.tyleck, gdChitiet.soluong);
    }

    if (fields === 'tienck') {
      gdChitiet.tienck = value ? parseFloat(value) : 0;
    }

    if (fields === 'tylecktrendon') {
      gdChitiet.tylecktrendon = parseFloat(value);
      // if (tinhCK == PublicValue.Luuthuc) {
      //   tienckphuxanh = Tienhang * tileckphuxanh / 100;
      // }
      gdChitiet.tiencktrendon = gdChitiet.thanhtien * gdChitiet.tylecktrendon / 100;
    }
    if (fields === 'tiencktrendon') {

      gdChitiet.tiencktrendon = parseFloat(value);
      if (gdChitiet.tienhang === 0) {
        gdChitiet.tylecktrendon = 0;
      } else {
        // if (tinhCK == PublicValue.Luuthuc) {
        //   tileckphuxanh = tienckphuxanh / Tienhang * 100;
        // }
        // else {
        gdChitiet.tylecktrendon = gdChitiet.tiencktrendon / gdChitiet.thanhtien * 100;
      }
    }

    // if (fields !== 'tienck')
    //   gdChitiet.tienck = TinhTien.TienChietKhauByGiaKhongVat(gdChitiet.dongiachuavat, gdChitiet.tyleck, gdChitiet.soluong);

    gdChitiet.tienhang = TinhTien.TienHangByDonGia(gdChitiet.dongiachuavat, gdChitiet.soluong);
    // tslint:disable-next-line: max-line-length
    gdChitiet.tienvat = TinhTien.TienVatByCongThuc(gdChitiet.tienhang, gdChitiet.tienck, this.dataService.dmVat, gdChitiet.mavat, 0);
    gdChitiet.doanhthu = TinhTien.DoanhThuByCongThuc(gdChitiet.tienhang, gdChitiet.tienck, gdChitiet.tienvat, gdChitiet.tiencktrendon, this.dataService.dmPtnx, this.dataService.thamsohethong.maptnx);
    // tslint:disable-next-line: max-line-length
    gdChitiet.thanhtien = TinhTien.ThanhTienByCongThuc(gdChitiet.tienhang, gdChitiet.tienck, gdChitiet.tienvat, gdChitiet.tiencktrendon, this.dataService.dmPtnx, this.dataService.thamsohethong.maptnx);
  }

  LoadThongTinTaiKhoan(gdChitiet: Giaodichct) {
    const rPtnx = this.dataService.dmPtnx.find(d => d.maptnx === this.dataService.thamsohethong.maptnx);
    if (rPtnx) {
      gdChitiet.matkco = rPtnx.matkcodf;
      gdChitiet.matkno = rPtnx.matknodf;
      gdChitiet.matkchietkhauco = rPtnx.matkchietkhaucodf;
      gdChitiet.matkchietkhauno = rPtnx.matkchietkhaunodf;
      gdChitiet.matkchiphikhacco = rPtnx.matkchiphikhaccodf;
      gdChitiet.matkchiphikhacno = rPtnx.matkchiphikhacnodf;
      gdChitiet.matkthuegtgtco = rPtnx.matkthuegtgtcodf;
      gdChitiet.matkthuegtgtno = rPtnx.matkthuegtgtnodf;
      gdChitiet.matkkhuyenmaico = rPtnx.matkkhuyenmaicodf;
      gdChitiet.matkkhuyenmaino = rPtnx.matkkhuyenmainodf;
      gdChitiet.matkgiavon = rPtnx.matkgiavondf;
      gdChitiet.matkvtu = rPtnx.matkvtudf;
    }
  }

  LoadThongtinTaikhoanKhuyenMai(gdChitiet: Giaodichct) {
    const rPtnx = this.dataService.dmPtnx.find(d => d.maptnx === this.dataService.thamsohethong.maptnx);
    if (rPtnx) {
      gdChitiet.matkco = rPtnx.matkcodf;
      gdChitiet.matkno = rPtnx.matknodf;
      gdChitiet.matkchietkhauco = rPtnx.matkchietkhaucodf;
      gdChitiet.matkchietkhauno = rPtnx.matkchietkhaunodf;
      gdChitiet.matkchiphikhacco = rPtnx.matkchiphikhaccodf;
      gdChitiet.matkchiphikhacno = rPtnx.matkchiphikhacnodf;
      gdChitiet.matkthuegtgtco = rPtnx.matkthuegtgtcodf;
      gdChitiet.matkthuegtgtno = rPtnx.matkthuegtgtnodf;
      gdChitiet.matkkhuyenmaico = rPtnx.matkkhuyenmaicodf;
      gdChitiet.matkkhuyenmaino = rPtnx.matkkhuyenmainodf;
      gdChitiet.matkgiavon = rPtnx.matkgiavondf;
      gdChitiet.matkvtu = rPtnx.matkvtudf;
    }
  }

  TinhtoanTienhangKhuyenmaiNhomMaxMin(datarview: Giaodichct, ColumnName: string, ValueColumn: any) {
    if (ColumnName === giaodichctFields.dongiachuavat) {
      datarview.dongiachuavat = ValueColumn;
      datarview.giathungchuavat = datarview.dongiachuavat * datarview.quycach;
    } else if (ColumnName === giaodichctFields.giathungchuavat) {
      datarview.giathungchuavat = ValueColumn;
      datarview.dongiachuavat = datarview.giathungchuavat / datarview.quycach;
    } else if (ColumnName === giaodichctFields.tienhang) {
      if (datarview.soluong > 0) {
        datarview.dongiachuavat = datarview.tienhang / datarview.soluong;
        datarview.giathungchuavat = datarview.dongiachuavat * datarview.quycach;
      }
    } else if (ColumnName === giaodichctFields.tyleck) {
      datarview.tyleck = ValueColumn;
    } else if (ColumnName === giaodichctFields.tienck) {
      datarview.tyleck = datarview.tienck / datarview.tienhang * 100;
    }
    datarview.tienck = TinhTien.TienChietKhauByGiaKhongVat(datarview.dongiachuavat, datarview.tyleck, datarview.soluong);

    datarview.tienhang = TinhTien.TienHangByDonGia(datarview.dongiachuavat, datarview.soluong);
    datarview.tienvat = TinhTien.TienVatByCongThuc(datarview.tienhang, datarview.tienck, this.dataService.dmVat, datarview.mavat, 0);
    // tslint:disable-next-line: max-line-length
    datarview.doanhthu = TinhTien.DoanhThuByCongThuc(datarview.tienhang, datarview.tienck, datarview.tienvat, 0, this.dataService.dmPtnx, this.dataService.thamsohethong.maptnx);
    datarview.thanhtien = TinhTien.ThanhTienByCongThuc(datarview.tienhang, datarview.tienck, datarview.tienvat, 0, this.dataService.dmPtnx, this.dataService.thamsohethong.maptnx);
  }

  TinhtoanTienhangKhuyenMai(datarview: Giaodichct, ColumnName: string, ValueColumn: any) {
    // tslint:disable-next-line: max-line-length
    let Soluong = 0, Quycach = 1, Dongiachuavat = 0, Dongiacovat = 0, Giathungchuavat = 0, Tyleck = 0, Tienck = 0, Tienvat = 0, Tienhang = 0, Thanhtien = 0, Doanhthu = 0;
    Soluong = datarview.soluong;
    Quycach = datarview.quycach;
    Dongiachuavat = datarview.dongiachuavat;
    Tyleck = datarview.tyleck;
    Tienck = datarview.tienck;
    Tienvat = datarview.tienvat;
    Tienhang = datarview.tienhang;
    Thanhtien = datarview.thanhtien;
    Giathungchuavat = datarview.giathungchuavat;

    if (ColumnName === giaodichctFields.soluong) {
      const rHanghoa = this.productService.products.find(p => p.masieuthi === datarview.masieuthi);
      if (rHanghoa) {
        Soluong = ValueColumn;
        Quycach = datarview.quycach;
        datarview.sothung = TinhTien.ConverThungByLe(Soluong, Quycach);
        datarview.soluong = Soluong;
      }
    } else if (ColumnName === giaodichctFields.dongiachuavat) {
      Dongiachuavat = ValueColumn;
      Giathungchuavat = Dongiachuavat * Quycach;
      datarview.giathungchuavat = Giathungchuavat;
      datarview.dongiachuavat = Dongiachuavat;
      datarview.dongiacovat = Dongiachuavat;
    }
    Tienhang = TinhTien.TienHangByDonGia(Dongiachuavat, Soluong);
    Tienvat = TinhTien.TienVatByCongThuc(Tienhang, Tienck, this.dataService.dmVat, datarview.mavat, 0);
    Doanhthu = TinhTien.DoanhThuByCongThuc(Tienhang, Tienck, Tienvat, 0, this.dataService.dmPtnx, this.dataService.thamsohethong.maptnx);
    Thanhtien = TinhTien.ThanhTienByCongThuc(Tienhang, Tienck, Tienvat, 0, this.dataService.dmPtnx, this.dataService.thamsohethong.maptnx);
    datarview.tienhang = Tienhang;
    datarview.tienck = Tienck;
    datarview.tienvat = Tienvat;
    datarview.doanhthu = Doanhthu;
    datarview.thanhtien = Thanhtien;
  }

  LoadThongtinHanghoaKhuyenMai(datarview: Giaodichct, ValueColumn: any, ColumnName: string) {
    let rHanghoa: Product;
    let giabanbuonchuavat = 0, Quycach = 1;
    let tileck = 0;
    if (ColumnName === giaodichctFields.masieuthi) {
      rHanghoa = this.productService.products.find(p => p.masieuthi === ValueColumn.masieuthi);
      if (rHanghoa) {
        giabanbuonchuavat = rHanghoa.giabanbuonchuavat;
        datarview.masieuthi = ValueColumn.masieuthi;
        datarview.mahangcuancc = rHanghoa.mahangcuancc;
        datarview.manganh = rHanghoa.manganh;
        datarview.manhomhang = rHanghoa.manhomhang;
        datarview.tendaydu = rHanghoa.tendaydu;
        datarview.dongiachuavat = giabanbuonchuavat;
        datarview.dongiacovat = giabanbuonchuavat;
        datarview.quycach = rHanghoa.quycach;
        datarview.mavat = rHanghoa.mavatmua;
        datarview.soluong = 0;
        datarview.tylecktrendon = 0;
        datarview.tiencktrendon = 0;
        datarview.tyleck = tileck;
        datarview.mabohang = '-';

      }
    }
    if (rHanghoa) {
      Quycach = rHanghoa.quycach;
      datarview.giathungchuavat = giabanbuonchuavat * Quycach;
      // decimal giavon = 0;
      // decimal toncuoiky = 0;
      // try {
      // tslint:disable-next-line: max-line-length
      //   DataRow rowGiavon = DB.XNT_Gettonkhomathang(PublicValue.DataBaseXnt, PublicValue.XNT_TABLENAME(PublicValue.ngayPhatSinh), makho, PublicValue.maDonVi, rHanghoa[MathangFields.Masieuthi).Rows[0];
      //   if (rowGiavon != null) {
      //     decimal.TryParse(rowGiavon[PublicValue.Giavon].ToString(), out giavon);
      //     decimal.TryParse(rowGiavon[PublicValue.Toncuoikysl].ToString(), out toncuoiky);
      //   }
      // }
      // catch { }
      // datarview.giavon = rHanghoa.;
    }
  }
}
