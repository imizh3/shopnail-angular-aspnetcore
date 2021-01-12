import { Component, OnInit, OnDestroy, AfterViewInit } from "@angular/core";
import { NbThemeService } from "@nebular/theme";

@Component({
  selector: "ngx-chart-pie",
  templateUrl: "./chart-pie.component.html",
  styleUrls: ["./chart-pie.component.scss"],
})
export class ChartPieComponent implements OnDestroy, AfterViewInit {
  options: any = {};
  themeSubscription: any;

  constructor(private theme: NbThemeService) {}

  ngAfterViewInit() {
    this.themeSubscription = this.theme.getJsTheme().subscribe((config) => {
      const colors = config.variables;
      const echarts: any = config.variables.echarts;

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
          data: ["Doanh số còn lại", "Doanh số thực"],
          textStyle: {
            color: echarts.textColor,
          },
        },
        series: [
          {
            name: "Doanh số",
            type: "pie",
            radius: "80%",
            center: ["50%", "50%"],
            data: [
              { value: 300, name: "Doanh số còn lại" },
              { value: 400, name: "Doanh số thực" },
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

  ngOnDestroy(): void {
    this.themeSubscription.unsubscribe();
  }
}
