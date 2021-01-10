import { BaocaoRequest } from "./../data/baocaoRequest";
import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { LIB } from "../utils";

@Injectable({
  providedIn: "root",
})
export class ReportService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private lib: LIB
  ) {
    this.baseUrl = baseUrl;
  }

  getBaocaoxuatbanbuonTH(request: BaocaoRequest) {
    return this.http.post(
      this.baseUrl + "api/Report/baocaoxuatbanbuonth",
      request,
      this.lib.httpOption()
    );
  }
}
