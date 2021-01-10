import { Component } from '@angular/core';

@Component({
  selector: 'ngx-one-column-no-sidebar-layout',
  styleUrls: ['./one-column-no-sidebar.layout.scss'],
  template: `
    <nb-layout windowMode='false' >
      <nb-layout-header fixed>
        <ngx-header></ngx-header>
      </nb-layout-header>
      <nb-sidebar class="menu-sidebar" tag="menu-sidebar" responsive start>
          <ngx-menu-cart></ngx-menu-cart>
      </nb-sidebar>
      <nb-layout-column>
        <ng-content select="router-outlet"></ng-content>
      </nb-layout-column>
    </nb-layout>
  `,
})
export class OneColumnNoSidebarLayoutComponent {
}
