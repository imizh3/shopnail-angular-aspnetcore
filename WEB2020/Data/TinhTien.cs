using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WEB2020.Models;

namespace WEB2020.Data
{
    public class TinhTien
    {
        //1. Tính giá có vat = giá không vat*(vat/100 + 1)
        public static decimal GiaCoVATByGiaKhongVAT(decimal giaKhongVat, List<Vat> DT_VAT, string maVat)
        {
            string giaTriVat = "";
            Vat row_vat = DT_VAT.Where(d => d.Mavat == maVat).FirstOrDefault();
            if (row_vat != null) giaTriVat = row_vat.Mavat.ToString();
            decimal vat = 0; decimal.TryParse(giaTriVat, out vat);
            return giaKhongVat * (vat / 100 + 1);
        }

        //1. Tính giá không vat = giá có vat/(1 + vat/100)
        public static decimal GiaKhongVATByGiaCoVAT(decimal giaCoVat, List<Vat> DT_VAT, string maVat)
        {
            string giaTriVat = "";
            Vat row_vat = DT_VAT.Where(d => d.Mavat == maVat).FirstOrDefault();
            if (row_vat != null) giaTriVat = row_vat.Mavat.ToString();
            decimal vat = 0; decimal.TryParse(giaTriVat, out vat);
            return giaCoVat / (1 + vat / 100);
        }

        //2. tính số lượng lẻ = số lượng thùng * quy cách + số lượng lẻ
        public static decimal SoLuongLeBySoLuongThung(string donViThung, string quyCach)
        {
            decimal quycach = 1; decimal.TryParse(quyCach, out quycach);
            string[] thungle = donViThung.Replace(" ", "").Split('/');
            decimal soluongthung = 0;
            decimal soluongle = 0;
            if (thungle.Length == 2)
            {
                decimal.TryParse(thungle[0], out soluongthung);
                decimal.TryParse(thungle[1], out soluongle);
            }
            else
            {
                decimal.TryParse(thungle[0], out soluongle);
            }
            return soluongthung * quycach + soluongle;
        }

        //3. tính giá thùng = đơn giá * quy cách
        public static decimal GiaThungByDonGia(string donGia, string quyCach)
        {
            decimal dongia = 0; decimal.TryParse(donGia, out dongia);
            decimal quycach = 1; decimal.TryParse(quyCach, out quycach);
            return Math.Round(dongia * quycach, 2);
        }

        //3. tính đơn giá = giá thùng vat /  quy cách
        public static decimal DonGiaByGiaThung(string giaThung, string quyCach)
        {
            decimal giathung = 0; decimal.TryParse(giaThung, out giathung);
            decimal quycach = 1; decimal.TryParse(quyCach, out quycach);
            return Math.Round(giathung / quycach, 2);
        }

        //4. tính giá bán(buôn, lẻ) = (giá có vat - tỷ lệ chiết khấu* giá có vat/100)*(tỷ lệ lãi/100 + 1)
        public static decimal GiaBanByTyLeLai(string giaNhapCoVat, string tyLeCK, string tyLeLai)
        {
            try
            {
                decimal giaMuaCoVat = 0; decimal.TryParse(giaNhapCoVat, out giaMuaCoVat);
                decimal CK = 0; decimal.TryParse(tyLeCK, out CK);
                decimal lai = 0; decimal.TryParse(tyLeLai, out lai);
                return (giaMuaCoVat - giaMuaCoVat * CK / 100) * (lai / 100 + 1);
            }
            catch
            {
                return 0;
            }
        }

