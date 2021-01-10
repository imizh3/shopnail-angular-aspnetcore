namespace WEB2020.Data.Collection
{
	public class KhuyenmaiCollection
	{
	 public KhuyenmaiCollection() { }
        public KhuyenmaiCollection(string _CONNECT_STR)
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
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[12];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = @"SELECT        Machuongtrinh, Madonvi, Loaiapdung, Maloaichuongtrinh, Tenchuongtrinh, Trangthai, Trangthaikm, Giobatdau, Gioketthuc, Phutbatdau, Phutkethuc, Ngaytao, Mact, Tendangnhap, Tendangnhapsua, Ngayphatsinh, Ngaybatdau, 
                         Ngayketthuc, Diengiaikm
FROM            Khuyenmai";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "DELETE FROM Khuyenmai\r\nWHERE        (Machuongtrinh = @Machuongtrinh) AND (Madonvi" +
                " = @Madonvi)";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = @"SELECT Diengiaikm, Giobatdau, Gioketthuc, Loaiapdung, Machuongtrinh, Mact, Madonvi, Maloaichuongtrinh, Ngaybatdau, Ngayketthuc, Ngayphatsinh, Ngaytao, Phutbatdau, Phutkethuc, Tenchuongtrinh, Tendangnhap, Tendangnhapsua, Trangthai, Trangthaikm FROM Khuyenmai WHERE (Madonvi = @Madonvi) AND (Trangthaikm = @Trangthaikm) AND (Ngaybatdau <= @Ngayphatsinh) AND (Ngayketthuc >= @Ngayphatsinh) AND (Trangthai = @Trangthai)";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikm", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaybatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthai", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthai", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = @"SELECT Diengiaikm, Giobatdau, Gioketthuc, Loaiapdung, Machuongtrinh, Mact, Madonvi, Maloaichuongtrinh, Ngaybatdau, Ngayketthuc, Ngayphatsinh, Ngaytao, Phutbatdau, Phutkethuc, Tenchuongtrinh, Tendangnhap, Tendangnhapsua, Trangthai, Trangthaikm FROM Khuyenmai WHERE (Madonvi = @Madonvi) AND (Ngayphatsinh >= @Ngayphatsinh)";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.Date, 3, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = @"SELECT Diengiaikm, Giobatdau, Gioketthuc, Loaiapdung, Machuongtrinh, Mact, Madonvi, Maloaichuongtrinh, Ngaybatdau, Ngayketthuc, Ngayphatsinh, Ngaytao, Phutbatdau, Phutkethuc, Tenchuongtrinh, Tendangnhap, Tendangnhapsua, Trangthai, Trangthaikm FROM Khuyenmai WHERE (Madonvi = @Madonvi) AND (Ngayphatsinh >= @Tungay) AND (Ngayphatsinh <= @Denngay)";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tungay", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Denngay", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[5].Connection = this.Connection;
            this._commandCollection[5].CommandText = @"SELECT Diengiaikm, Giobatdau, Gioketthuc, Loaiapdung, Machuongtrinh, Mact, Madonvi, Maloaichuongtrinh, Ngaybatdau, Ngayketthuc, Ngayphatsinh, Ngaytao, Phutbatdau, Phutkethuc, Tenchuongtrinh, Tendangnhap, Tendangnhapsua, Trangthai, Trangthaikm FROM Khuyenmai WHERE (Machuongtrinh = @Machuongtrinh) AND (Madonvi = @Madonvi)";
            this._commandCollection[5].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[6].Connection = this.Connection;
            this._commandCollection[6].CommandText = @"SELECT Diengiaikm, Giobatdau, Gioketthuc, Loaiapdung, Machuongtrinh, Mact, Madonvi, Maloaichuongtrinh, Ngaybatdau, Ngayketthuc, Ngayphatsinh, Ngaytao, Phutbatdau, Phutkethuc, Tenchuongtrinh, Tendangnhap, Tendangnhapsua, Trangthai, Trangthaikm FROM Khuyenmai WHERE (Tenchuongtrinh = @Tenchuongtrinh) AND (Madonvi = @Madonvi)";
            this._commandCollection[6].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[6].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenchuongtrinh", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenchuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[7] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[7].Connection = this.Connection;
            this._commandCollection[7].CommandText = @"SELECT Diengiaikm, Giobatdau, Gioketthuc, Loaiapdung, Machuongtrinh, Mact, Madonvi, Maloaichuongtrinh, Ngaybatdau, Ngayketthuc, Ngayphatsinh, Ngaytao, Phutbatdau, Phutkethuc, Tenchuongtrinh, Tendangnhap, Tendangnhapsua, Trangthai, Trangthaikm FROM Khuyenmai WHERE (Madonvi = @Madonvi) AND (Trangthaikm = @Trangthaikm)";
            this._commandCollection[7].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[7].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[7].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikm", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[8].Connection = this.Connection;
            this._commandCollection[8].CommandText = @"INSERT INTO Khuyenmai
                         (Machuongtrinh, Madonvi, Loaiapdung, Maloaichuongtrinh, Tenchuongtrinh, Trangthai, Trangthaikm, Giobatdau, Gioketthuc, Phutbatdau, Phutkethuc, Mact, 
                         Tendangnhap, Ngayphatsinh, Ngaybatdau, Ngayketthuc)
VALUES        (@Machuongtrinh,@Madonvi,@Loaiapdung,@Maloaichuongtrinh,@Tenchuongtrinh,@Trangthai,@Trangthaikm,@Giobatdau,@Gioketthuc,@Phutbatdau,@Phutkethuc,@Mact,@Tendangnhap,@Ngayphatsinh,@Ngaybatdau,@Ngayketthuc)";
            this._commandCollection[8].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Loaiapdung", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Loaiapdung", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Maloaichuongtrinh", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Maloaichuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenchuongtrinh", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenchuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthai", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthai", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikm", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giobatdau", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Giobatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Gioketthuc", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Gioketthuc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Phutbatdau", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Phutbatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Phutkethuc", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Phutkethuc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mact", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Mact", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhap", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhap", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngaybatdau", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaybatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[8].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayketthuc", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayketthuc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[9].Connection = this.Connection;
            this._commandCollection[9].CommandText = "UPDATE       Khuyenmai\r\nSET                Diengiaikm = @Diengiaikm\r\nWHERE       " +
                " (Machuongtrinh = @Machuongtrinh) AND (Madonvi = @Madonvi)";
            this._commandCollection[9].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Diengiaikm", global::System.Data.SqlDbType.NVarChar, 1000, global::System.Data.ParameterDirection.Input, 0, 0, "Diengiaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[9].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[10] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[10].Connection = this.Connection;
            this._commandCollection[10].CommandText = @"UPDATE       Khuyenmai
SET                Loaiapdung = @Loaiapdung, Maloaichuongtrinh = @Maloaichuongtrinh, Tenchuongtrinh = @Tenchuongtrinh, Trangthai = @Trangthai, Trangthaikm = @Trangthaikm, 
                         Giobatdau = @Giobatdau, Gioketthuc = @Gioketthuc, Phutbatdau = @Phutbatdau, Phutkethuc = @Phutkethuc, Ngaytao = @Ngaytao, Mact = @Mact, 
                         Tendangnhapsua = @Tendangnhapsua, Ngayphatsinh = @Ngayphatsinh, Ngaybatdau = @Ngaybatdau, Ngayketthuc = @Ngayketthuc
WHERE        (Machuongtrinh = @Machuongtrinh) AND (Madonvi = @Madonvi)";
            this._commandCollection[10].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Loaiapdung", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Loaiapdung", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Maloaichuongtrinh", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Maloaichuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tenchuongtrinh", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Tenchuongtrinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthai", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthai", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikm", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Giobatdau", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Giobatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Gioketthuc", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Gioketthuc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Phutbatdau", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Phutbatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Phutkethuc", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Phutkethuc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngaytao", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaytao", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Mact", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Mact", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tendangnhapsua", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Tendangnhapsua", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayphatsinh", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayphatsinh", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngaybatdau", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngaybatdau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ngayketthuc", global::System.Data.SqlDbType.DateTime, 8, global::System.Data.ParameterDirection.Input, 0, 0, "Ngayketthuc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[10].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[11] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[11].Connection = this.Connection;
            this._commandCollection[11].CommandText = "UPDATE       Khuyenmai\r\nSET                Trangthaikm = @Trangthaikm\r\nWHERE     " +
                "   (Machuongtrinh = @Machuongtrinh) AND (Madonvi = @Madonvi)";
            this._commandCollection[11].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Trangthaikm", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Trangthaikm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Machuongtrinh", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Machuongtrinh", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[11].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
        }
	}
}