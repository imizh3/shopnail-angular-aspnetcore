import { CategoryService } from './../../@core/mock/category.service';
import { map, switchMap } from 'rxjs/operators';
import { ProductActions } from './../actions/product-actions';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Effect, Actions, ofType } from '@ngrx/effects';
import { ProductService } from '../../@core/mock/product.service';
import { Action } from '@ngrx/store';

@Injectable()
export class ProductEffects {
  @Effect()
  GetAllProducts$: Observable<Action> = this.actions$.pipe(
    ofType(ProductActions.GET_ALL_PRODUCTS),
    switchMap((action: any) => this.productService.getProducts(action.payload)),
    map((data: any) =>
      this.productActions.getAllProductsSuccess({ products: data }),
    ),
  );
  @Effect()
  GetProductsByQuery$: Observable<Action> = this.actions$.pipe(
    ofType(ProductActions.GET_PRODUCTS_BY_QUERY),
    switchMap((action: any) => this.productService.getProductsByQuery(action.payload)),
    map((data: any) =>
      this.productActions.getAllProductsSuccess({ products: data }),
    ),
  );

  @Effect()
  loadProduct$: Observable<Action> = this.actions$.pipe(
    ofType(ProductActions.LOAD_PRODUCTS),
    switchMap((action: any) => this.productService.LoadData(action)),
    map((data: any) =>
      this.productActions.loadProductSuccess(data),
    ),
  );

  @Effect()
  loadCategory$: Observable<Action> = this.actions$.pipe(
    ofType(ProductActions.LOAD_MENU),
    switchMap((action: any) => this.categoryService.loadCategory()),
    map((data: any) =>
      this.productActions.loadCategorySuccess(data),
    ),
  );

  constructor(
    private actions$: Actions,
    private productService: ProductService,
    private categoryService: CategoryService,
    private productActions: ProductActions,
  ) { }
}
