import { ThongKeComponent } from "./thong-ke/thong-ke.component";
import { QuanTriComponent } from "./quan-tri/quan-tri.component";
import { DonHangCtComponent } from "./don-hang/don-hang-ct/don-hang-ct.component";
import { KhuyenMaiCtComponent } from "./khuyen-mai/khuyen-mai-ct/khuyen-mai-ct.component";
import { KhuyenMaiComponent } from "./khuyen-mai/khuyen-mai.component";

import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";

import { PagesComponent } from "./pages.component";
import { DashboardComponent } from "./dashboard/dashboard.component";
import { HomeComponent } from "./home/home.component";
import { AuthGuard } from "../auth/auth-guard.service";
import { ProductsResolver } from "./home/guards/products-resolver";
import { DonHangComponent } from "./don-hang/don-hang.component";

const routes: Routes = [
  {
    path: "",
    canActivate: [AuthGuard],
    component: PagesComponent,
    children: [
      {
        path: "dashboard",
        canActivate: [AuthGuard],
        component: DashboardComponent,
      },
      {
        path: "Home",
        canActivate: [AuthGuard],
        component: HomeComponent,
        resolve: {
          data: ProductsResolver,
        },
      },
      {
        path: "Search",
        canActivate: [AuthGuard],
        component: HomeComponent,
        resolve: {
          data: ProductsResolver,
        },
      },
      {
        path: "Home?:query",
        canActivate: [AuthGuard],
        component: HomeComponent,
        resolve: {
          data: ProductsResolver,
        },
      },
      {
        path: "Home/:id",
        canActivate: [AuthGuard],
        component: HomeComponent,
        resolve: {
          data: ProductsResolver,
        },
      },
      {
        path: "Home/:id/:nhom",
        canActivate: [AuthGuard],
        component: HomeComponent,
        resolve: {
          data: ProductsResolver,
        },
      },
      {
        path: "Khuyen-mai",
        canActivate: [AuthGuard],
        component: KhuyenMaiComponent,
      },
      {
        path: "Quan-tri",
        canActivate: [AuthGuard],
        component: QuanTriComponent,
      },
      {
        path: "Thong-ke",
        canActivate: [AuthGuard],
        component: ThongKeComponent,
      },
      {
        path: "chi-tiet-khuyen-mai",
        canActivate: [AuthGuard],
        component: KhuyenMaiCtComponent,
      },
      {
        path: "Don-hang",
        canActivate: [AuthGuard],
        component: DonHangComponent,
      },
      {
        path: "chi-tiet-don-hang",
        canActivate: [AuthGuard],
        component: DonHangCtComponent,
      },
      {
        path: "",
        redirectTo: "Home",
        pathMatch: "full",
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule {}
