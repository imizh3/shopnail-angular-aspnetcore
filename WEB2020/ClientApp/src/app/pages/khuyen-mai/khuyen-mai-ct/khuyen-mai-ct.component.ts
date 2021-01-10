import { ProductService } from "./../../../@core/mock/product.service";
import { Product } from "./../../../@core/data/product";
import { Khuyenmaict } from "./../../../@core/data/khuyenmaict";
import { DataService } from "./../../../@core/mock/data.service";
import { filter } from "rxjs/operators";
import { ActivatedRoute } from "@angular/router";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "ngx-khuyen-mai-ct",
  templateUrl: "./khuyen-mai-ct.component.html",
  styleUrls: ["./khuyen-mai-ct.component.scss"],
})
export class KhuyenMaiCtComponent implements OnInit {
  products: Product[];
  allProducts: Product[];
  dienGiaiKhuyenMai: string;
  khuyenMaiCts: Khuyenmaict[];
  constructor(
    private activatedRoute: ActivatedRoute,
    private data: DataService,
    private productService: ProductService
  ) {}

  ngOnInit(): void {
    this.allProducts = this.productService.products;
    this.activatedRoute.queryParams
      .pipe(filter((params) => params.query))
      .subscribe((params) => {
        this.loadChiTietKhuyenMai(params.query);
      });
  }
  loadChiTietKhuyenMai(query) {
    // lấy list khuyến mại chi tiết theo query : mã chương trình
    this.khuyenMaiCts = this.data.ctKhuyenMai.khuyenmaicts.filter(
      (d: Khuyenmaict) => d.machuongtrinh === query
    );
    console.log(this.khuyenMaiCts);
    // lấy products theo list khuyến mại chi tiết
    // this.products = this.allProducts.filter((d) => {
    //   return this.khuyenMaiCts.some((f) => {
    //     return f.masieuthiban === d.masieuthi;
    //   });
    // });
    // console.log(this.products);
  }
  loadDienGiaiKhuyenMai(masieuthi) {
    const khuyenMaiCt = this.khuyenMaiCts.find(
      (d) => d.masieuthiban === masieuthi
    );
    if (khuyenMaiCt) {
      if (khuyenMaiCt.soluongkm || khuyenMaiCt.soluongkm > 0) {
        return (this.dienGiaiKhuyenMai =
          "SL bán: " +
          khuyenMaiCt.soluongban +
          " => tặng: " +
          khuyenMaiCt.soluongkm +
          " " +
          this.getProductById(masieuthi).tendaydu);
      } else if (khuyenMaiCt.tilechietkhau || khuyenMaiCt.tienchietkhau > 0) {
        return (this.dienGiaiKhuyenMai =
          "SL bán: " +
          khuyenMaiCt.soluongban +
          " => tặng: " +
          khuyenMaiCt.tilechietkhau +
          " % chiết khấu ");
      } else {
        return (this.dienGiaiKhuyenMai =
          "SL bán: " +
          khuyenMaiCt.soluongban +
          " => tặng: " +
          khuyenMaiCt.tienchietkhau +
          " tiền chiết khấu");
      }
    }

    return this.dienGiaiKhuyenMai;
  }
  getProductById(masieuthi) {
    const product = this.allProducts.find((d) => d.masieuthi === masieuthi);
    return product;
  }
}
