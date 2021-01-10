import { ThungLeComponent } from "./thung-le/thung-le.component";
import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { AutoKhachhangComponent } from "./auto-khachhang/auto-khachhang.component";
import { NbAutocompleteModule, NbInputModule } from "@nebular/theme";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { AutoSanphamComponent } from "./auto-sanpham/auto-sanpham.component";
import { PipeModule } from "../@core/pipes/pipes.module";
import { ChartBarComponent } from "./chart-bar/chart-bar.component";
import { ChartModule } from "angular2-chartjs";
import { TotalBarComponent } from "./total-bar/total-bar.component";
import { ChartPieComponent } from "./chart-pie/chart-pie.component";
import { NgxEchartsModule } from "ngx-echarts";

@NgModule({
  imports: [
    CommonModule,
    NbInputModule,
    NbAutocompleteModule,
    FormsModule,
    PipeModule,
    ChartModule,
    NgxEchartsModule,
  ],
  declarations: [
    AutoKhachhangComponent,
    AutoSanphamComponent,
    ThungLeComponent,
    ChartBarComponent,
    TotalBarComponent,
    ChartPieComponent,
  ],
  exports: [
    AutoKhachhangComponent,
    AutoSanphamComponent,
    ThungLeComponent,
    ChartBarComponent,
    TotalBarComponent,
    ChartPieComponent,
  ],
})
export class ControllModule {}
