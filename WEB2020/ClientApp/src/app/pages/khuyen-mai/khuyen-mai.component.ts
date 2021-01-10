import { Router } from '@angular/router';
import { Chuongtrinhkm } from './../../@core/data/chuongtrinhkm';
import { DataService } from './../../@core/mock/data.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'ngx-khuyen-mai',
  templateUrl: './khuyen-mai.component.html',
  styleUrls: ['./khuyen-mai.component.scss'],
})
export class KhuyenMaiComponent implements OnInit {
  chuongtrinhkm: Chuongtrinhkm;
  constructor(private data: DataService, private router: Router) {}

  ngOnInit(): void {
    this.chuongtrinhkm = this.data.ctKhuyenMai.khuyenmais;
  }

  btnChiTietKhuyenMai(machuongtrinh) {
    if (machuongtrinh) {
      this.router.navigate(['/chi-tiet-khuyen-mai'], {
        queryParams: { query: machuongtrinh },
      });
    }
  }
}
