import {
  NbButtonModule,
  NbCardModule,
  NbDatepickerModule,
  NbFormFieldModule,
  NbIconModule,
  NbInputModule,
  NbListModule,
  NbPopoverModule,
  NbSelectModule,
  NbSpinnerModule,
  NbUserModule,
} from "@nebular/theme";
import { ControllModule } from "./../@component/controll.module";
import { ThemeModule } from "./../@theme/theme.module";
import { ReportComponent } from "./report.component";
import { NgModule } from "@angular/core";
import { ReportRoutingModule } from "./report-routing.module";
import { BaoCaoComponent } from "./bao-cao/bao-cao.component";
import { NbEvaIconsModule } from "@nebular/eva-icons";
import { NbMomentDateModule } from "@nebular/moment";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BcNhapMuaComponent } from './bc-nhap-mua/bc-nhap-mua.component';
import { BcNhapTraLaiComponent } from './bc-nhap-tra-lai/bc-nhap-tra-lai.component';
import { BcBanHangTheoNhanComponent } from './bc-ban-hang-theo-nhan/bc-ban-hang-theo-nhan.component';
import { BcHangXuatTraComponent } from './bc-hang-xuat-tra/bc-hang-xuat-tra.component';
import { BcXntComponent } from './bc-xnt/bc-xnt.component';
import { BcHangTonKhoComponent } from './bc-hang-ton-kho/bc-hang-ton-kho.component';
import { BcKhuyenMaiTheoChtrinhComponent } from './bc-khuyen-mai-theo-chtrinh/bc-khuyen-mai-theo-chtrinh.component';
import { BcTongHopKhuyenMaiComponent } from './bc-tong-hop-khuyen-mai/bc-tong-hop-khuyen-mai.component';
import { BcCongNoNccComponent } from './bc-cong-no-ncc/bc-cong-no-ncc.component';
import { BcCongNoKhachHangComponent } from './bc-cong-no-khach-hang/bc-cong-no-khach-hang.component';
import { BcCongNoNvGiaoHangComponent } from './bc-cong-no-nv-giao-hang/bc-cong-no-nv-giao-hang.component';
import { BcQuyTienMatComponent } from './bc-quy-tien-mat/bc-quy-tien-mat.component';
import { BcBangKePhieuThuComponent } from './bc-bang-ke-phieu-thu/bc-bang-ke-phieu-thu.component';
import { BcBangKePhieuChiComponent } from './bc-bang-ke-phieu-chi/bc-bang-ke-phieu-chi.component';

@NgModule({
  imports: [
    ThemeModule,
    ReportRoutingModule,
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
  ],
  declarations: [ReportComponent, BaoCaoComponent, BcNhapMuaComponent, BcNhapTraLaiComponent, BcBanHangTheoNhanComponent, BcHangXuatTraComponent, BcXntComponent, BcHangTonKhoComponent, BcKhuyenMaiTheoChtrinhComponent, BcTongHopKhuyenMaiComponent, BcCongNoNccComponent, BcCongNoKhachHangComponent, BcCongNoNvGiaoHangComponent, BcQuyTienMatComponent, BcBangKePhieuThuComponent, BcBangKePhieuChiComponent],
})
export class ReportModule {}
