import { CategoryService } from './../../../@core/mock/category.service';
import { Component, OnInit, OnDestroy, Input } from '@angular/core';
import { Subject } from 'rxjs';
import { NbMenuService, NbMenuItem, NbSidebarService } from '@nebular/theme';
import { takeUntil } from 'rxjs/operators';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { map } from 'rxjs/operators';
import { AppState } from '../../../@store/app-state';
import { IsLoadedCategory } from '../../../@store/selectors/product-selectors';
import { Observable, of } from 'rxjs';
import { ProductActions } from '../../../@store/actions/product-actions';
import { LayoutService } from '../../../@core/utils';

@Component({
  selector: 'ngx-menu-cart',
  templateUrl: './menu-cart.component.html',
  styleUrls: ['./menu-cart.component.scss'],
})
export class MenuCartComponent implements OnInit, OnDestroy {
  menuFormDb: Observable<any>;
  menuItems: NbMenuItem[] = [
    {
      title: 'Home',
      icon: 'home-outline',
      link: '/Home',
      home: true,
    },
    {
      title: 'CT Khuyến mại',
      icon: 'gift-outline',
      link: '/Khuyen-mai',
    },
    {
      title: 'Đơn hàng',
      icon: 'file-text-outline',
      link: '/Don-hang',
    },
  ];

  private destroy$ = new Subject<void>();
  selectedItem: string;
  isloaded = false;
  public constructor(
    private menuService: NbMenuService,
    private router: Router,
    private categoryService: CategoryService,
    private store: Store<AppState>,
    private productAction: ProductActions,
    private sidebarService: NbSidebarService,
    private layoutService: LayoutService,
  ) {

  }

  ngOnInit(): void {
    // tslint:disable-next-line: max-line-length
    //this.sidebarService.toggle(true, 'menu-sidebar');
    //this.layoutService.changeLayoutSize();
  }

  ngOnDestroy() {
    this.menuItems = [];
    this.destroy$.next();
    this.destroy$.complete();
  }

  addMenuItem() {
    this.menuService.addItems([{
      title: '@nebular/theme',
      icon: 'plus-outline',
      link: '/Home/2',
    }, {
      title: '@nebular/theme',
      icon: 'plus-outline',
      link: '/Home/1/4',
    }], 'menu-cart');
  }

  collapseAll() {
    this.menuService.collapseAll('menu-cart');
  }

  navigateHome() {
    this.menuService.navigateHome('menu-cart');
  }

  getSelectedItem() {
    this.menuService.getSelectedItem('menu-cart')
      .pipe(takeUntil(this.destroy$))
      .subscribe((menuBag) => {
        this.selectedItem = menuBag.item.title;
      });
  }

}
