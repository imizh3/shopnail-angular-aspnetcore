
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { NbLoginComponent } from '@nebular/auth';
import { User } from '../../@core/data/user';
import { Store } from '@ngrx/store';
import { AppState } from '../../@store/app-state';
import { ProductActions } from '../../@store/actions/product-actions';

@Component({
  selector: 'ngx-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent extends NbLoginComponent implements OnInit {
  user: User;
  ngOnInit(): void {
    this.user = new User();
  }

  login() {
    this.service.authenticate('email', this.user).subscribe((d) => {
      if (d.isFailure()) {
        this.errors = d.getErrors();
      } else if (d.isSuccess()) {
        this.router.navigate([d.getRedirect()]);
      }
    });
  }
}
