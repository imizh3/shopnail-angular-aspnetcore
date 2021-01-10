using System.Data;

namespace WEB2020.Data.Collection
{
    public class CapmatudongCollection
    {
        public CapmatudongCollection() { }
        public CapmatudongCollection(string _CONNECT_STR)
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
        private void InitCommandCollection()
        {
            this._commandCollection = new global::System.Data.SqlClient.SqlCommand[6];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[0].Connection = this.Connection;
            this._commandCollection[0].CommandText = "SELECT        Sotutang, Madonvi, Chucnang, Ten, Sokytu, IsAuto, Kieututang, Matru" +
                "oc, Masau, Loai\r\nFROM            Capmatudong";
            this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[1].Connection = this.Connection;
            this._commandCollection[1].CommandText = "SELECT        Sotutang, Madonvi, Chucnang, Ten, Sokytu, IsAuto, Kieututang, Matru" +
                "oc, Masau, Loai\r\nFROM            Capmatudong\r\nWHERE        (Madonvi = @Madonvi) " +
                "AND (Chucnang = @Chucnang) AND (Loai = @Loai)";
            this._commandCollection[1].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Chucnang", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Chucnang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Loai", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Loai", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[2].Connection = this.Connection;
            this._commandCollection[2].CommandText = "SELECT        Sotutang, Madonvi, Chucnang, Ten, Sokytu, IsAuto, Kieututang, Matru" +
                "oc, Masau, Loai\r\nFROM            Capmatudong\r\nWHERE        (Madonvi = @Madonvi)";
            this._commandCollection[2].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[2].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[3].Connection = this.Connection;
            this._commandCollection[3].CommandText = "INSERT INTO [Capmatudong] ([Sotutang], [Madonvi], [Chucnang], [Ten], [Sokytu], [I" +
                "sAuto], [Kieututang], [Matruoc], [Masau], [Loai]) VALUES (@Sotutang, @Madonvi, @" +
                "Chucnang, @Ten, @Sokytu, @IsAuto, @Kieututang, @Matruoc, @Masau, @Loai);";
            this._commandCollection[3].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Sotutang", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Sotutang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Chucnang", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Chucnang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Ten", global::System.Data.SqlDbType.NVarChar, 250, global::System.Data.ParameterDirection.Input, 0, 0, "Ten", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Sokytu", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Sokytu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@IsAuto", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "IsAuto", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Kieututang", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Kieututang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matruoc", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matruoc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masau", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Loai", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Loai", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[4].Connection = this.Connection;
            this._commandCollection[4].CommandText = "UPDATE       Capmatudong\r\nSET                Sotutang = @Sotutang, Sokytu = @Soky" +
                "tu, Matruoc = @Matruoc, Masau = @Masau\r\nWHERE        (Madonvi = @Original_Madonv" +
                "i) AND (Chucnang = @Original_Chucnang) AND (Loai = @Original_Loai)";
            this._commandCollection[4].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Sotutang", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Sotutang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Sokytu", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Sokytu", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Matruoc", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Matruoc", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Masau", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Masau", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Chucnang", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Chucnang", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[4].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Loai", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Loai", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            this._commandCollection[5].Connection = this.Connection;
            this._commandCollection[5].CommandText = "UPDATE       Capmatudong\r\nSET                Sotutang = @Sotutang\r\nWHERE        (" +
                "Madonvi = @Original_Madonvi) AND (Chucnang = @Original_Chucnang) AND (Loai = @Or" +
                "iginal_Loai)";
            this._commandCollection[5].CommandType = global::System.Data.CommandType.Text;
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Sotutang", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 0, 0, "Sotutang", global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Madonvi", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Madonvi", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Chucnang", global::System.Data.SqlDbType.VarChar, 50, global::System.Data.ParameterDirection.Input, 0, 0, "Chucnang", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
            this._commandCollection[5].Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@Original_Loai", global::System.Data.SqlDbType.VarChar, 20, global::System.Data.ParameterDirection.Input, 0, 0, "Loai", global::System.Data.DataRowVersion.Original, false, null, "", "", ""));
        }
    }
}