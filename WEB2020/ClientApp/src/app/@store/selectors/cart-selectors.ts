import { AppState } from '../app-state';
import { CartState } from '../state/cart-state';
import { createSelector } from '@ngrx/store';
import { Product } from '../../@core/data/product';

// Base product state selector function
const CartState = (state: AppState): CartState => state.cart;

// ******************** Individual selectors ***************************
export function fetchCart(state: CartState) {
  return state.order;
}

export function fetchGiaodichct(state: CartState) {
  return state.order.giaodichct;
}
// *************************** PUBLIC API's ****************************

export const getCart = createSelector(
  CartState,
  fetchCart,
);

export const getCartCt = createSelector(
  CartState,
  fetchGiaodichct,
);
