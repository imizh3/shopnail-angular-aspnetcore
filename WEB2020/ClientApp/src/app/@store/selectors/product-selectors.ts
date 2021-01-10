import { AppState } from './../app-state';
import { ProductState } from './../state/product-state';
import { createSelector } from '@ngrx/store';
import { Product } from '../../@core/data/product';
import { Nganhnhom } from '../../@core/data/nganhnhom';

// Base product state selector function
const getProductState = (state: AppState): ProductState => state.products;
const isLoadedCategory = (state: AppState) => state.products.isLoadedCategory;

// ******************** Individual selectors ***************************
export function fetchProducts(state: ProductState): Product[] {
  const productEntities = state.showAllProducts;
  return (productEntities.map(id => id) as unknown) as Product[];
}

export function fetchMenus(state: ProductState): Nganhnhom[] {
  const menu = state.menu;
  return (menu.map(d => d) as unknown) as Nganhnhom[];
}

// *************************** PUBLIC API's ****************************

export const getProducts = createSelector(
  getProductState,
  fetchProducts,
);

export const getMenu = createSelector(
  getProductState,
  fetchMenus,
);

export const getListProducts = createSelector(
  getProductState,
  (d) => (d.listProduct.map(c => c) as unknown) as Product[],
);

export const IsLoadedCategory = createSelector(
  isLoadedCategory, (d) => d,
);

