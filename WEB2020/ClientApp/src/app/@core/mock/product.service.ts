import { AppState } from "./../../@store/app-state";
import { getProducts } from "./../../@store/selectors/product-selectors";
import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { map } from "rxjs/operators";
import { of, Observable } from "rxjs";
import { Product } from "../data/product";
import { Store } from "@ngrx/store";
import { LIB } from "../utils";

const TOTAL_PAGES = 7;
@Injectable({
  providedIn: "root",
})
export class ProductService {
  isLoading = false;
  products: Product[];
  products$: Observable<Product[]>;
  productResual: Product[];
  constructor(
    private http: HttpClient,
    private stord: Store<AppState>,
    private lib: LIB
  ) {
    this.Init();
  }

  Init(): void {
    this.LoadData("");
    this.stord.select(getProducts).subscribe((d) => (this.productResual = d));
  }

  LoadData(action: any) {
    this.products$ = this.http
      .get<Product[]>(this.lib.baseUrl + "api/products", this.lib.httpOption())
      .pipe((d) => d);
    this.products$.subscribe((d) => {
      this.products = d;
      this.productResual = d;
      this.isLoading = true;
    });
    return this.products$;
  }

  load(page: number, pageSize: number) {
    this.stord.select(getProducts).subscribe((d) => {
      this.productResual = d;
      //xay ra khi logout , login lai thi chua co products trong state
      if (this.productResual.length === undefined) {
        this.productResual = this.products;
      }
    });
    const startIndex = ((page - 1) % TOTAL_PAGES) * pageSize;
    if (startIndex > this.products.length) {
      return;
    }
    if (this.isLoading === false) {
      return this.products$.pipe(
        map((p) => p.sort()),
        map((news) => news.slice(startIndex, startIndex + pageSize - 1))
      );
    }

    return of(this.productResual).pipe(
      map((p) => p.sort()),
      map((news) => news.slice(startIndex, startIndex + pageSize - 1))
    );
  }

  getProducts(requet: any) {
    const nganhhang = requet.nganhhang;
    const nhomhang = requet.nhomhang;
    if (nganhhang && nhomhang) {
      const abcc = this.products.filter(
        (d: Product) => d.manhomhang === nhomhang
      );
      return of(abcc);
    } else if (nganhhang) {
      const abcc = this.products.filter(
        (d: Product) => d.manganh === nganhhang
      );
      return of(abcc);
    } else {
      const abcc = this.products;
      return of(abcc);
    }
  }

  getProductsByQuery(request: any) {
    const query = request.query;
    // tslint:disable-next-line: arrow-return-shorthand
    const products = this.products.filter((d: Product) => {
      return (
        d.tendaydu.toUpperCase().match(query.toUpperCase()) ||
        d.masieuthi.toUpperCase().match(query.toUpperCase()) ||
        d.mahangcuancc.toUpperCase().match(query.toUpperCase()) ||
        d.tenviettat.toUpperCase().match(query.toUpperCase()) ||
        this.xoa_dau(d.tendaydu.toUpperCase()).match(
          this.xoa_dau(query.toUpperCase())
        )
      );
    });
    return [products];
  }

  xoa_dau(str) {
    str = str.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g, "a");
    str = str.replace(/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g, "e");
    str = str.replace(/ì|í|ị|ỉ|ĩ/g, "i");
    str = str.replace(/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g, "o");
    str = str.replace(/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g, "u");
    str = str.replace(/ỳ|ý|ỵ|ỷ|ỹ/g, "y");
    str = str.replace(/đ/g, "d");
    str = str.replace(/À|Á|Ạ|Ả|Ã|Â|Ầ|Ấ|Ậ|Ẩ|Ẫ|Ă|Ằ|Ắ|Ặ|Ẳ|Ẵ/g, "A");
    str = str.replace(/È|É|Ẹ|Ẻ|Ẽ|Ê|Ề|Ế|Ệ|Ể|Ễ/g, "E");
    str = str.replace(/Ì|Í|Ị|Ỉ|Ĩ/g, "I");
    str = str.replace(/Ò|Ó|Ọ|Ỏ|Õ|Ô|Ồ|Ố|Ộ|Ổ|Ỗ|Ơ|Ờ|Ớ|Ợ|Ở|Ỡ/g, "O");
    str = str.replace(/Ù|Ú|Ụ|Ủ|Ũ|Ư|Ừ|Ứ|Ự|Ử|Ữ/g, "U");
    str = str.replace(/Ỳ|Ý|Ỵ|Ỷ|Ỹ/g, "Y");
    str = str.replace(/Đ/g, "D");
    return str;
  }
}
