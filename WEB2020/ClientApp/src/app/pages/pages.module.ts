import { PipeModule } from './../@core/pipes/pipes.module';
import { CoreModule } from './../@core/core.module';
import { ControllModule } from './../@component/controll.module';
import { NgModule } from '@angular/core';
import { ThemeModule } from '../@theme/theme.module';
import { PagesComponent } from './pages.component';
import { DashboardModule } from './dashboard/dashboard.module';
import { PagesRoutingModule } from './pages-routing.module';
import { HomeComponent } from './home/home.component';
import { ProductsListComponent } from './home/products-list/products-list.component';
import { ProductsItemComponent } from './home/products-item/products-item.component';
import {
  NbMenuModule,
  NbCardModule,
  NbListModule,
  NbUserModule,
  NbInputModule,
  NbButtonModule,
  NbIconModule,
  NbFormFieldModule,
  NbDatepickerModule,
  NbSelectModule,
  NbSpinnerModule,
  NbPopoverModule,

} from '@nebular/theme';
import { NbEvaIconsModule } from '@nebular/eva-icons';
import { ProductsResolver } from './home/guards/products-resolver';
import { KhuyenMaiComponent } from './khuyen-mai/khuyen-mai.component';
import { KhuyenMaiCtComponent } from './khuyen-mai/khuyen-mai-ct/khuyen-mai-ct.component';
import { DonHangComponent } from './don-hang/don-hang.component';
import {NbMomentDateModule} from '@nebular/moment'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DonHangCtComponent } from './don-hang/don-hang-ct/don-hang-ct.component';
import { ThemDonHangCtComponent } from './don-hang/them-don-hang-ct/them-don-hang-ct.component';
import { QuanTriComponent } from './quan-tri/quan-tri.component';
import { ThongKeComponent } from './thong-ke/thong-ke.component';

@NgModule({
  imports: [
    PagesRoutingModule,
    ThemeModule,
    DashboardModule,
    NbCardModule,
    NbListModule,
    NbUserModule,
    NbInputModule,
    NbButtonModule,
    NbIconModule,
    NbFormFieldModule,
    NbEvaIconsModule,
    NbDatepickerModule,
    NbSelectModule,
    NbPopoverModule,
    NbMomentDateModule,
    NbSpinnerModule,
    ControllModule,
    FormsModule,
    ReactiveFormsModule,
    PipeModule,
  ],
  declarations: [

    PagesComponent,
    HomeComponent,
    ProductsListComponent,
    ProductsItemComponent,
    KhuyenMaiComponent,
    KhuyenMaiCtComponent,
    DonHangComponent,
    DonHangCtComponent,
    ThemDonHangCtComponent,
    QuanTriComponent,
    ThongKeComponent,
  ],
  providers: [
    ProductsResolver,

  ],
})
export class PagesModule {
}
