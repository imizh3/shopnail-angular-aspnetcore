import { DataService } from "./../../@core/mock/data.service";
import { getCartCt } from "./../../@store/selectors/cart-selectors";
import { Giaodichct, giaodichctFields } from "./../../@core/data/giaodichct";
import { CartService } from "./../../@core/mock/cart.service";
import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Store } from "@ngrx/store";
import { AppState } from "../../@store/app-state";
import { CartActions } from "../../@store/actions/cart-actions";
import { giaodichFields } from "../../@core/data/giaodich";
import { getCart } from "../../@store/selectors/cart-selectors";
import { Observable, of } from "rxjs";
import { Khachhang } from "../../@core/data/khachhang";

@Component({
  selector: "ngx-cart",
  templateUrl: "./cart.component.html",
  styleUrls: ["./cart.component.scss"],
})
export class CartComponent implements OnInit {
  hadData: boolean;
  firstForm: FormGroup;
  secondForm: FormGroup;
  thirdForm: FormGroup;
  fouthForm: FormGroup;
  product$: Observable<Giaodichct[]>;
  tongSoLuong: number;
  tongTienHang: number;
  tongCkTrenDon: number;
  tongDon: number;
  chietKhau: number;
  tienChietKhau: number;
  txtChotDon: string;
  txtIcon: string;
  sdt: number;
  constructor(
    private fb: FormBuilder,
    private store: Store<AppState>,
    private action: CartActions,
    private cartService: CartService,
    private dataService: DataService
  ) {}

  ngOnInit() {
    this.txtChotDon = "Tiếp theo";
    this.txtIcon = "arrow-circle-right-outline";
    this.hadData = this.isHadData();
    this.secondForm = this.fb.group({
      tenkhachhang: ["", Validators.required],
      dienthoai: [
        "",
        [
          Validators.required,
          Validators.minLength(10),
          Validators.pattern(/(([0-9]{2})+([0-9]{8})\b)/g),
        ],
      ],
      diachigiaohang: ["", Validators.required],
      ghichu: [""],
    });
    this.product$ = this.store.select(getCartCt);
    this.product$.subscribe((d) => {
      this.tongSoLuong = 0;
      this.chietKhau = 0;
      this.tongTienHang = 0;
      this.tienChietKhau = 0;
      this.tongCkTrenDon = 0;
      if (d) {
        for (let i = 0; i < d.length; i++) {
          this.tienChietKhau = this.tienChietKhau + d[i].tienck;
          this.tongSoLuong = this.tongSoLuong + d[i].soluong;
          this.tongCkTrenDon = this.tongCkTrenDon + d[i].tiencktrendon;
          this.tongTienHang = this.tongTienHang + d[i].tienhang;
          this.chietKhau = d[i].tylecktrendon;
        }
      }
      this.tongDon =
        this.tongTienHang - this.tienChietKhau - this.tongCkTrenDon;
    });
  }

  onFirstStepNext(stepper) {
    this.hadData = this.isHadData();
    if (this.isHadData()) {
      stepper.next();
    } else {
      this.hadData = this.isHadData();
    }
  }
  onSecondStepNext(stepper) {
    stepper.next();
    this.txtChotDon = "Chốt Đơn";
    this.txtIcon = "shopping-cart-outline";
  }
  onSecondSubmit(stepper) {
    if (typeof this.secondForm.value.tenkhachhang === "string") {
      let khachhang = new Khachhang();
      khachhang.diachi = this.secondForm.get("diachigiaohang").value;
      khachhang.dienthoai = this.secondForm.get("dienthoai").value;
      khachhang.tenkhachhang = this.secondForm.get("tenkhachhang").value;
      this.tenkhachhang.setValue(khachhang);
    }
    if (this.secondForm.valid === true) {
      this.store.dispatch(
        this.action.addItemSuccess({
          order: this.cartService.updateCart(
            giaodichFields.khachhang,
            this.secondForm.value
          ),
        })
      );
      this.cartService.createOrder().subscribe((result: any) => {
        // tslint:disable-next-line: no-console
        console.log(result);
        if (result.iSsuccess) {
          this.store.dispatch(this.action.createOrderSuccess());
          stepper.next();
          localStorage.removeItem("order");
          this.dataService.LoadData();
        }
      });
    }
    this.secondForm.markAsDirty();
  }

  onChangeKhachHang(value) {
    if (value) {
      this.secondForm.patchValue({ dienthoai: value.dienthoai });
      this.secondForm.patchValue({ diachigiaohang: value.diachi });
    }
  }

  isHadData(): boolean {
    const order = JSON.parse(localStorage.getItem("order"));
    if (order === null || order.giaodichct.length === 0) {
      return false;
    } else {
      return true;
    }
  }
  updateCk(ck: number) {
    this.chietKhau = ck;
    if (this.chietKhau > 100)
      this.cartService.updateCktrendon(
        giaodichctFields.tiencktrendon,
        this.chietKhau
      );
    else
      this.cartService.updateCktrendon(
        giaodichctFields.tylecktrendon,
        this.chietKhau
      );
  }

  btnMuaSamClicked(stepper) {
    if (stepper.selectedIndex === 0) {
      this.onFirstStepNext(stepper);
    } else if (stepper.selectedIndex === 2) {
      this.onSecondSubmit(stepper);
    } else if (stepper.selectedIndex === 1) {
      this.onSecondStepNext(stepper);
    }
  }

  btnBackClicked(btnBack) {
    this.txtChotDon = " Tiếp theo";
    this.txtIcon = "arrow-circle-right-outline";
  }

  btnDuyetkhuyenmai() {
    this.cartService.duyetKM();
  }

  get tenkhachhang() {
    return this.secondForm.get("tenkhachhang");
  }
  get dienthoai() {
    return this.secondForm.get("dienthoai");
  }

  get diachigiaohang() {
    return this.secondForm.get("diachigiaohang");
  }
}
