import { AppState } from './../../../@store/app-state';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, Router, RouterStateSnapshot } from '@angular/router';
import { Store } from '@ngrx/store';
import { ProductActions } from '../../../@store/actions/product-actions';

@Injectable()
export class ProductsResolver implements Resolve<any> {
  constructor(
    private store: Store<AppState>,
    private router: Router,
    private actions: ProductActions,
  ) { }

  resolve(
    route: ActivatedRouteSnapshot,
    _state: RouterStateSnapshot,
  ) {
    const nganhhang = route.params['id'];
    const nhomhang = route.params['nhom'];
    const search = route.queryParams['query'];
    if (search) {
      this.store.dispatch(this.actions.getProductsByQuery({ query: search }));

    } else {
      this.store.dispatch(this.actions.getAllProducts({ nganhhang: nganhhang, nhomhang: nhomhang }));
    }
  }
}
