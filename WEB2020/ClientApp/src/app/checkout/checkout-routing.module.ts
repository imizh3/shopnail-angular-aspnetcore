
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CheckoutComponent } from './checkout.component';
import { CartComponent } from './cart/cart.component';
import { AuthGuard } from '../auth/auth-guard.service';


const routes: Routes = [
  {
    path: '',
    canActivate: [AuthGuard],
    component: CheckoutComponent,
    children: [
      {
        path: 'Cart',
        canActivate: [AuthGuard],
        component: CartComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CheckoutRoutingModule { }
