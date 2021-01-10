namespace WEB2020.Data.Collection
{
    public class GiaodichcttaikhoanCollection
    {
        public GiaodichcttaikhoanCollection() { }
        public GiaodichcttaikhoanCollection(string _CONNECT_STR)
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
            this._commandCollection[0].CommandText = @"SELECT Magiaodichpk, Madonvi, Masieuthi, Makhohang, Matkno, Matkco, Matknhapkhauno, Matknhapkhauco, Matkthuedacbietno, Matkthuedacbietco, Matkthuegtgtno, Matkthuegtgtco, Matkchietkhauno, Matkchietkhauco, Matkgiamgiano, Matkgiamgiaco, Matklephino, Matklephico, Matkchiphino, Matkchiphico, Matkchiphikhacno, Matkchiphikhacco, Matkkhuyenmaino, Matkkhuyenmaico, Matkthuekhautruno, Matkthuekhautruco, Matkbanamno, Matkbanamco, Matkchietkhausaubanhangno, Matkchietkhausaubanhangco, Matkgiavon, Matkvtu, Sort FROM Giaodichcttaikhoan";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "DELETE FROM [dbo].[Giaodichcttaikhoan] WHERE [Magiaodichpk] = @Magiaodichpk AND [" +
                "Madonvi] = @Madonvi";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = @"SELECT        Magiaodichpk, Madonvi, Masieuthi, Makhohang, Matkno, Matkco, Matknhapkhauno, Matknhapkhauco, Matkthuedacbietno, Matkthuedacbietco, Matkthuegtgtno, Matkthuegtgtco, Matkchietkhauno, Matkchietkhauco, 
                         Matkgiamgiano, Matkgiamgiaco, Matklephino, Matklephico, Matkchiphino, Matkchiphico, Matkchiphikhacno, Matkchiphikhacco, Matkkhuyenmaino, Matkkhuyenmaico, Matkthuekhautruno, Matkthuekhautruco, 
                         Matkbanamno, Matkbanamco, Matkchietkhausaubanhangno, Matkchietkhausaubanhangco, Matkgiavon, Matkvtu, Sort
FROM            Giaodichcttaikhoan
WHERE        (Magiaodichpk = @Magiaodichpk) AND (Madonvi = @Madonvi)";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = @"INSERT INTO [Giaodichcttaikhoan] ([Magiaodichpk], [Madonvi], [Masieuthi], [Makhohang], [Matkno], [Matkco], [Matknhapkhauno], [Matknhapkhauco], [Matkthuedacbietno], [Matkthuedacbietco], [Matkthuegtgtno], [Matkthuegtgtco], [Matkchietkhauno], [Matkchietkhauco], [Matkgiamgiano], [Matkgiamgiaco], [Matklephino], [Matklephico], [Matkchiphino], [Matkchiphico], [Matkchiphikhacno], [Matkchiphikhacco], [Matkkhuyenmaino], [Matkkhuyenmaico], [Matkthuekhautruno], [Matkthuekhautruco], [Matkbanamno], [Matkbanamco], [Matkchietkhausaubanhangno], [Matkchietkhausaubanhangco], [Matkgiavon], [Matkvtu], [Sort]) VALUES (@Magiaodichpk, @Madonvi, @Masieuthi, @Makhohang, @Matkno, @Matkco, @Matknhapkhauno, @Matknhapkhauco, @Matkthuedacbietno, @Matkthuedacbietco, @Matkthuegtgtno, @Matkthuegtgtco, @Matkchietkhauno, @Matkchietkhauco, @Matkgiamgiano, @Matkgiamgiaco, @Matklephino, @Matklephico, @Matkchiphino, @Matkchiphico, @Matkchiphikhacno, @Matkchiphikhacco, @Matkkhuyenmaino, @Matkkhuyenmaico, @Matkthuekhautruno, @Matkthuekhautruco, @Matkbanamno, @Matkbanamco, @Matkchietkhausaubanhangno, @Matkchietkhausaubanhangco, @Matkgiavon, @Matkvtu, @Sort)";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masieuthi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masieuthi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhohang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhohang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matknhapkhauno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matknhapkhauno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matknhapkhauco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matknhapkhauco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkthuedacbietno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkthuedacbietno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkthuedacbietco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkthuedacbietco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkthuegtgtno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkthuegtgtno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkthuegtgtco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkthuegtgtco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchietkhauno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchietkhauno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchietkhauco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchietkhauco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkgiamgiano", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkgiamgiano", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkgiamgiaco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkgiamgiaco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matklephino", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matklephino", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matklephico", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matklephico", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchiphino", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchiphino", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchiphico", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchiphico", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchiphikhacno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchiphikhacno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchiphikhacco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchiphikhacco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkkhuyenmaino", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkkhuyenmaino", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkkhuyenmaico", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkkhuyenmaico", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkthuekhautruno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkthuekhautruno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkthuekhautruco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkthuekhautruco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkbanamno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkbanamno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkbanamco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkbanamco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchietkhausaubanhangno", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchietkhausaubanhangno", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkchietkhausaubanhangco", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkchietkhausaubanhangco", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkgiavon", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkgiavon", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matkvtu", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matkvtu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Sort", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Sort", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "UPDATE       Giaodichcttaikhoan\r\nSET                Makhohang = @Makhohang\r\nWHERE" +
                "        (Magiaodichpk = @Magiaodichpk) AND (Madonvi = @Madonvi)";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Makhohang", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Makhohang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Magiaodichpk", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Magiaodichpk", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
        }
    }
}