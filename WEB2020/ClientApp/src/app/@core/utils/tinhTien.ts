import { List, Stack } from 'immutable';

export class TinhTien {

  public static TIEN_CK: string = 'TIENCK';
  public static TIEN_HANG: string = 'TIENHANG';
  public static TIEN_VAT: string = 'TIENVAT';
  public static TIEN_KM: string = 'TIENKM';
  public static TIEN_CPVC: string = 'TIENCPVC';
  public static TIEN_CPKHAC: string = 'TIENCPKHAC';
  public static TIEN_THUE_NK: string = 'TIENTHUENK';

  public static GiaCoVATByGiaKhongVAT(giaKhongVat: number, DT_VAT: any, maVat: string) {
    let giaTriVat = '';
    const row_vat = DT_VAT.find(d => d.mavat === maVat);
    row_vat ? giaTriVat = row_vat.vat : '';
    let vat = 0;
    vat = parseFloat(giaTriVat);
    return giaKhongVat * (vat / 100 + 1);
  }

  // tslint:disable-next-line: comment-format
  //1. Tính giá không vat = giá có vat/(1 + vat/100)
  public static GiaKhongVATByGiaCoVAT(giaCoVat: number, DT_VAT: any, maVat: string) {
    let giaTriVat = '';
    const row_vat = DT_VAT.find(d => d.mavat === maVat);
    row_vat ? giaTriVat = row_vat.vat : '';
    let vat = 0;
    vat = parseFloat(giaTriVat);
    return giaCoVat / (1 + vat / 100);
  }

  // tslint:disable-next-line: comment-format
  //2. tính số lượng lẻ = số lượng thùng * quy cách + số lượng lẻ
  public static SoLuongLeBySoLuongThung(donViThung: string, quyCach: string) {
    let quycach = 1;
    quycach = parseFloat(quyCach);
    const thungle: string[] = donViThung.replace(' ', '').split('/');
    let soluongthung = 0;
    let soluongle = 0;
    if (thungle.length === 2) {
      soluongthung = parseFloat(thungle[0]);
      soluongle = parseFloat(thungle[1]);
    } else {
      soluongle = parseFloat(thungle[0]);
    }
    return soluongthung * quycach + soluongle;
  }

  // tslint:disable-next-line: comment-format
  //3. tính giá thùng = đơn giá * quy cách
  public static GiaThungByDonGia(donGia: number, quyCach: number) {
    donGia = donGia ? donGia : 0;
    quyCach = quyCach ? quyCach : 1;
    return donGia * quyCach;
  }

  // tslint:disable-next-line: comment-format
  //3. tính đơn giá = giá thùng vat /  quy cách
  public static DonGiaByGiaThung(giaThung: number, quyCach: number) {
    giaThung = giaThung ? giaThung : 0;
    quyCach = quyCach ? quyCach : 1;
    return giaThung / quyCach;
  }

  // tslint:disable-next-line: comment-format
  //4. tính giá bán(buôn, lẻ) = (giá có vat - tỷ lệ chiết khấu* giá có vat/100)*(tỷ lệ lãi/100 + 1)
  public static GiaBanByTyLeLai(giaNhapCoVat: number, tyLeCK: number, tyLeLai: number) {
    try {
      giaNhapCoVat = giaNhapCoVat ? giaNhapCoVat : 0;
      tyLeCK = tyLeCK ? tyLeCK : 0;
      tyLeLai = tyLeLai ? tyLeLai : 0;
      return (giaNhapCoVat - giaNhapCoVat * tyLeCK / 100) * (tyLeLai / 100 + 1);
    } catch {
      return 0;
    }
  }

  // tslint:disable-next-line: comment-format
  //4. tính tỉ lệ lãi = ((giá bán(buôn, lẻ)/(đơn giá - tỷ lệ chiết khấu* đơn giá/100) - 1)*100)
  public static TyLeLaiByGiaBan(giaBan: number, donGiaCoVat: number, tyLeCK: number) {
    try {
      giaBan = giaBan ? giaBan : 0;
      donGiaCoVat = donGiaCoVat ? donGiaCoVat : 0;
      tyLeCK = tyLeCK ? tyLeCK : 0;
      return (giaBan / (donGiaCoVat - donGiaCoVat * tyLeCK / 100) - 1) * 100;
    } catch {
      return 0;
    }
  }

