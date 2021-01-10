import { BcBangKePhieuChiComponent } from "./bc-bang-ke-phieu-chi/bc-bang-ke-phieu-chi.component";
import { BcBangKePhieuThuComponent } from "./bc-bang-ke-phieu-thu/bc-bang-ke-phieu-thu.component";
import { BcQuyTienMatComponent } from "./bc-quy-tien-mat/bc-quy-tien-mat.component";
import { BcCongNoNvGiaoHangComponent } from "./bc-cong-no-nv-giao-hang/bc-cong-no-nv-giao-hang.component";
import { BcCongNoKhachHangComponent } from "./bc-cong-no-khach-hang/bc-cong-no-khach-hang.component";
import { BcCongNoNccComponent } from "./bc-cong-no-ncc/bc-cong-no-ncc.component";
import { BcTongHopKhuyenMaiComponent } from "./bc-tong-hop-khuyen-mai/bc-tong-hop-khuyen-mai.component";
import { BcKhuyenMaiTheoChtrinhComponent } from "./bc-khuyen-mai-theo-chtrinh/bc-khuyen-mai-theo-chtrinh.component";
import { BcHangTonKhoComponent } from "./bc-hang-ton-kho/bc-hang-ton-kho.component";
import { BcXntComponent } from "./bc-xnt/bc-xnt.component";
import { BcHangXuatTraComponent } from "./bc-hang-xuat-tra/bc-hang-xuat-tra.component";
import { BcNhapTraLaiComponent } from "./bc-nhap-tra-lai/bc-nhap-tra-lai.component";
import { BcNhapMuaComponent } from "./bc-nhap-mua/bc-nhap-mua.component";
import { BaoCaoComponent } from "./bao-cao/bao-cao.component";

import { ReportComponent } from "./report.component";
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthGuard } from "../auth/auth-guard.service";
import { BcBanHangTheoNhanComponent } from "./bc-ban-hang-theo-nhan/bc-ban-hang-theo-nhan.component";

const routes: Routes = [
  {
    path: "",
    canActivate: [AuthGuard],
    component: ReportComponent,
    children: [
      {
        path: "bao-cao",
        canActivate: [AuthGuard],
        component: BaoCaoComponent,
      },
      {
        path: "bao-cao-nhap-mua",
        canActivate: [AuthGuard],
        component: BcNhapMuaComponent,
      },
      {
        path: "bao-cao-nhap-tra-lai",
        canActivate: [AuthGuard],
        component: BcNhapTraLaiComponent,
      },
      {
        path: "bao-cao-ban-hang-theo-nhan",
        canActivate: [AuthGuard],
        component: BcBanHangTheoNhanComponent,
      },
      {
        path: "bao-cao-hang-xuat-tra",
        canActivate: [AuthGuard],
        component: BcHangXuatTraComponent,
      },
      {
        path: "bao-cao-xnt",
        canActivate: [AuthGuard],
        component: BcXntComponent,
      },
      {
        path: "bao-cao-ton-kho",
        canActivate: [AuthGuard],
        component: BcHangTonKhoComponent,
      },
      {
        path: "bao-cao-khuyen-mai-theo-ctr",
        canActivate: [AuthGuard],
        component: BcKhuyenMaiTheoChtrinhComponent,
      },
      {
        path: "bao-cao-tong-hop-km",
        canActivate: [AuthGuard],
        component: BcTongHopKhuyenMaiComponent,
      },
      {
        path: "bao-cao-cong-no-ncc",
        canActivate: [AuthGuard],
        component: BcCongNoNccComponent,
      },
      {
        path: "bao-cao-cong-no-kh",
        canActivate: [AuthGuard],
        component: BcCongNoKhachHangComponent,
      },
      {
        path: "bao-cao-cong-no-nvgiaohang",
        canActivate: [AuthGuard],
        component: BcCongNoNvGiaoHangComponent,
      },
      {
        path: "bao-cao-quy-tien-mat",
        canActivate: [AuthGuard],
        component: BcQuyTienMatComponent,
      },
      {
        path: "bang-ke-phieu-thu",
        canActivate: [AuthGuard],
        component: BcBangKePhieuThuComponent,
      },
      {
        path: "bang-ke-phieu-chi",
        canActivate: [AuthGuard],
        component: BcBangKePhieuChiComponent,
      },
      {
        path: "",
        redirectTo: "bao-cao",
        pathMatch: "full",
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ReportRoutingModule {}
