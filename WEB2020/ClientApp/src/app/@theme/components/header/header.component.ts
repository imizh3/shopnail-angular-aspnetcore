import {
  Component,
  OnDestroy,
  OnInit,
  ViewChild,
  ElementRef,
} from "@angular/core";
import {
  NbMediaBreakpointsService,
  NbSidebarService,
  NbThemeService,
  NbSearchService,
  NbMenuService,
  NbLayoutRulerService,
} from "@nebular/theme";

import { UserData } from "../../../@core/data/users";
import { LayoutService } from "../../../@core/utils";
import { map, takeUntil } from "rxjs/operators";
import { Subject, Observable } from "rxjs";
import { RippleService } from "../../../@core/utils/ripple.service";
import { Store } from "@ngrx/store";
import { AppState } from "../../../@store/app-state";
import { getCart } from "../../../@store/selectors/cart-selectors";
import { Router } from "@angular/router";
import { NbAuthService, NbAuthJWTToken } from "@nebular/auth";

@Component({
  selector: "ngx-header",
  styleUrls: ["./header.component.scss"],
  templateUrl: "./header.component.html",
})
export class HeaderComponent implements OnInit, OnDestroy {
  cartCount = 0;
  private destroy$: Subject<void> = new Subject<void>();
  public readonly materialTheme$: Observable<boolean>;
  userPictureOnly: boolean = false;
  user: any;
  sum$: any;
  searchString: string;
  @ViewChild("btnSidebar") toggleButton: ElementRef;
  themes = [
    {
      value: "default",
      name: "Light",
    },
    {
      value: "dark",
      name: "Dark",
    },
    {
      value: "cosmic",
      name: "Cosmic",
    },
    {
      value: "corporate",
      name: "Corporate",
    },
    {
      value: "material-light",
      name: "Material Light",
    },
    {
      value: "material-dark",
      name: "Material Dark",
    },
  ];

  currentTheme = "default";

  userMenu = [{ title: "Cá nhân" }, { title: "Đăng xuất" }];

  public constructor(
    private sidebarService: NbSidebarService,
    private themeService: NbThemeService,
    private userService: UserData,
    private layoutRulerService: NbLayoutRulerService,
    private layoutService: LayoutService,
    private breakpointService: NbMediaBreakpointsService,
    private rippleService: RippleService,
    private store: Store<AppState>,
    private router: Router,
    private authService: NbAuthService,
    private menuserver: NbMenuService
  ) {
    this.materialTheme$ = this.themeService.onThemeChange().pipe(
      map((theme) => {
        const themeName: string = theme?.name || "";
        return themeName.startsWith("material");
      })
    );

    this.store.select(getCart).subscribe((cart) => {
      if (cart) {
        if (cart.giaodichct) {
          this.sum$ = cart.giaodichct.length;
        } else this.sum$ = undefined;
      } else this.sum$ = undefined;
    });
  }

  ngOnInit() {
    this.currentTheme = this.themeService.currentTheme;

    this.userService
      .getUsers()
      .pipe(takeUntil(this.destroy$))
      .subscribe((users: any) => (this.user = users.nick));

    const { xl } = this.breakpointService.getBreakpointsMap();
    this.themeService
      .onMediaQueryChange()
      .pipe(
        map(([, currentBreakpoint]) => currentBreakpoint.width < xl),
        takeUntil(this.destroy$)
      )
      .subscribe(
        (isLessThanXl: boolean) => (this.userPictureOnly = isLessThanXl)
      );

    this.themeService
      .onThemeChange()
      .pipe(
        map(({ name }) => name),
        takeUntil(this.destroy$)
      )
      .subscribe((themeName) => {
        this.currentTheme = themeName;
        this.rippleService.toggle(themeName?.startsWith("material"));
      });

    this.authService.onTokenChange().subscribe((token: NbAuthJWTToken) => {
      if (token.isValid()) {
        this.user = token.getPayload(); // here we receive a payload from the token and assigns it to our `user` variable
      } else {
        this.router.navigate(["/auth/login"]);
      }
    });

    this.menuserver.onItemClick().subscribe((d) => {
      if (d.item.title === "Đăng xuất") {
        this.logout();
      } else {
        if (d.item.title === "Báo cáo") {
          this.openBaoCao();
        }
        if (d.item.title === "Cá nhân") {
          this.openCaNhan();
        }
      }
      if (d.tag === "menu" && this.userPictureOnly) {
        this.toggleSidebar();
      }
    });

    this.menuserver.onSubmenuToggle().subscribe((d) => {
      if (d.tag === "menu" && this.userPictureOnly) {
        this.toggleSidebar();
      }
    });
  }
  //   @HostListener('document:mousedown', ['$event']) onGlobalClick(event) {
  //     if (!this.toggleButton.nativeElement.contains(event.target)) {
  //       // clicked outside => close menu-sidebar
  //       this.sidebarService.compact("menu-sidebar");
  //    }

  // }
  logout() {
    // this.tokenservice.clear();
    this.router.navigate(["/auth/logout"]);
  }
  ngOnDestroy() {
    this.destroy$.next();
    this.destroy$.complete();
  }

  changeTheme(themeName: string) {
    this.themeService.changeTheme(themeName);
  }

  toggleSidebar(): boolean {
    this.sidebarService.toggle(true, "menu-sidebar");
    this.layoutService.changeLayoutSize();

    return false;
  }

  search(searchString: string) {
    if (searchString) {
      this.router.navigate(["/Search"], {
        queryParams: { query: searchString },
      });
    }
  }

  navigateHome() {
    this.router.navigate(["/"]);
    return false;
  }

  openBaoCao() {
    this.router.navigate(["/Report/bao-cao"]);
  }
  openCaNhan() {
    this.router.navigate(["/Ca-nhan"]);
  }
}
