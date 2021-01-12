import { ThemUserComponent } from "./them-user/them-user.component";
import { NguoidungService } from "./../../@core/mock/nguoidung.service";
import { Observable } from "rxjs";
import { Nguoidung } from "./../../@core/data/nguoidung";
import { Component, OnInit } from "@angular/core";
import { UserService } from "../../@core/mock/users.service";
import { NbWindowService } from "@nebular/theme";

@Component({
  selector: "ngx-quan-tri",
  templateUrl: "./quan-tri.component.html",
  styleUrls: ["./quan-tri.component.scss"],
})
export class QuanTriComponent implements OnInit {
  nguoidungs: Nguoidung[];
  nguoidungs$: Observable<Nguoidung[]>;
  constructor(
    private nguoidungService: NguoidungService,
    private windowService: NbWindowService
  ) {}

  ngOnInit(): void {
    this.nguoidungs$ = this.nguoidungService.getNguoidungs();
    this.nguoidungs$.subscribe((d) => {
      this.nguoidungs = d;
      console.log(this.nguoidungs);
    });
  }
  openAddNguoiDung() {
    this.windowService.open(ThemUserComponent, {
      title: "Thêm tài khoản ",
    });
  }
  toggle(checked: boolean) {}
}
