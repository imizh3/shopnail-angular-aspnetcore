import { LogoutComponent } from './logout/logout.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NbAuthComponent,
  NbRegisterComponent,
  NbLogoutComponent,
  NbRequestPasswordComponent,
  NbResetPasswordComponent,
} from '@nebular/auth';
import { LoginComponent } from './login/login.component';

export const routes: Routes = [
  {
    path: '',
    component: NbAuthComponent,
    children: [
      {
        path: 'login',
        component: LoginComponent,
      },
      {
        path: 'logout',
        component: LogoutComponent,
      }
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class NgxAuthRoutingModule {
}
