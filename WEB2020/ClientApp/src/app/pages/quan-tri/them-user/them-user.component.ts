import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import {
  NbGlobalPhysicalPosition,
  NbToastrService,
  NbWindowRef,
} from "@nebular/theme";
import { Giaodich } from "../../../@core/data/giaodich";
import { OrderService } from "../../../@core/mock/order.service";
import { DataSourceService } from "../../../services/data.service";

@Component({
  selector: "ngx-them-user",
  templateUrl: "./them-user.component.html",
  styleUrls: ["./them-user.component.scss"],
})
export class ThemUserComponent implements OnInit {
  constructor(
    private fb: FormBuilder,
    private winRef: NbWindowRef,
    private orderService: OrderService,
    private toastService: NbToastrService,
    private data: DataSourceService
  ) {}

  ngOnInit(): void {}

  onSubmit() {}
}
