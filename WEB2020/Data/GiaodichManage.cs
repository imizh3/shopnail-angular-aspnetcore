using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Extensions.Configuration;
using WEB2020.Model;
using WEB2020.Models;

namespace WEB2020.Data
{
    public class orderResult
    {
        public Order data { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public bool iSsuccess { get; set; }
    }
    public class GiaodichManage : BaseManage
    {
        public MARTContext db;
        public static List<Vat> Vats = new List<Vat>();
        public static List<Dmptnx> Dmptnxes = new List<Dmptnx>();
        public static List<Mathang> Mathangs = new List<Mathang>();
        public GiaodichManage(IConfiguration configuration, MARTContext _db) : base(configuration)
        {
            db = _db;
            Vats = db.Vat.Where(d => d.Madonvi == this.Madonvi).ToList();
            Dmptnxes = db.Dmptnx.Where(d => d.Madonvi == this.Madonvi).ToList();
            Mathangs = db.Mathang.Where(d => d.Madonvi == this.Madonvi).ToList();
        }
        internal List<OrderResult> GetOrders(OrderRequest orderRequest)
        {
            DateTime tuNgay = DateTime.Parse(orderRequest.tuNgay);
            DateTime denNgay = DateTime.Parse(orderRequest.denNgay);
            List<OrderResult> orders = new List<OrderResult>();
            DataTable DT_Orders = DB.Fill_GiaodichVinamilkByTungayDenngay(orderRequest.trangThai, this.Madonvi, "X_BANBUON", tuNgay, denNgay);

            orders = LIB.ConvertDataTableToList<OrderResult>(DT_Orders);
            orders = orders.Where(d => d.Manhanviendathang == orderRequest.maNhanVien).ToList();
            return orders;
        }

        internal Order Duyetctkhuyenmai(Order value)
        {
            this.KMMOTSOSANPHAMNEW(value.Giaodichct, value.Giaodichct, value.Ngayphatsinh, this.Maptnx);
            return value;
        }

        internal List<Orderct> GetOrderDetails(OrderRequest orderRequest)
        {
            List<Orderct> giaodichcts = new List<Orderct>();
            DataTable DT_Giaodichcts = DB.GetDataGiaodichctByMagiaodichpk(orderRequest.magiaodichpk, this.Madonvi);
            giaodichcts = LIB.ConvertDataTableToList<Orderct>(DT_Giaodichcts);
            return giaodichcts;
        }


        internal object CreateOrder(Order order, string sukien)
        {
            orderResult result = new orderResult
            {
                data = order,
                message = "OK",
                status = "200",
                iSsuccess = true,
            };
            if (order.Trangthai == 10)
            {
                result = new orderResult
                {
                    data = order,
                    message = "Đơn hàng đã được duyệt bởi kế toán không thể sửa!",
                    status = "2001",
                    iSsuccess = false,
                };
                return result;
            }
            if (sukien.Equals("ADD"))
            {
                string Magiaodichpk = LIB.GET_MATUDONG("Đơn đặt hàng web", "dathangweb", "dathangweb", this.Madonvi, true, "WE");
                order.Magiaodichpk = Magiaodichpk;
                order.Sochungtugoc = Magiaodichpk;
                order.Maptnx = this.Maptnx;
                order.Madonvi = this.Madonvi;
                order.Ngaytao = DateTime.Now;
            }
            order.Maptnx = this.Maptnx;
            order.Madonvi = this.Madonvi;
            order.Mangoaite = "VND";
            order.Tygia = 1;
            if (string.IsNullOrEmpty(order.Makhachhang) && string.IsNullOrEmpty(order.Khachhang.Makhachhang))
            {
                Khachhang checkkh = db.Khachhang.Where(d => d.Madonvi == this.Madonvi && d.Dienthoai == order.Khachhang.Dienthoai).FirstOrDefault();
                if (checkkh != null)
                    order.Makhachhang = checkkh.Makhachhang;
                else
                {
                    order.Makhachhang = LIB.GET_MATUDONG("Danh mục khách hàng web", "frmKhachhang", "frmKhachhang", this.Madonvi, true, "KW");
                    Khachhang khAdd = new Khachhang();
                    khAdd.Makhachhang = order.Makhachhang;
                    khAdd.Maloaikhach = PublicValue.MA_KH;
                    khAdd.Madonvi = this.Madonvi;
                    khAdd.Tenkhachhang = order.Khachhang.Tenkhachhang;
                    khAdd.Tendangnhap = order.Tendangnhap;
                    khAdd.Manhomkhachhang = "";
                    khAdd.Ngaytao = DateTime.Now;
                    khAdd.Ngaysinh = DateTime.Now;
                    khAdd.Diachi = order.Khachhang.Diachi;
                    khAdd.Dienthoai = order.Khachhang.Dienthoai;
                    khAdd.Dienthoai2 = order.Khachhang.Dienthoai;
                    khAdd.Fax = "";
                    khAdd.Email = "";
                    khAdd.Masothue = "";
                    khAdd.Trangthai = 1;
                    khAdd.Congnomax = 0;
                    khAdd.Matuyen = "";
                    khAdd.Diachigiaohang = khAdd.Diachi;
                    khAdd.Nguoigiaodich = "";
                    khAdd.Doanhso = 0;
                    khAdd.Mathe = "";
                    khAdd.Gioitinh = 3;

                    db.Khachhang.Add(khAdd);
                    db.SaveChanges();

                    Nhanvienkhachhang nhanvienkhachhang = new Nhanvienkhachhang();
                    nhanvienkhachhang.Makhachhang = khAdd.Makhachhang;
                    nhanvienkhachhang.Manhanvien = order.Manhanviendathang;
                    nhanvienkhachhang.Madonvi = this.Madonvi;
                    db.Nhanvienkhachhang.Add(nhanvienkhachhang);
                    db.SaveChanges();

                }
            }
            //update thông tin khach hang
            try
            {
                Khachhang update = db.Khachhang.Where(d => d.Madonvi == this.Madonvi && d.Makhachhang == order.Khachhang.Makhachhang).FirstOrDefault();
                update.Diachi = order.Khachhang.Diachi;
                update.Diachigiaohang = order.Khachhang.Diachigiaohang;
                db.Entry(update).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {

            }

            order.Giaodichctkhuyenmai = order.Giaodichctkhuyenmai != null ? order.Giaodichctkhuyenmai : new List<Orderct>();

            result = SaveGiaodich(order, sukien);

            if (result.iSsuccess)
            {
                //Bước 2: Insert vào bảng giao dịch chi tiết
                if (sukien.Equals("EDIT"))
                    DB.DeleteByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                result = SaveGiaodichct(order.Giaodichct, 0, order);
                if (result.iSsuccess)
                {
                    result = SaveGiaodichct(order.Giaodichctkhuyenmai, order.Giaodichct.Count, order);
                    if (result.iSsuccess)
                    {
                        //Bước 3: Insert vào bảng giao dich chi tiet tài khoản
                        if (this.trangThaiHTKT == "1")
                        {
                            if (sukien.Equals("EDIT"))
                                DB.DeleteCtTaikhoanByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                            result = SaveGiaodichctTaikhoan(order.Giaodichct, 0, order);
                            result = SaveGiaodichctTaikhoan(order.Giaodichctkhuyenmai, order.Giaodichct.Count, order);
                            if (result.iSsuccess)
                            {
                                return result;
                            }
                            else
                            {
                                if (sukien.Equals("ADD"))
                                {
                                    DB.DeleteGiaodichctkm(order.Magiaodichpk, order.Madonvi);
                                    DB.DeleteByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                                    DB.DeleteCtTaikhoanByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                                    DB.DeleteGiaodich(order.Magiaodichpk, order.Madonvi);
                                }
                                return result;
                            }
                        }
                        else
                        {
                            return result;
                        }
                    }
                    else
                    {
                        if (sukien.Equals("ADD"))
                        {
                            DB.DeleteGiaodichctkm(order.Magiaodichpk, order.Madonvi);
                            DB.DeleteByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                            DB.DeleteGiaodich(order.Magiaodichpk, order.Madonvi);
                        }
                        return result;
                    }
                }
                else
                {
                    if (sukien.Equals("ADD"))
                    {
                        DB.DeleteByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                        DB.DeleteGiaodich(order.Magiaodichpk, order.Madonvi);
                    }
                    return result;
                }
            }
            else
            {
                return result;
            }
        }

