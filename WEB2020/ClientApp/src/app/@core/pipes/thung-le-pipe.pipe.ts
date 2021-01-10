import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
  name: "thungLePipe",
})
export class ThungLePipePipe implements PipeTransform {
  layThungOrLe(value: string, type: string) {
    const indexOfSlash = value.indexOf("/");
    const thung = parseInt(value.slice(0, indexOfSlash));
    const le = parseInt(value.slice(indexOfSlash + 1, value.length));
    if (type === "thung") {
      return thung;
    } else return le;
  }
  transform(value: string, ...args: any[]): any {
    let type = "thung";
    if (args && args.length > 0) {
      type = args[0].toString();
    }
    if (value !== undefined && value !== null) {
      return this.layThungOrLe(value, type);
    }
    return null;
  }
}
