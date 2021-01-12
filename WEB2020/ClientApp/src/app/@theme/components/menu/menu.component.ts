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
  menuFormDb: Observable<any>;
  menuItems: NbMenuItem[] = [
    // {
    //   title: "Bán hàng",
    //   icon: "home-outline",
    //   link: "/Home",
    //   home: true,
    // },
    {
      title: "Đơn hàng",
      icon: "file-text-outline",
      link: "/Don-hang",
    },
    {
      title: "Quản trị",
      icon: "shield-outline",
      link: "/Quan-tri",
    },
    {
      title: "Thống kê",
      icon: "pie-chart-outline",
      link: "/Thong-ke",
    },
  ];

  private destroy$ = new Subject<void>();
  selectedItem: string;
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
    // tslint:disable-next-line: max-line-length
    this.isClicked = false;
    this.store.select(IsLoadedCategory).subscribe((isLoaded) => {
      if (!isLoaded) {
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
            if (!isLoaded) {
              //this.menuService.addItems(d, "menu");
              this.menuItems.push(banhangitem);
              this.store.dispatch(this.productAction.setIsloadedCategory(true));
            }
          });
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
    this.menuItems = [];
    this.destroy$.next();
    this.destroy$.complete();
  }

  addMenuItem() {
    this.menuService.addItems(
      [
        {
          title: "@nebular/theme",
          icon: "plus-outline",
          link: "/Home/2",
        },
        {
          title: "@nebular/theme",
          icon: "plus-outline",
          link: "/Home/1/4",
        },
      ],
      "menu"
    );
  }

  collapseAll() {
    this.menuService.collapseAll("menu");
  }

  navigateHome() {
    this.menuService.navigateHome("menu");
  }

  getSelectedItem() {
    this.menuService
      .getSelectedItem("menu")
      .pipe(takeUntil(this.destroy$))
      .subscribe((menuBag) => {
        this.selectedItem = menuBag.item.title;
      });
  }
}
