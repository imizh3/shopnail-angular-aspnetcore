import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { NbAuthService, NbTokenService } from '@nebular/auth';

@Component({
  selector: 'ngx-logout',
  templateUrl: './logout.component.html',
  styleUrls: ['./logout.component.scss']
})
export class LogoutComponent implements OnInit {

  constructor(private authService: NbAuthService, private router: Router, private tokenservice: NbTokenService) { }

  ngOnInit(): void {
    this.authService.logout('email').subscribe(d => {
      if (d.isSuccess) {
        this.tokenservice.clear();
        //this.router.navigate(['/auth/login']);
        location.reload();
      }
    });
  }

}
