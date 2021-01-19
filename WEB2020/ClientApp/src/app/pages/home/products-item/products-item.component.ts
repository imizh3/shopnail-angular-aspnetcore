import {
  Component,
  OnInit,
  Input,
  ChangeDetectionStrategy,
  ViewChild,
  ElementRef,
} from "@angular/core";
import {
  NbGlobalPhysicalPosition,
  NbIconLibraries,
  NbToastrService,
} from "@nebular/theme";
import { Store } from "@ngrx/store";
import { AppState } from "../../../@store/app-state";
import { CartActions } from "../../../@store/actions/cart-actions";
import { Product } from "../../../@core/data/product";
import { DataService } from "../../../@core/mock/data.service";
import { LIB } from "../../../@core/utils";

@Component({
  selector: "ngx-products-item",
  templateUrl: "./products-item.component.html",
  styleUrls: ["./products-item.component.scss"],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductsItemComponent implements OnInit {
  @Input() product: Product;
  @Input() dienGiaiKhuyenMai: string;
  baseUrl: string;
  soluong: number;
  sothung: number;
  sole: number;
  imageUrls: any[];
  constructor(
    iconsLibrary: NbIconLibraries,
    private store: Store<AppState>,
    private actions: CartActions,
    private toastrService: NbToastrService,
    private dataService: DataService,
    private lib: LIB
  ) {
    iconsLibrary.registerFontPack("fa", {
      packClass: "fa",
      iconClassPrefix: "fa",
    });
  }
  ngOnInit(): void {
    this.baseUrl = this.lib.baseUrl + "images";
    this.soluong = 1;
  }
  tangSoluong() {
    this.soluong++;
  }
  giamSoluong() {
    this.soluong--;
  }

  AddToCart() {
    // tslint:disable-next-line: radix
    const sothung = this.sothung ? this.sothung : 0;
    const sole = this.sole ? this.sole : 0;
    const quycach = this.product.quycach ? this.product.quycach : 1;
    this.soluong = sothung * quycach + sole;
    if (this.soluong <= 0) {
      // alert('số lượng đặt hàng không hợp lệ!');
      this.toastrService.show(
        "số lượng đặt hàng không hợp lệ!",
        "Không thêm được sản phẩm!",
        {
          position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
          status: "warning",
        }
      );
      return;
    }
    const giaodichct = {
      ...this.product,
      soluong: this.soluong,
    };
    this.store.dispatch(this.actions.addItem(giaodichct));
  }

  AddKmToCart() {
    // tslint:disable-next-line: radix
    const sothung = this.sothung ? this.sothung : 0;
    const sole = this.sole ? this.sole : 0;
    const quycach = this.product.quycach ? this.product.quycach : 1;
    this.soluong = sothung * quycach + sole;
    if (this.soluong <= 0) {
      // alert('số lượng đặt hàng không hợp lệ!');
      this.toastrService.show(
        "số lượng đặt hàng không hợp lệ!",
        "Không thêm được sản phẩm!",
        {
          position: NbGlobalPhysicalPosition.BOTTOM_RIGHT,
          status: "warning",
        }
      );
      return;
    }
    const giaodichct = {
      ...this.product,
      soluong: this.soluong,
      iskhuyenmai: true,
    };
    this.store.dispatch(this.actions.addItem(giaodichct));
  }

  setValue(soluong: string) {
    // tslint:disable-next-line: radix
    this.sole = parseInt(soluong);
  }

  setValueThung(soluong: string) {
    // tslint:disable-next-line: radix
    this.sothung = parseInt(soluong);
  }
  @ViewChild("soleid") btnAddToCart: ElementRef;
  sendTab(event) {
    if (event.keyCode === 13) {
      this.btnAddToCart.nativeElement.focus();
    }
  }

  getImage(fileName: string) {
    this.imageUrls = this.dataService.imageUrls;
    return this.imageUrls.find((d) => d.search(fileName) >= 0);
  }
}
