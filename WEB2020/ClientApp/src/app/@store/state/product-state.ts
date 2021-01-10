import { NbMenuItem } from '@nebular/theme';
import { Product } from '../../@core/data/product';
import { Map, Record, List } from 'immutable';
import { Nganhnhom } from '../../@core/data/nganhnhom';

export interface ProductState extends Map<string, any> {
  showAllProducts: List<Product>;
  menu: List<Nganhnhom>;
  listProduct: List<Product>;
  isLoadedCategory: boolean;
}

export const ProductStateRecord = Record({
  showAllProducts: List([]),
  menu: List([]),
  listProduct: List([]),
  isLoadedCategory: false,
});
