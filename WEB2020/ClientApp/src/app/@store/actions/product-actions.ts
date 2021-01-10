import { NbMenuItem } from '@nebular/theme';
import { ofType } from '@ngrx/effects';
import { Product } from '../../@core/data/product';

export class ProductActions {
  static GET_ALL_PRODUCTS = 'GET_ALL_PRODUCTS';
  static GET_ALL_PRODUCTS_SUCCESS = 'GET_ALL_PRODUCTS_SUCCESS';
  static LOAD_PRODUCTS = 'LOAD_PRODUCTS';
  static LOAD_PRODUCTS_SUCCESS = 'LOAD_PRODUCTS_SUCCESS';
  static LOAD_MENU = 'LOAD_MENU';
  static LOAD_MENU_SUCCESS = 'LOAD_MENU_SUCCESS';
  static GET_PRODUCTS_BY_QUERY = 'GET_PRODUCTS_BY_QUERY';
  static SET_ISLOADED_CATEGORY = 'SET_ISLOADED_CATEGORY';

  getAllProducts(request: any) {
    return {
      type: ProductActions.GET_ALL_PRODUCTS,
      payload: request,
    };
  }
  getProductsByQuery(request: any) {
    return {
      type: ProductActions.GET_PRODUCTS_BY_QUERY,
      payload: request,
    };
  }

  getAllProductsSuccess(products: any) {
    return {
      type: ProductActions.GET_ALL_PRODUCTS_SUCCESS,
      payload: products,
    };
  }

  loadCategory() {
    return {
      type: ProductActions.LOAD_MENU,
    };
  }

  loadCategorySuccess(menu: any) {
    return {
      type: ProductActions.LOAD_MENU_SUCCESS,
      payload: menu,
    };
  }

  loadProduct() {
    return {
      type: ProductActions.LOAD_PRODUCTS,
    };
  }

  loadProductSuccess(data: any) {
    return {
      type: ProductActions.LOAD_PRODUCTS_SUCCESS,
      payload: data,
    };
  }

  setIsloadedCategory(status: boolean) {
    return {
      type: ProductActions.SET_ISLOADED_CATEGORY,
      payload: status,
    }
  }
}
