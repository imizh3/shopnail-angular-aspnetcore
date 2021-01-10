import { Component, OnInit, Input, OnChanges, ChangeDetectionStrategy } from '@angular/core';
import { ProductService } from '../../../@core/mock/product.service';
import { Store } from '@ngrx/store';
import { AppState } from '../../../@store/app-state';
import { ProductActions } from '../../../@store/actions/product-actions';
import { getProducts } from '../../../@store/selectors/product-selectors';
import { Observable } from 'rxjs';
import { Product } from '../../../@core/data/product';

@Component({
  selector: 'ngx-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.scss'],
})
export class ProductsListComponent implements OnInit {
  @Input() productlist: any;
  constructor( private productsService: ProductService,
  ) { }

  ngOnInit(): void {
  }
  firstCard = {
    products: [],
    loading: false,
    pageToLoadNext: 1,
  };
  pageSize = 5;


  loadNext(cardData) {
    // if (cardData.loading) { return ; }
    // cardData.loading = true;
    // this.productsService.load(cardData.pageToLoadNext, this.pageSize)
    //   .subscribe(nextProducts => {
    //     cardData.products.push(...nextProducts);
    //     cardData.loading = false;
    //     cardData.pageToLoadNext++;
    //   });
  }

}
