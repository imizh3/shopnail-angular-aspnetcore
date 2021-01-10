import { NbMenuItem } from '@nebular/theme';
import { platform } from 'process';
import { Product } from './../../@core/data/product';
import { ProductActions } from './../actions/product-actions';
import { ProductState, ProductStateRecord } from './../state/product-state';

export const initialState: ProductState = (new ProductStateRecord() as unknown) as ProductState;

export function reducer(
  state = initialState,
  { type, payload }: any,
): ProductState {
  switch (type) {
    case ProductActions.GET_ALL_PRODUCTS_SUCCESS:
      const _showAllProducts: Product[] = payload.products;
      return state.merge({
        showAllProducts: _showAllProducts,
      }) as ProductState;
    case ProductActions.LOAD_MENU_SUCCESS:
      return state.merge({
        menu: payload,
      }) as ProductState;
    case ProductActions.LOAD_PRODUCTS_SUCCESS:
      const _listProduct: Product[] = payload;
      return state.merge({
        listProduct: _listProduct,
      }) as ProductState;
    case ProductActions.SET_ISLOADED_CATEGORY:
      return state.set('isLoadedCategory', payload);
    default:
      return state;
  }
}
