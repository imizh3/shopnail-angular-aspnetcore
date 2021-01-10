namespace WEB2020.Data.Collection
{
    public class MathangCollection
    {
        public MathangCollection() { }
        public MathangCollection(string _CONNECT_STR)
        {
            CONNECT_STR = _CONNECT_STR;
            this.Connection = new System.Data.SqlClient.SqlConnection(CONNECT_STR);
        }

        private string CONNECT_STR;
        private global::System.Data.SqlClient.SqlConnection _connection;
        private void InitConnection()
        {
            this._connection = new global::System.Data.SqlClient.SqlConnection();
            this._connection.ConnectionString = CONNECT_STR;
        }
        internal global::System.Data.SqlClient.SqlConnection Connection
        {
            get
            {
                if ((this._connection == null))
                {
                    this.InitConnection();
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
                for (int i = 0; (i < this.CommandCollection.Length); i = (i + 1))
                {
                    if ((this.CommandCollection[i] != null))
                    {
                        ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[i])).Connection = value;
                    }
                }
            }
        }
        public global::System.Data.SqlClient.SqlCommand[] CommandCollection
        {
            get
            {
                if ((this._commandCollection == null))
                {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        private global::System.Data.SqlClient.SqlCommand[] _commandCollection;

        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[24];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = @"SELECT        Masieuthi, Madonvi, Manganh, Manhomhang, Makhachhang, Madvtinh, Tendaydu, Tenviettat, Mahangcuancc, Mavatmua, Mavatban, Trangthaikd, Ngaytao, Barcode, Giabanlecovat, Giabanbuoncovat, Giabanlechuavat, 
                         Giabanbuonchuavat, Giamuacovat, Giamuachuavat, Tylelaibuon, Tylelaile, Tendangnhap, Tendangnhapsua, Ngayphatsinh, Itemcode, QuanlySerial, Thoigianbaohanh, Kieubaohanh, Makehang, Quycach, Madongbo, Hieusuat, 
                         Mahaiquan, Mahs, Mavatnk, Mota, Mactpk, Maplv, Tyleckmua, Tyleckban, Giathungbuonchuavat, Giathungbuoncovat
FROM            Mathang";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "DELETE FROM Mathang\r\nWHERE        (Masieuthi = @Masieuthi) AND (Madonvi = @Madonv" +
                "i)";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "SELECT        Mathang.Barcode, Mathang.Giabanbuonchuavat, Mathang.Giabanbuoncovat" +
                ", Mathang.Giabanlechuavat, Mathang.Giabanlecovat, Mathang.Giamuachuavat, Mathang" +
                ".Giamuacovat, Mathang.Itemcode, Mathang.Kieubaohanh, \r\n                         " +
                "Mathang.Madonvi, Mathang.Madvtinh, Mathang.Mahangcuancc, Mathang.Makehang, Matha" +
                "ng.Makhachhang, Mathang.Manganh, Mathang.Manhomhang, Mathang.Masieuthi, Mathang." +
                "Mavatban, Mathang.Mavatmua, \r\n                         Mathang.Ngayphatsinh, Mat" +
                "hang.Ngaytao, Mathang.QuanlySerial, Mathang.Quycach, Mathang.Tendangnhap, Mathan" +
                "g.Tendangnhapsua, Mathang.Tendaydu, Mathang.Tenviettat, Mathang.Thoigianbaohanh," +
                " \r\n                         Mathang.Trangthaikd, Mathang.Tylelaibuon, Mathang.Ty" +
                "lelaile, Donvitinh.Donvile, Nganhhang.Tennganh, Nhomhang.Tennhomhang, Khachhang." +
                "Tenkhachhang, Mathang.Madongbo, Mathang.Mavatnk, Mathang.Mahaiquan, \r\n          " +
                "               Mathang.Mota, Mathang.Mahs, Mathang.Mactpk, Mathang.Maplv, Mathan" +
                "g.Hieusuat, Mathang.Tyleckmua, Mathang.Tyleckban, Mathang.Giathungbuonchuavat, M" +
                "athang.Giathungbuoncovat\r\nFROM            Mathang INNER JOIN\r\n                  " +
                "       Donvitinh ON Mathang.Madvtinh = Donvitinh.Madvtinh AND Mathang.Madonvi = " +
                "Donvitinh.Madonvi INNER JOIN\r\n                         Nganhhang ON Mathang.Mang" +
                "anh = Nganhhang.Manganh AND Mathang.Madonvi = Nganhhang.Madonvi INNER JOIN\r\n    " +
                "                     Nhomhang ON Mathang.Manhomhang = Nhomhang.Manhomhang AND Ma" +
                "thang.Madonvi = Nhomhang.Madonvi LEFT OUTER JOIN\r\n                         Khach" +
                "hang ON Mathang.Makhachhang = Khachhang.Makhachhang AND Mathang.Madonvi = Khachh" +
                "ang.Madonvi\r\nWHERE        (Mathang.Madonvi = @Madonvi)";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "SELECT        Mathang.Barcode, Mathang.Giabanbuonchuavat, Mathang.Giabanbuoncovat" +
                ", Mathang.Giabanlechuavat, Mathang.Giabanlecovat, Mathang.Giamuachuavat, Mathang" +
                ".Giamuacovat, Mathang.Itemcode, Mathang.Kieubaohanh, \r\n                         " +
                "Mathang.Madonvi, Mathang.Madvtinh, Mathang.Mahangcuancc, Mathang.Makehang, Matha" +
                "ng.Makhachhang, Mathang.Manganh, Mathang.Manhomhang, Mathang.Masieuthi, Mathang." +
                "Mavatban, Mathang.Mavatmua, \r\n                         Mathang.Ngayphatsinh, Mat" +
                "hang.Ngaytao, Mathang.QuanlySerial, Mathang.Quycach, Mathang.Tendangnhap, Mathan" +
                "g.Tendangnhapsua, Mathang.Tendaydu, Mathang.Tenviettat, Mathang.Thoigianbaohanh," +
                " \r\n                         Mathang.Trangthaikd, Mathang.Tylelaibuon, Mathang.Ty" +
                "lelaile, Donvitinh.Donvile, Nganhhang.Tennganh, Nhomhang.Tennhomhang, Khachhang." +
                "Tenkhachhang, Mathang.Madongbo, Mathang.Mavatnk, Mathang.Mahaiquan, \r\n          " +
                "               Mathang.Mota, Mathang.Mahs, Mathang.Mactpk, Mathang.Maplv, Mathan" +
                "g.Hieusuat, Mathang.Tyleckmua, Mathang.Tyleckban, Mathang.Giathungbuonchuavat, M" +
                "athang.Giathungbuoncovat\r\nFROM            Mathang INNER JOIN\r\n                  " +
                "       Donvitinh ON Mathang.Madvtinh = Donvitinh.Madvtinh AND Mathang.Madonvi = " +
                "Donvitinh.Madonvi INNER JOIN\r\n                         Nganhhang ON Mathang.Mang" +
                "anh = Nganhhang.Manganh AND Mathang.Madonvi = Nganhhang.Madonvi INNER JOIN\r\n    " +
                "                     Nhomhang ON Mathang.Manhomhang = Nhomhang.Manhomhang AND Ma" +
                "thang.Madonvi = Nhomhang.Madonvi LEFT OUTER JOIN\r\n                         Khach" +
                "hang ON Mathang.Makhachhang = Khachhang.Makhachhang AND Mathang.Madonvi = Khachh" +
                "ang.Madonvi\r\nWHERE        (Mathang.Madonvi = @Madonvi) AND (Mathang.Trangthaikd " +
                "= @Trangthaikd)";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikd", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikd", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "SELECT        Mathang.Barcode, Mathang.Giabanbuonchuavat, Mathang.Giabanbuoncovat" +
                ", Mathang.Giabanlechuavat, Mathang.Giabanlecovat, Mathang.Giamuachuavat, Mathang" +
                ".Giamuacovat, Mathang.Itemcode, Mathang.Kieubaohanh, \r\n                         " +
                "Mathang.Madonvi, Mathang.Madvtinh, Mathang.Mahangcuancc, Mathang.Makehang, Matha" +
                "ng.Makhachhang, Mathang.Manganh, Mathang.Manhomhang, Mathang.Masieuthi, Mathang." +
                "Mavatban, Mathang.Mavatmua, \r\n                         Mathang.Ngayphatsinh, Mat" +
                "hang.Ngaytao, Mathang.QuanlySerial, Mathang.Quycach, Mathang.Tendangnhap, Mathan" +
                "g.Tendangnhapsua, Mathang.Tendaydu, Mathang.Tenviettat, Mathang.Thoigianbaohanh," +
                " \r\n                         Mathang.Trangthaikd, Mathang.Tylelaibuon, Mathang.Ty" +
                "lelaile, Donvitinh.Donvile, Nganhhang.Tennganh, Nhomhang.Tennhomhang, Khachhang." +
                "Tenkhachhang, Mathang.Madongbo, Mathang.Hieusuat, Mathang.Mota, \r\n              " +
                "           Mathang.Mahs, Mathang.Mavatnk, Mathang.Mahaiquan, Mathang.Mactpk, Mat" +
                "hang.Maplv\r\nFROM            Mathang INNER JOIN\r\n                         Donviti" +
                "nh ON Mathang.Madvtinh = Donvitinh.Madvtinh AND Mathang.Madonvi = Donvitinh.Mado" +
                "nvi INNER JOIN\r\n                         Nganhhang ON Mathang.Manganh = Nganhhan" +
                "g.Manganh AND Mathang.Madonvi = Nganhhang.Madonvi INNER JOIN\r\n                  " +
                "       Nhomhang ON Mathang.Manhomhang = Nhomhang.Manhomhang AND Mathang.Madonvi " +
                "= Nhomhang.Madonvi LEFT OUTER JOIN\r\n                         Khachhang ON Mathan" +
                "g.Makhachhang = Khachhang.Makhachhang AND Mathang.Madonvi = Khachhang.Madonvi\r\nW" +
                "HERE        (Mathang.Madonvi = @Madonvi) AND (Mathang.Manganh IN\r\n              " +
                "               (SELECT        Manganh\r\n                               FROM      " +
                "      Nganhhang AS Nganhhang_1\r\n                               WHERE        (Mad" +
                "onvi = @Madonvi) AND (Loai = @Loai)))";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Loai", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[5].Connection = this.Connection;
            this._commandCollection[5].CommandText = @"SELECT        Barcode, Giabanbuonchuavat, Giabanbuoncovat, Giabanlechuavat, Giabanlecovat, Giamuachuavat, Giamuacovat, Giathungbuonchuavat, Giathungbuoncovat, Hieusuat, Itemcode, Kieubaohanh, Mactpk, Madongbo, Madonvi, 
                         Madvtinh, Mahaiquan, Mahangcuancc, Mahs, Makehang, Makhachhang, Manganh, Manhomhang, Maplv, Masieuthi, Mavatban, Mavatmua, Mavatnk, Mota, Ngayphatsinh, Ngaytao, QuanlySerial, Quycach, Tendangnhap, 
                         Tendangnhapsua, Tendaydu, Tenviettat, Thoigianbaohanh, Trangthaikd, Tyleckban, Tyleckmua, Tylelaibuon, Tylelaile
FROM            Mathang
WHERE        (Ngayphatsinh >= @Ngayphatsinh) AND (Madonvi = @Madonvi)";
            this._commandCollection[5].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[6].Connection = this.Connection;
            this._commandCollection[6].CommandText = @"SELECT Barcode, Giabanbuonchuavat, Giabanbuoncovat, Giabanlechuavat, Giabanlecovat, Giamuachuavat, Giamuacovat, Giathungbuonchuavat, Giathungbuoncovat, Hieusuat, Itemcode, Kieubaohanh, Mactpk, Madongbo, Madonvi, Madvtinh, Mahaiquan, Mahangcuancc, Mahs, Makehang, Makhachhang, Manganh, Manhomhang, Maplv, Masieuthi, Mavatban, Mavatmua, Mavatnk, Mota, Ngayphatsinh, Ngaytao, QuanlySerial, Quycach, Tendangnhap, Tendangnhapsua, Tendaydu, Tenviettat, Thoigianbaohanh, Trangthaikd, Tyleckban, Tyleckmua, Tylelaibuon, Tylelaile FROM Mathang WHERE (Madonvi = @Madonvi) AND (Mahangcuancc = @Mahangcuancc)";
            this._commandCollection[6].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[6].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahangcuancc", global::System.Data.SqlDbType.VarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, "Mahangcuancc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[7] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[7].Connection = this.Connection;
            this._commandCollection[7].CommandText = @"SELECT Barcode, Giabanbuonchuavat, Giabanbuoncovat, Giabanlechuavat, Giabanlecovat, Giamuachuavat, Giamuacovat, Giathungbuonchuavat, Giathungbuoncovat, Hieusuat, Itemcode, Kieubaohanh, Mactpk, Madongbo, Madonvi, Madvtinh, Mahaiquan, Mahangcuancc, Mahs, Makehang, Makhachhang, Manganh, Manhomhang, Maplv, Masieuthi, Mavatban, Mavatmua, Mavatnk, Mota, Ngayphatsinh, Ngaytao, QuanlySerial, Quycach, Tendangnhap, Tendangnhapsua, Tendaydu, Tenviettat, Thoigianbaohanh, Trangthaikd, Tyleckban, Tyleckmua, Tylelaibuon, Tylelaile FROM Mathang WHERE (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[7].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[7].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[7].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[8].Connection = this.Connection;
            this._commandCollection[8].CommandText = @"SELECT Barcode, Giabanbuonchuavat, Giabanbuoncovat, Giabanlechuavat, Giabanlecovat, Giamuachuavat, Giamuacovat, Giathungbuonchuavat, Giathungbuoncovat, Hieusuat, Itemcode, Kieubaohanh, Mactpk, Madongbo, Madonvi, Madvtinh, Mahaiquan, Mahangcuancc, Mahs, Makehang, Makhachhang, Manganh, Manhomhang, Maplv, Masieuthi, Mavatban, Mavatmua, Mavatnk, Mota, Ngayphatsinh, Ngaytao, QuanlySerial, Quycach, Tendangnhap, Tendangnhapsua, Tendaydu, Tenviettat, Thoigianbaohanh, Trangthaikd, Tyleckban, Tyleckmua, Tylelaibuon, Tylelaile FROM Mathang WHERE (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[8].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[9].Connection = this.Connection;
            this._commandCollection[9].CommandText = @"INSERT INTO Mathang
                         (Masieuthi, Madonvi, Manganh, Manhomhang, Makhachhang, Madvtinh, Tendaydu, Tenviettat, Mahangcuancc, Mavatmua, Mavatban, Trangthaikd, Quycach, Barcode, Giabanlecovat, Giabanbuoncovat, Giabanlechuavat, 
                         Giabanbuonchuavat, Giamuacovat, Giamuachuavat, Tylelaibuon, Tylelaile, Tendangnhap, Ngayphatsinh, Itemcode, QuanlySerial, Thoigianbaohanh, Kieubaohanh, Makehang, Mavatnk, Mahaiquan, Mota, Mahs, Mactpk, Maplv)
VALUES        (@Masieuthi,@Madonvi,@Manganh,@Manhomhang,@Makhachhang,@Madvtinh,@Tendaydu,@Tenviettat,@Mahangcuancc,@Mavatmua,@Mavatban,@Trangthaikd,@Quycach,@Barcode,@Giabanlecovat,@Giabanbuoncovat,@Giabanlechuavat,@Giabanbuonchuavat,@Giamuacovat,@Giamuachuavat,@Tylelaibuon,@Tylelaile,@Tendangnhap,@Ngayphatsinh,@Itemcode,@QuanlySerial,@Thoigianbaohanh,@Kieubaohanh,@Makehang,@Mavatnk,@Mahaiquan,@Mota,@Mahs,@Mactpk,@Maplv)";
            this._commandCollection[9].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manganh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manganh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madvtinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madvtinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendaydu", global::System.Data.SqlDbType.NVarChar, 300, global::System.Data.ParameterDirection.Input, 0, 0, "Tendaydu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenviettat", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenviettat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahangcuancc", global::System.Data.SqlDbType.VarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, "Mahangcuancc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatmua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikd", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikd", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Quycach", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Quycach", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Barcode", global::System.Data.SqlDbType.NVarChar, 2000, global::System.Data.ParameterDirection.Input, 0, 0, "Barcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlecovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlecovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuoncovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuoncovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlechuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlechuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuonchuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuonchuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuacovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuacovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuachuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuachuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaibuon", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaibuon", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaile", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaile", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhap", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhap", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Itemcode", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Itemcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@QuanlySerial", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QuanlySerial", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Thoigianbaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Thoigianbaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieubaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Kieubaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makehang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makehang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatnk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatnk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahaiquan", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mahaiquan", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mota", global::System.Data.SqlDbType.NVarChar, 500, global::System.Data.ParameterDirection.Input, 0, 0, "Mota", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahs", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mahs", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mactpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mactpk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Maplv", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Maplv", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[10].Connection = this.Connection;
            this._commandCollection[10].CommandText = @"INSERT INTO Mathang
                         (Masieuthi, Madonvi, Manganh, Manhomhang, Makhachhang, Madvtinh, Tendaydu, Tenviettat, Mahangcuancc, Mavatmua, Mavatban, Trangthaikd, Quycach, 
                         Barcode, Giabanlecovat, Giabanbuoncovat, Giabanlechuavat, Giabanbuonchuavat, Giamuacovat, Giamuachuavat, Tylelaibuon, Tylelaile, Tendangnhap, 
                         Ngayphatsinh, Itemcode, QuanlySerial, Thoigianbaohanh, Kieubaohanh, Makehang, Hieusuat)
VALUES        (@Masieuthi,@Madonvi,@Manganh,@Manhomhang,@Makhachhang,@Madvtinh,@Tendaydu,@Tenviettat,@Mahangcuancc,@Mavatmua,@Mavatban,@Trangthaikd,@Quycach,@Barcode,@Giabanlecovat,@Giabanbuoncovat,@Giabanlechuavat,@Giabanbuonchuavat,@Giamuacovat,@Giamuachuavat,@Tylelaibuon,@Tylelaile,@Tendangnhap,@Ngayphatsinh,@Itemcode,@QuanlySerial,@Thoigianbaohanh,@Kieubaohanh,@Makehang,@Hieusuat)";
            this._commandCollection[10].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manganh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manganh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madvtinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madvtinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendaydu", global::System.Data.SqlDbType.NVarChar, 300, global::System.Data.ParameterDirection.Input, 0, 0, "Tendaydu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenviettat", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenviettat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahangcuancc", global::System.Data.SqlDbType.VarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, "Mahangcuancc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatmua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikd", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikd", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Quycach", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Quycach", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Barcode", global::System.Data.SqlDbType.NVarChar, 2000, global::System.Data.ParameterDirection.Input, 0, 0, "Barcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlecovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlecovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuoncovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuoncovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlechuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlechuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuonchuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuonchuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuacovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuacovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuachuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuachuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaibuon", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaibuon", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaile", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaile", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhap", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhap", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Itemcode", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Itemcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@QuanlySerial", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QuanlySerial", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Thoigianbaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Thoigianbaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieubaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Kieubaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makehang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makehang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Hieusuat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Hieusuat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[11].Connection = this.Connection;
            this._commandCollection[11].CommandText = @"UPDATE       Mathang
SET                Makhachhang = @Makhachhang, Mavatmua = @Mavatmua, Giabanlecovat = @Giabanlecovat, Giabanbuoncovat = @Giabanbuoncovat, Giabanlechuavat = @Giabanlechuavat, Giabanbuonchuavat = @Giabanbuonchuavat, 
                         Giamuacovat = @Giamuacovat, Giamuachuavat = @Giamuachuavat, Tylelaibuon = @Tylelaibuon, Tylelaile = @Tylelaile
WHERE        (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[11].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatmua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlecovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlecovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuoncovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuoncovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlechuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlechuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuonchuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuonchuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuacovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuacovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuachuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuachuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaibuon", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaibuon", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaile", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaile", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[12] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[12].Connection = this.Connection;
            this._commandCollection[12].CommandText = "UPDATE       Mathang\r\nSET                Giathungbuonchuavat = @Giathungbuonchuav" +
                "at, Giathungbuoncovat = @Giathungbuoncovat\r\nWHERE        (Masieuthi = @Masieuthi" +
                ") AND (Madonvi = @Madonvi)";
            this._commandCollection[12].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[12].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giathungbuonchuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giathungbuonchuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[12].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giathungbuoncovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giathungbuoncovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[12].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[12].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[13] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[13].Connection = this.Connection;
            this._commandCollection[13].CommandText = "UPDATE       Mathang\r\nSET                Makehang = @Makehang\r\nWHERE        (Masi" +
                "euthi = @Masieuthi) AND (Madonvi = @Madonvi); ";
            this._commandCollection[13].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[13].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makehang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makehang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[13].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[13].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[14] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[14].Connection = this.Connection;
            this._commandCollection[14].CommandText = "UPDATE       Mathang\r\nSET                Makhachhang = @Makhachhangmoi\r\nWHERE    " +
                "    (Madonvi = @Madonvi) AND (Makhachhang = @Makhachhangcu)";
            this._commandCollection[14].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[14].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhangmoi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[14].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[14].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhangcu", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[15] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[15].Connection = this.Connection;
            this._commandCollection[15].CommandText = @"UPDATE       Mathang
SET                Madongbo = @Madongbo
WHERE        (Masieuthi = @Original_Masieuthi) AND (Madonvi = @Original_Madonvi); 
SELECT Masieuthi, Madonvi, Manganh, Manhomhang, Makhachhang, Madvtinh, Tendaydu, Tenviettat, Mahangcuancc, Mavatmua, Mavatban, Trangthaikd, Ngaytao, Barcode, Giabanlecovat, Giabanbuoncovat, Giabanlechuavat, Giabanbuonchuavat, Giamuacovat, Giamuachuavat, Tylelaibuon, Tylelaile, Tendangnhap, Tendangnhapsua, Ngayphatsinh, Itemcode, QuanlySerial, Thoigianbaohanh, Kieubaohanh, Makehang, Quycach, Madongbo FROM Mathang WHERE (Madonvi = @Original_Madonvi) AND (Masieuthi = @Original_Masieuthi)";
            this._commandCollection[15].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[15].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madongbo", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Madongbo", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[15].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[15].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[16] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[16].Connection = this.Connection;
            this._commandCollection[16].CommandText = @"UPDATE       Mathang
SET                Manhomhang = @Manhomhang, Makhachhang = @Makhachhang, Madvtinh = @Madvtinh, Tendaydu = @Tendaydu, Tenviettat = @Tenviettat, Mahangcuancc = @Mahangcuancc, Mavatmua = @Mavatmua, 
                         Mavatban = @Mavatban, Trangthaikd = @Trangthaikd, Ngaytao = @Ngaytao, Quycach = @Quycach, Barcode = @Barcode, Giabanlecovat = @Giabanlecovat, Giabanbuoncovat = @Giabanbuoncovat, 
                         Giabanlechuavat = @Giabanlechuavat, Giabanbuonchuavat = @Giabanbuonchuavat, Giamuacovat = @Giamuacovat, Giamuachuavat = @Giamuachuavat, Tylelaibuon = @Tylelaibuon, Tylelaile = @Tylelaile, 
                         Tendangnhapsua = @Tendangnhapsua, Ngayphatsinh = @Ngayphatsinh, Itemcode = @Itemcode, QuanlySerial = @QuanlySerial, Thoigianbaohanh = @Thoigianbaohanh, Kieubaohanh = @Kieubaohanh, 
                         Makehang = @Makehang, Mavatnk = @Mavatnk, Mahaiquan = @Mahaiquan, Mota = @Mota, Mahs = @Mahs, Mactpk = @Mactpk, Maplv = @Maplv
WHERE        (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[16].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madvtinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madvtinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendaydu", global::System.Data.SqlDbType.NVarChar, 300, global::System.Data.ParameterDirection.Input, 0, 0, "Tendaydu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenviettat", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenviettat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahangcuancc", global::System.Data.SqlDbType.VarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, "Mahangcuancc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatmua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikd", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikd", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngaytao", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaytao", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Quycach", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Quycach", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Barcode", global::System.Data.SqlDbType.NVarChar, 2000, global::System.Data.ParameterDirection.Input, 0, 0, "Barcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlecovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlecovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuoncovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuoncovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlechuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlechuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuonchuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuonchuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuacovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuacovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuachuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuachuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaibuon", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaibuon", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaile", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaile", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhapsua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhapsua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Itemcode", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Itemcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@QuanlySerial", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QuanlySerial", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Thoigianbaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Thoigianbaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieubaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Kieubaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makehang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makehang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatnk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatnk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahaiquan", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mahaiquan", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mota", global::System.Data.SqlDbType.NVarChar, 500, global::System.Data.ParameterDirection.Input, 0, 0, "Mota", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahs", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mahs", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mactpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mactpk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Maplv", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Maplv", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[16].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[17] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[17].Connection = this.Connection;
            this._commandCollection[17].CommandText = @"UPDATE       Mathang
SET                Manhomhang = @Manhomhang, Makhachhang = @Makhachhang, Madvtinh = @Madvtinh, Tendaydu = @Tendaydu, Tenviettat = @Tenviettat, 
                         Mahangcuancc = @Mahangcuancc, Mavatmua = @Mavatmua, Mavatban = @Mavatban, Trangthaikd = @Trangthaikd, Ngaytao = @Ngaytao, Quycach = @Quycach, 
                         Barcode = @Barcode, Giabanlecovat = @Giabanlecovat, Giabanbuoncovat = @Giabanbuoncovat, Giabanlechuavat = @Giabanlechuavat, 
                         Giabanbuonchuavat = @Giabanbuonchuavat, Giamuacovat = @Giamuacovat, Giamuachuavat = @Giamuachuavat, Tylelaibuon = @Tylelaibuon, 
                         Tylelaile = @Tylelaile, Tendangnhapsua = @Tendangnhapsua, Ngayphatsinh = @Ngayphatsinh, Itemcode = @Itemcode, QuanlySerial = @QuanlySerial, 
                         Thoigianbaohanh = @Thoigianbaohanh, Kieubaohanh = @Kieubaohanh, Makehang = @Makehang, Hieusuat = @Hieusuat
WHERE        (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[17].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madvtinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madvtinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendaydu", global::System.Data.SqlDbType.NVarChar, 300, global::System.Data.ParameterDirection.Input, 0, 0, "Tendaydu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenviettat", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenviettat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahangcuancc", global::System.Data.SqlDbType.VarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, "Mahangcuancc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatmua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikd", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikd", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngaytao", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaytao", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Quycach", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Quycach", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Barcode", global::System.Data.SqlDbType.NVarChar, 2000, global::System.Data.ParameterDirection.Input, 0, 0, "Barcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlecovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlecovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuoncovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuoncovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanlechuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanlechuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giabanbuonchuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giabanbuonchuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuacovat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuacovat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giamuachuavat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giamuachuavat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaibuon", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaibuon", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tylelaile", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tylelaile", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhapsua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhapsua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Itemcode", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Itemcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@QuanlySerial", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QuanlySerial", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Thoigianbaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Thoigianbaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieubaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Kieubaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makehang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makehang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Hieusuat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Hieusuat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[17].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[18] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[18].Connection = this.Connection;
            this._commandCollection[18].CommandText = "UPDATE       Mathang\r\nSET                Manganh = @Manganh, Manhomhang = @Manhom" +
                "hang\r\nWHERE        (Masieuthi = @Original_Masieuthi) AND (Madonvi = @Original_Ma" +
                "donvi)";
            this._commandCollection[18].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[18].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manganh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manganh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[18].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[18].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[18].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[19] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[19].Connection = this.Connection;
            this._commandCollection[19].CommandText = "UPDATE       Mathang\r\nSET                Makhachhang = @Makhachhang\r\nWHERE       " +
                " (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[19].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[19].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[19].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[19].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[20] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[20].Connection = this.Connection;
            this._commandCollection[20].CommandText = @"UPDATE       Mathang
SET                Manhomhang = @Manhomhang, Makhachhang = @Makhachhang, Madvtinh = @Madvtinh, Tendaydu = @Tendaydu, Tenviettat = @Tenviettat, Mahangcuancc = @Mahangcuancc, Mavatmua = @Mavatmua, 
                         Mavatban = @Mavatban, Barcode = @Barcode, Tendangnhapsua = @Tendangnhapsua, Itemcode = @Itemcode, QuanlySerial = @QuanlySerial, Thoigianbaohanh = @Thoigianbaohanh, Kieubaohanh = @Kieubaohanh, 
                         Makehang = @Makehang, Quycach = @Quycach, Hieusuat = @Hieusuat
WHERE        (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[20].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhachhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhachhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madvtinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madvtinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendaydu", global::System.Data.SqlDbType.NVarChar, 300, global::System.Data.ParameterDirection.Input, 0, 0, "Tendaydu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenviettat", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenviettat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mahangcuancc", global::System.Data.SqlDbType.VarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, "Mahangcuancc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatmua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mavatban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mavatban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Barcode", global::System.Data.SqlDbType.NVarChar, 2000, global::System.Data.ParameterDirection.Input, 0, 0, "Barcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhapsua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhapsua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Itemcode", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Itemcode", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@QuanlySerial", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 0, 0, "QuanlySerial", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Thoigianbaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Thoigianbaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieubaohanh", global::System.Data.SqlDbType.NVarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Kieubaohanh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makehang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makehang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Quycach", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Quycach", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Hieusuat", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Hieusuat", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[20].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[21] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[21].Connection = this.Connection;
            this._commandCollection[21].CommandText = "UPDATE       Mathang\r\nSET                Trangthaikd = @Trangthaikd\r\nWHERE       " +
                " (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[21].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[21].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikd", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikd", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[21].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[21].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[22] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[22].Connection = this.Connection;
            this._commandCollection[22].CommandText = "UPDATE       Mathang\r\nSET                Tyleckmua = @Tyleckmua\r\nWHERE        (Ma" +
                "sieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[22].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[22].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tyleckmua", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tyleckmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[22].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[22].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[23] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[23].Connection = this.Connection;
            this._commandCollection[23].CommandText = "UPDATE       Mathang\r\nSET                Tyleckmua = @Tyleckmua, Tyleckban = @Tyl" +
                "eckban\r\nWHERE        (Masieuthi = @Masieuthi) AND (Madonvi = @Madonvi)";
            this._commandCollection[23].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[23].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tyleckmua", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tyleckmua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[23].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tyleckban", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tyleckban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[23].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[23].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
        }
    }
}