  // tslint:disable-next-line: comment-format
  //5. tính tiền hàng = đơn giá không vat * số lượng
  public static TienHangByDonGia(Dongiachuavat: number, soLuongLe: number) {
    Dongiachuavat = Dongiachuavat ? Dongiachuavat : 0;
    soLuongLe = soLuongLe ? soLuongLe : 0;
    return Dongiachuavat * soLuongLe;
  }

  // tslint:disable-next-line: comment-format
  //5. tính tiền không vat = tiền hàng / số lượng
  public static DonGiaKhongVatByTienHang(tienHang: number, soLuongLe: number) {
    try {
      tienHang = tienHang ? tienHang : 0;
      soLuongLe = soLuongLe ? soLuongLe : 0;
      return tienHang / soLuongLe;
    } catch
    {
      return 0;
    }
  }

  // tslint:disable-next-line: comment-format
  //6. tính tiền chiết khấu = donGia0Vat*soLuongLe*tyLeCK/100
  public static TienChietKhauByGiaKhongVat(donGia0Vat: number, tyLeCK: number, soLuongLe: number) {
    donGia0Vat = donGia0Vat ? donGia0Vat : 0;
    tyLeCK = tyLeCK ? tyLeCK : 0;
    return donGia0Vat * soLuongLe * tyLeCK / 100;
  }

  // tslint:disable-next-line: comment-format
  //7. tính tiền vat theo công thức trong danh mục vat
  public static TienVatByCongThuc(tienHang: number, tienChietkhau: number, DT_VAT: any, maVat: string, tienThueNk: number) {
    try {
      let tienvat = 0;
      let congthucvat = '';
      const row_vat = DT_VAT.find(d => d.mavat === maVat);
      congthucvat = row_vat ? row_vat.congthuc : '';
      const giaTriBien = {};
      giaTriBien[this.TIEN_HANG] = tienHang ? tienHang : 0;
      giaTriBien[this.TIEN_CK] = tienChietkhau ? tienChietkhau : 0;
      giaTriBien[this.TIEN_THUE_NK] = tienThueNk ? tienThueNk : 0;
      tienvat = congthucvat ? this.TINHBIEUTHUC(congthucvat, giaTriBien) : 0;

      return tienvat;
    } catch
    {
      return 0;
    }
  }

  public static TienVatNkByCongThuc(tienHang: number, tienChietkhau: number, DT_VAT: any, maVat: string) {
    try {
      let tienvat = 0;
      let congthucvat = '';
      const row_vat = DT_VAT.find(d => d.mavat === maVat);
      if (row_vat != null)
        congthucvat = row_vat ? row_vat.congthuc : '';
      const giaTriBien = {};
      giaTriBien[this.TIEN_HANG] = tienHang ? tienHang : 0;
      giaTriBien[this.TIEN_CK] = tienChietkhau ? tienChietkhau : 0;
      tienvat = congthucvat ? this.TINHBIEUTHUC(congthucvat, giaTriBien) : 0;
      return tienvat;
    } catch
    {
      return 0;
    }
  }
  // tslint:disable-next-line: comment-format
  //8. tính thành tiền theo công thức
  // tslint:disable-next-line: max-line-length
  public static ThanhTienByCongThuc(tienHang: number, tienChietkhau: number, tienVat: number, tienKM: number, DT_PTNX: any, maPTNX: string) {
    try {
      const giaTriBien = {};
      giaTriBien[this.TIEN_HANG] = tienHang ? tienHang : 0;
      giaTriBien[this.TIEN_CK] = tienChietkhau ? tienChietkhau : 0;
      giaTriBien[this.TIEN_VAT] = tienVat ? tienVat : 0;
      giaTriBien[this.TIEN_KM] = tienKM ? tienVat : 0;
      let congthucThanhtien = '';
      let thanhtien = 0;
      const rowPtnx = DT_PTNX.find(d => d.maptnx === maPTNX);
      congthucThanhtien = rowPtnx ? rowPtnx.ctthanhtien : '';

      thanhtien = congthucThanhtien ? this.TINHBIEUTHUC(congthucThanhtien, giaTriBien) : 0;
      return thanhtien;
    } catch
    {
      return 0;
    }
  }

