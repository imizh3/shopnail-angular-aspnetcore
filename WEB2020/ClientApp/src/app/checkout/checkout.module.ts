import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CheckoutRoutingModule } from './checkout-routing.module';
import { CheckoutComponent } from './checkout.component';
import { ThemeModule } from '../@theme/theme.module';
import { CartComponent } from './cart/cart.component';
import { Ng2SmartTableModule } from 'ng2-smart-table';
// tslint:disable-next-line: max-line-length
import { NbStepperModule, NbFormFieldModule, NbInputModule, NbButtonModule, NbIconModule, NbCardModule, NbDialogModule, NbUserModule, NbActionsModule } from '@nebular/theme';
import { NbEvaIconsModule } from '@nebular/eva-icons';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { QuantityComponent } from './cart/quantity/quantity.component';
import { CartInfoComponent } from './cart/cart-info/cart-info.component';
import { ControllModule } from '../@component/controll.module';
import { PipeModule } from '../@core/pipes/pipes.module';


@NgModule({
  imports: [
    CommonModule,
    ThemeModule,
    CheckoutRoutingModule,
    Ng2SmartTableModule,
    NbDialogModule.forChild(),
    NbCardModule,
    NbUserModule,
    NbActionsModule,
    NbStepperModule,
    NbFormFieldModule,
    NbInputModule,
    NbButtonModule,
    NbIconModule,
    NbEvaIconsModule,
    FormsModule,
    ReactiveFormsModule,
    ControllModule,
    PipeModule,
  ],
  declarations: [
    CheckoutComponent,
    CartComponent,
    QuantityComponent,
    CartInfoComponent,
  ],
})
export class CheckoutModule { }