        internal orderResult DeleteOrder(Order order)
        {
            try
            {
                orderResult result = new orderResult
                {
                    data = order,
                    message = "OK",
                    status = "200",
                    iSsuccess = true,
                };
                Giaodich d = db.Giaodich.Where(d => d.Madonvi == this.Madonvi && d.Magiaodichpk == order.Magiaodichpk).FirstOrDefault();
                if (d != null && d.Trangthai != 10)
                {

                    DB.DeleteGiaodichctkm(order.Magiaodichpk, this.Madonvi);
                    DB.DeleteByMadonviAndMagiaodichpk(order.Magiaodichpk, this.Madonvi);
                    DB.DeleteCtTaikhoanByMadonviAndMagiaodichpk(order.Magiaodichpk, this.Madonvi);
                    DB.DeleteGiaodich(order.Magiaodichpk, this.Madonvi);
                }
                else if (d.Trangthai == 10)
                {

                    result = new orderResult
                    {
                        data = order,
                        message = "Đơn đã được duyệt và xuất kho không thể xoá!",
                        status = "2001",
                        iSsuccess = false,
                    };
                    return result;
                }


                return result;
            }
            catch (Exception ex)
            {
                return new orderResult
                {
                    data = order,
                    message = ex.Message,
                    status = "2001",
                    iSsuccess = false,
                };
            }
        }

        internal KhuyenmaiModel GetKhuyenmai()
        {
            DataTable DT_Khuyenmai = DB.KM_GetDataByMadonviAndNgayBatdauAndNgayKetthuc(this.Madonvi, 10, DateTime.Now, 10);
            DataTable DT_Khuyenmaict = DB.KMCT_GetDataByMadonviAndMachuongtrinhAndNgay(this.Madonvi, 10, DateTime.Now, 10);
            DataTable DT_KmMotsosanpham = DB.GetData_VTHH_KMMOTSOSANPHAM(this.Madonvi, DateTime.Now);
            DataTable DT_KmMotsosanphamnew = DB.GetData_VTHH_KMMOTSOSANPHAMNEW(this.Madonvi, DateTime.Now);
            List<Khuyenmaict> kmmotsosanpham = LIB.ConvertDataTableToList<Khuyenmaict>(DT_KmMotsosanpham);
            List<Khuyenmai> khuyenmais = LIB.ConvertDataTableToList<Khuyenmai>(DT_Khuyenmai);
            List<Khuyenmaict> khuyenmaicts = LIB.ConvertDataTableToList<Khuyenmaict>(DT_Khuyenmaict);
            List<KhuyenmaimotsosanphamModel> khuyenmaimotsosanpham = LIB.ConvertDataTableToList<KhuyenmaimotsosanphamModel>(DT_KmMotsosanphamnew);
            KhuyenmaiModel khuyenmai = new KhuyenmaiModel();
            khuyenmai.Khuyenmais = khuyenmais;
            khuyenmai.Khuyenmaicts = khuyenmaicts;
            khuyenmai.KmMotsosanpham = kmmotsosanpham;
            khuyenmai.KmMotsosanphamnew = khuyenmaimotsosanpham;
            return khuyenmai;
        }

        private orderResult SaveGiaodichctTaikhoan(List<Orderct> giaodichct, int Sort, Order order)
        {
            try
            {
                var result = new orderResult
                {
                    data = order,
                    message = "OK",
                    status = "200",
                    iSsuccess = true,
                };
                foreach (Orderct rChitiet in giaodichct)
                {
                    //int.TryParse(rChitiet[GiaodichctFields.Sort, out Sort);
                    try
                    {
                        if (string.IsNullOrEmpty(rChitiet.Masieuthi)) continue;
                        decimal Soluong = decimal.Parse(rChitiet.Soluong.ToString());
                        if (string.IsNullOrEmpty(rChitiet.Makhohang))
                        {
                            rChitiet.Makhohang = this.Makho;
                        }
                        if (Soluong <= 0) continue;
                        DB.InsertCtTaikhoan(order.Magiaodichpk, order.Madonvi, rChitiet.Masieuthi
                            , rChitiet.Makhohang, rChitiet.Matkno
                            , rChitiet.Matkco, rChitiet.Matknhapkhauno
                            , rChitiet.Matknhapkhauco, rChitiet.Matkthuedacbietno
                            , rChitiet.Matkthuedacbietco, rChitiet.Matkthuegtgtno
                            , rChitiet.Matkthuegtgtco, rChitiet.Matkchietkhauno
                            , rChitiet.Matkchietkhauco, rChitiet.Matkgiamgiano
                            , rChitiet.Matkgiamgiaco, rChitiet.Matklephino
                            , rChitiet.Matklephico, rChitiet.Matkchiphino
                            , rChitiet.Matkchiphico, rChitiet.Matkchiphikhacno
                            , rChitiet.Matkchiphikhacco, rChitiet.Matkkhuyenmaino
                            , rChitiet.Matkkhuyenmaico, rChitiet.Matkthuekhautruno
                            , rChitiet.Matkthuekhautruco, rChitiet.Matkbanamno
                            , rChitiet.Matkbanamco, rChitiet.Matkchietkhausaubanhangno
                            , rChitiet.Matkchietkhausaubanhangco, rChitiet.Matkgiavon
                            , rChitiet.Matkvtu, Sort);
                    }
                    catch (Exception ex)
                    {
                        DB.DeleteCtTaikhoanByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);
                        result = new orderResult
                        {
                            data = order,
                            message = "Giaodichcttaikhoan:" + ex.Message,
                            status = "2001",
                            iSsuccess = false,
                        };
                        return result;
                    }
                    Sort++;
                }
                return result;
            }
            catch (Exception ex)
            {
                var result = new orderResult
                {
                    data = order,
                    message = "Giaodichcttaikhoan:" + ex.Message,
                    status = "2001",
                    iSsuccess = false,
                };
                return result;
            }
        }