  public static ThanhTienNkByCongThuc(tienHang: number, tienChietkhau: number, tienVat: number, tienKM: number
    , tienVatNk: number, tienChiphiKhac: number, tienChiphiVc: number, DT_PTNX: any, maPTNX: string) {
    try {
      const giaTriBien = {};
      giaTriBien[this.TIEN_HANG] = tienHang ? tienHang : 0;
      giaTriBien[this.TIEN_CK] = tienChietkhau ? tienChietkhau : 0;
      giaTriBien[this.TIEN_VAT] = tienVat ? tienVat : 0;
      giaTriBien[this.TIEN_KM] = tienKM ? tienKM : 0;
      giaTriBien[this.TIEN_THUE_NK] = tienVatNk ? tienVatNk : 0;
      giaTriBien[this.TIEN_CPKHAC] = tienChiphiKhac ? tienChiphiKhac : 0;
      giaTriBien[this.TIEN_CPVC] = tienChiphiVc ? tienChiphiVc : 0;
      let congthucThanhtien = '';
      let thanhtien = 0;
      const rowPtnx = DT_PTNX.find(d => d.maptnx === maPTNX);
      congthucThanhtien = rowPtnx ? rowPtnx.ctthanhtien : '';
      thanhtien = congthucThanhtien ? this.TINHBIEUTHUC(congthucThanhtien, giaTriBien) : 0;
      return thanhtien;
    } catch
    {
      return 0;
    }
  }

  public static ConverThungByLe(soluong: number, quycach: number) {
    let sothung: string;

    // tslint:disable-next-line: radix
    const thung = parseInt((soluong / quycach).toString());
    const _sothung = parseFloat(thung.toString());
    // tslint:disable-next-line: radix
    const le = parseInt((soluong - (_sothung * quycach)).toString());
    sothung = _sothung.toString() + '/' + le.toString();
    return sothung;
  }

  public static ConverLeByThung(thung: string, quycach: number) {
    let soluong = 0;
    const listSothuong: string[] = thung.toString().split('/');
    let _sothung = 0, _soluongle = 0;
    _sothung = parseFloat(listSothuong[0].toString());
    if (listSothuong.length > 1) _soluongle = parseFloat(listSothuong[1].toString());

    soluong = (_sothung ? _sothung : 0) * quycach + (_soluongle ? _soluongle : 0);
    return soluong;
  }

