import { map, switchMap } from 'rxjs/operators';
import { CartActions } from './../actions/cart-actions';
import { Observable, pipe } from 'rxjs';
import { Injectable } from '@angular/core';
import { Effect, Actions, ofType } from '@ngrx/effects';
import { CartService } from '../../@core/mock/cart.service';
import { Action } from '@ngrx/store';

@Injectable()
export class CartEffects {
  @Effect()
  addItem$: Observable<Action> = this.actions$.pipe(
    ofType(CartActions.ADD_ITEM),
    switchMap((action: any) => this.cartService.addItemToCart(action.payload)),
    map((data: any) =>
      this.cartActions.addItemSuccess({ order: data },
      ),
    ),
  );

  @Effect()
  updateItem$: Observable<Action> = this.actions$.pipe(
    ofType(CartActions.UPDATE_ITEM),
    switchMap((action: any) => this.cartService.updateItem(action.payload.giaodichct, action.payload.fields, action.payload.value)),
    map((data: any) =>
      this.cartActions.addItemSuccess({ order: data },
      ),
    ),
  );
  @Effect()
  removeItem$: Observable<Action> = this.actions$.pipe(
    ofType(CartActions.REMOVE_ITEM),
    switchMap((action: any) => this.cartService.removeCartItem(action.payload)),
    map((data: any) =>
      this.cartActions.addItemSuccess({ order: data },
      ),
    ),
  );

  @Effect()
  updateCart$: Observable<Action> = this.actions$.pipe(
    ofType(CartActions.UPDATE_CART),
    switchMap((action: any) => this.cartService.updateCart(action.payload.fields, action.payload.value)),
    map((data: any) =>
      this.cartActions.addItemSuccess({ order: data },
      ),
    ),
  );

  constructor(
    private actions$: Actions,
    private cartService: CartService,
    private cartActions: CartActions,
  ) { }
}
