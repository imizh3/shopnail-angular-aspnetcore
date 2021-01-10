import { Giaodich } from '../../@core/data/giaodich';
import { Giaodichct } from '../../@core/data/giaodichct';
import { Giaodichctkhuyenmai } from '../../@core/data/giaodichctkhuyenmai';
import { Map, Record, List } from 'immutable';

export interface CartState extends Map<string, any> {
  giaodich: Giaodich;
  order: any;
}
export const CartStateRecord = Record({
  giaodich: {},
  order: {},
});
