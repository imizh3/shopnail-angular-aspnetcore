import { BaocaoxuatbanbuonTH } from "./../../@core/data/baocaoxuatbanbuonTH";
import { Component, Input, OnInit } from "@angular/core";

@Component({
  selector: "ngx-total-bar",
  templateUrl: "./total-bar.component.html",
  styleUrls: ["./total-bar.component.scss"],
})
export class TotalBarComponent implements OnInit {
  @Input() data: BaocaoxuatbanbuonTH;
  constructor() {}

  ngOnInit(): void {}
}
