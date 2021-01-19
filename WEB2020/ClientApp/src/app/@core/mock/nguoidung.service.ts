import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Nguoidung } from "../data/nguoidung";
import { LIB } from "../utils";

@Injectable({
  providedIn: "root",
})
export class NguoidungService {
  constructor(
    private http: HttpClient,
    @Inject("BASE_URL") baseUrl: string,
    private lib: LIB
  ) {}
  getNguoidungs() {
    return this.http.get<Nguoidung[]>(
      this.lib.baseUrl + "api/Users",
      this.lib.httpOption()
    );
  }
  getNguoidung(tendangnhap: string) {
    return this.http.get<Nguoidung>(
      this.lib.baseUrl + "api/Users" + "/" + tendangnhap,
      this.lib.httpOption()
    );
  }
}
