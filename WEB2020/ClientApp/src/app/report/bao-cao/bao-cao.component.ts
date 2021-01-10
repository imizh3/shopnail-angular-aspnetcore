import { List } from "immutable";
import { BaocaoRequest } from "./../../@core/data/baocaoRequest";
import { BaocaoxuatbanbuonTH } from "./../../@core/data/baocaoxuatbanbuonTH";
import { ReportService } from "./../../@core/mock/report.service";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "ngx-bao-cao",
  templateUrl: "./bao-cao.component.html",
  styleUrls: ["./bao-cao.component.scss"],
})
export class BaoCaoComponent implements OnInit {
  baocaoxuatbanbuonTHs: BaocaoxuatbanbuonTH[];
  bc: BaocaoxuatbanbuonTH;
  baocaoRequest: BaocaoRequest;
  constructor(private reportService: ReportService) {}

  ngOnInit(): void {
    this.baocaoRequest = new BaocaoRequest();
    this.baocaoRequest.trangThai = 10;
    this.baocaoRequest.tuNgay = "2020/10/01";
    this.baocaoRequest.denNgay = "2020/10/09";
    const $baocao = this.reportService.getBaocaoxuatbanbuonTH(
      this.baocaoRequest
    );
    $baocao.subscribe((d: BaocaoxuatbanbuonTH[]) => {
      this.baocaoxuatbanbuonTHs = d;
      this.bc = this.baocaoxuatbanbuonTHs[0];
      //console.log(this.bc);
    });
  }
}