        //4. tính tỉ lệ lãi = ((giá bán(buôn, lẻ)/(đơn giá - tỷ lệ chiết khấu* đơn giá/100) - 1)*100)
        public static decimal TyLeLaiByGiaBan(string giaBan, string donGiaCoVat, string tyLeCK)
        {
            try
            {
                decimal dGiaBan = 0; decimal.TryParse(giaBan, out dGiaBan);
                decimal dDonGiaCoVat = 0; decimal.TryParse(donGiaCoVat, out dDonGiaCoVat);
                decimal dTyLeCK = 0; decimal.TryParse(tyLeCK, out dTyLeCK);
                return (dGiaBan / (dDonGiaCoVat - dDonGiaCoVat * dTyLeCK / 100) - 1) * 100;
            }
            catch
            {
                return 0;
            }
        }

        //5. tính tiền hàng = đơn giá không vat * số lượng
        public static decimal TienHangByDonGia(decimal Dongiachuavat, decimal soLuongLe)
        {
            return Dongiachuavat * soLuongLe;
        }

        //5. tính tiền không vat = tiền hàng / số lượng
        public static decimal DonGiaKhongVatByTienHang(string tienHang, string soLuongLe)
        {
            try
            {
                decimal dTienHang = 0; decimal.TryParse(tienHang, out dTienHang);
                decimal dSoLuongLe = 0; decimal.TryParse(soLuongLe, out dSoLuongLe);
                return Math.Round((dTienHang / dSoLuongLe), 2);
            }
            catch
            {
                return 0;
            }
        }

        //6. tính tiền chiết khấu = donGia0Vat*soLuongLe*tyLeCK/100
        public static decimal TienChietKhauByGiaKhongVat(decimal donGia0Vat, decimal tyLeCK, decimal soLuongLe)
        {
            return donGia0Vat * soLuongLe * tyLeCK / 100;
        }