  public static TINHBIEUTHUC(congThuc: string, giaTriBien: object) {
    if (!(congThuc)) return 0;
    const listCongThuc = [];
    let i = 0;
    const n = congThuc.length;
    let s = '';
    let bTinh: boolean = false;
    while (i < n) {
      if (congThuc[i] === '+' || congThuc[i] === '-' || congThuc[i] === '*'
        || congThuc[i] === '/' || congThuc[i] === '(' || congThuc[i] === ')') {
        let flag = true;
        if (s.length > 0) {
          if (giaTriBien[s] !== undefined) {
            listCongThuc.push(giaTriBien[s]);
          } else {
            try {
              listCongThuc.push(parseFloat(s));
            } catch { flag = false; }
          }
          s = '';
        }
        if (flag) { listCongThuc.push(congThuc[i].toString()); }
      } else {
        s += congThuc[i];
      }
      i++;
    }

    if (s.length > 0) {
      if (giaTriBien[s] !== undefined) {
        listCongThuc.push(giaTriBien[s]);
      } else {
        listCongThuc.push(parseFloat(s));
      }

    }

    let stack = Stack();
    stack.clear();
    const listKQ = [];

    for (let j = 0; j < listCongThuc.length; j++) {
      if (listCongThuc[j] === ')') {
        while (stack.peek() !== '(') {
          stack = stack.pop();
        }
        continue;
      }
      if (listCongThuc[j] === '+' || listCongThuc[j] === '-'
        || listCongThuc[j] === '*' || listCongThuc[j] === '/'
        || listCongThuc[j] === '(') {
        stack = stack.push(listCongThuc[j]);
        bTinh = false;
      } else {
        listKQ.push(listCongThuc[j]);
        bTinh = true;
      }
      if (stack.size === 0) continue;
      const toanTu = stack.peek();
      if (bTinh && listKQ.length > 1 && (toanTu === '+' || toanTu === '-' || toanTu === '*' || toanTu === '/')) {
        const toanHangA = parseFloat(listKQ[listKQ.length - 2]);
        const toanHangB = parseFloat(listKQ[listKQ.length - 1]);
        listKQ.pop();
        listKQ.pop();
        switch (toanTu) {
          case '+':
            listKQ.push(toanHangA + toanHangB);
            break;
          case '-':
            listKQ.push(toanHangA - toanHangB);
            break;
          case '*':
            listKQ.push(toanHangA * toanHangB);
            break;
          case '/':
            listKQ.push(toanHangA / toanHangB);
            break;
          default:
            break;
        }
      } else {
        stack.push(toanTu);
      }
    }

    while (listKQ.length > 1) {
      if (listKQ.length > 1 && stack.size > 0) {
        const toanTu = stack.peek();
        stack = stack.pop();
        const toanHangA = parseFloat(listKQ[listKQ.length - 2]);
        const toanHangB = parseFloat(listKQ[listKQ.length - 1]);
        listKQ.pop();
        listKQ.pop();
        switch (toanTu) {
          case '+':
            listKQ.push(toanHangA + toanHangB);
            break;
          case '-':
            listKQ.push(toanHangA - toanHangB);
            break;
          case '*':
            listKQ.push(toanHangA * toanHangB);
            break;
          case '/':
            listKQ.push(toanHangA / toanHangB);
            break;
          default:
            break;
        }
      }
    }
    if (listKQ.length === 0) return 0;
    const kq = parseFloat(listKQ[0]);
    return kq;
  }

  public static DoanhThuByCongThuc(tienHang: number, tienChietKhau: number, tienVat: number, tienKM: number, DT_PTNX: any, maPTNX: string) {
    try {
      const giaTriBien = {};
      giaTriBien[this.TIEN_HANG] = tienHang ? tienHang : 0;
      giaTriBien[this.TIEN_CK] = tienChietKhau ? tienChietKhau : 0;
      giaTriBien[this.TIEN_VAT] = tienVat ? tienVat : 0;
      giaTriBien[this.TIEN_KM] = tienKM ? tienKM : 0;


      let congthucDoanhthu = '';
      const rowPtnx = DT_PTNX.find(d => d.maptnx === maPTNX);
      congthucDoanhthu = rowPtnx ? rowPtnx.ctthucdoanhthu : '';
      let doanhthu = 0;
      doanhthu = this.TINHBIEUTHUC(congthucDoanhthu, giaTriBien);
      return doanhthu;
    } catch
    {
      return 0;
    }
  }

  public static DoanhThuNKByCongThuc(tienHang: number, tienChietkhau: number, tienVat: number, tienKM: number
    , tienVatNk: number, tienChiphiKhac: number, tienChiphiVc: number, DT_PTNX: any, maPTNX: string) {
    try {
      const giaTriBien = {};
      giaTriBien[this.TIEN_HANG] = tienHang ? tienHang : 0;
      giaTriBien[this.TIEN_CK] = tienChietkhau ? tienChietkhau : 0;
      giaTriBien[this.TIEN_VAT] = tienVat ? tienVat : 0;
      giaTriBien[this.TIEN_KM] = tienKM ? tienKM : 0;
      giaTriBien[this.TIEN_THUE_NK] = tienVatNk ? tienVatNk : 0;
      giaTriBien[this.TIEN_CPKHAC] = tienChiphiKhac ? tienChiphiKhac : 0;
      giaTriBien[this.TIEN_CPVC] = tienChiphiVc ? tienChiphiVc : 0;
      let congthucDoanhthu = '';
      let doanhthu = 0;
      const rowPtnx = DT_PTNX.find(d => d.maptnx === maPTNX);
      congthucDoanhthu = rowPtnx ? rowPtnx.ctthucdoanhthu : '';
      doanhthu = congthucDoanhthu ? this.TINHBIEUTHUC(congthucDoanhthu, giaTriBien) : 0;
      return doanhthu;
    } catch
    {
      return 0;
    }
  }

}
