import { ThemeModule } from './../@theme/theme.module';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { NgxAuthRoutingModule } from './auth-routing.module';
import { NbAuthModule } from '@nebular/auth';
import {
  NbAlertModule,
  NbButtonModule,
  NbCheckboxModule,
  NbInputModule,
  NbIconModule,
} from '@nebular/theme';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';


@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ThemeModule,
    RouterModule,
    NbAlertModule,
    NbInputModule,
    NbButtonModule,
    NbCheckboxModule,
    NgxAuthRoutingModule,
    NbIconModule,

    NbAuthModule,
  ],
  declarations: [
    // ... here goes our new components
  LoginComponent,
    LogoutComponent],
})
export class NgxAuthModule {
}
