import { CartActions } from './../actions/cart-actions';
import { CartState, CartStateRecord } from './../state/cart-state';
import { CartService } from '../../@core/mock/cart.service';
export const initialState: CartState = (new CartStateRecord() as unknown) as CartState;

export function reducer(
  state = initialState,
  { type, payload }: any,
): CartState {
  switch (type) {
    case CartActions.ADD_ITEM_SUCCESS:
      const order = payload.order;
      return state.merge({
        order: order,
      }) as CartState;
    case CartActions.CREATE_ORDER_SUCCESS:
      return state.merge({
        order: {},
      }) as CartState;
    default:
      return state;
  }
}
