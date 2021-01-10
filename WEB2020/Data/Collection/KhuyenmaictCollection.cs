namespace WEB2020.Data.Collection
{
    public class KhuyenmaictCollection
    {
        public KhuyenmaictCollection() { }
        public KhuyenmaictCollection(string _CONNECT_STR)
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

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[6];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = @"SELECT        Itemid, Madonvi, Machuongtrinh, Masieuthiban, Masieuthikm, Mabohang, Soluongban, Soluongkm, Makhohangban, Makhohangkm, Soluongmaxinbin, Giatrikmmax, 
                         Giatrikmmin, Tilechietkhau, Tienchietkhau, Manganhhang, Manhomhang, Manhacungcap
FROM            Khuyenmaict";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "DELETE FROM Khuyenmaict\r\nWHERE        (Madonvi = @Madonvi) AND (Machuongtrinh = @" +
                "Machuongtrinh)";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = @"SELECT        Giatrikmmax, Giatrikmmin, Itemid, Mabohang, Machuongtrinh, Madonvi, Makhohangban, Makhohangkm, Manganhhang, Manhacungcap, Manhomhang, Masieuthiban,
                          Masieuthikm, Soluongban, Soluongkm, Soluongmaxinbin, Tienchietkhau, Tilechietkhau
FROM            Khuyenmaict
WHERE        (Madonvi = @Madonvi) AND (Machuongtrinh = @Machuongtrinh)";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = @"SELECT        Khuyenmaict.Masieuthiban, Khuyenmaict.Masieuthikm, Khuyenmaict.Mabohang, Khuyenmaict.Soluongban, Khuyenmaict.Soluongkm, Khuyenmaict.Makhohangban, 
                         Khuyenmaict.Makhohangkm, Khuyenmaict.Soluongmaxinbin, Khuyenmaict.Giatrikmmax, Khuyenmaict.Giatrikmmin, Khuyenmaict.Tilechietkhau, 
                         Khuyenmaict.Tienchietkhau, Khuyenmaict.Manganhhang, Khuyenmaict.Manhomhang, Khuyenmai.Ngaybatdau, Khuyenmai.Ngayketthuc, 
                         Khuyenmai.Maloaichuongtrinh, Khuyenmai.Mact, Khuyenmaict.Manhacungcap, Khuyenmai.Loaiapdung, Khuyenmai.Trangthai, Khuyenmai.Trangthaikm, 
                         Khuyenmai.Giobatdau, Khuyenmai.Gioketthuc, Khuyenmai.Phutbatdau, Khuyenmai.Phutkethuc, Khuyenmai.Ngayphatsinh, Khuyenmai.Machuongtrinh
FROM            Khuyenmai INNER JOIN
                         Khuyenmaict ON Khuyenmai.Machuongtrinh = Khuyenmaict.Machuongtrinh AND Khuyenmai.Madonvi = Khuyenmaict.Madonvi
WHERE        (Khuyenmai.Madonvi = @madonvi) AND (Khuyenmai.Trangthaikm = @trangthai) AND (Khuyenmai.Ngaybatdau <= @ngayphatsinh) AND 
                         (@ngayphatsinh <= Khuyenmai.Ngayketthuc) AND (Khuyenmai.Mact = N'') AND (Khuyenmaict.Madonvi = @madonvi) AND (Khuyenmai.Trangthai = @apdungcho)";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@trangthai", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaybatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@apdungcho", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthai", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = @"SELECT        Giatrikmmax, Giatrikmmin, Itemid, Mabohang, Machuongtrinh, Madonvi, Makhohangban, Makhohangkm, Manganhhang, Manhacungcap, Manhomhang, Masieuthiban,
                          Masieuthikm, Soluongban, Soluongkm, Soluongmaxinbin, Tienchietkhau, Tilechietkhau
FROM            Khuyenmaict
WHERE        (Madonvi = @Madonvi) AND (Machuongtrinh IN
                             (SELECT        Machuongtrinh
                               FROM            Khuyenmai
                               WHERE        (Madonvi = @Madonvi) AND (Ngayphatsinh >= @Ngayphatsinh)))";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[5].Connection = this.Connection;
            this._commandCollection[5].CommandText = @"INSERT INTO Khuyenmaict
                         (Madonvi, Machuongtrinh, Masieuthiban, Masieuthikm, Mabohang, Soluongban, Soluongkm, Makhohangban, Makhohangkm, Soluongmaxinbin, Giatrikmmax, 
                         Giatrikmmin, Tilechietkhau, Tienchietkhau, Manganhhang, Manhomhang, Manhacungcap)
VALUES        (@Madonvi,@Machuongtrinh,@Masieuthiban,@Masieuthikm,@Mabohang,@Soluongban,@Soluongkm,@Makhohangban,@Makhohangkm,@Soluongmaxinbin,@Giatrikmmax,@Giatrikmmin,@Tilechietkhau,@Tienchietkhau,@Manganhhang,@Manhomhang,@Manhacungcap)";
            this._commandCollection[5].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthiban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthiban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthikm", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mabohang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Mabohang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Soluongban", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Soluongban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Soluongkm", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Soluongkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhohangban", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhohangban", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhohangkm", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhohangkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Soluongmaxinbin", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Soluongmaxinbin", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giatrikmmax", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giatrikmmax", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giatrikmmin", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Giatrikmmin", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tilechietkhau", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tilechietkhau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tienchietkhau", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tienchietkhau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manganhhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manganhhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhomhang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhomhang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Manhacungcap", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Manhacungcap", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
    }
}