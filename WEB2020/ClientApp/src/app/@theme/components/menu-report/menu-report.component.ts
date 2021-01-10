import { OnDestroy } from "@angular/core";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { NbMenuItem, NbMenuService } from "@nebular/theme";
import { Store } from "@ngrx/store";
import { Observable, Subject } from "rxjs";
import { ProductActions } from "../../../@store/actions/product-actions";
import { AppState } from "../../../@store/app-state";

@Component({
  selector: "ngx-menu-report",
  templateUrl: "./menu-report.component.html",
  styleUrls: ["./menu-report.component.scss"],
})
export class MenuReportComponent implements OnInit, OnDestroy {
  menuFormDb: Observable<any>;
  menuItems: NbMenuItem[] = [
    {
      title: "Home",
      icon: "home-outline",
      link: "/Home",
      home: true,
    },
    {
      title: "Dashboard",
      icon: "pie-chart-outline",
      link: "/Report/bao-cao",
    },
  ];
  private destroy$ = new Subject<void>();

  constructor(
    private menuService: NbMenuService,
    private router: Router,
    private productAction: ProductActions,
    private store: Store<AppState>
  ) {}

  ngOnInit(): void {
    this.menuService.addItems(
      [
        {
          title: "Báo cáo nhập hàng",
          link: "/Report/bao-cao-nhap-mua",
          children: [
            {
              title: "Báo cáo nhập mua",
              link: "/Report/bao-cao-nhap-mua",
            },
            {
              title: "Báo cáo nhập trả lại",
              link: "/Report/bao-cao-nhap-tra-lai",
            },
          ],
        },
        {
          title: "Báo cáo xuất bán",
          link: "/Report/bao-cao-ban-hang-theo-nhan",
          children: [
            {
              title: "Báo cáo bán hàng theo nhãn",
              link: "/Report/bao-cao-ban-hang-theo-nhan",
            },
            {
              title: "Báo cáo hàng xuất trả",
              link: "/Report/bao-cao-hang-xuat-tra",
            },
          ],
        },
        {
          title: "Báo cáo tồn kho",
          link: "/Report/bao-cao-xnt",
          children: [
            {
              title: "Báo cáo Nhập - Xuất - Tồn",
              link: "/Report/bao-cao-xnt",
            },
            {
              title: "Báo cáo hàng tồn kho",
              link: "/Report/bao-cao-ton-kho",
            },
          ],
        },
        {
          title: "Báo cáo khuyến mại",
          link: "/Report/bao-cao-khuyen-mai-theo-ctr",
          children: [
            {
              title: "Báo cáo khuyến mại theo chtrình",
              link: "/Report/bao-cao-khuyen-mai-theo-ctr",
            },
            {
              title: "Báo cáo tổng hợp khuyến mại",
              link: "/Report/bao-cao-tong-hop-km",
            },
          ],
        },
        {
          title: "Báo cáo công nợ",
          link: "/Report/bao-cao-cong-no-ncc",
          children: [
            {
              title: "Báo cáo công nợ ncc",
              link: "/Report/bao-cao-cong-no-ncc",
            },
            {
              title: "Báo cáo công nợ khách hàng",
              link: "/Report/bao-cao-cong-no-kh",
            },
            {
              title: "Báo cáo công nợ nv giao hàng",
              link: "/Report/bao-cao-cong-no-nvgiaohang",
            },
          ],
        },
        {
          title: "Báo cáo quỹ",
          link: "/Report/bao-cao-quy-tien-mat",
          children: [
            {
              title: "Báo cáo quỹ tiền mặt",
              link: "/Report/bao-cao-quy-tien-mat",
            },
            {
              title: "Bảng kê phiếu thu",
              link: "/Report/bang-ke-phieu-thu",
            },
            {
              title: "Bảng kê phiếu chi",
              link: "bang-ke-phieu-chi",
            },
          ],
        },
      ],
      "menu-report"
    );
    this.menuService.onSubmenuToggle().subscribe((menuBag) => {
      this.router.navigateByUrl(menuBag.item.link);
    });
  }
  ngOnDestroy() {
    this.menuItems = [];
    this.destroy$.next();
    this.destroy$.complete();
  }
}
