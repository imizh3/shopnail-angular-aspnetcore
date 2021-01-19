import { BaocaoxuatbanbuonTH } from "./../../@core/data/baocaoxuatbanbuonTH";
import {
  Component,
  OnInit,
  OnDestroy,
  AfterViewInit,
  Input,
  OnChanges,
} from "@angular/core";
import { NbThemeService } from "@nebular/theme";

@Component({
  selector: "ngx-chart-pie",
  templateUrl: "./chart-pie.component.html",
  styleUrls: ["./chart-pie.component.scss"],
})
export class ChartPieComponent
  implements OnDestroy, AfterViewInit, OnInit, OnChanges {
  @Input() data: BaocaoxuatbanbuonTH;
  @Input() tenbieudo: string;
  options: any = {};
  themeSubscription: any;
  value: number;
  muctieu: number;
  constructor(private theme: NbThemeService) {}

  ngOnChanges() {
    if (this.data === undefined) {
      this.data = new BaocaoxuatbanbuonTH();
      this.data.soluong = 0;
      this.data.tienhang = 0;
    }
    this.themeSubscription = this.theme.getJsTheme().subscribe((config) => {
      const colors = config.variables;
      const echarts: any = config.variables.echarts;
      if (this.tenbieudo === "Doanh thu") {
        this.muctieu = 400000;
        this.value = this.data.tienhang;
      } else {
        this.muctieu = 100;
        this.value = this.data.soluong;
      }
      this.options = {
        backgroundColor: echarts.bg,
        color: [
          colors.warningLight,
          colors.infoLight,
          colors.dangerLight,
          colors.successLight,
          colors.primaryLight,
        ],
        tooltip: {
          trigger: "item",
          formatter: "{a} <br/>{b} : {c} ({d}%)",
        },
        legend: {
          orient: "vertical",
          left: "left",
          data: ["Còn lại", "Đã đạt"],
          textStyle: {
            color: echarts.textColor,
          },
        },
        series: [
          {
            name: this.tenbieudo,
            type: "pie",
            radius: "80%",
            center: ["50%", "50%"],
            data: [
              { value: this.muctieu - this.data.soluong, name: "Còn lại" },
              { value: this.value, name: "Đã đạt" },
            ],
            itemStyle: {
              emphasis: {
                shadowBlur: 10,
                shadowOffsetX: 0,
                shadowColor: echarts.itemHoverShadowColor,
              },
            },
            label: {
              normal: {
                textStyle: {
                  color: echarts.textColor,
                },
              },
            },
            labelLine: {
              normal: {
                lineStyle: {
                  color: echarts.axisLineColor,
                },
              },
            },
          },
        ],
      };
    });
  }
  ngOnInit() {}
  ngAfterViewInit() {
    // if (this.data === undefined) {
    //   this.data = new BaocaoxuatbanbuonTH();
    //   this.data.soluong = 0;
    //   this.data.tienhang = 0;
    // }
    // this.themeSubscription = this.theme.getJsTheme().subscribe((config) => {
    //   const colors = config.variables;
    //   const echarts: any = config.variables.echarts;
    //   if (this.tenbieudo === "Doanh thu") {
    //     this.muctieu = 400000;
    //     this.value = this.data.tienhang;
    //   } else {
    //     this.muctieu = 100;
    //     this.value = this.data.soluong;
    //   }
    //   this.options = {
    //     backgroundColor: echarts.bg,
    //     color: [
    //       colors.warningLight,
    //       colors.infoLight,
    //       colors.dangerLight,
    //       colors.successLight,
    //       colors.primaryLight,
    //     ],
    //     tooltip: {
    //       trigger: "item",
    //       formatter: "{a} <br/>{b} : {c} ({d}%)",
    //     },
    //     legend: {
    //       orient: "vertical",
    //       left: "left",
    //       data: ["Còn lại", "Đã đạt"],
    //       textStyle: {
    //         color: echarts.textColor,
    //       },
    //     },
    //     series: [
    //       {
    //         name: this.tenbieudo,
    //         type: "pie",
    //         radius: "80%",
    //         center: ["50%", "50%"],
    //         data: [
    //           { value: this.muctieu - this.data.soluong, name: "Còn lại" },
    //           { value: this.value, name: "Đã đạt" },
    //         ],
    //         itemStyle: {
    //           emphasis: {
    //             shadowBlur: 10,
    //             shadowOffsetX: 0,
    //             shadowColor: echarts.itemHoverShadowColor,
    //           },
    //         },
    //         label: {
    //           normal: {
    //             textStyle: {
    //               color: echarts.textColor,
    //             },
    //           },
    //         },
    //         labelLine: {
    //           normal: {
    //             lineStyle: {
    //               color: echarts.axisLineColor,
    //             },
    //           },
    //         },
    //       },
    //     ],
    //   };
    // });
  }

  ngOnDestroy(): void {
    this.themeSubscription.unsubscribe();
  }
}
