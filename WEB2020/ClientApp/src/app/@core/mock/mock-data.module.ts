import { NgModule, ModuleWithProviders } from "@angular/core";
import { CommonModule } from "@angular/common";

import { UserService } from "./users.service";
import { CategoryService } from "./category.service";
import { ProductService } from "./product.service";
import { CartService } from "./cart.service";
import { DataService } from "./data.service";
import { ReportService } from "./report.service";

const SERVICES = [
  UserService,
  CategoryService,
  ProductService,
  CartService,
  DataService,
  ReportService,
];

@NgModule({
  imports: [CommonModule],
  providers: [...SERVICES],
})
export class MockDataModule {
  static forRoot(): ModuleWithProviders {
    return <ModuleWithProviders>{
      ngModule: MockDataModule,
      providers: [...SERVICES],
    };
  }
}
