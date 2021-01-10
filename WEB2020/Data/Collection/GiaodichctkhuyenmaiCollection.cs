namespace WEB2020.Data.Collection
{
    public class GiaodichctkhuyenmaiCollection
    {
        public GiaodichctkhuyenmaiCollection() { }
        public GiaodichctkhuyenmaiCollection(string _CONNECT_STR)
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
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[5];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT        Magiaodichpk, Madonvi, Soluongkm, Tienkm, Chuongtrinhkm, ID, Kieukm" +
                ", Masieuthi\r\nFROM            Giaodichctkhuyenmai";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "DELETE FROM Giaodichctkhuyenmai\r\nWHERE        (Magiaodichpk = @Magiaodichpk) AND " +
                "(Madonvi = @Madonvi)";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "SELECT Chuongtrinhkm, ID, Kieukm, Madonvi, Magiaodichpk, Masieuthi, Soluongkm, Ti" +
                "enkm FROM Giaodichctkhuyenmai WHERE (Magiaodichpk = @Magiaodichpk) AND (Madonvi " +
                "= @Madonvi) AND (Chuongtrinhkm = @Chuongtrinhkm)";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Chuongtrinhkm", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Chuongtrinhkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "INSERT INTO Giaodichctkhuyenmai\r\n                         (Magiaodichpk, Madonvi," +
                " Soluongkm, Tienkm, Chuongtrinhkm, ID, Kieukm, Masieuthi)\r\nVALUES        (@Magia" +
                "odichpk,@Madonvi,@Soluongkm,@Tienkm,@Chuongtrinhkm,@ID,@Kieukm,@Masieuthi)";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Soluongkm", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Soluongkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tienkm", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tienkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Chuongtrinhkm", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Chuongtrinhkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@ID", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "ID", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieukm", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Kieukm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "UPDATE       Giaodichctkhuyenmai\r\nSET                Soluongkm = @Soluongkm, Tien" +
                "km = @Tienkm\r\nWHERE        (Magiaodichpk = @Magiaodichpk) AND (Madonvi = @Madonv" +
                "i) AND (Chuongtrinhkm = @Chuongtrinhkm)";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Soluongkm", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Soluongkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Tienkm", global::System.Data.SqlDbType.Decimal, 13, global::System.Data.ParameterDirection.Input, 20, 8, "Tienkm", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Chuongtrinhkm", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Chuongtrinhkm", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
        }
    }
}