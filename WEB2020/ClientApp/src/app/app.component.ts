import { DataService } from './@core/mock/data.service';
import { AppState } from './@store/app-state';
/**
 * @license
 * Copyright Akveo. All Rights Reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 */
import { Component, OnInit } from '@angular/core';
import { AnalyticsService } from './@core/utils/analytics.service';
import { Store } from '@ngrx/store';
import { ProductActions } from './@store/actions/product-actions';
import { NbAuthService, NbTokenService } from '@nebular/auth';

@Component({
  selector: 'ngx-app',
  template: `
      <router-outlet></router-outlet>
  `,
})
export class AppComponent implements OnInit {

  constructor(
    private analytics: AnalyticsService,
    private store: Store<AppState>,
    private productAction: ProductActions,
    private authService: NbAuthService,
    private dataService: DataService,
  ) {
    // this.store.dispatch(this.productAction.loadCategory());
    // this.store.dispatch(this.productAction.loadProduct());
  }

  ngOnInit() {
    this.analytics.trackPageViews();
    this.authService.onTokenChange().subscribe(d => {
      this.store.dispatch(this.productAction.loadCategory());
      this.store.dispatch(this.productAction.loadProduct());
      this.dataService.LoadData();
    });
  }
}
