import { Nganhnhom } from "./../../@core/data/nganhnhom";
import { CategoryService } from "./../../@core/mock/category.service";
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
  nganhNhoms$: Observable<Nganhnhom[]>;
  nganhs: Nganhnhom[];
  constructor(
    private nguoidungService: NguoidungService,
    private windowService: NbWindowService,
    private categoryService: CategoryService
  ) {}

  ngOnInit(): void {
    this.nguoidungs$ = this.nguoidungService.getNguoidungs();
    this.nguoidungs$.subscribe((d) => {
      this.nguoidungs = d;
      // console.log(this.nguoidungs);
    });
    this.nganhNhoms$ = this.categoryService.loadCategory();
    this.nganhNhoms$.subscribe(
      (d) => (this.nganhs = d.filter((nganh) => nganh.macha == null))
    );
  }
  openAddNguoiDung() {
    this.windowService.open(ThemUserComponent, {
      title: "Thêm tài khoản ",
    });
  }
  toggle(checked: boolean, manganh: string) {
    console.log(manganh + " - " + checked);
  }
  btnChiTietNguoiDung(tendangnhap: string) {
    this.nguoidungService
      .getNguoidung(tendangnhap)
      .subscribe((d) => console.log(d));
  }
  togglePQ(checked: boolean) {}
}