        private orderResult SaveGiaodichct(List<Orderct> gdchitiet, int sort, Order order)
        {
            try
            {
                var result = new orderResult
                {
                    data = order,
                    message = "OK",
                    status = "200",
                    iSsuccess = true,
                };
                int id = 0;
                decimal Tongtientrathuong = 0;
                DataTable dtkm = DB.Getdata_VTHH_giaodichctkm(order.Madonvi, order.Magiaodichpk);
                DB.DeleteGiaodichctkm(order.Magiaodichpk, order.Madonvi);
                foreach (Orderct rChitiet in gdchitiet)
                {
                    if (string.IsNullOrEmpty(rChitiet.Masieuthi)) continue;
                    Mathang rHanghoa = LIB.ConvertDataTableToList<Mathang>(DB.MH_GetDataByMasieuthiMadonvi(rChitiet.Masieuthi, order.Madonvi))[0];
                    decimal Soluong = 0, tongtienck = 0, tientrathuong = 0, Tiencktrendon = 0, Tienck = 0;
                    decimal.TryParse(rChitiet.Soluong.ToString(), out Soluong);
                    decimal.TryParse(rChitiet.Tiencktrendon.ToString(), out Tiencktrendon);
                    decimal.TryParse(rChitiet.Tienck.ToString(), out Tienck);
                    tongtienck = Tiencktrendon + Tienck;
                    decimal.TryParse(rChitiet.Tiencktrathuong.ToString(), out tientrathuong);
                    if (string.IsNullOrEmpty(rChitiet.Makhohang))
                    {
                        rChitiet.Makhohang = this.Makho;
                    }
                    if (Soluong <= 0)
                    {
                        //LIB.MessageBoxWarning("Kiểm tra lại số lượng của mã hàng: " + rChitiet[GiaodichctFields.Masieuthi);
                        continue;
                    }
                    try
                    {
                        DB.InsertQueryGiaodichctBanbuon(order.Magiaodichpk, order.Madonvi, rChitiet.Masieuthi
                            , rHanghoa.Manganh, rHanghoa.Makhachhang, rHanghoa.Manhomhang, rChitiet.Makhohang
                            , "-", Soluong, rChitiet.Dongiacovat
                            , rChitiet.Dongiachuavat, rChitiet.Tienhang
                            , rChitiet.Tienvat, rChitiet.Thanhtien
                            , rChitiet.Tyleck, rChitiet.Tienck
                            , sort, rChitiet.Giavon, rChitiet.Doanhthu, "", rChitiet.Mavat
                            , rChitiet.Ghichu, 0, 0, 0, 0, 0, 0, rChitiet.Giathungchuavat, "", rChitiet.Mangoaite, rChitiet.Tygia, rChitiet.Magiaodichphu,
                            rChitiet.Machuongtrinhkm, rChitiet.Tylecktrendon, Tiencktrendon, tientrathuong, "", "");
                        if (tientrathuong != 0)
                        {
                            Tongtientrathuong = Tongtientrathuong + tientrathuong;
                        }
                        if (!string.IsNullOrEmpty(rChitiet.Machuongtrinhkm))
                        {
                            DB.InsertGiaodichctkm(order.Magiaodichpk, order.Madonvi, decimal.Parse(rChitiet.Soluong.ToString()),
                                tongtienck, rChitiet.Machuongtrinhkm, order.Magiaodichpk + id, 1, rChitiet.Masieuthi);
                            id++;
                        }
                    }
                    catch (Exception ex)
                    {

                        DB.DeleteByMadonviAndMagiaodichpk(order.Magiaodichpk, order.Madonvi);

                        result = new orderResult
                        {
                            data = order,
                            message = "Giaodichct:" + ex.Message,
                            status = "2001",
                            iSsuccess = false,
                        };
                        return result;
                    }
                    sort++;
                }
                if (dtkm != null)
                {
                    int indexcheck = 1;
                    foreach (DataRow item in dtkm.Rows)
                    {
                        decimal tientrathuong = 0;
                        decimal.TryParse(item["Tienkm"].ToString(), out tientrathuong);
                        if (Tongtientrathuong > 0)
                        {
                            if (dtkm.Rows.Count == 1 || indexcheck == dtkm.Rows.Count)
                            {
                                tientrathuong = Tongtientrathuong;
                            }
                            else
                            {
                                if (tientrathuong <= Tongtientrathuong)
                                {
                                    Tongtientrathuong = Tongtientrathuong - tientrathuong;
                                }
                                else
                                {
                                    tientrathuong = Tongtientrathuong;
                                }
                            }
                            DB.InsertGiaodichctkm(order.Magiaodichpk, order.Madonvi,
                                   0, tientrathuong, item["Chuongtrinhkm"].ToString(),
                                   order.Magiaodichpk + id, 10, item["Masieuthi"].ToString());
                            indexcheck++;
                            id++;
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                var result = new orderResult
                {
                    data = order,
                    message = "Giaodichct:" + ex.Message,
                    status = "2001",
                    iSsuccess = false,
                };
                return result;
            }
        }

        public orderResult SaveGiaodich(Order order, string action)
        {
            try
            {
                var result = new orderResult
                {
                    data = order,
                    message = "OK",
                    status = "200",
                    iSsuccess = true,
                };

                if (action == "ADD")
                {
                    try
                    {
                        DB.InsertGiaodichnt(order.Magiaodichpk, order.Madonvi, order.Maptnx, order.Ghichu, 1
                            , order.Sochungtugoc, DateTime.Parse(order.Ngayhoadon.ToString()), "", 0, order.Makhachhang, DateTime.Parse(order.Ngaythanhtoan.ToString())
                            , DateTime.Parse(order.Ngaythanhtoan.ToString()), order.Sohoadon
                            , order.Kyhieuhoadon, order.Magiaodichphu, order.Makhachhang, "", "", order.Manhanviendathang
                            , order.Tendangnhap, order.Tendangnhapsua, order.Nguoigiaohang, order.Ngayphatsinh, "", 0, order.Mangoaite, order.Tygia, 0);
                    }
                    catch (Exception ex)
                    {
                        result = new orderResult
                        {
                            data = order,
                            message = "Giaodich:" + ex.Message,
                            status = "2001",
                            iSsuccess = false,
                        };
                        return result;
                    }
                }
                else if (action == "EDIT")
                {
                    try
                    {
                        DB.UpdateGiaodichnt(order.Maptnx, order.Ghichu, 1
                            , DateTime.Now, order.Sochungtugoc, DateTime.Parse(order.Ngayhoadon.ToString()), "", 0, "", DateTime.Parse(order.Ngaythanhtoan.ToString())
                            , DateTime.Parse(order.Ngaythanhtoan.ToString()), order.Sohoadon
                            , order.Kyhieuhoadon, order.Magiaodichphu, order.Makhachhang, "", "", order.Manhanviendathang
                            , order.Tendangnhap, order.Tendangnhapsua, order.Nguoigiaohang, order.Ngayphatsinh, 0, order.Mangoaite, order.Tygia, 0, order.Magiaodichpk, order.Madonvi);
                    }
                    catch (Exception ex)
                    {
                        result = new orderResult
                        {
                            data = order,
                            message = "Giaodich:" + ex.Message,
                            status = "2001",
                            iSsuccess = false,
                        };
                        return result;
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                var result = new orderResult
                {
                    data = order,
                    message = "Giaodich:" + ex.Message,
                    status = "2001",
                    iSsuccess = false,
                };
                return result;
            }

        }

        #region Hàm khuyến mãi
        public void KMMOTSOSANPHAMNEW(List<Orderct> dtGiaodichct, List<Orderct> dtGiaodichkhuyenmai, DateTime ngayphatsinh, string maPtnx)
        {
            try
            {
                DataTable CHUONGTRINHKM = DB.GetData_VTHH_KMMOTSOSANPHAMNEW(this.Madonvi, ngayphatsinh);

                List<KhuyenmaimotsosanphamModel> DTCHUONGTRINHKM = LIB.ConvertDataTableToList<KhuyenmaimotsosanphamModel>(CHUONGTRINHKM);

                List<KhuyenmaimotsosanphamModel> kmMotsosanpham, kmMotsosanphamslthung;
                try
                {
                    kmMotsosanpham = DTCHUONGTRINHKM.Where(d => d.Loaiapdung == 5).ToList();
                }
                catch { kmMotsosanpham = null; }
                try
                {
                    kmMotsosanphamslthung = DTCHUONGTRINHKM.Where(d => d.Loaiapdung == 1).ToList();
                }
                catch
                {
                    kmMotsosanphamslthung = null;
                }

                List<Orderct> dtGiaodichctkhuyenmai = new List<Orderct>();

                //CLEAR KHUYẾN MẠI CŨ
                try
                {
                    List<Orderct> rKhuyenmai = dtGiaodichkhuyenmai.Where(d => d.Machuongtrinhkm != "" && d.Dongiachuavat != 0).ToList();
                    foreach (Orderct item in rKhuyenmai)
                    {
                        item.Machuongtrinhkm = "";
                        item.Tyleck = 0;
                        item.Tienck = 0;
                        item.Tiencknt = 0;

                    }
                }
                catch
                {
                    //trường hợp tbKhuyenmai khác tb dtgiaodichct
                    List<Orderct> rKhuyenmai = dtGiaodichct.Where(d => d.Machuongtrinhkm != "" && d.Dongiachuavat != 0).ToList();
                    foreach (Orderct item in rKhuyenmai)
                    {
                        item.Machuongtrinhkm = "";
                        item.Tyleck = 0;
                        item.Tienck = 0;
                        item.Tiencknt = 0;

                    }
                }
                dtGiaodichctkhuyenmai.Clear();
                //Khuyến mại 1 số sản phẩm theo số lượng lẻ
                #region Khuyến mại 1 số sản phẩm theo số lượng lẻ

                if (dtGiaodichct != null && dtGiaodichct.Count > 0 && kmMotsosanpham != null && kmMotsosanpham.Count > 0)
                {
                    string mactkmdadung = "";
                    string mahangbandaapdung = "";
                    foreach (Orderct item in dtGiaodichct)
                    {
                        List<KhuyenmaimotsosanphamModel> listRowChuongtrinhApdung = kmMotsosanpham.Where(d => d.Doituongapdung == item.Masieuthi && !mahangbandaapdung.Contains(d.Doituongapdung) && !mactkmdadung.Contains(d.Machuongtrinh)).OrderByDescending(d => d.Soluongban).OrderByDescending(d => d.Giatrikmmin).ToList();
                        //("Doituongapdung ='" + item[GiaodichctFields.MasieuthiColumn.ColumnName].ToString() + "' and Doituongapdung not in ('" + mahangbandaapdung.Replace(",", "','") + "')" + " and Machuongtrinh not in ('" + mactkmdadung.Replace(",", "','") + "')", "Soluongban desc, Giatrikmmin desc");
                        decimal soluongbantoithieudau = 0, giatribantoithieudau = 0;
                        string Machuongtrinhdaduyethangban = "";
                        foreach (KhuyenmaimotsosanphamModel rowkm in listRowChuongtrinhApdung)
                        {
                            string maSieuthiban = rowkm.Masieuthiban.ToString();
                            List<Orderct> dtGiaodichkm = new List<Orderct>();
                            try
                            {
                                dtGiaodichkm = dtGiaodichct.Where(d => maSieuthiban.Contains(d.Masieuthi) && d.Dongiachuavat != 0).ToList();
                                //(GiaodichctFields.MasieuthiColumn.ColumnName + " in ('" + maSieuthiban.Replace(",", "','") + "') and " + GiaodichctFields.DongiachuavatColumn.ColumnName + " <> 0").CopyToDataTable();
                            }
                            catch
                            {
                                dtGiaodichkm = null;
                            }

                            string maSieuthibanhientai = rowkm.Masieuthiban;
                            string mactkm = rowkm.Machuongtrinh;
                            var ctdaduyet = Machuongtrinhdaduyethangban.Contains(mactkm);
                            if (dtGiaodichkm != null && dtGiaodichkm.Count > 0 && !ctdaduyet)
                            {
                                decimal tyleck = 0, soluongkm = 0, tienck = 0;
                                decimal.TryParse(rowkm.Tilechietkhau.ToString(), out tyleck);
                                decimal.TryParse(rowkm.Tienchietkhau.ToString(), out tienck);
                                decimal.TryParse(rowkm.Soluongkm.ToString(), out soluongkm);
                                #region Khuyến tỷ lệ chiết khấu
                                if (tyleck != 0)
                                {
                                    decimal soluongbantoithieu = 0, giatribantoithieu = 0;
                                    decimal.TryParse(rowkm.Soluongban.ToString(), out soluongbantoithieu);
                                    decimal.TryParse(rowkm.Giatrikmmin.ToString(), out giatribantoithieu);
                                    if (soluongbantoithieu != 0)
                                    {
                                        decimal soluongthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Soluong).ToString(), out soluongthucban);
                                        if (soluongthucban >= soluongbantoithieu && soluongbantoithieu > soluongbantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                {
                                                    row.Tyleck = tyleck;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", tyleck.ToString(), maPtnx);
                                                    //dtGiaodichct.AcceptChanges();
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            soluongbantoithieudau = soluongbantoithieu;
                                        }
                                        else
                                        {
                                            if (soluongbantoithieu > soluongbantoithieudau)
                                            {
                                                foreach (Orderct update in dtGiaodichkm)
                                                {
                                                    Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                    string macthientai = row.Machuongtrinhkm;
                                                    if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                    {
                                                        row.Tyleck = 0;
                                                        row.Machuongtrinhkm = "";
                                                        TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", "0", maPtnx);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (giatribantoithieu != 0)
                                    {
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Tienhang).ToString(), out tongTienthucban);
                                        if (tongTienthucban >= giatribantoithieu && giatribantoithieu > giatribantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || !macthientai.Equals(mactkm))
                                                {
                                                    row.Tyleck = tyleck;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", tyleck.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            giatribantoithieudau = giatribantoithieu;
                                        }
                                        else
                                        {
                                            if (giatribantoithieu > giatribantoithieudau)
                                            {
                                                foreach (Orderct update in dtGiaodichkm)
                                                {
                                                    Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                    string macthientai = row.Machuongtrinhkm;
                                                    if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                    {
                                                        row.Tyleck = 0;
                                                        row.Machuongtrinhkm = "";
                                                        TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", "0", maPtnx);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion

                                #region Tiền chiết khấu
                                if (tienck != 0)
                                {
                                    decimal soluongbantoithieu = 0, giatribantoithieu = 0;
                                    decimal.TryParse(rowkm.Soluongban.ToString(), out soluongbantoithieu);
                                    decimal.TryParse(rowkm.Giatrikmmin.ToString(), out giatribantoithieu);
                                    string masieuthikm = rowkm.Masieuthikm.ToString();
                                    string makhokm = rowkm.Makhohangkm.ToString();
                                    if (soluongbantoithieu != 0)
                                    {
                                        decimal soluongthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Soluong).ToString(), out soluongthucban);
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Tienhang).ToString(), out tongTienthucban);
                                        if (soluongthucban >= soluongbantoithieu && soluongbantoithieu > soluongbantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                decimal tienHangban = 0;
                                                decimal.TryParse(update.Tienhang.ToString(), out tienHangban);
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                {
                                                    int solan = (int)(soluongthucban / soluongbantoithieu);
                                                    decimal tiencknhan = solan * (tienck * (tienHangban / tongTienthucban));
                                                    row.Tienck = tiencknhan;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tienck", tiencknhan.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            soluongbantoithieudau = soluongbantoithieu;
                                        }
                                        //else
                                        //{
                                        //    if (soluongbantoithieu > soluongbantoithieudau)
                                        //    {
                                        //        foreach (DataRow update in dtGiaodichkm.Rows)
                                        //        {
                                        //            DataRow row = dtGiaodichct.Select(GiaodichctFields.MasieuthiColumn.ColumnName + " ='" + update[GiaodichctFields.MasieuthiColumn.ColumnName] + "'").FirstOrDefault();
                                        //            string macthientai = row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName].ToString();
                                        //            if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                        //            {
                                        //                row[GiaodichctFields.TienckColumn.ColumnName] = 0;
                                        //                row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName] = "";
                                        //                TinhtoanTienhangKhuyenmaiNhomMaxMin(row, GiaodichctFields.TienckColumn.ColumnName, "0", maPtnx);
                                        //                dtGiaodichct.AcceptChanges();
                                        //            }
                                        //        }
                                        //    }
                                        //}
                                    }
                                    else if (giatribantoithieu != 0)
                                    {
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Tienhang).ToString(), out tongTienthucban);
                                        if (tongTienthucban >= giatribantoithieu && giatribantoithieu > giatribantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                decimal tienHangban = 0;
                                                decimal.TryParse(update.Tienhang.ToString(), out tienHangban);
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || !macthientai.Equals(mactkm))
                                                {
                                                    int solan = (int)(tongTienthucban / giatribantoithieu);
                                                    decimal tiencknhan = solan * (tienck * (tienHangban / tongTienthucban));
                                                    row.Tienck = tiencknhan;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tienck", tiencknhan.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            giatribantoithieudau = giatribantoithieu;
                                        }
                                        //else
                                        //{
                                        //    if (giatribantoithieu > giatribantoithieudau)
                                        //    {
                                        //        foreach (DataRow update in dtGiaodichkm.Rows)
                                        //        {
                                        //            DataRow row = dtGiaodichct.Select(GiaodichctFields.MasieuthiColumn.ColumnName + " ='" + update[GiaodichctFields.MasieuthiColumn.ColumnName] + "'").FirstOrDefault();
                                        //            string macthientai = row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName].ToString();
                                        //            if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                        //            {
                                        //                row[GiaodichctFields.TienckColumn.ColumnName] = 0;
                                        //                row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName] = "";
                                        //                TinhtoanTienhangKhuyenmaiNhomMaxMin(row, GiaodichctFields.TienckColumn.ColumnName, "0", maPtnx);
                                        //                dtGiaodichct.AcceptChanges();
                                        //            }
                                        //        }
                                        //    }
                                        //}
                                    }
                                }
                                #endregion

                                #region Khuyến mại tặng hàng
                                if (soluongkm != 0)
                                {
                                    decimal soluongbantoithieu = 0, giatribantoithieu = 0;
                                    decimal.TryParse(rowkm.Soluongban.ToString(), out soluongbantoithieu);
                                    decimal.TryParse(rowkm.Giatrikmmin.ToString(), out giatribantoithieu);
                                    string masieuthikm = rowkm.Makhohangkm.ToString();
                                    string makhokm = rowkm.Makhohangkm.ToString();
                                    if (soluongbantoithieu != 0)
                                    {
                                        decimal soluongthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Soluong).ToString(), out soluongthucban);
                                        if (soluongthucban >= soluongbantoithieu)
                                        {
                                            //DataTable dt = DB.XNT_GETTONKHO(PublicValue.DataBaseXnt, PublicValue.XNT_TABLENAME(PublicValue.ngayPhatSinh), makhokm, PublicValue.maDonVi, masieuthikm);
                                            //if (dt == null || dt.Rows.Count == 0)
                                            //    continue;
                                            //else
                                            //{
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            //(GiaodichctFields.MasieuthiColumn.ColumnName + " ='" + masieuthikm + "' and " + GiaodichctFields.MakhohangColumn.ColumnName + " ='" + makhokm + "'");
                                            if (rowCheck == null || rowCheck.Count == 0)
                                            {
                                                int solan = (int)(soluongthucban / soluongbantoithieu);
                                                soluongkm = soluongkm * solan;
                                                if (soluongkm == 0) continue;
                                                Orderct rowadd = new Orderct();

                                                LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                rowadd.Iskhuyenmai = true;
                                                LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                dtGiaodichctkhuyenmai.Add(rowadd);
                                                if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                {
                                                    Machuongtrinhdaduyethangban = mactkm;
                                                }
                                                else
                                                {
                                                    Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                }
                                            }
                                            else
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    decimal soluongkmcu = 0;
                                                    decimal.TryParse(rowcheckkm.Soluong.ToString(), out soluongkmcu);
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanpham.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (masieuthibankmcu.Equals(maSieuthibanhientai))
                                                        {
                                                            decimal slbantoithieuctcu = 0;
                                                            decimal.TryParse(rowkmcu.Soluongban.ToString(), out slbantoithieuctcu);
                                                            decimal slbandu = soluongthucban % slbantoithieuctcu;
                                                            string mactmoi = rowkm.Machuongtrinh.ToString();
                                                            if (slbandu > 0)
                                                            {
                                                                if (slbandu >= soluongbantoithieu)
                                                                {
                                                                    int solan = (int)(slbandu / soluongbantoithieu);
                                                                    soluongkm = soluongkm * solan;
                                                                    if (soluongkm == 0) continue;
                                                                    if (mact.Equals(mactmoi))
                                                                    {
                                                                        soluongkm = soluongkm + soluongkmcu;
                                                                        TinhtoanTienhangKhuyenMai(rowcheckkm, "Soluong", soluongkm.ToString());
                                                                    }
                                                                    else
                                                                    {
                                                                        Orderct rowadd = new Orderct();
                                                                        LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                                        TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                                        TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                                        //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                                        //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                                        rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                                        rowadd.Iskhuyenmai = true;
                                                                        LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                                        dtGiaodichctkhuyenmai.Add(rowadd);
                                                                        if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                                        {
                                                                            Machuongtrinhdaduyethangban = mactkm;
                                                                        }
                                                                        else
                                                                        {
                                                                            Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            int solan = (int)(soluongthucban / soluongbantoithieu);
                                                            soluongkm = soluongkm * solan;
                                                            if (soluongkm == 0) continue;
                                                            Orderct rowadd = new Orderct();

                                                            LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                            //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                            //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                            rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                            rowadd.Iskhuyenmai = true;
                                                            LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                            dtGiaodichctkhuyenmai.Add(rowadd);
                                                            if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                            {
                                                                Machuongtrinhdaduyethangban = mactkm;
                                                            }
                                                            else
                                                            {
                                                                Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck != null)
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanpham.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (masieuthibankmcu.Equals(maSieuthibanhientai))
                                                        {
                                                            dtGiaodichctkhuyenmai.Remove(rowcheckkm);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (giatribantoithieu != 0)
                                    {
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Thanhtien).ToString(), out tongTienthucban);
                                        if (tongTienthucban >= giatribantoithieu)
                                        {
                                            //DataTable dt = DB.XNT_GETTONKHO(PublicValue.DataBaseXnt, PublicValue.XNT_TABLENAME(PublicValue.ngayPhatSinh), makhokm, PublicValue.maDonVi, masieuthikm);
                                            //if (dt == null || dt.Rows.Count == 0)
                                            //    continue;
                                            //else
                                            //{
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck == null || rowCheck.Count == 0)
                                            {
                                                int solan = (int)(tongTienthucban / giatribantoithieu);
                                                soluongkm = soluongkm * solan;
                                                if (soluongkm == 0) continue;
                                                Orderct rowadd = new Orderct();
                                                LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                rowadd.Iskhuyenmai = true;
                                                LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                dtGiaodichctkhuyenmai.Add(rowadd);

                                                if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                {
                                                    Machuongtrinhdaduyethangban = mactkm;
                                                }
                                                else
                                                {
                                                    Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                }
                                            }
                                            else
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanpham.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (!masieuthibankmcu.Equals(maSieuthiban))
                                                        {
                                                            int solan = (int)(tongTienthucban / giatribantoithieu);
                                                            soluongkm = soluongkm * solan;
                                                            if (soluongkm == 0) continue;
                                                            Orderct rowadd = new Orderct();
                                                            LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                            //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                            //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                            rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                            rowadd.Iskhuyenmai = true;
                                                            LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                            dtGiaodichctkhuyenmai.Add(rowadd);
                                                            if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                            {
                                                                Machuongtrinhdaduyethangban = mactkm;
                                                            }
                                                            else
                                                            {
                                                                Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                            }
                                                        }
                                                    }
                                                }
                                                //}
                                            }
                                        }
                                        else
                                        {
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck != null)
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanpham.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (masieuthibankmcu.Equals(maSieuthiban))
                                                        {
                                                            dtGiaodichctkhuyenmai.Remove(rowcheckkm);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion

                                if (string.IsNullOrEmpty(mactkmdadung))
                                {
                                    mactkmdadung = rowkm.Machuongtrinh.ToString();
                                }
                                else
                                {
                                    mactkmdadung = mactkmdadung + "," + rowkm.Machuongtrinh.ToString();
                                }

                                if (string.IsNullOrEmpty(mahangbandaapdung))
                                {
                                    mahangbandaapdung = item.Masieuthi.ToString();
                                }
                                else
                                {
                                    mahangbandaapdung = mahangbandaapdung + "," + item.Masieuthi.ToString();
                                }
                            }
                        }
                    }
                    //try
                    //{
                    //    DataRow[] rKhuyenmai = dtGiaodichkhuyenmai.Select(GiaodichctFields.MachuongtrinhkmColumn.ColumnName + " <> '' and " + GiaodichctFields.TienckColumn.ColumnName + " = 0 and " + GiaodichctFields.DongiachuavatColumn.ColumnName + " = 0");
                    //    foreach (DataRow item in rKhuyenmai)
                    //    {
                    //        dtGiaodichkhuyenmai.Rows.Remove(item);

                    //    }
                    //    dtGiaodichkhuyenmai.AcceptChanges();
                    //    foreach (DataRow item in dtGiaodichctkhuyenmai.Rows)
                    //    {
                    //        dtGiaodichkhuyenmai.Rows.Add(item.ItemArray);
                    //    }
                    //    dtGiaodichkhuyenmai.AcceptChanges();
                    //}
                    //catch
                    //{
                    //    //trường hợp tbKhuyenmai khác tb dtgiaodichct
                    //    DataRow[] rKhuyenmai = dtGiaodichct.Select(GiaodichctFields.MachuongtrinhkmColumn.ColumnName + " <> '' and " + GiaodichctFields.TienckColumn.ColumnName + " = 0 and " + GiaodichctFields.DongiachuavatColumn.ColumnName + " = 0");
                    //    foreach (DataRow item in rKhuyenmai)
                    //    {
                    //        dtGiaodichct.Rows.Remove(item);

                    //    }
                    //    dtGiaodichct.AcceptChanges();
                    //    foreach (DataRow item in dtGiaodichctkhuyenmai.Rows)
                    //    {
                    //        dtGiaodichct.Rows.Add(item.ItemArray);
                    //    }
                    //    dtGiaodichct.AcceptChanges();
                    //}
                }
                #endregion

                //Khuyến mại 1 số sản phẩm số lượng thùng
                #region Khuyến mại 1 số sản phẩm số lượng thùng

                if (dtGiaodichct != null && dtGiaodichct.Count > 0 && kmMotsosanphamslthung != null && kmMotsosanphamslthung.Count > 0)
                {
                    string mactkmdadung = "";
                    string mahangbandaapdung = "";
                    foreach (Orderct item in dtGiaodichct)
                    {
                        List<KhuyenmaimotsosanphamModel> listRowChuongtrinhApdung = kmMotsosanphamslthung.Where(d => d.Doituongapdung == item.Masieuthi && !mahangbandaapdung.Contains(d.Doituongapdung) && !mactkmdadung.Contains(d.Machuongtrinh)).OrderByDescending(d => d.Soluongban).OrderByDescending(d => d.Giatrikmmin).ToList();
                        decimal soluongbantoithieudau = 0, giatribantoithieudau = 0;
                        string Machuongtrinhdaduyethangban = "";
                        foreach (KhuyenmaimotsosanphamModel rowkm in listRowChuongtrinhApdung)
                        {
                            string maSieuthiban = rowkm.Masieuthiban.ToString();
                            List<Orderct> dtGiaodichkm = new List<Orderct>();
                            try
                            {
                                dtGiaodichkm = dtGiaodichct.Where(d => maSieuthiban.Contains(d.Masieuthi) && d.Dongiachuavat != 0).ToList();
                                //(GiaodichctFields.MasieuthiColumn.ColumnName + " in ('" + maSieuthiban.Replace(",", "','") + "') and " + GiaodichctFields.DongiachuavatColumn.ColumnName + " <> 0").CopyToDataTable();
                            }
                            catch
                            {
                                dtGiaodichkm = null;
                            }

                            string maSieuthibanhientai = rowkm.Masieuthiban.ToString();
                            string mactkm = rowkm.Machuongtrinh.ToString();
                            var ctdaduyet = Machuongtrinhdaduyethangban.Contains(mactkm);
                            if (dtGiaodichkm != null && dtGiaodichkm.Count > 0 && !ctdaduyet)
                            {
                                decimal tyleck = 0, soluongkm = 0, tienck = 0;
                                decimal.TryParse(rowkm.Tilechietkhau.ToString(), out tyleck);
                                decimal.TryParse(rowkm.Tienchietkhau.ToString(), out tienck);
                                decimal.TryParse(rowkm.Soluongkm.ToString(), out soluongkm);
                                #region Khuyến tỷ lệ chiết khấu
                                if (tyleck != 0)
                                {
                                    decimal soluongbantoithieu = 0, giatribantoithieu = 0;
                                    decimal.TryParse(rowkm.Soluongban.ToString(), out soluongbantoithieu);
                                    decimal.TryParse(rowkm.Giatrikmmin.ToString(), out giatribantoithieu);
                                    if (soluongbantoithieu != 0)
                                    {
                                        decimal soluongthucban = 0;
                                        soluongthucban = SoluongthucbanThung(dtGiaodichkm);
                                        if (soluongthucban >= soluongbantoithieu && soluongbantoithieu > soluongbantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                {
                                                    row.Tyleck = tyleck;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", tyleck.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            soluongbantoithieudau = soluongbantoithieu;
                                        }
                                        else
                                        {
                                            if (soluongbantoithieu > soluongbantoithieudau)
                                            {
                                                foreach (Orderct update in dtGiaodichkm)
                                                {
                                                    Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                    string macthientai = row.Machuongtrinhkm;
                                                    if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                    {
                                                        row.Tyleck = 0;
                                                        row.Machuongtrinhkm = "";
                                                        TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", "0", maPtnx);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (giatribantoithieu != 0)
                                    {
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Tienhang).ToString(), out tongTienthucban);
                                        if (tongTienthucban >= giatribantoithieu && giatribantoithieu > giatribantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || !macthientai.Equals(mactkm))
                                                {
                                                    row.Tyleck = tyleck;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", tyleck.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            giatribantoithieudau = giatribantoithieu;
                                        }
                                        else
                                        {
                                            if (giatribantoithieu > giatribantoithieudau)
                                            {
                                                foreach (Orderct update in dtGiaodichkm)
                                                {
                                                    Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                    string macthientai = row.Machuongtrinhkm;
                                                    if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                    {
                                                        row.Tyleck = 0;
                                                        row.Machuongtrinhkm = "";
                                                        TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tyleck", "0", maPtnx);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion

                                #region Tiền chiết khấu
                                if (tienck != 0)
                                {
                                    decimal soluongbantoithieu = 0, giatribantoithieu = 0;
                                    decimal.TryParse(rowkm.Soluongban.ToString(), out soluongbantoithieu);
                                    decimal.TryParse(rowkm.Giatrikmmin.ToString(), out giatribantoithieu);
                                    string masieuthikm = rowkm.Masieuthikm.ToString();
                                    string makhokm = rowkm.Makhohangkm.ToString();
                                    if (soluongbantoithieu != 0)
                                    {
                                        decimal soluongthucban = 0;
                                        soluongthucban = SoluongthucbanThung(dtGiaodichkm);
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Tienhang).ToString(), out tongTienthucban);
                                        if (soluongthucban >= soluongbantoithieu && soluongbantoithieu > soluongbantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                decimal tienHangban = 0;
                                                decimal.TryParse(update.Tienhang.ToString(), out tienHangban);
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                                {
                                                    int solan = (int)(soluongthucban / soluongbantoithieu);
                                                    decimal tiencknhan = solan * (tienck * (tienHangban / tongTienthucban));
                                                    row.Tienck = tiencknhan;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tienck", tiencknhan.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            soluongbantoithieudau = soluongbantoithieu;
                                        }
                                        //else
                                        //{
                                        //    if (soluongbantoithieu > soluongbantoithieudau)
                                        //    {
                                        //        foreach (DataRow update in dtGiaodichkm.Rows)
                                        //        {
                                        //            DataRow row = dtGiaodichct.Select(GiaodichctFields.MasieuthiColumn.ColumnName + " ='" + update[GiaodichctFields.MasieuthiColumn.ColumnName] + "'").FirstOrDefault();
                                        //            string macthientai = row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName].ToString();
                                        //            if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                        //            {
                                        //                row[GiaodichctFields.TienckColumn.ColumnName] = 0;
                                        //                row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName] = "";
                                        //                TinhtoanTienhangKhuyenmaiNhomMaxMin(row, GiaodichctFields.TienckColumn.ColumnName, "0", maPtnx);
                                        //                dtGiaodichct.AcceptChanges();
                                        //            }
                                        //        }
                                        //    }
                                        //}
                                    }
                                    else if (giatribantoithieu != 0)
                                    {
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Tienhang).ToString(), out tongTienthucban);
                                        if (tongTienthucban >= giatribantoithieu && giatribantoithieu > giatribantoithieudau)
                                        {
                                            foreach (Orderct update in dtGiaodichkm)
                                            {
                                                Orderct row = dtGiaodichct.Where(d => d.Masieuthi == update.Masieuthi).FirstOrDefault();
                                                decimal tienHangban = 0;
                                                decimal.TryParse(update.Tienhang.ToString(), out tienHangban);
                                                string macthientai = row.Machuongtrinhkm;
                                                if (string.IsNullOrEmpty(macthientai) || !macthientai.Equals(mactkm))
                                                {
                                                    int solan = (int)(tongTienthucban / giatribantoithieu);
                                                    decimal tiencknhan = solan * (tienck * (tienHangban / tongTienthucban));
                                                    row.Tienck = tiencknhan;
                                                    row.Machuongtrinhkm = mactkm;
                                                    TinhtoanTienhangKhuyenmaiNhomMaxMin(row, "Tienck", tiencknhan.ToString(), maPtnx);
                                                    if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                    {
                                                        Machuongtrinhdaduyethangban = mactkm;
                                                    }
                                                    else
                                                    {
                                                        Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                    }
                                                }
                                            }
                                            giatribantoithieudau = giatribantoithieu;
                                        }
                                        //else
                                        //{
                                        //    if (giatribantoithieu > giatribantoithieudau)
                                        //    {
                                        //        foreach (DataRow update in dtGiaodichkm.Rows)
                                        //        {
                                        //            DataRow row = dtGiaodichct.Select(GiaodichctFields.MasieuthiColumn.ColumnName + " ='" + update[GiaodichctFields.MasieuthiColumn.ColumnName] + "'").FirstOrDefault();
                                        //            string macthientai = row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName].ToString();
                                        //            if (string.IsNullOrEmpty(macthientai) || macthientai.Equals(mactkm))
                                        //            {
                                        //                row[GiaodichctFields.TienckColumn.ColumnName] = 0;
                                        //                row[GiaodichctFields.MachuongtrinhkmColumn.ColumnName] = "";
                                        //                TinhtoanTienhangKhuyenmaiNhomMaxMin(row, GiaodichctFields.TienckColumn.ColumnName, "0", maPtnx);
                                        //                dtGiaodichct.AcceptChanges();
                                        //            }
                                        //        }
                                        //    }
                                        //}
                                    }
                                }
                                #endregion

                                #region Khuyến mại tặng hàng
                                if (soluongkm != 0)
                                {
                                    decimal soluongbantoithieu = 0, giatribantoithieu = 0;
                                    decimal.TryParse(rowkm.Soluongban.ToString(), out soluongbantoithieu);
                                    decimal.TryParse(rowkm.Giatrikmmin.ToString(), out giatribantoithieu);
                                    string masieuthikm = rowkm.Masieuthikm.ToString();
                                    string makhokm = rowkm.Makhohangkm.ToString();
                                    if (soluongbantoithieu != 0)
                                    {
                                        decimal soluongthucban = 0;
                                        soluongthucban = SoluongthucbanThung(dtGiaodichkm);
                                        if (soluongthucban >= soluongbantoithieu)
                                        {
                                            //DataTable dt = DB.XNT_GETTONKHO(PublicValue.DataBaseXnt, PublicValue.XNT_TABLENAME(PublicValue.ngayPhatSinh), makhokm, PublicValue.maDonVi, masieuthikm);
                                            //if (dt == null || dt.Rows.Count == 0)
                                            //    continue;
                                            //else
                                            //{
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck == null || rowCheck.Count == 0)
                                            {
                                                int solan = (int)(soluongthucban / soluongbantoithieu);
                                                soluongkm = soluongkm * solan;
                                                if (soluongkm == 0) continue;
                                                Orderct rowadd = new Orderct();

                                                LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                rowadd.Iskhuyenmai = true;
                                                LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                dtGiaodichctkhuyenmai.Add(rowadd);
                                                if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                {
                                                    Machuongtrinhdaduyethangban = mactkm;
                                                }
                                                else
                                                {
                                                    Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                }
                                            }
                                            else
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    decimal soluongkmcu = 0;
                                                    decimal.TryParse(rowcheckkm.Soluong.ToString(), out soluongkmcu);
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanphamslthung.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (masieuthibankmcu.Equals(maSieuthibanhientai))
                                                        {
                                                            decimal slbantoithieuctcu = 0;
                                                            decimal.TryParse(rowkmcu.Soluongban.ToString(), out slbantoithieuctcu);
                                                            decimal slbandu = soluongthucban % slbantoithieuctcu;
                                                            string mactmoi = rowkm.Machuongtrinh.ToString();
                                                            if (slbandu > 0)
                                                            {
                                                                if (slbandu >= soluongbantoithieu)
                                                                {
                                                                    int solan = (int)(slbandu / soluongbantoithieu);
                                                                    soluongkm = soluongkm * solan;
                                                                    if (soluongkm == 0) continue;
                                                                    if (mact.Equals(mactmoi))
                                                                    {
                                                                        soluongkm = soluongkm + soluongkmcu;
                                                                        TinhtoanTienhangKhuyenMai(rowcheckkm, "Soluong", soluongkm.ToString());
                                                                    }
                                                                    else
                                                                    {
                                                                        Orderct rowadd = new Orderct();
                                                                        LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                                        TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                                        TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                                        //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                                        //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                                        rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                                        rowadd.Iskhuyenmai = true;
                                                                        LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                                        dtGiaodichctkhuyenmai.Add(rowadd);
                                                                        if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                                        {
                                                                            Machuongtrinhdaduyethangban = mactkm;
                                                                        }
                                                                        else
                                                                        {
                                                                            Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            int solan = (int)(soluongthucban / soluongbantoithieu);
                                                            soluongkm = soluongkm * solan;
                                                            if (soluongkm == 0) continue;
                                                            Orderct rowadd = new Orderct();

                                                            LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                            //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                            //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                            rowadd.Machuongtrinhkm = rowkm.Machuongtrinh;
                                                            rowadd.Iskhuyenmai = true;
                                                            LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                            dtGiaodichctkhuyenmai.Add(rowadd);
                                                            if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                            {
                                                                Machuongtrinhdaduyethangban = mactkm;
                                                            }
                                                            else
                                                            {
                                                                Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck != null)
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanphamslthung.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (masieuthibankmcu.Equals(maSieuthibanhientai))
                                                        {
                                                            dtGiaodichctkhuyenmai.Remove(rowcheckkm);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (giatribantoithieu != 0)
                                    {
                                        decimal tongTienthucban = 0;
                                        decimal.TryParse(dtGiaodichkm.Sum(d => d.Thanhtien).ToString(), out tongTienthucban);
                                        if (tongTienthucban >= giatribantoithieu)
                                        {
                                            //DataTable dt = DB.XNT_GETTONKHO(PublicValue.DataBaseXnt, PublicValue.XNT_TABLENAME(PublicValue.ngayPhatSinh), makhokm, PublicValue.maDonVi, masieuthikm);
                                            //if (dt == null || dt.Rows.Count == 0)
                                            //    continue;
                                            //else
                                            //{
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck == null || rowCheck.Count == 0)
                                            {
                                                int solan = (int)(tongTienthucban / giatribantoithieu);
                                                soluongkm = soluongkm * solan;
                                                if (soluongkm == 0) continue;
                                                Orderct rowadd = new Orderct();
                                                LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                rowadd.Iskhuyenmai = true;
                                                LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                dtGiaodichctkhuyenmai.Add(rowadd);

                                                if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                {
                                                    Machuongtrinhdaduyethangban = mactkm;
                                                }
                                                else
                                                {
                                                    Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                }
                                            }
                                            else
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanphamslthung.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (!masieuthibankmcu.Equals(maSieuthiban))
                                                        {
                                                            int solan = (int)(tongTienthucban / giatribantoithieu);
                                                            soluongkm = soluongkm * solan;
                                                            if (soluongkm == 0) continue;
                                                            Orderct rowadd = new Orderct();
                                                            LoadThongtinHanghoaKhuyenMai(rowadd, "Masieuthi", masieuthikm, makhokm, ngayphatsinh);
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Soluong", soluongkm.ToString());
                                                            TinhtoanTienhangKhuyenMai(rowadd, "Dongiachuavat", "0");
                                                            //Gán cột machuongtrinhkm = mã hàng bán để kiểm tra xem mã hàng km này là của mã hàng bán nào.
                                                            //Trong trường hợp mã hàng km tặng kèm cho nhiều mã hàng bán
                                                            rowadd.Machuongtrinhkm = rowkm.Machuongtrinh.ToString();
                                                            rowadd.Iskhuyenmai = true;
                                                            LoadThongtinTaikhoanKhuyenMai(rowadd, maPtnx);
                                                            dtGiaodichctkhuyenmai.Add(rowadd);
                                                            if (string.IsNullOrEmpty(Machuongtrinhdaduyethangban))
                                                            {
                                                                Machuongtrinhdaduyethangban = mactkm;
                                                            }
                                                            else
                                                            {
                                                                Machuongtrinhdaduyethangban = Machuongtrinhdaduyethangban + "," + mactkm;
                                                            }
                                                        }
                                                    }
                                                }
                                                //}
                                            }
                                        }
                                        else
                                        {
                                            List<Orderct> rowCheck = dtGiaodichctkhuyenmai.Where(d => d.Masieuthi == masieuthikm && d.Makhohang == makhokm).ToList();
                                            if (rowCheck != null)
                                            {
                                                foreach (Orderct rowcheckkm in rowCheck)
                                                {
                                                    string mact = rowcheckkm.Machuongtrinhkm.ToString();
                                                    KhuyenmaimotsosanphamModel rowkmcu = kmMotsosanphamslthung.Where(d => d.Machuongtrinh == mact).FirstOrDefault();
                                                    if (rowkmcu != null)
                                                    {
                                                        string masieuthibankmcu = rowkmcu.Masieuthiban.ToString();
                                                        if (masieuthibankmcu.Equals(maSieuthiban))
                                                        {
                                                            dtGiaodichctkhuyenmai.Remove(rowcheckkm);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                #endregion

                                if (string.IsNullOrEmpty(mactkmdadung))
                                {
                                    mactkmdadung = rowkm.Machuongtrinh.ToString();
                                }
                                else
                                {
                                    mactkmdadung = mactkmdadung + "," + rowkm.Machuongtrinh.ToString();
                                }

                                if (string.IsNullOrEmpty(mahangbandaapdung))
                                {
                                    mahangbandaapdung = item.Masieuthi.ToString();
                                }
                                else
                                {
                                    mahangbandaapdung = mahangbandaapdung + "," + item.Masieuthi.ToString();
                                }
                            }
                        }
                    }

                }
                #endregion
                try
                {
                    List<Orderct> rKhuyenmai = dtGiaodichkhuyenmai.Where(d => d.Machuongtrinhkm != "" && d.Tienck == 0 && d.Dongiachuavat == 0).ToList();
                    //(GiaodichctFields.MachuongtrinhkmColumn.ColumnName + " <> '' and " + GiaodichctFields.TienckColumn.ColumnName + " = 0 and " + GiaodichctFields.DongiachuavatColumn.ColumnName + " = 0");
                    foreach (Orderct item in rKhuyenmai)
                    {
                        dtGiaodichkhuyenmai.Remove(item);

                    }
                    foreach (Orderct item in dtGiaodichctkhuyenmai)
                    {
                        dtGiaodichkhuyenmai.Add(item);
                    }
                }
                catch
                {
                    //trường hợp tbKhuyenmai khác tb dtgiaodichct
                    List<Orderct> rKhuyenmai = dtGiaodichct.Where(d => d.Machuongtrinhkm != "" && d.Tienck == 0 && d.Dongiachuavat == 0).ToList();
                    foreach (Orderct item in rKhuyenmai)
                    {
                        dtGiaodichct.Remove(item);

                    }
                    foreach (Orderct item in dtGiaodichctkhuyenmai)
                    {
                        dtGiaodichct.Add(item);
                    }
                }
            }
            catch { }
        }

        private decimal SoluongthucbanThung(List<Orderct> dtGiaodichkm)
        {
            try
            {
                decimal sothungkm = 0;
                foreach (Orderct item in dtGiaodichkm)
                {
                    decimal soluongthucban = 0, quycach = 0;
                    decimal.TryParse(item.Soluong.ToString(), out soluongthucban);
                    decimal.TryParse(item.Quycach.ToString(), out quycach);
                    sothungkm = sothungkm + soluongthucban / quycach;
                }
                return sothungkm;
            }
            catch
            {
                return 0;
            }
        }

        public void TinhtoanTienhangKhuyenmaiNhomMaxMin(Orderct datarview, string ColumnName, string ValueColumn, string Maptnx)
        {
            decimal Soluong = 0, Quycach = 1, Dongiachuavat = 0, Giathungchuavat = 0, Tyleck = 0, Tienck = 0, Tienvat = 0, Tienhang = 0, Thanhtien = 0, Doanhthu = 0;
            decimal.TryParse(datarview.Soluong.ToString(), out Soluong);
            decimal.TryParse(datarview.Quycach.ToString(), out Quycach);
            decimal.TryParse(datarview.Dongiachuavat.ToString(), out Dongiachuavat);
            decimal.TryParse(datarview.Tyleck.ToString(), out Tyleck);
            decimal.TryParse(datarview.Tienck.ToString(), out Tienck);
            decimal.TryParse(datarview.Tienvat.ToString(), out Tienvat);
            decimal.TryParse(datarview.Tienhang.ToString(), out Tienhang);
            decimal.TryParse(datarview.Thanhtien.ToString(), out Thanhtien);
            decimal.TryParse(datarview.Giathungchuavat.ToString(), out Giathungchuavat);

            if (ColumnName.Equals("Dongiachuavat"))
            {
                decimal.TryParse(ValueColumn, out Dongiachuavat);
                Giathungchuavat = Dongiachuavat * Quycach;
                datarview.Giathungchuavat = Giathungchuavat;
            }
            else if (ColumnName.Equals("Giathungchuavat"))
            {
                decimal.TryParse(ValueColumn, out Giathungchuavat);
                Dongiachuavat = Giathungchuavat / Quycach;
                datarview.Dongiachuavat = Dongiachuavat;
            }
            else if (ColumnName.Equals("Tienhang"))
            {
                decimal.TryParse(ValueColumn, out Tienhang);
                if (Soluong > 0)
                {
                    Dongiachuavat = Tienhang / Soluong;
                    Giathungchuavat = Dongiachuavat * Quycach;
                    datarview.Dongiachuavat = Dongiachuavat;
                    datarview.Giathungchuavat = Giathungchuavat;
                }
            }
            else if (ColumnName.Equals("Tyleck"))
            {
                decimal.TryParse(ValueColumn, out Tyleck);
                datarview.Tyleck = Tyleck;
                Tienck = TinhTien.TienChietKhauByGiaKhongVat(Dongiachuavat, Tyleck, Soluong);
            }
            else if (ColumnName.Equals("Tienck"))
            {
                decimal.TryParse(ValueColumn, out Tienck);
                datarview.Tyleck = 0;
            }

            Tienhang = TinhTien.TienHangByDonGia(Dongiachuavat, Soluong);
            Tienvat = TinhTien.TienVatByCongThuc(Tienhang, Tienck, Vats, datarview.Mavat.ToString(), 0);
            Doanhthu = TinhTien.DoanhThuByCongThuc(Tienhang, Tienck, Tienvat, 0, Dmptnxes, Maptnx);
            Thanhtien = TinhTien.ThanhTienByCongThuc(Tienhang, Tienck, Tienvat, 0, Dmptnxes, Maptnx);
            datarview.Tienhang = Tienhang;
            datarview.Tienck = Tienck;
            datarview.Tienvat = Tienvat;
            datarview.Doanhthu = Doanhthu;
            datarview.Thanhtien = Thanhtien;
        }

        public void TinhtoanTienhangKhuyenMai(Orderct datarview, string ColumnName, string ValueColumn)
        {
            decimal Soluong = 0, Quycach = 1, Dongiachuavat = 0, Dongiacovat = 0, Giathungchuavat = 0, Tyleck = 0, Tienck = 0, Tienvat = 0, Tienhang = 0, Thanhtien = 0, Doanhthu = 0;
            decimal.TryParse(datarview.Soluong.ToString(), out Soluong);
            decimal.TryParse(datarview.Quycach.ToString(), out Quycach);
            decimal.TryParse(datarview.Dongiachuavat.ToString(), out Dongiachuavat);
            decimal.TryParse(datarview.Tyleck.ToString(), out Tyleck);
            decimal.TryParse(datarview.Tienck.ToString(), out Tienck);
            decimal.TryParse(datarview.Tienvat.ToString(), out Tienvat);
            decimal.TryParse(datarview.Tienhang.ToString(), out Tienhang);
            decimal.TryParse(datarview.Thanhtien.ToString(), out Thanhtien);
            decimal.TryParse(datarview.Giathungchuavat.ToString(), out Giathungchuavat);

            if (ColumnName.Equals("Soluong"))
            {
                decimal.TryParse(ValueColumn, out Soluong);
                decimal _sothung = 0;
                decimal.TryParse(datarview.Quycach.ToString(), out Quycach);
                int thung = Convert.ToInt32(Soluong) / Convert.ToInt32(Quycach);
                _sothung = decimal.Parse(thung.ToString());
                int le = Convert.ToInt32(Soluong - (_sothung * Quycach));
                datarview.Sothung = _sothung.ToString() + "/" + le.ToString();
                datarview.Soluong = Soluong;
            }
            if (ColumnName.Equals("Sothung"))
            {
                string[] listSothuong = ValueColumn.ToString().Split('/');
                decimal _sothung = 0, _soluongle = 0;
                decimal.TryParse(listSothuong[0].ToString(), out _sothung);
                if (listSothuong.Length > 1) decimal.TryParse(listSothuong[1].ToString(), out _soluongle);
                Soluong = _sothung * Quycach + _soluongle;
                datarview.Soluong = Soluong;

            }
            else if (ColumnName.Equals("Dongiachuavat"))
            {
                decimal.TryParse(ValueColumn, out Dongiachuavat);
                Giathungchuavat = Dongiachuavat * Quycach;
                datarview.Giathungchuavat = Giathungchuavat;
                datarview.Dongiachuavat = Dongiachuavat;
                datarview.Dongiacovat = 0;
                datarview.Dongiacovatnt = 0;
            }
            else if (ColumnName.Equals("Giathungchuavat"))
            {
                decimal.TryParse(ValueColumn, out Giathungchuavat);
                Dongiachuavat = Giathungchuavat / Quycach;
                datarview.Dongiachuavat = Dongiachuavat;
                datarview.Giathungchuavat = Giathungchuavat;
                datarview.Dongiacovat = 0;
                datarview.Dongiacovatnt = 0;
            }

            datarview.Tienhang = 0;
            datarview.Tienck = 0;
            datarview.Tienvat = 0;
            datarview.Doanhthu = 0;
            datarview.Thanhtien = 0;
        }

        public void LoadThongtinHanghoaKhuyenMai(Orderct datarview, string ColumnName, string ValueColumn, string makho, DateTime Ngayphatsinh)
        {
            Mathang rHanghoa = null;
            decimal giabanbuonchuavat = 0, Quycach = 1; decimal tileck = 0;
            //decimal.TryParse(txtTyleck.Text, out tileck);
            if (ColumnName.Equals("Masieuthi"))
            {
                rHanghoa = Mathangs.Where(d => d.Masieuthi == ValueColumn).FirstOrDefault();
                if (rHanghoa != null)
                {
                    //decimal.TryParse(rHanghoa[MathangFields.GiabanbuonchuavatColumn.ColumnName].ToString(), out giabanbuonchuavat);
                    datarview.Masieuthi = ValueColumn;
                    datarview.Mahangcuancc = rHanghoa.Mahangcuancc;
                    datarview.Tendaydu = rHanghoa.Tendaydu;
                    datarview.Dongiachuavat = giabanbuonchuavat;
                    datarview.Quycach = rHanghoa.Quycach;
                    datarview.Mavat = rHanghoa.Mavatban;
                    datarview.Makhohang = makho;
                    datarview.Soluong = 0;
                    datarview.Sothung = "0";
                    datarview.Tyleck = tileck;
                    datarview.Tylecktrendon = 0;
                    datarview.Tiencktrendon = 0;
                    datarview.Tygia = 1;
                    datarview.Mangoaite = "VND";
                    datarview.Tiencktrathuong = 0;
                }
            }
            if (rHanghoa != null)
            {
                decimal.TryParse(rHanghoa.Quycach.ToString(), out Quycach);
                datarview.Giathungchuavat = giabanbuonchuavat * Quycach;
                decimal giavon = 0;
                decimal toncuoiky = 0;
                try
                {
                    DataRow rowGiavon = DB.XNT_Gettonkhomathang(this.DataBaseXnt, DB.XNT_TABLENAME(Ngayphatsinh), makho, this.Madonvi, rHanghoa.Masieuthi).Rows[0];
                    if (rowGiavon != null)
                    {
                        decimal.TryParse(rowGiavon["Giavon"].ToString(), out giavon);
                        decimal.TryParse(rowGiavon["Toncuoikysl"].ToString(), out toncuoiky);
                    }
                }
                catch { }
                datarview.Giavon = giavon;
                datarview.Toncuoikysl = toncuoiky;
            }
        }

        public void LoadThongtinTaikhoanKhuyenMai(Orderct datarview, string Maptnx)
        {
            Dmptnx rPtnx = null;
            rPtnx = Dmptnxes.Where(d => d.Maptnx == Maptnx).FirstOrDefault();
            if (rPtnx != null)
            {
                datarview.Matkco = rPtnx.Matkcodf.ToString();
                datarview.Matkno = rPtnx.Matknodf.ToString();
                datarview.Matkchietkhauco = rPtnx.Matkchietkhaucodf.ToString();
                datarview.Matkchietkhauno = rPtnx.Matkchietkhaunodf.ToString();
                datarview.Matkchiphikhacco = rPtnx.Matkchiphikhaccodf.ToString();
                datarview.Matkchiphikhacno = rPtnx.Matkchiphikhacnodf.ToString();
                datarview.Matkthuegtgtco = rPtnx.Matkthuegtgtcodf.ToString();
                datarview.Matkthuegtgtno = rPtnx.Matkthuegtgtnodf.ToString();
                datarview.Matkkhuyenmaico = rPtnx.Matkkhuyenmaicodf.ToString();
                datarview.Matkkhuyenmaino = rPtnx.Matkkhuyenmainodf.ToString();
                datarview.Matkgiavon = rPtnx.Matkgiavondf.ToString();
                datarview.Matkvtu = rPtnx.Matkvtudf.ToString();
            }
        }
        #endregion
    }
}