import { NguoidungService } from "./mock/nguoidung.service";
import { ReportService } from "./mock/report.service";

import { OrderService } from "./mock/order.service";
import {
  ModuleWithProviders,
  NgModule,
  Optional,
  SkipSelf,
} from "@angular/core";
import { CommonModule, DatePipe } from "@angular/common";
import {
  NbAuthModule,
  NbDummyAuthStrategy,
  NbPasswordAuthStrategy,
  NbAuthJWTToken,
} from "@nebular/auth";
import { NbSecurityModule, NbRoleProvider } from "@nebular/security";
import { of as observableOf } from "rxjs";

import { throwIfAlreadyLoaded } from "./module-import-guard";
import { AnalyticsService, LayoutService, LIB } from "./utils";
import { UserData } from "./data/users";
import { UserService } from "./mock/users.service";
import { MockDataModule } from "./mock/mock-data.module";
import { EffectsModule } from "@ngrx/effects";
import { ProductEffects } from "../@store/effects/product-effects";
import { ProductActions } from "../@store/actions/product-actions";
import { CartActions } from "../@store/actions/cart-actions";
import { CartEffects } from "../@store/effects/cart-effects";
import { AuthGuard } from "../auth/auth-guard.service";
import { CategoryService } from "./mock/category.service";
import { ProductService } from "./mock/product.service";
import { CartService } from "./mock/cart.service";
import { DataService } from "./mock/data.service";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

const formSetting: any = {
  redirectDelay: 0,
  showMessages: {
    success: true,
  },
};
const socialLinks = [
  {
    url: "https://github.com/akveo/nebular",
    target: "_blank",
    icon: "github",
  },
  {
    url: "https://www.facebook.com/akveo/",
    target: "_blank",
    icon: "facebook",
  },
  {
    url: "https://twitter.com/akveo_inc",
    target: "_blank",
    icon: "twitter",
  },
];

const DATA_SERVICES = [
  {
    provide: UserData,
    useClass: UserService,
    CategoryService,
    ProductService,
    CartService,
    DataService,
    OrderService,
    ReportService,
    NguoidungService,
  },
];

export class NbSimpleRoleProvider extends NbRoleProvider {
  getRole() {
    // here you could provide any role based on any auth flow
    return observableOf("guest");
  }
}

export const NB_CORE_PROVIDERS = [
  ...MockDataModule.forRoot().providers,
  ...DATA_SERVICES,
  ProductActions,
  CartActions,
  AuthGuard,
  ...NbAuthModule.forRoot({
    strategies: [
      NbPasswordAuthStrategy.setup({
        name: "email",
        baseEndpoint: "api/",
        token: {
          class: NbAuthJWTToken,

          key: "jwtToken", // this parameter tells where to look for the token
        },
        login: {
          endpoint: "Users/authenticate",
          method: "post",
        },
        register: {
          endpoint: "/auth/sign-up",
          method: "post",
        },
        logout: {
          endpoint: "Users/signout",
          method: "post",
        },
        requestPass: {
          endpoint: "/auth/request-pass",
          method: "post",
        },
        resetPass: {
          endpoint: "/auth/reset-pass",
          method: "post",
        },
      }),
    ],
    forms: {
      login: formSetting,
      register: formSetting,
      requestPassword: formSetting,
      resetPassword: formSetting,
      logout: {
        redirectDelay: 0,
      },
    },
  }).providers,

  NbSecurityModule.forRoot({
    accessControl: {
      guest: {
        view: "*",
      },
      user: {
        parent: "guest",
        create: "*",
        edit: "*",
        remove: "*",
      },
    },
  }).providers,

  {
    provide: NbRoleProvider,
    useClass: NbSimpleRoleProvider,
  },
  AnalyticsService,
  LIB,
  LayoutService,
];

@NgModule({
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    EffectsModule.forFeature([ProductEffects, CartEffects]),
  ],
  exports: [NbAuthModule],
  declarations: [],
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    throwIfAlreadyLoaded(parentModule, "CoreModule");
  }

  static forRoot(): ModuleWithProviders<CoreModule> {
    return {
      ngModule: CoreModule,
      providers: [...NB_CORE_PROVIDERS, DatePipe],
    };
  }
}
