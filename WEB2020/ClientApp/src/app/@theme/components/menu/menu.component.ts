import { CategoryService } from "./../../../@core/mock/category.service";
import { Component, OnInit, OnDestroy, Input } from "@angular/core";
import { Subject } from "rxjs";
import { NbMenuService, NbMenuItem } from "@nebular/theme";
import { takeUntil } from "rxjs/operators";
import { Router } from "@angular/router";
import { Store } from "@ngrx/store";
import { map } from "rxjs/operators";
import { AppState } from "../../../@store/app-state";
import { IsLoadedCategory } from "../../../@store/selectors/product-selectors";
import { Observable, of } from "rxjs";
import { ProductActions } from "../../../@store/actions/product-actions";

@Component({
  selector: "ngx-menu",
  templateUrl: "./menu.component.html",
  styleUrls: ["./menu.component.scss"],
})
export class MenuComponent implements OnInit, OnDestroy {
  menuItems: NbMenuItem[] = [
    // {
    //   title: "Bán hàng",
    //   icon: "home-outline",
    //   link: "/Home",
    //   home: true,
    // },
    // {
    //   title: "Đơn hàng",
    //   icon: "file-text-outline",
    //   link: "/Don-hang",
    // },
    // {
    //   title: "Quản trị",
    //   icon: "shield-outline",
    //   link: "/Quan-tri",
    // },
    // {
    //   title: "Thống kê",
    //   icon: "pie-chart-outline",
    //   link: "/Thong-ke",
    // },
  ];

  private destroy$ = new Subject<void>();
  isloaded = false;
  isClicked = false;
  public constructor(
    private menuService: NbMenuService,
    private router: Router,
    private categoryService: CategoryService,
    private store: Store<AppState>,
    private productAction: ProductActions
  ) {}

  ngOnInit(): void {
    this.store.select(IsLoadedCategory).subscribe((isLoaded) => {
      //if (!isLoaded) {
      if (this.menuItems === null || this.menuItems.length === 0) {
        this.categoryService
          .loadCategory()
          .pipe(
            map((d) =>
              d.map((c) => ({
                title: c.ten,
                link: "/Home/" + c.ma,
                children: d
                  .filter((f) => f.macha === c.ma)
                  .map((item) => ({
                    title: item.ten,
                    link: "/Home/" + item.macha + "/" + item.ma,
                  })),
                macha: c.macha,
              }))
            ),
            map((d) =>
              d
                .filter((c) => c.macha === null)
                .map((c) => ({
                  title: c.title,
                  link: c.link,
                  children: c.children.length > 0 ? c.children : null,
                }))
            )
          )
          .subscribe((d) => {
            var banhangitem = {
              title: "Bán hàng",
              icon: "home-outline",
              link: "/Home",
              children: d,
            };
            //if (!isLoaded) {
            //this.menuService.addItems(d, "menu");
            this.menuItems.push(banhangitem);
            this.menuItems.push({
              title: "Đơn hàng",
              icon: "file-text-outline",
              link: "/Don-hang",
            });
            this.menuItems.push({
              title: "Quản trị",
              icon: "shield-outline",
              link: "/Quan-tri",
            });
            this.menuItems.push({
              title: "Thống kê",
              icon: "pie-chart-outline",
              link: "/Thong-ke",
            });
            this.store.dispatch(this.productAction.setIsloadedCategory(true));
            //}
          });
      } else {
        console.log(this.menuItems);
      }
    });
    this.menuService.onSubmenuToggle().subscribe((menuBag) => {
      if (this.isClicked) {
        this.router.navigateByUrl(menuBag.item.link);
      }
      this.isClicked = true;
    });
  }

  ngOnDestroy() {
    // this.menuItems = [];
    // this.destroy$.next();
    // this.destroy$.complete();
  }
}
