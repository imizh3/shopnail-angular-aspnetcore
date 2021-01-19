import { DatePipe } from "@angular/common";
import { Component, OnInit, ViewChild } from "@angular/core";
import { NbPopoverDirective } from "@nebular/theme";
import { BaocaoRequest } from "../../@core/data/baocaoRequest";
import { BaocaoxuatbanbuonTH } from "../../@core/data/baocaoxuatbanbuonTH";
import { ReportService } from "../../@core/mock/report.service";
import { LIB } from "../../@core/utils";

@Component({
  selector: "ngx-thong-ke",
  templateUrl: "./thong-ke.component.html",
  styleUrls: ["./thong-ke.component.scss"],
})
export class ThongKeComponent implements OnInit {
  user: any;
  baocaoxuatbanbuonTHs: BaocaoxuatbanbuonTH[];
  bc: BaocaoxuatbanbuonTH;
  baocaoRequest: BaocaoRequest;
  tuNgayDate = this.datePipe.transform(new Date(Date.now()), "yyyy-MM-dd");
  denNgayDate = this.datePipe.transform(new Date(Date.now()), "yyyy-MM-dd");
  @ViewChild(NbPopoverDirective) popover;
  constructor(
    private lib: LIB,
    private reportService: ReportService,
    private datePipe: DatePipe
  ) {}

  ngOnInit(): void {
    this.user = this.lib.user;
    this.baocaoRequest = new BaocaoRequest();
    this.baocaoRequest.trangThai = 10;
    this.baocaoRequest.tuNgay = this.tuNgayDate;
    this.baocaoRequest.denNgay = this.denNgayDate;
    this.baocaoRequest.manhanvien = "";
    const $baocao = this.reportService.getBaocaoxuatbanbuonTH(
      this.baocaoRequest
    );
    $baocao.subscribe((d: BaocaoxuatbanbuonTH[]) => {
      this.baocaoxuatbanbuonTHs = d;
      this.bc = this.baocaoxuatbanbuonTHs[0];
      if (this.bc === undefined) {
        this.bc = new BaocaoxuatbanbuonTH();
        this.bc.soluong = 0;
        this.bc.tienhang = 0;
      }
    });
  }
  btnLocClicked() {
    this.baocaoRequest.tuNgay = this.tuNgayDate;
    this.baocaoRequest.denNgay = this.denNgayDate;
    this.baocaoRequest.manhanvien = "";
    const $baocao = this.reportService.getBaocaoxuatbanbuonTH(
      this.baocaoRequest
    );
    $baocao.subscribe((d: BaocaoxuatbanbuonTH[]) => {
      this.baocaoxuatbanbuonTHs = d;
      this.bc = this.baocaoxuatbanbuonTHs[0];
    });
    this.popover;
  }
}
