import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';
import { Giaodichct } from '../../../@core/data/giaodichct';
import { Store } from '@ngrx/store';
import { AppState } from '../../../@store/app-state';
import { getCartCt } from '../../../@store/selectors/cart-selectors';
import { CartActions } from '../../../@store/actions/cart-actions';

@Component({
  selector: 'ngx-cart-info',
  templateUrl: './cart-info.component.html',
  styleUrls: ['./cart-info.component.scss'],
})
export class CartInfoComponent implements OnInit {
  product$: Observable<Giaodichct>;

  constructor(private store: Store<AppState>, private action: CartActions) { }

  ngOnInit(): void {
    this.product$ = this.store.select(getCartCt);
  }

  onEditConfirm(data: any, soluong: any): void {
    this.store.dispatch(
      this.action.updateItem(data, 'soluong', soluong.target.value)
    );
  }

  onEditTyleck(data: any, field: string, ck: any): void {
    this.store.dispatch(this.action.updateItem(data, field, ck.target.value));
  }

  onDeleteConfirm(gdChiTiet: any): void {
    this.store.dispatch(this.action.removeItem(gdChiTiet));
  }

  onEditThungLe(giaodichct, value) {

    this.store.dispatch(
      this.action.updateItem(
        giaodichct,
        'sothung',
        value,
      ),
    );
  }
}
