import { async } from "@angular/core/testing";
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "ngx-one-column-layout",
  styleUrls: ["./one-column.layout.scss"],
  template: `
    <nb-layout windowMode="false">
      <nb-layout-header fixed>
        <ngx-header></ngx-header>
      </nb-layout-header>

      <nb-sidebar class="menu-sidebar" tag="menu-sidebar" responsive start>
        <ngx-menu></ngx-menu>
      </nb-sidebar>

      <nb-layout-column>
        <ng-content select="router-outlet"></ng-content>
      </nb-layout-column>
    </nb-layout>
  `,
})
export class OneColumnLayoutComponent {}