        //7. tính tiền vat theo công thức trong danh mục vat
        public static decimal TienVatByCongThuc(decimal tienHang, decimal tienChietkhau, List<Vat> DT_VAT, string maVat, decimal tienThueNk)
        {
            try
            {
                decimal tienvat = 0;
                string congthucvat = "";
                Vat row_vat = DT_VAT.Where(d => d.Mavat == maVat).FirstOrDefault();
                if (row_vat != null) congthucvat = row_vat.Congthuc.ToString();
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TIEN_HANG, tienHang);
                giaTriBien.Add(PublicValue.TIEN_CK, tienChietkhau);
                giaTriBien.Add(PublicValue.TIEN_THUE_NK, tienThueNk);
                if (!string.IsNullOrEmpty(congthucvat)) tienvat = TINHBIEUTHUC(congthucvat, giaTriBien);

                return tienvat;
            }
            catch
            {
                return 0;
            }
        }
        public static decimal TienVatNkByCongThuc(decimal tienHang, decimal tienChietkhau, List<Vat> DT_VAT, string maVat)
        {
            try
            {
                decimal tienvat = 0;
                string congthucvat = "";
                Vat row_vat = DT_VAT.Where(d => d.Mavat == maVat).FirstOrDefault();
                if (row_vat != null) congthucvat = row_vat.Congthuc.ToString();
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TIEN_HANG, tienHang);
                giaTriBien.Add(PublicValue.TIEN_CK, tienChietkhau);
                if (!string.IsNullOrEmpty(congthucvat)) tienvat = TINHBIEUTHUC(congthucvat, giaTriBien);
                return tienvat;
            }
            catch
            {
                return 0;
            }
        }
        //8. tính thành tiền theo công thức
        public static decimal ThanhTienByCongThuc(decimal tienHang, decimal tienChietkhau, decimal tienVat, decimal tienKM, List<Dmptnx> DT_PTNX, string maPTNX)
        {
            try
            {
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TIEN_HANG, tienHang);
                giaTriBien.Add(PublicValue.TIEN_CK, tienChietkhau);
                giaTriBien.Add(PublicValue.TIEN_VAT, tienVat);
                giaTriBien.Add(PublicValue.TIEN_KM, tienKM);
                string congthucThanhtien = "";
                decimal thanhtien = 0;
                Dmptnx[] rowPtnx = DT_PTNX.Where(d => d.Maptnx == maPTNX).ToArray();
                if (rowPtnx.Length == 1)
                {
                    congthucThanhtien = rowPtnx[0].Ctthanhtien.ToString();
                }
                if (!string.IsNullOrEmpty(congthucThanhtien)) thanhtien = TINHBIEUTHUC(congthucThanhtien, giaTriBien);
                return thanhtien;
            }
            catch
            {
                return 0;
            }
        }
        public static decimal ThanhTienNkByCongThuc(decimal tienHang, decimal tienChietkhau, decimal tienVat, decimal tienKM
            , decimal tienVatNk, decimal tienChiphiKhac, decimal tienChiphiVc, List<Dmptnx> DT_PTNX, string maPTNX)
        {
            try
            {
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TIEN_HANG, tienHang);
                giaTriBien.Add(PublicValue.TIEN_CK, tienChietkhau);
                giaTriBien.Add(PublicValue.TIEN_VAT, tienVat);
                giaTriBien.Add(PublicValue.TIEN_KM, tienKM);
                giaTriBien.Add(PublicValue.TIEN_THUE_NK, tienVatNk);
                giaTriBien.Add(PublicValue.TIEN_CPKHAC, tienChiphiKhac);
                giaTriBien.Add(PublicValue.TIEN_CPVC, tienChiphiVc);
                string congthucThanhtien = "";
                decimal thanhtien = 0;
                Dmptnx[] rowPtnx = DT_PTNX.Where(d => d.Maptnx == maPTNX).ToArray();
                if (rowPtnx.Length == 1)
                {
                    congthucThanhtien = rowPtnx[0].Ctthanhtien.ToString();
                }
                if (!string.IsNullOrEmpty(congthucThanhtien)) thanhtien = TINHBIEUTHUC(congthucThanhtien, giaTriBien);
                return thanhtien;
            }
            catch
            {
                return 0;
            }
        }
        //9. tính doanh thu theo công thức
        public static decimal DoanhThuByCongThuc(decimal tienHang, decimal tienChietkhau, decimal tienVat, decimal tienKM, List<Dmptnx> DT_PTNX, string maPTNX)
        {
            try
            {
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TIEN_HANG, tienHang);
                giaTriBien.Add(PublicValue.TIEN_CK, tienChietkhau);
                giaTriBien.Add(PublicValue.TIEN_VAT, tienVat);
                giaTriBien.Add(PublicValue.TIEN_KM, tienKM);
                string congthucDoanhthu = "";
                decimal doanhthu = 0;
                Dmptnx[] rowPtnx = DT_PTNX.Where(d => d.Maptnx == maPTNX).ToArray();
                if (rowPtnx.Length == 1)
                {
                    congthucDoanhthu = rowPtnx[0].Ctthucdoanhthu.ToString();
                }
                if (!string.IsNullOrEmpty(congthucDoanhthu)) doanhthu = TINHBIEUTHUC(congthucDoanhthu, giaTriBien);
                return doanhthu;
            }
            catch
            {
                return 0;
            }
        }
        public static decimal DoanhThuNKByCongThuc(decimal tienHang, decimal tienChietkhau, decimal tienVat, decimal tienKM
            , decimal tienVatNk, decimal tienChiphiKhac, decimal tienChiphiVc, List<Dmptnx> DT_PTNX, string maPTNX)
        {
            try
            {
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TIEN_HANG, tienHang);
                giaTriBien.Add(PublicValue.TIEN_CK, tienChietkhau);
                giaTriBien.Add(PublicValue.TIEN_VAT, tienVat);
                giaTriBien.Add(PublicValue.TIEN_KM, tienKM);
                giaTriBien.Add(PublicValue.TIEN_THUE_NK, tienVatNk);
                giaTriBien.Add(PublicValue.TIEN_CPKHAC, tienChiphiKhac);
                giaTriBien.Add(PublicValue.TIEN_CPVC, tienChiphiVc);
                string congthucDoanhthu = "";
                decimal doanhthu = 0;
                Dmptnx[] rowPtnx = DT_PTNX.Where(d => d.Maptnx == maPTNX).ToArray();
                if (rowPtnx.Length == 1)
                {
                    congthucDoanhthu = rowPtnx[0].Ctthucdoanhthu.ToString();
                }
                if (!string.IsNullOrEmpty(congthucDoanhthu)) doanhthu = TINHBIEUTHUC(congthucDoanhthu, giaTriBien);
                return doanhthu;
            }
            catch
            {
                return 0;
            }
        }
        // Công thức tính lương

        public static decimal TinhLuongByCongThuc(decimal tienLuongHD, decimal tienBaohiem, decimal tienKyluat,
                                                    decimal tienLuongthuong, decimal tienLuonglamthem, decimal tienPhucap,
                                                    decimal tienThunhapkhac, decimal dTienVanChuyen, decimal dTienChaiLong, string congThuc)
        {
            try
            {
                Dictionary<string, decimal> giaTriBien = new Dictionary<string, decimal>();
                giaTriBien.Add(PublicValue.TienLuongHD, tienLuongHD);
                giaTriBien.Add(PublicValue.TienBaoHiem, tienBaohiem);
                giaTriBien.Add(PublicValue.TienKyLuat, tienKyluat);
                giaTriBien.Add(PublicValue.TienThuong, tienLuongthuong);
                giaTriBien.Add(PublicValue.TienPhuCap, tienPhucap);
                giaTriBien.Add(PublicValue.TienLamThem, tienLuonglamthem);
                giaTriBien.Add(PublicValue.TienThuNhapKhac, tienThunhapkhac);
                giaTriBien.Add(PublicValue.TienVanChuyen, dTienVanChuyen);
                giaTriBien.Add(PublicValue.TienChaiLong, dTienChaiLong);

                return TINHBIEUTHUC(congThuc, giaTriBien);
            }
            catch
            {
                return 0;
            }
        }


        //10. Convert chuỗi thành số
        public static decimal TryParse(string chuoi)
        {
            decimal number = 0; decimal.TryParse(chuoi, out number);
            return number;
        }

        public static decimal TINHBIEUTHUC(string congThuc, Dictionary<string, decimal> giaTriBien)
        {
            if (string.IsNullOrEmpty(congThuc)) return 0;
            ArrayList listCongThuc = new ArrayList();
            int i = 0;
            int n = congThuc.Length;
            string s = "";
            bool bTinh = false;
            //int k = 0;
            while (i < n)
            {
                if (congThuc[i] == '+' || congThuc[i] == '-' || congThuc[i] == '*'
                    || congThuc[i] == '/' || congThuc[i] == '(' || congThuc[i] == ')')
                {
                    bool flag = true;
                    if (s.Length > 0)
                    {
                        if (giaTriBien.ContainsKey(s))
                        {
                            listCongThuc.Add(giaTriBien[s]);
                        }
                        else
                        {
                            try
                            {
                                listCongThuc.Add(Convert.ToDecimal(s));
                            }
                            catch { flag = false; }
                        }
                        //k++;
                        s = "";
                    }
                    if (flag) { listCongThuc.Add(congThuc[i].ToString()); }
                }
                else
                {
                    s += congThuc[i];
                }
                i++;
            }//while

            if (s.Length > 0)
            {
                if (giaTriBien.ContainsKey(s))
                {
                    listCongThuc.Add(giaTriBien[s]);
                }
                else
                {
                    listCongThuc.Add(Convert.ToDecimal(s));
                }

            }

            Stack<string> stack = new Stack<string>();
            ArrayList listKQ = new ArrayList();

            for (int j = 0; j < listCongThuc.Count; j++)
            {
                if (listCongThuc[j].ToString() == ")")
                {
                    //string strDongNgoac = stack.Pop();
                    while (stack.Pop() != "(")
                    { }
                    continue;
                }

                if (listCongThuc[j].ToString() == "+" || listCongThuc[j].ToString() == "-"
                    || listCongThuc[j].ToString() == "*" || listCongThuc[j].ToString() == "/"
                    || listCongThuc[j].ToString() == "(")
                {
                    stack.Push(listCongThuc[j].ToString());
                    bTinh = false;
                }
                else
                {
                    listKQ.Add(listCongThuc[j]);
                    bTinh = true;
                }

                if (stack.Count == 0) continue;

                string toanTu = stack.Pop();

                if (bTinh && listKQ.Count > 1 && (toanTu == "+" || toanTu == "-" || toanTu == "*" || toanTu == "/"))
                {
                    decimal toanHangA = Convert.ToDecimal(listKQ[listKQ.Count - 2]);
                    decimal toanHangB = Convert.ToDecimal(listKQ[listKQ.Count - 1]);
                    listKQ.Remove(listKQ[listKQ.Count - 2]);
                    listKQ.Remove(listKQ[listKQ.Count - 1]);
                    switch (toanTu)
                    {
                        case "+":
                            listKQ.Add(toanHangA + toanHangB);
                            break;
                        case "-":
                            listKQ.Add(toanHangA - toanHangB);
                            break;
                        case "*":
                            listKQ.Add(toanHangA * toanHangB);
                            break;
                        case "/":
                            listKQ.Add(toanHangA / toanHangB);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    stack.Push(toanTu);
                }
            }//for
            while (listKQ.Count > 1)
            {
                if (listKQ.Count > 1 && stack.Count > 0)
                {
                    string toanTu = stack.Pop();
                    decimal toanHangA = Convert.ToDecimal(listKQ[listKQ.Count - 2]);
                    decimal toanHangB = Convert.ToDecimal(listKQ[listKQ.Count - 1]);
                    listKQ.Remove(listKQ[listKQ.Count - 2]);
                    listKQ.Remove(listKQ[listKQ.Count - 1]);
                    switch (toanTu)
                    {
                        case "+":
                            listKQ.Add(toanHangA + toanHangB);
                            break;
                        case "-":
                            listKQ.Add(toanHangA - toanHangB);
                            break;
                        case "*":
                            listKQ.Add(toanHangA * toanHangB);
                            break;
                        case "/":
                            listKQ.Add(toanHangA / toanHangB);
                            break;
                        default:
                            break;
                    }
                }
            }
            if (listKQ.Count == 0) return 0;
            return Convert.ToDecimal(listKQ[0]);
        }//TinhBieuThuc

        public static string ConverThungByLe(decimal soluong, decimal quycach)
        {
            string sothung = "";
            if (PublicValue.trangThaiQuydoiThungLe.Equals("1"))
            {
                sothung = Math.Round(soluong / quycach, 3).ToString();
            }
            else
            {
                int thung = Convert.ToInt32(soluong) / Convert.ToInt32(quycach);
                decimal _sothung = decimal.Parse(thung.ToString());
                int le = Convert.ToInt32(soluong - (_sothung * quycach));
                sothung = _sothung.ToString() + "/" + le.ToString();
            }

            return sothung;
        }

        public static decimal ConverLeByThung(string thung, decimal quycach)
        {
            decimal soluong = 0;
            string[] listSothuong = thung.ToString().Split('/');
            decimal _sothung = 0, _soluongle = 0;
            decimal.TryParse(listSothuong[0].ToString(), out _sothung);
            if (listSothuong.Length > 1) decimal.TryParse(listSothuong[1].ToString(), out _soluongle);
            //decimal.TryParse(ValueColumn, out Soluongthung);
            soluong = _sothung * quycach + _soluongle;
            return soluong;
        }
    }
}