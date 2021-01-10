import { ProductState } from './state/product-state'
import { CartState } from './state/cart-state';
export interface AppState {
  products: ProductState,
  cart: CartState,
}
