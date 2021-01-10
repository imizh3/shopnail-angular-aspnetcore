import { Giaodichct } from './../../@core/data/giaodichct';
export class CartActions {
  static ADD_ITEM = 'ADD_ITEM';
  static ADD_ITEM_SUCCESS = 'ADD_ITEM_SUCCESS';
  static REMOVE_ITEM = 'REMOVE_ITEM';
  static UPDATE_ITEM = 'UPDATE_ITEM';
  static UPDATE_CART = 'UPDATE_CART';
  static CREATE_ORDER = 'CREATE_ORDER';
  static CREATE_ORDER_SUCCESS = 'CREATE_ORDER_SUCCESS';
  static DUYET_KM = 'DUYET_KM';

  addItem(giaodichct: any) {
    return {
      type: CartActions.ADD_ITEM,
      payload: giaodichct,
    };
  }

  addItemSuccess(order: any) {
    return {
      type: CartActions.ADD_ITEM_SUCCESS,
      payload: order,
    };
  }

  updateItem(_giaodichct: any, _fields: string, _value: any) {
    return {
      type: CartActions.UPDATE_ITEM,
      payload: {
        giaodichct: _giaodichct,
        fields: _fields,
        value: _value,
      },
    };
  }

  removeItem(giaodichct: any) {
    return {
      type: CartActions.REMOVE_ITEM,
      payload: giaodichct,
    };
  }

  updateCart(_fields: string, _value: any) {
    return {
      type: CartActions.UPDATE_CART,
      payload: {
        fields: _fields,
        value: _value,
      },
    };
  }

  createOrder() {
    return {
      type: CartActions.CREATE_ORDER,
    };
  }

  duyetKM() {
    return {
      type: CartActions.DUYET_KM,
    };
  }

  createOrderSuccess() {
    return {
      type: CartActions.CREATE_ORDER_SUCCESS,
    };
  }
}
