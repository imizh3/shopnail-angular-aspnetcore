using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using WEB2020.Data.Collection;
using System.Data.SqlClient;

namespace WEB2020.Data
{
    public class DB
    {
        private static string CONN_STRING = "";

        public static void Set_Connect(string Key_Config)
        {
            CONN_STRING = Key_Config;
        }

        public static string Get_Connect()
        {
            return CONN_STRING;
        }

        private static DataTable ExecuteSPReader(string StoredProcedure, string tableName, params DictionaryEntry[] ParamName)
        {

            SqlConnection Connection = new SqlConnection(CONN_STRING);
            SqlCommand comm = new SqlCommand(StoredProcedure);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = 0;
            foreach (DictionaryEntry paramV in ParamName)
            {
                comm.Parameters.AddWithValue(paramV.Key.ToString(), paramV.Value);
            }
            SqlDataAdapter resultDA = new SqlDataAdapter();
            resultDA.SelectCommand = comm;
            resultDA.SelectCommand.Connection = Connection;
            Connection.Open();
            DataSet resultDS = new DataSet();
            try
            {
                resultDA.Fill(resultDS, tableName);
            }
            catch { return null; }
            finally
            {
                Connection.Close();
            }
            return resultDS.Tables[0];
        }

        private static bool ExecuteSPReaderReturnBool(string StoredProcedure, params DictionaryEntry[] ParamName)
        {
            bool isok = false;
            SqlConnection Connection = new SqlConnection(CONN_STRING);
            SqlCommand comm = new SqlCommand(StoredProcedure);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = 0;
            foreach (DictionaryEntry paramV in ParamName)
            {
                comm.Parameters.AddWithValue(paramV.Key.ToString(), paramV.Value);
            }
            SqlDataAdapter resultDA = new SqlDataAdapter();
            resultDA.SelectCommand = comm;
            resultDA.SelectCommand.Connection = Connection;
            Connection.Open();
            try
            {
                comm.ExecuteNonQuery();
                isok = true;
            }
            catch
            {
                isok = false;
            }
            finally
            {
                Connection.Close();
            }
            return isok;
        }

        private static object ExecuteSPReaderReturnIntValue(string StoredProcedure, string ReturnParam, params DictionaryEntry[] ParamName)
        {
            SqlConnection Connection = new SqlConnection(CONN_STRING);
            SqlCommand comm = new SqlCommand(StoredProcedure);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = 0;
            foreach (DictionaryEntry paramV in ParamName)
            {
                comm.Parameters.AddWithValue(paramV.Key.ToString(), paramV.Value);
            }
            SqlParameter RuturnValue = new SqlParameter(ReturnParam, SqlDbType.Int);
            RuturnValue.Direction = ParameterDirection.Output;
            comm.Parameters.Add(RuturnValue);

            SqlDataAdapter resultDA = new SqlDataAdapter();
            resultDA.SelectCommand = comm;
            resultDA.SelectCommand.Connection = Connection;
            Connection.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            return RuturnValue.Value;
        }

        private static object ExecuteSPReaderReturnStringValue(string StoredProcedure, string ReturnParam, params DictionaryEntry[] ParamName)
        {
            SqlConnection Connection = new SqlConnection(CONN_STRING);
            SqlCommand comm = new SqlCommand(StoredProcedure);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandTimeout = 0;
            foreach (DictionaryEntry paramV in ParamName)
            {
                comm.Parameters.AddWithValue(paramV.Key.ToString(), paramV.Value);
            }
            SqlParameter RuturnValue = new SqlParameter(ReturnParam, SqlDbType.NVarChar);
            RuturnValue.Direction = ParameterDirection.Output;
            comm.Parameters.Add(RuturnValue);

            SqlDataAdapter resultDA = new SqlDataAdapter();
            resultDA.SelectCommand = comm;
            resultDA.SelectCommand.Connection = Connection;
            Connection.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Connection.Close();
            }
            return RuturnValue.Value;
        }

        public static Boolean ExecuteQuery(string Query)
        {

            SqlConnection con = new SqlConnection(CONN_STRING);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 0;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = Query;
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch { con.Close(); return false; }

        }

        #region Khuyenmaict
        public static DataTable KMCT_GetDataByMadonviAndMachuongtrinhAndNgay(string madonvi, global::System.Nullable<int> trangthai, global::System.Nullable<global::System.DateTime> ngayphatsinh, global::System.Nullable<int> apdungcho)
        {
            KhuyenmaictCollection collection = new KhuyenmaictCollection(CONN_STRING);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = collection.CommandCollection[3];
            Adapter.SelectCommand.Connection = collection.Connection;
            collection.Connection.Open();
            if ((madonvi == null))
            {
                throw new global::System.ArgumentNullException("madonvi");
            }
            else
            {
                Adapter.SelectCommand.Parameters[0].Value = ((string)(madonvi));
            }
            if ((trangthai.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[1].Value = ((int)(trangthai.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((ngayphatsinh.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[2].Value = ((System.DateTime)(ngayphatsinh.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((apdungcho.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[3].Value = ((int)(apdungcho.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            DataSet dataTable = new DataSet();
            try
            {
                Adapter.Fill(dataTable, "DATA");
            }
            catch { return null; }
            finally
            {
                collection.Connection.Close();
            }
            return dataTable.Tables[0];
        }
        #endregion

        #region Khuyenmai
        public static DataTable KM_GetDataByMadonviAndNgayBatdauAndNgayKetthuc(string Madonvi, global::System.Nullable<int> Trangthaikm, global::System.Nullable<global::System.DateTime> Ngayphatsinh, global::System.Nullable<int> Trangthai)
        {
            KhuyenmaiCollection collection = new KhuyenmaiCollection(CONN_STRING);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = collection.CommandCollection[2];
            Adapter.SelectCommand.Connection = collection.Connection;
            collection.Connection.Open();
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                Adapter.SelectCommand.Parameters[0].Value = ((string)(Madonvi));
            }
            if ((Trangthaikm.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[1].Value = ((int)(Trangthaikm.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            if ((Ngayphatsinh.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[2].Value = ((System.DateTime)(Ngayphatsinh.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Trangthai.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[3].Value = ((int)(Trangthai.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[3].Value = global::System.DBNull.Value;
            }
            DataSet dataTable = new DataSet();
            try
            {
                Adapter.Fill(dataTable, "DATA");
            }
            catch { return null; }
            finally
            {
                collection.Connection.Close();
            }
            return dataTable.Tables[0];
        }

        #endregion

        #region Mathang
        public static DataTable MH_GetDataByMadonvi(string Madonvi, global::System.Nullable<int> Trangthaikd)
        {
            MathangCollection collection = new MathangCollection(CONN_STRING);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = collection.CommandCollection[3];
            Adapter.SelectCommand.Connection = collection.Connection;
            collection.Connection.Open();
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                Adapter.SelectCommand.Parameters[0].Value = ((string)(Madonvi));
            }
            if ((Trangthaikd.HasValue == true))
            {
                Adapter.SelectCommand.Parameters[1].Value = ((int)(Trangthaikd.Value));
            }
            else
            {
                Adapter.SelectCommand.Parameters[1].Value = global::System.DBNull.Value;
            }
            DataSet dataTable = new DataSet();
            try
            {
                Adapter.Fill(dataTable, "DATA");
            }
            catch { return null; }
            finally
            {
                collection.Connection.Close();
            }
            return dataTable.Tables[0];
        }

        public static DataTable MH_GetDataByMasieuthiMadonvi(string Masieuthi, string Madonvi)
        {
            MathangCollection collection = new MathangCollection(CONN_STRING);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = collection.CommandCollection[7];
            Adapter.SelectCommand.Connection = collection.Connection;
            collection.Connection.Open();
            if ((Masieuthi == null))
            {
                throw new global::System.ArgumentNullException("Masieuthi");
            }
            else
            {
                Adapter.SelectCommand.Parameters[0].Value = ((string)(Masieuthi));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                Adapter.SelectCommand.Parameters[1].Value = ((string)(Madonvi));
            }
            DataSet dataTable = new DataSet();
            try
            {
                Adapter.Fill(dataTable, "DATA");
            }
            catch { return null; }
            finally
            {
                collection.Connection.Close();
            }
            return dataTable.Tables[0];
        }

        #endregion

        #region Giaodichcttaikhoan

        public static int DeleteCtTaikhoanByMadonviAndMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            GiaodichcttaikhoanCollection collection = new GiaodichcttaikhoanCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = collection.CommandCollection[1];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }

        public static int InsertCtTaikhoan(
                        string Magiaodichpk,
                        string Madonvi,
                        string Masieuthi,
                        string Makhohang,
                        string Matkno,
                        string Matkco,
                        string Matknhapkhauno,
                        string Matknhapkhauco,
                        string Matkthuedacbietno,
                        string Matkthuedacbietco,
                        string Matkthuegtgtno,
                        string Matkthuegtgtco,
                        string Matkchietkhauno,
                        string Matkchietkhauco,
                        string Matkgiamgiano,
                        string Matkgiamgiaco,
                        string Matklephino,
                        string Matklephico,
                        string Matkchiphino,
                        string Matkchiphico,
                        string Matkchiphikhacno,
                        string Matkchiphikhacco,
                        string Matkkhuyenmaino,
                        string Matkkhuyenmaico,
                        string Matkthuekhautruno,
                        string Matkthuekhautruco,
                        string Matkbanamno,
                        string Matkbanamco,
                        string Matkchietkhausaubanhangno,
                        string Matkchietkhausaubanhangco,
                        string Matkgiavon,
                        string Matkvtu,
                        global::System.Nullable<int> Sort)
        {
            GiaodichcttaikhoanCollection collection = new GiaodichcttaikhoanCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = collection.CommandCollection[3];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Masieuthi == null))
            {
                throw new global::System.ArgumentNullException("Masieuthi");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Masieuthi));
            }
            if ((Makhohang == null))
            {
                throw new global::System.ArgumentNullException("Makhohang");
            }
            else
            {
                command.Parameters[3].Value = ((string)(Makhohang));
            }
            if ((Matkno == null))
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[4].Value = ((string)(Matkno));
            }
            if ((Matkco == null))
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[5].Value = ((string)(Matkco));
            }
            if ((Matknhapkhauno == null))
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[6].Value = ((string)(Matknhapkhauno));
            }
            if ((Matknhapkhauco == null))
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[7].Value = ((string)(Matknhapkhauco));
            }
            if ((Matkthuedacbietno == null))
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[8].Value = ((string)(Matkthuedacbietno));
            }
            if ((Matkthuedacbietco == null))
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[9].Value = ((string)(Matkthuedacbietco));
            }
            if ((Matkthuegtgtno == null))
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[10].Value = ((string)(Matkthuegtgtno));
            }
            if ((Matkthuegtgtco == null))
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[11].Value = ((string)(Matkthuegtgtco));
            }
            if ((Matkchietkhauno == null))
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[12].Value = ((string)(Matkchietkhauno));
            }
            if ((Matkchietkhauco == null))
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[13].Value = ((string)(Matkchietkhauco));
            }
            if ((Matkgiamgiano == null))
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[14].Value = ((string)(Matkgiamgiano));
            }
            if ((Matkgiamgiaco == null))
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[15].Value = ((string)(Matkgiamgiaco));
            }
            if ((Matklephino == null))
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[16].Value = ((string)(Matklephino));
            }
            if ((Matklephico == null))
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[17].Value = ((string)(Matklephico));
            }
            if ((Matkchiphino == null))
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[18].Value = ((string)(Matkchiphino));
            }
            if ((Matkchiphico == null))
            {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[19].Value = ((string)(Matkchiphico));
            }
            if ((Matkchiphikhacno == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Matkchiphikhacno));
            }
            if ((Matkchiphikhacco == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Matkchiphikhacco));
            }
            if ((Matkkhuyenmaino == null))
            {
                command.Parameters[22].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[22].Value = ((string)(Matkkhuyenmaino));
            }
            if ((Matkkhuyenmaico == null))
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[23].Value = ((string)(Matkkhuyenmaico));
            }
            if ((Matkthuekhautruno == null))
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[24].Value = ((string)(Matkthuekhautruno));
            }
            if ((Matkthuekhautruco == null))
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[25].Value = ((string)(Matkthuekhautruco));
            }
            if ((Matkbanamno == null))
            {
                command.Parameters[26].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[26].Value = ((string)(Matkbanamno));
            }
            if ((Matkbanamco == null))
            {
                command.Parameters[27].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[27].Value = ((string)(Matkbanamco));
            }
            if ((Matkchietkhausaubanhangno == null))
            {
                command.Parameters[28].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[28].Value = ((string)(Matkchietkhausaubanhangno));
            }
            if ((Matkchietkhausaubanhangco == null))
            {
                command.Parameters[29].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[29].Value = ((string)(Matkchietkhausaubanhangco));
            }
            if ((Matkgiavon == null))
            {
                command.Parameters[30].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[30].Value = ((string)(Matkgiavon));
            }
            if ((Matkvtu == null))
            {
                command.Parameters[31].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[31].Value = ((string)(Matkvtu));
            }
            if ((Sort.HasValue == true))
            {
                command.Parameters[32].Value = ((int)(Sort.Value));
            }
            else
            {
                command.Parameters[32].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        #endregion

        #region Giaodichctkhuyenmai
        public static int DeleteGiaodichctkm(string Magiaodichpk, string Madonvi)
        {
            GiaodichctkhuyenmaiCollection collection = new GiaodichctkhuyenmaiCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = collection.CommandCollection[1];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }

        public static int InsertGiaodichctkm(string Magiaodichpk, string Madonvi, global::System.Nullable<decimal> Soluongkm, global::System.Nullable<decimal> Tienkm, string Chuongtrinhkm, string ID, global::System.Nullable<int> Kieukm, string Masieuthi)
        {
            GiaodichctkhuyenmaiCollection collection = new GiaodichctkhuyenmaiCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = collection.CommandCollection[3];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Soluongkm.HasValue == true))
            {
                command.Parameters[2].Value = ((decimal)(Soluongkm.Value));
            }
            else
            {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            if ((Tienkm.HasValue == true))
            {
                command.Parameters[3].Value = ((decimal)(Tienkm.Value));
            }
            else
            {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((Chuongtrinhkm == null))
            {
                throw new global::System.ArgumentNullException("Chuongtrinhkm");
            }
            else
            {
                command.Parameters[4].Value = ((string)(Chuongtrinhkm));
            }
            if ((ID == null))
            {
                throw new global::System.ArgumentNullException("ID");
            }
            else
            {
                command.Parameters[5].Value = ((string)(ID));
            }
            if ((Kieukm.HasValue == true))
            {
                command.Parameters[6].Value = ((int)(Kieukm.Value));
            }
            else
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Masieuthi == null))
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[7].Value = ((string)(Masieuthi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }

        #endregion

        #region Giaodichct
        public static int DeleteByMadonviAndMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            GiaodichctCollection giaodichctCollection = new GiaodichctCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichctCollection.CommandCollection[1];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int InsertQueryGiaodichctBanbuon(
                    string Magiaodichpk,
                    string Madonvi,
                    string Masieuthi,
                    string Manganh,
                    string Makhachhang,
                    string Manhomhang,
                    string Makhohang,
                    string Mabohang,
                    global::System.Nullable<decimal> Soluong,
                    global::System.Nullable<decimal> Dongiacovat,
                    global::System.Nullable<decimal> Dongiachuavat,
                    global::System.Nullable<decimal> Tienhang,
                    global::System.Nullable<decimal> Tienvat,
                    global::System.Nullable<decimal> Thanhtien,
                    global::System.Nullable<decimal> Tyleck,
                    global::System.Nullable<decimal> Tienck,
                    global::System.Nullable<int> Sort,
                    global::System.Nullable<decimal> Giavon,
                    global::System.Nullable<decimal> Doanhthu,
                    string Makhodieuchuyen,
                    string Mavat,
                    string Ghichu,
                    global::System.Nullable<decimal> Giabanlecovat,
                    global::System.Nullable<decimal> Giabanbuoncovat,
                    global::System.Nullable<decimal> Giabanlechuavat,
                    global::System.Nullable<decimal> Giabanbuonchuavat,
                    global::System.Nullable<decimal> Tylelaibuon,
                    global::System.Nullable<decimal> Tylelaile,
                    global::System.Nullable<decimal> Giathungchuavat,
                    string Mavuviec,
                    string Mangoaite,
                    global::System.Nullable<decimal> Tygia,
                    string Magiaodichphu,
                    string Machuongtrinhkm,
                    global::System.Nullable<decimal> Tylecktrendon,
                    global::System.Nullable<decimal> Tiencktrendon,
                    global::System.Nullable<decimal> Tiencktrathuong,
                    string Madoituongtaphop,
                    string Mamau)
        {
            GiaodichctCollection collection = new GiaodichctCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = collection.CommandCollection[13];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Masieuthi == null))
            {
                throw new global::System.ArgumentNullException("Masieuthi");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Masieuthi));
            }
            if ((Manganh == null))
            {
                throw new global::System.ArgumentNullException("Manganh");
            }
            else
            {
                command.Parameters[3].Value = ((string)(Manganh));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[4].Value = ((string)(Makhachhang));
            }
            if ((Manhomhang == null))
            {
                throw new global::System.ArgumentNullException("Manhomhang");
            }
            else
            {
                command.Parameters[5].Value = ((string)(Manhomhang));
            }
            if ((Makhohang == null))
            {
                throw new global::System.ArgumentNullException("Makhohang");
            }
            else
            {
                command.Parameters[6].Value = ((string)(Makhohang));
            }
            if ((Mabohang == null))
            {
                throw new global::System.ArgumentNullException("Mabohang");
            }
            else
            {
                command.Parameters[7].Value = ((string)(Mabohang));
            }
            if ((Soluong.HasValue == true))
            {
                command.Parameters[8].Value = ((decimal)(Soluong.Value));
            }
            else
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Dongiacovat.HasValue == true))
            {
                command.Parameters[9].Value = ((decimal)(Dongiacovat.Value));
            }
            else
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Dongiachuavat.HasValue == true))
            {
                command.Parameters[10].Value = ((decimal)(Dongiachuavat.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Tienhang.HasValue == true))
            {
                command.Parameters[11].Value = ((decimal)(Tienhang.Value));
            }
            else
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Tienvat.HasValue == true))
            {
                command.Parameters[12].Value = ((decimal)(Tienvat.Value));
            }
            else
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Thanhtien.HasValue == true))
            {
                command.Parameters[13].Value = ((decimal)(Thanhtien.Value));
            }
            else
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((Tyleck.HasValue == true))
            {
                command.Parameters[14].Value = ((decimal)(Tyleck.Value));
            }
            else
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Tienck.HasValue == true))
            {
                command.Parameters[15].Value = ((decimal)(Tienck.Value));
            }
            else
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Sort.HasValue == true))
            {
                command.Parameters[16].Value = ((int)(Sort.Value));
            }
            else
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Giavon.HasValue == true))
            {
                command.Parameters[17].Value = ((decimal)(Giavon.Value));
            }
            else
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Doanhthu.HasValue == true))
            {
                command.Parameters[18].Value = ((decimal)(Doanhthu.Value));
            }
            else
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Makhodieuchuyen == null))
            {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[19].Value = ((string)(Makhodieuchuyen));
            }
            if ((Mavat == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Mavat));
            }
            if ((Ghichu == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Ghichu));
            }
            if ((Giabanlecovat.HasValue == true))
            {
                command.Parameters[22].Value = ((decimal)(Giabanlecovat.Value));
            }
            else
            {
                command.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuoncovat.HasValue == true))
            {
                command.Parameters[23].Value = ((decimal)(Giabanbuoncovat.Value));
            }
            else
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            if ((Giabanlechuavat.HasValue == true))
            {
                command.Parameters[24].Value = ((decimal)(Giabanlechuavat.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuonchuavat.HasValue == true))
            {
                command.Parameters[25].Value = ((decimal)(Giabanbuonchuavat.Value));
            }
            else
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            if ((Tylelaibuon.HasValue == true))
            {
                command.Parameters[26].Value = ((decimal)(Tylelaibuon.Value));
            }
            else
            {
                command.Parameters[26].Value = global::System.DBNull.Value;
            }
            if ((Tylelaile.HasValue == true))
            {
                command.Parameters[27].Value = ((decimal)(Tylelaile.Value));
            }
            else
            {
                command.Parameters[27].Value = global::System.DBNull.Value;
            }
            if ((Giathungchuavat.HasValue == true))
            {
                command.Parameters[28].Value = ((decimal)(Giathungchuavat.Value));
            }
            else
            {
                command.Parameters[28].Value = global::System.DBNull.Value;
            }
            if ((Mavuviec == null))
            {
                command.Parameters[29].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[29].Value = ((string)(Mavuviec));
            }
            if ((Mangoaite == null))
            {
                command.Parameters[30].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[30].Value = ((string)(Mangoaite));
            }
            if ((Tygia.HasValue == true))
            {
                command.Parameters[31].Value = ((decimal)(Tygia.Value));
            }
            else
            {
                command.Parameters[31].Value = global::System.DBNull.Value;
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[32].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[32].Value = ((string)(Magiaodichphu));
            }
            if ((Machuongtrinhkm == null))
            {
                command.Parameters[33].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[33].Value = ((string)(Machuongtrinhkm));
            }
            if ((Tylecktrendon.HasValue == true))
            {
                command.Parameters[34].Value = ((decimal)(Tylecktrendon.Value));
            }
            else
            {
                command.Parameters[34].Value = global::System.DBNull.Value;
            }
            if ((Tiencktrendon.HasValue == true))
            {
                command.Parameters[35].Value = ((decimal)(Tiencktrendon.Value));
            }
            else
            {
                command.Parameters[35].Value = global::System.DBNull.Value;
            }
            if ((Tiencktrathuong.HasValue == true))
            {
                command.Parameters[36].Value = ((decimal)(Tiencktrathuong.Value));
            }
            else
            {
                command.Parameters[36].Value = global::System.DBNull.Value;
            }
            if ((Madoituongtaphop == null))
            {
                command.Parameters[37].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[37].Value = ((string)(Madoituongtaphop));
            }
            if ((Mamau == null))
            {
                command.Parameters[38].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[38].Value = ((string)(Mamau));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int InsertGiaodichct(
                            string Magiaodichpk,
                            string Madonvi,
                            string Masieuthi,
                            string Manganh,
                            string Makhachhang,
                            string Manhomhang,
                            string Makhohang,
                            string Mabohang,
                            global::System.Nullable<decimal> Soluong,
                            global::System.Nullable<decimal> Dongiacovat,
                            global::System.Nullable<decimal> Dongiachuavat,
                            global::System.Nullable<decimal> Tienhang,
                            global::System.Nullable<decimal> Tienvat,
                            global::System.Nullable<decimal> Thanhtien,
                            global::System.Nullable<decimal> Tyleck,
                            global::System.Nullable<decimal> Tienck,
                            global::System.Nullable<int> Sort,
                            global::System.Nullable<decimal> Giavon,
                            global::System.Nullable<decimal> Doanhthu,
                            string Makhodieuchuyen,
                            string Mavat,
                            string Ghichu,
                            global::System.Nullable<decimal> Giabanlecovat,
                            global::System.Nullable<decimal> Giabanbuoncovat,
                            global::System.Nullable<decimal> Giabanlechuavat,
                            global::System.Nullable<decimal> Giabanbuonchuavat,
                            global::System.Nullable<decimal> Tylelaibuon,
                            global::System.Nullable<decimal> Tylelaile,
                            global::System.Nullable<decimal> Giathungchuavat,
                            string Mavuviec,
                            string Mangoaite,
                            global::System.Nullable<decimal> Tygia,
                            global::System.Nullable<decimal> Tienvatnk,
                            global::System.Nullable<decimal> Tienchiphikhac,
                            global::System.Nullable<decimal> Tienchiphivc,
                            string Mavatnk,
                            string Madoituongtaphop,
                            string Magiaodichphu,
                            string Mathanhpham)
        {
            GiaodichctCollection collection = new GiaodichctCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = collection.CommandCollection[6];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Masieuthi == null))
            {
                throw new global::System.ArgumentNullException("Masieuthi");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Masieuthi));
            }
            if ((Manganh == null))
            {
                throw new global::System.ArgumentNullException("Manganh");
            }
            else
            {
                command.Parameters[3].Value = ((string)(Manganh));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[4].Value = ((string)(Makhachhang));
            }
            if ((Manhomhang == null))
            {
                throw new global::System.ArgumentNullException("Manhomhang");
            }
            else
            {
                command.Parameters[5].Value = ((string)(Manhomhang));
            }
            if ((Makhohang == null))
            {
                throw new global::System.ArgumentNullException("Makhohang");
            }
            else
            {
                command.Parameters[6].Value = ((string)(Makhohang));
            }
            if ((Mabohang == null))
            {
                throw new global::System.ArgumentNullException("Mabohang");
            }
            else
            {
                command.Parameters[7].Value = ((string)(Mabohang));
            }
            if ((Soluong.HasValue == true))
            {
                command.Parameters[8].Value = ((decimal)(Soluong.Value));
            }
            else
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Dongiacovat.HasValue == true))
            {
                command.Parameters[9].Value = ((decimal)(Dongiacovat.Value));
            }
            else
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Dongiachuavat.HasValue == true))
            {
                command.Parameters[10].Value = ((decimal)(Dongiachuavat.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Tienhang.HasValue == true))
            {
                command.Parameters[11].Value = ((decimal)(Tienhang.Value));
            }
            else
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Tienvat.HasValue == true))
            {
                command.Parameters[12].Value = ((decimal)(Tienvat.Value));
            }
            else
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Thanhtien.HasValue == true))
            {
                command.Parameters[13].Value = ((decimal)(Thanhtien.Value));
            }
            else
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((Tyleck.HasValue == true))
            {
                command.Parameters[14].Value = ((decimal)(Tyleck.Value));
            }
            else
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Tienck.HasValue == true))
            {
                command.Parameters[15].Value = ((decimal)(Tienck.Value));
            }
            else
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Sort.HasValue == true))
            {
                command.Parameters[16].Value = ((int)(Sort.Value));
            }
            else
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Giavon.HasValue == true))
            {
                command.Parameters[17].Value = ((decimal)(Giavon.Value));
            }
            else
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Doanhthu.HasValue == true))
            {
                command.Parameters[18].Value = ((decimal)(Doanhthu.Value));
            }
            else
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Makhodieuchuyen == null))
            {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[19].Value = ((string)(Makhodieuchuyen));
            }
            if ((Mavat == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Mavat));
            }
            if ((Ghichu == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Ghichu));
            }
            if ((Giabanlecovat.HasValue == true))
            {
                command.Parameters[22].Value = ((decimal)(Giabanlecovat.Value));
            }
            else
            {
                command.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuoncovat.HasValue == true))
            {
                command.Parameters[23].Value = ((decimal)(Giabanbuoncovat.Value));
            }
            else
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            if ((Giabanlechuavat.HasValue == true))
            {
                command.Parameters[24].Value = ((decimal)(Giabanlechuavat.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuonchuavat.HasValue == true))
            {
                command.Parameters[25].Value = ((decimal)(Giabanbuonchuavat.Value));
            }
            else
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            if ((Tylelaibuon.HasValue == true))
            {
                command.Parameters[26].Value = ((decimal)(Tylelaibuon.Value));
            }
            else
            {
                command.Parameters[26].Value = global::System.DBNull.Value;
            }
            if ((Tylelaile.HasValue == true))
            {
                command.Parameters[27].Value = ((decimal)(Tylelaile.Value));
            }
            else
            {
                command.Parameters[27].Value = global::System.DBNull.Value;
            }
            if ((Giathungchuavat.HasValue == true))
            {
                command.Parameters[28].Value = ((decimal)(Giathungchuavat.Value));
            }
            else
            {
                command.Parameters[28].Value = global::System.DBNull.Value;
            }
            if ((Mavuviec == null))
            {
                command.Parameters[29].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[29].Value = ((string)(Mavuviec));
            }
            if ((Mangoaite == null))
            {
                command.Parameters[30].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[30].Value = ((string)(Mangoaite));
            }
            if ((Tygia.HasValue == true))
            {
                command.Parameters[31].Value = ((decimal)(Tygia.Value));
            }
            else
            {
                command.Parameters[31].Value = global::System.DBNull.Value;
            }
            if ((Tienvatnk.HasValue == true))
            {
                command.Parameters[32].Value = ((decimal)(Tienvatnk.Value));
            }
            else
            {
                command.Parameters[32].Value = global::System.DBNull.Value;
            }
            if ((Tienchiphikhac.HasValue == true))
            {
                command.Parameters[33].Value = ((decimal)(Tienchiphikhac.Value));
            }
            else
            {
                command.Parameters[33].Value = global::System.DBNull.Value;
            }
            if ((Tienchiphivc.HasValue == true))
            {
                command.Parameters[34].Value = ((decimal)(Tienchiphivc.Value));
            }
            else
            {
                command.Parameters[34].Value = global::System.DBNull.Value;
            }
            if ((Mavatnk == null))
            {
                command.Parameters[35].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[35].Value = ((string)(Mavatnk));
            }
            if ((Madoituongtaphop == null))
            {
                command.Parameters[36].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[36].Value = ((string)(Madoituongtaphop));
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[37].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[37].Value = ((string)(Magiaodichphu));
            }
            if ((Mathanhpham == null))
            {
                command.Parameters[38].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[38].Value = ((string)(Mathanhpham));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int InsertGiaodichctBanbuonnt(
                    string Magiaodichpk,
                    string Madonvi,
                    string Masieuthi,
                    string Manganh,
                    string Makhachhang,
                    string Manhomhang,
                    string Makhohang,
                    string Mabohang,
                    global::System.Nullable<decimal> Soluong,
                    global::System.Nullable<decimal> Dongiacovat,
                    global::System.Nullable<decimal> Dongiachuavat,
                    global::System.Nullable<decimal> Tienhang,
                    global::System.Nullable<decimal> Tienvat,
                    global::System.Nullable<decimal> Thanhtien,
                    global::System.Nullable<decimal> Tyleck,
                    global::System.Nullable<decimal> Tienck,
                    global::System.Nullable<int> Sort,
                    global::System.Nullable<decimal> Giavon,
                    global::System.Nullable<decimal> Doanhthu,
                    string Makhodieuchuyen,
                    string Mavat,
                    string Ghichu,
                    global::System.Nullable<decimal> Giabanlecovat,
                    global::System.Nullable<decimal> Giabanbuoncovat,
                    global::System.Nullable<decimal> Giabanlechuavat,
                    global::System.Nullable<decimal> Giabanbuonchuavat,
                    global::System.Nullable<decimal> Tylelaibuon,
                    global::System.Nullable<decimal> Tylelaile,
                    global::System.Nullable<decimal> Giathungchuavat,
                    string Mavuviec,
                    string Mangoaite,
                    global::System.Nullable<decimal> Tygia,
                    string Magiaodichphu,
                    string Machuongtrinhkm,
                    global::System.Nullable<decimal> Tylecktrendon,
                    global::System.Nullable<decimal> Tiencktrendon,
                    global::System.Nullable<decimal> Tiencktrathuong,
                    string Madoituongtaphop,
                    global::System.Nullable<decimal> Dongiacovatnt,
                    global::System.Nullable<decimal> Dongiachuavatnt,
                    global::System.Nullable<decimal> Tienhangnt,
                    global::System.Nullable<decimal> Tienvatnt,
                    global::System.Nullable<decimal> Thanhtiennt,
                    global::System.Nullable<decimal> Tiencknt,
                    global::System.Nullable<decimal> Giavonnt,
                    global::System.Nullable<decimal> Doanhthunt,
                    global::System.Nullable<decimal> Giabanlecovatnt,
                    global::System.Nullable<decimal> Giabanbuoncovatnt,
                    global::System.Nullable<decimal> Giabanlechuavatnt,
                    global::System.Nullable<decimal> Giabanbuonchuavatnt,
                    global::System.Nullable<decimal> Giathungchuavatnt,
                    global::System.Nullable<decimal> Tiencktrendonnt,
                    global::System.Nullable<decimal> Tiencktrathuongnt)
        {
            GiaodichctCollection giaodichctCollection = new GiaodichctCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichctCollection.CommandCollection[7];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Masieuthi == null))
            {
                throw new global::System.ArgumentNullException("Masieuthi");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Masieuthi));
            }
            if ((Manganh == null))
            {
                throw new global::System.ArgumentNullException("Manganh");
            }
            else
            {
                command.Parameters[3].Value = ((string)(Manganh));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[4].Value = ((string)(Makhachhang));
            }
            if ((Manhomhang == null))
            {
                throw new global::System.ArgumentNullException("Manhomhang");
            }
            else
            {
                command.Parameters[5].Value = ((string)(Manhomhang));
            }
            if ((Makhohang == null))
            {
                throw new global::System.ArgumentNullException("Makhohang");
            }
            else
            {
                command.Parameters[6].Value = ((string)(Makhohang));
            }
            if ((Mabohang == null))
            {
                throw new global::System.ArgumentNullException("Mabohang");
            }
            else
            {
                command.Parameters[7].Value = ((string)(Mabohang));
            }
            if ((Soluong.HasValue == true))
            {
                command.Parameters[8].Value = ((decimal)(Soluong.Value));
            }
            else
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Dongiacovat.HasValue == true))
            {
                command.Parameters[9].Value = ((decimal)(Dongiacovat.Value));
            }
            else
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Dongiachuavat.HasValue == true))
            {
                command.Parameters[10].Value = ((decimal)(Dongiachuavat.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Tienhang.HasValue == true))
            {
                command.Parameters[11].Value = ((decimal)(Tienhang.Value));
            }
            else
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Tienvat.HasValue == true))
            {
                command.Parameters[12].Value = ((decimal)(Tienvat.Value));
            }
            else
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            if ((Thanhtien.HasValue == true))
            {
                command.Parameters[13].Value = ((decimal)(Thanhtien.Value));
            }
            else
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            if ((Tyleck.HasValue == true))
            {
                command.Parameters[14].Value = ((decimal)(Tyleck.Value));
            }
            else
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            if ((Tienck.HasValue == true))
            {
                command.Parameters[15].Value = ((decimal)(Tienck.Value));
            }
            else
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            if ((Sort.HasValue == true))
            {
                command.Parameters[16].Value = ((int)(Sort.Value));
            }
            else
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            if ((Giavon.HasValue == true))
            {
                command.Parameters[17].Value = ((decimal)(Giavon.Value));
            }
            else
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            if ((Doanhthu.HasValue == true))
            {
                command.Parameters[18].Value = ((decimal)(Doanhthu.Value));
            }
            else
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            if ((Makhodieuchuyen == null))
            {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[19].Value = ((string)(Makhodieuchuyen));
            }
            if ((Mavat == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Mavat));
            }
            if ((Ghichu == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Ghichu));
            }
            if ((Giabanlecovat.HasValue == true))
            {
                command.Parameters[22].Value = ((decimal)(Giabanlecovat.Value));
            }
            else
            {
                command.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuoncovat.HasValue == true))
            {
                command.Parameters[23].Value = ((decimal)(Giabanbuoncovat.Value));
            }
            else
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            if ((Giabanlechuavat.HasValue == true))
            {
                command.Parameters[24].Value = ((decimal)(Giabanlechuavat.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuonchuavat.HasValue == true))
            {
                command.Parameters[25].Value = ((decimal)(Giabanbuonchuavat.Value));
            }
            else
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            if ((Tylelaibuon.HasValue == true))
            {
                command.Parameters[26].Value = ((decimal)(Tylelaibuon.Value));
            }
            else
            {
                command.Parameters[26].Value = global::System.DBNull.Value;
            }
            if ((Tylelaile.HasValue == true))
            {
                command.Parameters[27].Value = ((decimal)(Tylelaile.Value));
            }
            else
            {
                command.Parameters[27].Value = global::System.DBNull.Value;
            }
            if ((Giathungchuavat.HasValue == true))
            {
                command.Parameters[28].Value = ((decimal)(Giathungchuavat.Value));
            }
            else
            {
                command.Parameters[28].Value = global::System.DBNull.Value;
            }
            if ((Mavuviec == null))
            {
                command.Parameters[29].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[29].Value = ((string)(Mavuviec));
            }
            if ((Mangoaite == null))
            {
                command.Parameters[30].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[30].Value = ((string)(Mangoaite));
            }
            if ((Tygia.HasValue == true))
            {
                command.Parameters[31].Value = ((decimal)(Tygia.Value));
            }
            else
            {
                command.Parameters[31].Value = global::System.DBNull.Value;
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[32].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[32].Value = ((string)(Magiaodichphu));
            }
            if ((Machuongtrinhkm == null))
            {
                command.Parameters[33].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[33].Value = ((string)(Machuongtrinhkm));
            }
            if ((Tylecktrendon.HasValue == true))
            {
                command.Parameters[34].Value = ((decimal)(Tylecktrendon.Value));
            }
            else
            {
                command.Parameters[34].Value = global::System.DBNull.Value;
            }
            if ((Tiencktrendon.HasValue == true))
            {
                command.Parameters[35].Value = ((decimal)(Tiencktrendon.Value));
            }
            else
            {
                command.Parameters[35].Value = global::System.DBNull.Value;
            }
            if ((Tiencktrathuong.HasValue == true))
            {
                command.Parameters[36].Value = ((decimal)(Tiencktrathuong.Value));
            }
            else
            {
                command.Parameters[36].Value = global::System.DBNull.Value;
            }
            if ((Madoituongtaphop == null))
            {
                command.Parameters[37].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[37].Value = ((string)(Madoituongtaphop));
            }
            if ((Dongiacovatnt.HasValue == true))
            {
                command.Parameters[38].Value = ((decimal)(Dongiacovatnt.Value));
            }
            else
            {
                command.Parameters[38].Value = global::System.DBNull.Value;
            }
            if ((Dongiachuavatnt.HasValue == true))
            {
                command.Parameters[39].Value = ((decimal)(Dongiachuavatnt.Value));
            }
            else
            {
                command.Parameters[39].Value = global::System.DBNull.Value;
            }
            if ((Tienhangnt.HasValue == true))
            {
                command.Parameters[40].Value = ((decimal)(Tienhangnt.Value));
            }
            else
            {
                command.Parameters[40].Value = global::System.DBNull.Value;
            }
            if ((Tienvatnt.HasValue == true))
            {
                command.Parameters[41].Value = ((decimal)(Tienvatnt.Value));
            }
            else
            {
                command.Parameters[41].Value = global::System.DBNull.Value;
            }
            if ((Thanhtiennt.HasValue == true))
            {
                command.Parameters[42].Value = ((decimal)(Thanhtiennt.Value));
            }
            else
            {
                command.Parameters[42].Value = global::System.DBNull.Value;
            }
            if ((Tiencknt.HasValue == true))
            {
                command.Parameters[43].Value = ((decimal)(Tiencknt.Value));
            }
            else
            {
                command.Parameters[43].Value = global::System.DBNull.Value;
            }
            if ((Giavonnt.HasValue == true))
            {
                command.Parameters[44].Value = ((decimal)(Giavonnt.Value));
            }
            else
            {
                command.Parameters[44].Value = global::System.DBNull.Value;
            }
            if ((Doanhthunt.HasValue == true))
            {
                command.Parameters[45].Value = ((decimal)(Doanhthunt.Value));
            }
            else
            {
                command.Parameters[45].Value = global::System.DBNull.Value;
            }
            if ((Giabanlecovatnt.HasValue == true))
            {
                command.Parameters[46].Value = ((decimal)(Giabanlecovatnt.Value));
            }
            else
            {
                command.Parameters[46].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuoncovatnt.HasValue == true))
            {
                command.Parameters[47].Value = ((decimal)(Giabanbuoncovatnt.Value));
            }
            else
            {
                command.Parameters[47].Value = global::System.DBNull.Value;
            }
            if ((Giabanlechuavatnt.HasValue == true))
            {
                command.Parameters[48].Value = ((decimal)(Giabanlechuavatnt.Value));
            }
            else
            {
                command.Parameters[48].Value = global::System.DBNull.Value;
            }
            if ((Giabanbuonchuavatnt.HasValue == true))
            {
                command.Parameters[49].Value = ((decimal)(Giabanbuonchuavatnt.Value));
            }
            else
            {
                command.Parameters[49].Value = global::System.DBNull.Value;
            }
            if ((Giathungchuavatnt.HasValue == true))
            {
                command.Parameters[50].Value = ((decimal)(Giathungchuavatnt.Value));
            }
            else
            {
                command.Parameters[50].Value = global::System.DBNull.Value;
            }
            if ((Tiencktrendonnt.HasValue == true))
            {
                command.Parameters[51].Value = ((decimal)(Tiencktrendonnt.Value));
            }
            else
            {
                command.Parameters[51].Value = global::System.DBNull.Value;
            }
            if ((Tiencktrathuongnt.HasValue == true))
            {
                command.Parameters[52].Value = ((decimal)(Tiencktrathuongnt.Value));
            }
            else
            {
                command.Parameters[52].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        #endregion

        #region Giaodich
        public static int DeleteGiaodich(string Magiaodichpk, string Madonvi)
        {
            GiaodichCollection giaodichCollection = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollection.CommandCollection[1];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int InsertGiaodich(
                   string Magiaodichpk,
                   string Madonvi,
                   string Maptnx,
                   string Ghichu,
                   global::System.Nullable<int> Trangthai,
                   string Sochungtugoc,
                   global::System.Nullable<global::System.DateTime> Ngaychungtugoc,
                   string Kemtheo,
                   global::System.Nullable<decimal> Tiendathanhtoan,
                   string Mahopdong,
                   global::System.Nullable<global::System.DateTime> Ngaythanhtoan,
                   global::System.Nullable<global::System.DateTime> Ngayhoadon,
                   string Sohoadon,
                   string Kyhieuhoadon,
                   string Magiaodichphu,
                   string Makhachhang,
                   string Diachigiaohang,
                   string Manhanviencongno,
                   string Manhanviendathang,
                   string Tendangnhap,
                   string Tendangnhapsua,
                   string Nguoigiaohang,
                   System.DateTime Ngayphatsinh,
                   string Maquay,
                   global::System.Nullable<int> Trangthaidonhang)
        {
            GiaodichCollection giaodichCollection = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollection.CommandCollection[12];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Maptnx == null))
            {
                throw new global::System.ArgumentNullException("Maptnx");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Maptnx));
            }
            if ((Ghichu == null))
            {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[3].Value = ((string)(Ghichu));
            }
            if ((Trangthai.HasValue == true))
            {
                command.Parameters[4].Value = ((int)(Trangthai.Value));
            }
            else
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Sochungtugoc == null))
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[5].Value = ((string)(Sochungtugoc));
            }
            if ((Ngaychungtugoc.HasValue == true))
            {
                command.Parameters[6].Value = ((System.DateTime)(Ngaychungtugoc.Value));
            }
            else
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Kemtheo == null))
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[7].Value = ((string)(Kemtheo));
            }
            if ((Tiendathanhtoan.HasValue == true))
            {
                command.Parameters[8].Value = ((decimal)(Tiendathanhtoan.Value));
            }
            else
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Mahopdong == null))
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[9].Value = ((string)(Mahopdong));
            }
            if ((Ngaythanhtoan.HasValue == true))
            {
                command.Parameters[10].Value = ((System.DateTime)(Ngaythanhtoan.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Ngayhoadon.HasValue == true))
            {
                command.Parameters[11].Value = ((System.DateTime)(Ngayhoadon.Value));
            }
            else
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Sohoadon == null))
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[12].Value = ((string)(Sohoadon));
            }
            if ((Kyhieuhoadon == null))
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[13].Value = ((string)(Kyhieuhoadon));
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[14].Value = ((string)(Magiaodichphu));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[15].Value = ((string)(Makhachhang));
            }
            if ((Diachigiaohang == null))
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[16].Value = ((string)(Diachigiaohang));
            }
            if ((Manhanviencongno == null))
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[17].Value = ((string)(Manhanviencongno));
            }
            if ((Manhanviendathang == null))
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[18].Value = ((string)(Manhanviendathang));
            }
            if ((Tendangnhap == null))
            {
                throw new global::System.ArgumentNullException("Tendangnhap");
            }
            else
            {
                command.Parameters[19].Value = ((string)(Tendangnhap));
            }
            if ((Tendangnhapsua == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Tendangnhapsua));
            }
            if ((Nguoigiaohang == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Nguoigiaohang));
            }
            command.Parameters[22].Value = ((System.DateTime)(Ngayphatsinh));
            if ((Maquay == null))
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[23].Value = ((string)(Maquay));
            }
            if ((Trangthaidonhang.HasValue == true))
            {
                command.Parameters[24].Value = ((int)(Trangthaidonhang.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int InsertGiaodichnt(
                string Magiaodichpk,
                string Madonvi,
                string Maptnx,
                string Ghichu,
                global::System.Nullable<int> Trangthai,
                string Sochungtugoc,
                global::System.Nullable<global::System.DateTime> Ngaychungtugoc,
                string Kemtheo,
                global::System.Nullable<decimal> Tiendathanhtoan,
                string Mahopdong,
                global::System.Nullable<global::System.DateTime> Ngaythanhtoan,
                global::System.Nullable<global::System.DateTime> Ngayhoadon,
                string Sohoadon,
                string Kyhieuhoadon,
                string Magiaodichphu,
                string Makhachhang,
                string Diachigiaohang,
                string Manhanviencongno,
                string Manhanviendathang,
                string Tendangnhap,
                string Tendangnhapsua,
                string Nguoigiaohang,
                System.DateTime Ngayphatsinh,
                string Maquay,
                global::System.Nullable<int> Trangthaidonhang,
                string Mangoaite,
                global::System.Nullable<decimal> Tygia,
                global::System.Nullable<int> Solaninhoadon)
        {
            GiaodichCollection giaodichCollection = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollection.CommandCollection[13];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Maptnx == null))
            {
                throw new global::System.ArgumentNullException("Maptnx");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Maptnx));
            }
            if ((Ghichu == null))
            {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[3].Value = ((string)(Ghichu));
            }
            if ((Trangthai.HasValue == true))
            {
                command.Parameters[4].Value = ((int)(Trangthai.Value));
            }
            else
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Sochungtugoc == null))
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[5].Value = ((string)(Sochungtugoc));
            }
            if ((Ngaychungtugoc.HasValue == true))
            {
                command.Parameters[6].Value = ((System.DateTime)(Ngaychungtugoc.Value));
            }
            else
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Kemtheo == null))
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[7].Value = ((string)(Kemtheo));
            }
            if ((Tiendathanhtoan.HasValue == true))
            {
                command.Parameters[8].Value = ((decimal)(Tiendathanhtoan.Value));
            }
            else
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Mahopdong == null))
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[9].Value = ((string)(Mahopdong));
            }
            if ((Ngaythanhtoan.HasValue == true))
            {
                command.Parameters[10].Value = ((System.DateTime)(Ngaythanhtoan.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Ngayhoadon.HasValue == true))
            {
                command.Parameters[11].Value = ((System.DateTime)(Ngayhoadon.Value));
            }
            else
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Sohoadon == null))
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[12].Value = ((string)(Sohoadon));
            }
            if ((Kyhieuhoadon == null))
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[13].Value = ((string)(Kyhieuhoadon));
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[14].Value = ((string)(Magiaodichphu));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[15].Value = ((string)(Makhachhang));
            }
            if ((Diachigiaohang == null))
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[16].Value = ((string)(Diachigiaohang));
            }
            if ((Manhanviencongno == null))
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[17].Value = ((string)(Manhanviencongno));
            }
            if ((Manhanviendathang == null))
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[18].Value = ((string)(Manhanviendathang));
            }
            if ((Tendangnhap == null))
            {
                throw new global::System.ArgumentNullException("Tendangnhap");
            }
            else
            {
                command.Parameters[19].Value = ((string)(Tendangnhap));
            }
            if ((Tendangnhapsua == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Tendangnhapsua));
            }
            if ((Nguoigiaohang == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Nguoigiaohang));
            }
            command.Parameters[22].Value = ((System.DateTime)(Ngayphatsinh));
            if ((Maquay == null))
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[23].Value = ((string)(Maquay));
            }
            if ((Trangthaidonhang.HasValue == true))
            {
                command.Parameters[24].Value = ((int)(Trangthaidonhang.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Mangoaite == null))
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[25].Value = ((string)(Mangoaite));
            }
            if ((Tygia.HasValue == true))
            {
                command.Parameters[26].Value = ((decimal)(Tygia.Value));
            }
            else
            {
                command.Parameters[26].Value = global::System.DBNull.Value;
            }
            if ((Solaninhoadon.HasValue == true))
            {
                command.Parameters[27].Value = ((int)(Solaninhoadon.Value));
            }
            else
            {
                command.Parameters[27].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int InsertGiaodichntThue(
                    string Magiaodichpk,
                    string Madonvi,
                    string Maptnx,
                    string Ghichu,
                    global::System.Nullable<int> Trangthai,
                    string Sochungtugoc,
                    global::System.Nullable<global::System.DateTime> Ngaychungtugoc,
                    string Kemtheo,
                    global::System.Nullable<decimal> Tiendathanhtoan,
                    string Mahopdong,
                    global::System.Nullable<global::System.DateTime> Ngaythanhtoan,
                    global::System.Nullable<global::System.DateTime> Ngayhoadon,
                    string Sohoadon,
                    string Kyhieuhoadon,
                    string Magiaodichphu,
                    string Makhachhang,
                    string Diachigiaohang,
                    string Manhanviencongno,
                    string Manhanviendathang,
                    string Tendangnhap,
                    string Tendangnhapsua,
                    string Nguoigiaohang,
                    System.DateTime Ngayphatsinh,
                    string Maquay,
                    global::System.Nullable<int> Trangthaidonhang,
                    string Mangoaite,
                    global::System.Nullable<decimal> Tygia,
                    global::System.Nullable<int> Solaninhoadon,
                    string Mausohoadon)
        {
            GiaodichCollection giaodichCollection = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollection.CommandCollection[14];
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Maptnx == null))
            {
                throw new global::System.ArgumentNullException("Maptnx");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Maptnx));
            }
            if ((Ghichu == null))
            {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[3].Value = ((string)(Ghichu));
            }
            if ((Trangthai.HasValue == true))
            {
                command.Parameters[4].Value = ((int)(Trangthai.Value));
            }
            else
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((Sochungtugoc == null))
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[5].Value = ((string)(Sochungtugoc));
            }
            if ((Ngaychungtugoc.HasValue == true))
            {
                command.Parameters[6].Value = ((System.DateTime)(Ngaychungtugoc.Value));
            }
            else
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Kemtheo == null))
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[7].Value = ((string)(Kemtheo));
            }
            if ((Tiendathanhtoan.HasValue == true))
            {
                command.Parameters[8].Value = ((decimal)(Tiendathanhtoan.Value));
            }
            else
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            if ((Mahopdong == null))
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[9].Value = ((string)(Mahopdong));
            }
            if ((Ngaythanhtoan.HasValue == true))
            {
                command.Parameters[10].Value = ((System.DateTime)(Ngaythanhtoan.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Ngayhoadon.HasValue == true))
            {
                command.Parameters[11].Value = ((System.DateTime)(Ngayhoadon.Value));
            }
            else
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            if ((Sohoadon == null))
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[12].Value = ((string)(Sohoadon));
            }
            if ((Kyhieuhoadon == null))
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[13].Value = ((string)(Kyhieuhoadon));
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[14].Value = ((string)(Magiaodichphu));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[15].Value = ((string)(Makhachhang));
            }
            if ((Diachigiaohang == null))
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[16].Value = ((string)(Diachigiaohang));
            }
            if ((Manhanviencongno == null))
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[17].Value = ((string)(Manhanviencongno));
            }
            if ((Manhanviendathang == null))
            {
                command.Parameters[18].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[18].Value = ((string)(Manhanviendathang));
            }
            if ((Tendangnhap == null))
            {
                throw new global::System.ArgumentNullException("Tendangnhap");
            }
            else
            {
                command.Parameters[19].Value = ((string)(Tendangnhap));
            }
            if ((Tendangnhapsua == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Tendangnhapsua));
            }
            if ((Nguoigiaohang == null))
            {
                command.Parameters[21].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[21].Value = ((string)(Nguoigiaohang));
            }
            command.Parameters[22].Value = ((System.DateTime)(Ngayphatsinh));
            if ((Maquay == null))
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[23].Value = ((string)(Maquay));
            }
            if ((Trangthaidonhang.HasValue == true))
            {
                command.Parameters[24].Value = ((int)(Trangthaidonhang.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Mangoaite == null))
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[25].Value = ((string)(Mangoaite));
            }
            if ((Tygia.HasValue == true))
            {
                command.Parameters[26].Value = ((decimal)(Tygia.Value));
            }
            else
            {
                command.Parameters[26].Value = global::System.DBNull.Value;
            }
            if ((Solaninhoadon.HasValue == true))
            {
                command.Parameters[27].Value = ((int)(Solaninhoadon.Value));
            }
            else
            {
                command.Parameters[27].Value = global::System.DBNull.Value;
            }
            if ((Mausohoadon == null))
            {
                command.Parameters[28].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[28].Value = ((string)(Mausohoadon));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }

        public static int UpdateGhichugiaodich(string Ghichu, string Magiaodichpk, string Madonvi)
        {
            GiaodichCollection giaodichCollection = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollection.CommandCollection[15];
            if ((Ghichu == null))
            {
                command.Parameters[0].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[0].Value = ((string)(Ghichu));
            }
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int UpdateGiaodich(
                    string Maptnx,
                    string Ghichu,
                    global::System.Nullable<int> Trangthai,
                    System.DateTime Ngaytao,
                    string Sochungtugoc,
                    global::System.Nullable<global::System.DateTime> Ngaychungtugoc,
                    string Kemtheo,
                    global::System.Nullable<decimal> Tiendathanhtoan,
                    string Mahopdong,
                    global::System.Nullable<global::System.DateTime> Ngaythanhtoan,
                    global::System.Nullable<global::System.DateTime> Ngayhoadon,
                    string Sohoadon,
                    string Kyhieuhoadon,
                    string Magiaodichphu,
                    string Makhachhang,
                    string Diachigiaohang,
                    string Manhanviencongno,
                    string Manhanviendathang,
                    string Tendangnhap,
                    string Tendangnhapsua,
                    string Nguoigiaohang,
                    System.DateTime Ngayphatsinh,
                    global::System.Nullable<int> Trangthaidonhang,
                    string Magiaodichpk,
                    string Madonvi)
        {
            GiaodichCollection giaodichCollectionch = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollectionch.CommandCollection[16];
            if ((Maptnx == null))
            {
                throw new global::System.ArgumentNullException("Maptnx");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Maptnx));
            }
            if ((Ghichu == null))
            {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[1].Value = ((string)(Ghichu));
            }
            if ((Trangthai.HasValue == true))
            {
                command.Parameters[2].Value = ((int)(Trangthai.Value));
            }
            else
            {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            command.Parameters[3].Value = ((System.DateTime)(Ngaytao));
            if ((Sochungtugoc == null))
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[4].Value = ((string)(Sochungtugoc));
            }
            if ((Ngaychungtugoc.HasValue == true))
            {
                command.Parameters[5].Value = ((System.DateTime)(Ngaychungtugoc.Value));
            }
            else
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Kemtheo == null))
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[6].Value = ((string)(Kemtheo));
            }
            if ((Tiendathanhtoan.HasValue == true))
            {
                command.Parameters[7].Value = ((decimal)(Tiendathanhtoan.Value));
            }
            else
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Mahopdong == null))
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[8].Value = ((string)(Mahopdong));
            }
            if ((Ngaythanhtoan.HasValue == true))
            {
                command.Parameters[9].Value = ((System.DateTime)(Ngaythanhtoan.Value));
            }
            else
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Ngayhoadon.HasValue == true))
            {
                command.Parameters[10].Value = ((System.DateTime)(Ngayhoadon.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Sohoadon == null))
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[11].Value = ((string)(Sohoadon));
            }
            if ((Kyhieuhoadon == null))
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[12].Value = ((string)(Kyhieuhoadon));
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[13].Value = ((string)(Magiaodichphu));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[14].Value = ((string)(Makhachhang));
            }
            if ((Diachigiaohang == null))
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[15].Value = ((string)(Diachigiaohang));
            }
            if ((Manhanviencongno == null))
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[16].Value = ((string)(Manhanviencongno));
            }
            if ((Manhanviendathang == null))
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[17].Value = ((string)(Manhanviendathang));
            }
            if ((Tendangnhap == null))
            {
                throw new global::System.ArgumentNullException("Tendangnhap");
            }
            else
            {
                command.Parameters[18].Value = ((string)(Tendangnhap));
            }
            if ((Tendangnhapsua == null))
            {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[19].Value = ((string)(Tendangnhapsua));
            }
            if ((Nguoigiaohang == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Nguoigiaohang));
            }
            command.Parameters[21].Value = ((System.DateTime)(Ngayphatsinh));
            if ((Trangthaidonhang.HasValue == true))
            {
                command.Parameters[22].Value = ((int)(Trangthaidonhang.Value));
            }
            else
            {
                command.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[23].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[24].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        public static int UpdateGiaodichnt(
                    string Maptnx,
                    string Ghichu,
                    global::System.Nullable<int> Trangthai,
                    System.DateTime Ngaytao,
                    string Sochungtugoc,
                    global::System.Nullable<global::System.DateTime> Ngaychungtugoc,
                    string Kemtheo,
                    global::System.Nullable<decimal> Tiendathanhtoan,
                    string Mahopdong,
                    global::System.Nullable<global::System.DateTime> Ngaythanhtoan,
                    global::System.Nullable<global::System.DateTime> Ngayhoadon,
                    string Sohoadon,
                    string Kyhieuhoadon,
                    string Magiaodichphu,
                    string Makhachhang,
                    string Diachigiaohang,
                    string Manhanviencongno,
                    string Manhanviendathang,
                    string Tendangnhap,
                    string Tendangnhapsua,
                    string Nguoigiaohang,
                    System.DateTime Ngayphatsinh,
                    global::System.Nullable<int> Trangthaidonhang,
                    string Mangoaite,
                    global::System.Nullable<decimal> Tygia,
                    global::System.Nullable<int> Solaninhoadon,
                    string Magiaodichpk,
                    string Madonvi)
        {
            GiaodichCollection giaodichCollectionch = new GiaodichCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = giaodichCollectionch.CommandCollection[17];
            if ((Maptnx == null))
            {
                throw new global::System.ArgumentNullException("Maptnx");
            }
            else
            {
                command.Parameters[0].Value = ((string)(Maptnx));
            }
            if ((Ghichu == null))
            {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[1].Value = ((string)(Ghichu));
            }
            if ((Trangthai.HasValue == true))
            {
                command.Parameters[2].Value = ((int)(Trangthai.Value));
            }
            else
            {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            command.Parameters[3].Value = ((System.DateTime)(Ngaytao));
            if ((Sochungtugoc == null))
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[4].Value = ((string)(Sochungtugoc));
            }
            if ((Ngaychungtugoc.HasValue == true))
            {
                command.Parameters[5].Value = ((System.DateTime)(Ngaychungtugoc.Value));
            }
            else
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Kemtheo == null))
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[6].Value = ((string)(Kemtheo));
            }
            if ((Tiendathanhtoan.HasValue == true))
            {
                command.Parameters[7].Value = ((decimal)(Tiendathanhtoan.Value));
            }
            else
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            if ((Mahopdong == null))
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[8].Value = ((string)(Mahopdong));
            }
            if ((Ngaythanhtoan.HasValue == true))
            {
                command.Parameters[9].Value = ((System.DateTime)(Ngaythanhtoan.Value));
            }
            else
            {
                command.Parameters[9].Value = global::System.DBNull.Value;
            }
            if ((Ngayhoadon.HasValue == true))
            {
                command.Parameters[10].Value = ((System.DateTime)(Ngayhoadon.Value));
            }
            else
            {
                command.Parameters[10].Value = global::System.DBNull.Value;
            }
            if ((Sohoadon == null))
            {
                command.Parameters[11].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[11].Value = ((string)(Sohoadon));
            }
            if ((Kyhieuhoadon == null))
            {
                command.Parameters[12].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[12].Value = ((string)(Kyhieuhoadon));
            }
            if ((Magiaodichphu == null))
            {
                command.Parameters[13].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[13].Value = ((string)(Magiaodichphu));
            }
            if ((Makhachhang == null))
            {
                command.Parameters[14].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[14].Value = ((string)(Makhachhang));
            }
            if ((Diachigiaohang == null))
            {
                command.Parameters[15].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[15].Value = ((string)(Diachigiaohang));
            }
            if ((Manhanviencongno == null))
            {
                command.Parameters[16].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[16].Value = ((string)(Manhanviencongno));
            }
            if ((Manhanviendathang == null))
            {
                command.Parameters[17].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[17].Value = ((string)(Manhanviendathang));
            }
            if ((Tendangnhap == null))
            {
                throw new global::System.ArgumentNullException("Tendangnhap");
            }
            else
            {
                command.Parameters[18].Value = ((string)(Tendangnhap));
            }
            if ((Tendangnhapsua == null))
            {
                command.Parameters[19].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[19].Value = ((string)(Tendangnhapsua));
            }
            if ((Nguoigiaohang == null))
            {
                command.Parameters[20].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[20].Value = ((string)(Nguoigiaohang));
            }
            command.Parameters[21].Value = ((System.DateTime)(Ngayphatsinh));
            if ((Trangthaidonhang.HasValue == true))
            {
                command.Parameters[22].Value = ((int)(Trangthaidonhang.Value));
            }
            else
            {
                command.Parameters[22].Value = global::System.DBNull.Value;
            }
            if ((Mangoaite == null))
            {
                command.Parameters[23].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[23].Value = ((string)(Mangoaite));
            }
            if ((Tygia.HasValue == true))
            {
                command.Parameters[24].Value = ((decimal)(Tygia.Value));
            }
            else
            {
                command.Parameters[24].Value = global::System.DBNull.Value;
            }
            if ((Solaninhoadon.HasValue == true))
            {
                command.Parameters[25].Value = ((int)(Solaninhoadon.Value));
            }
            else
            {
                command.Parameters[25].Value = global::System.DBNull.Value;
            }
            if ((Magiaodichpk == null))
            {
                throw new global::System.ArgumentNullException("Magiaodichpk");
            }
            else
            {
                command.Parameters[26].Value = ((string)(Magiaodichpk));
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[27].Value = ((string)(Madonvi));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        #endregion

        #region Capmatudong
        public static DataTable GetDataKey(string Madonvi, string Chucnang, string Loai)
        {
            CapmatudongCollection capmatudongCollection = new CapmatudongCollection(CONN_STRING);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = capmatudongCollection.CommandCollection[1];
            Adapter.SelectCommand.Connection = capmatudongCollection.Connection;
            capmatudongCollection.Connection.Open();
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                Adapter.SelectCommand.Parameters[0].Value = ((string)(Madonvi));
            }
            if ((Chucnang == null))
            {
                throw new global::System.ArgumentNullException("Chucnang");
            }
            else
            {
                Adapter.SelectCommand.Parameters[1].Value = ((string)(Chucnang));
            }
            if ((Loai == null))
            {
                throw new global::System.ArgumentNullException("Loai");
            }
            else
            {
                Adapter.SelectCommand.Parameters[2].Value = ((string)(Loai));
            }
            DataSet dataTable = new DataSet();
            try
            {
                Adapter.Fill(dataTable, "DATA");
            }
            catch { return null; }
            finally
            {
                capmatudongCollection.Connection.Close();
            }
            return dataTable.Tables[0];
        }
        public static int InsertCapmatudong(global::System.Nullable<int> Sotutang, string Madonvi, string Chucnang, string Ten, global::System.Nullable<int> Sokytu, global::System.Nullable<int> IsAuto, global::System.Nullable<int> Kieututang, string Matruoc, string Masau, string Loai)
        {
            CapmatudongCollection capmatudongCollection = new CapmatudongCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = capmatudongCollection.CommandCollection[3];
            if ((Sotutang.HasValue == true))
            {
                command.Parameters[0].Value = ((int)(Sotutang.Value));
            }
            else
            {
                command.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Madonvi));
            }
            if ((Chucnang == null))
            {
                throw new global::System.ArgumentNullException("Chucnang");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Chucnang));
            }
            if ((Ten == null))
            {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[3].Value = ((string)(Ten));
            }
            if ((Sokytu.HasValue == true))
            {
                command.Parameters[4].Value = ((int)(Sokytu.Value));
            }
            else
            {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            if ((IsAuto.HasValue == true))
            {
                command.Parameters[5].Value = ((int)(IsAuto.Value));
            }
            else
            {
                command.Parameters[5].Value = global::System.DBNull.Value;
            }
            if ((Kieututang.HasValue == true))
            {
                command.Parameters[6].Value = ((int)(Kieututang.Value));
            }
            else
            {
                command.Parameters[6].Value = global::System.DBNull.Value;
            }
            if ((Matruoc == null))
            {
                command.Parameters[7].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[7].Value = ((string)(Matruoc));
            }
            if ((Masau == null))
            {
                command.Parameters[8].Value = global::System.DBNull.Value;
            }
            else
            {
                command.Parameters[8].Value = ((string)(Masau));
            }
            if ((Loai == null))
            {
                throw new global::System.ArgumentNullException("Loai");
            }
            else
            {
                command.Parameters[9].Value = ((string)(Loai));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }

        public static int UpdateSotutang(global::System.Nullable<int> Sotutang, string Original_Madonvi, string Original_Chucnang, string Original_Loai)
        {
            CapmatudongCollection capmatudongCollection = new CapmatudongCollection(CONN_STRING);
            global::System.Data.SqlClient.SqlCommand command = capmatudongCollection.CommandCollection[5];
            if ((Sotutang.HasValue == true))
            {
                command.Parameters[0].Value = ((int)(Sotutang.Value));
            }
            else
            {
                command.Parameters[0].Value = global::System.DBNull.Value;
            }
            if ((Original_Madonvi == null))
            {
                throw new global::System.ArgumentNullException("Original_Madonvi");
            }
            else
            {
                command.Parameters[1].Value = ((string)(Original_Madonvi));
            }
            if ((Original_Chucnang == null))
            {
                throw new global::System.ArgumentNullException("Original_Chucnang");
            }
            else
            {
                command.Parameters[2].Value = ((string)(Original_Chucnang));
            }
            if ((Original_Loai == null))
            {
                throw new global::System.ArgumentNullException("Original_Loai");
            }
            else
            {
                command.Parameters[3].Value = ((string)(Original_Loai));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        #endregion

        public static DataTable WEB_GETNGANHNHOM(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("WEB_GETNGANHNHOM", "DATA", myArr);
        }
        private static string XNTTABLENAME = "";
        public static string XNT_TABLENAME(DateTime ngayHachtoan)
        {
            string ngay = "", thang = "", nam = "";
            ngay = ngayHachtoan.Day.ToString(); if (ngayHachtoan.Day < 10) ngay = "0" + ngayHachtoan.Day.ToString();
            thang = ngayHachtoan.Month.ToString(); if (ngayHachtoan.Month < 10) thang = "0" + ngayHachtoan.Month.ToString();
            nam = ngayHachtoan.Year.ToString();
            XNTTABLENAME = "XNT_" + ngay + thang + nam;
            return XNTTABLENAME;
        }

    #region Get data
        public static DataTable GetMatHangByBarcode(string maSieuThi, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            //parameters.Add(new SqlParameter("@ZoneId", SqlDbType.NVarChar), ZoneId);
            parameters.Add(new SqlParameter("@maSieuThi", SqlDbType.VarChar), maSieuThi);
            parameters.Add(new SqlParameter("@maDonVi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetMatHangByBarcode", "DATA", myArr);
        }
        public static DataTable GetMatHangByTendaydu(string Masieuthi,string Tendaydu, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.NVarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Tendaydu", SqlDbType.VarChar), Tendaydu);
            parameters.Add(new SqlParameter("@maDonVi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetMatHangByTendaydu", "DATA", myArr);
        }
        public static DataTable GetGiabanByMasieuthi(string maSieuThi, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maSieuThi", SqlDbType.VarChar), maSieuThi);
            parameters.Add(new SqlParameter("@maDonVi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetGiabanByMasieuthi", "DATA", myArr);
        }
        public static DataTable GetBoHangByBarcode(string maSieuThi)
        {
            ListDictionary parameters = new ListDictionary();
            //parameters.Add(new SqlParameter("@ZoneId", SqlDbType.NVarChar), ZoneId);
            parameters.Add(new SqlParameter("@maSieuThi", SqlDbType.VarChar), maSieuThi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetBoHangByBarcode", "DATA", myArr);
        }

        public static DataTable GetMatHangBoHang(string maBohang, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maBohang", SqlDbType.VarChar), maBohang);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetMatHangBoHang", "DATA", myArr);
        }
        public static DataTable GetSxDmcongthucsxct(string Mactpk, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactpk", SqlDbType.VarChar), Mactpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_SxDmcongthucsxct", "DATA", myArr);
        }

        public static DataTable SxDmcongthucsxctByPLV(string Mactpk,string Maplv, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactpk", SqlDbType.VarChar), Mactpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            parameters.Add(new SqlParameter("@Maplv", SqlDbType.VarChar), Maplv);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_SxDmcongthucsxctByPLV", "DATA", myArr);
        }
        
        public static DataTable GetBohangchitietExtend(string maBohang, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maBohang", SqlDbType.VarChar), maBohang);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetBohangchitietExtend", "DATA", myArr);
        }
        public static DataTable GetAllBohangchitietExtendByMadonvi(string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllBohangchitietExtendByMadonvi", "DATA", myArr);
        }
        public static DataTable GetAllMatHangBoHang(string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllMatHangBoHang", "DATA", myArr);
        }

        public static DataTable GetSumBoHang(string maBohang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maBohang", SqlDbType.VarChar), maBohang);
            //parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetSumBoHang", "DATA", myArr);
        }
        public static DataTable GetMatHangBoHangNgayHienTai(string maDonVi, DateTime ngayPhatSinh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            parameters.Add(new SqlParameter("@ngayPhatSinh", SqlDbType.DateTime), ngayPhatSinh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetMatHangBoHangNgayHienTai", "DATA", myArr);
        }
        public static DataTable GetSumBoHangAll(string maBohang, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maBohang", SqlDbType.VarChar), maBohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            //parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetSumBoHangFull", "DATA", myArr);
        }

        public static DataTable GetdataKhuyenmaict(string maChuongtrinhkm, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Machuongtrinh", SqlDbType.VarChar), maChuongtrinhkm);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            //parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Khuyenmaict", "DATA", myArr);
        }

        public static DataTable Getdata_Khuyenmaictkm(string maChuongtrinhkm, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Machuongtrinh", SqlDbType.VarChar), maChuongtrinhkm);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Khuyenmaictkm", "DATA", myArr);
        }

        public static DataTable Getdata_Khuyenmaictban(string maChuongtrinhkm, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Machuongtrinh", SqlDbType.VarChar), maChuongtrinhkm);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Khuyenmaictban", "DATA", myArr);
        }

        public static DataTable Getdata_Khuyenmaictphanbo(string maChuongtrinhkm, string maDonVi, string kieuphanbo)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Machuongtrinh", SqlDbType.VarChar), maChuongtrinhkm);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            parameters.Add(new SqlParameter("@Kieuphanbo", SqlDbType.VarChar), kieuphanbo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Khuyenmaictphanbo", "DATA", myArr);
        }

        public static DataTable GetMathangdayweb(string TABLEXNT_NAME, string DB_NAME, string DB_NAME_XNT, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetMathangdayweb", "DATA", myArr);
        }

        public static DataTable GetLichLamViecNhanVien(string Madonvi, int Trangthaisudung, DateTime Ngaydauthang, DateTime Ngaycuoithang)
        {
            ListDictionary parameters = new ListDictionary();
            //parameters.Add(new SqlParameter("@ZoneId", SqlDbType.NVarChar), ZoneId);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            parameters.Add(new SqlParameter("@Ngaydauthang", SqlDbType.DateTime), Ngaydauthang);
            parameters.Add(new SqlParameter("@Ngaycuoithang", SqlDbType.DateTime), Ngaycuoithang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLichLamViecNhanVien", "DATA", myArr);
        }

        public static DataTable GetLichlamvieccasangcachieu(string Madonvi, string Mabophan)
        {
            ListDictionary parameters = new ListDictionary();
            //parameters.Add(new SqlParameter("@ZoneId", SqlDbType.NVarChar), ZoneId);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLichlamvieccasangcachieu", "DATA", myArr);
        }
        public static DataTable Getbaohiemnhanvien(string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getbaohiemnhanvien", "DATA", myArr);

        }

        public static DataTable GetDangKyNghiNhanVien(string Madonvi, DateTime Ngaydangky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngaydangky", SqlDbType.DateTime), Ngaydangky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDangKyNghiNhanVien", "DATA", myArr);

        }
        public static DataTable Getphucapnhanvien(string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getphucapnhanvien", "DATA", myArr);
        }
        public static DataTable GetDangKyLamThemNhanVien(string Madonvi, DateTime Ngaydauthang, DateTime Ngaycuoithang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngaydauthang", SqlDbType.DateTime), Ngaydauthang);
            parameters.Add(new SqlParameter("@Ngaycuoithang", SqlDbType.DateTime), Ngaycuoithang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDangKyLamThemNhanVien", "DATA", myArr);

        }

        public static DataTable GetLuongphucapnhanvien(string Madonvi, string Mabophan, int Trangthaisudung, DateTime Tungay, DateTime Denngay, int Binhthuong)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Binhthuong", SqlDbType.Int), Binhthuong);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuongphucapnhanvien", "DATA", myArr);

        }

        public static DataTable GetLuongtrachnhiemgiamsatnhanvien(string Madonvi, string Mabophan, int Trangthaisudung, int Trachnhiem, int Giamsat)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            parameters.Add(new SqlParameter("@Trachnhiem", SqlDbType.Int), Trachnhiem);
            parameters.Add(new SqlParameter("@Giamsat", SqlDbType.Int), Giamsat);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuongtrachnhiemgiamsatnhanvien", "DATA", myArr);

        }

        public static DataTable GetLuongkhenthuongkyluatnhanvien(string Madonvi, string Mabophan, int Loai, DateTime Tungay, DateTime Denngay, int Trangthaisudung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Loai", SqlDbType.Int), Loai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuongkhenthuongkyluatnhanvien", "DATA", myArr);

        }

        public static DataTable GetLuongluonghopdongnhanvien(string Madonvi, string Mabophan, int Trangthaisudung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuongluonghopdongnhanvien", "DATA", myArr);

        }

        public static DataTable GetLuongluonghopdongnhanvienNB(string Madonvi, string Manhanvien, int Trangthaisudung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuongluonghopdongnhanvienNB", "DATA", myArr);

        }


        public static DataTable GetTinhbangluongnhanvien(string Madonvi, string Mabophan, int Thang, int Nam, int Trangthaisudung, int Trangthai, int Khenthuong, int Kyluat, DateTime Tungay, DateTime Denngay, int Binhthuong)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Khenthuong", SqlDbType.Int), Khenthuong);
            parameters.Add(new SqlParameter("@Kyluat", SqlDbType.Int), Kyluat);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Binhthuong", SqlDbType.Int), Binhthuong);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetTinhbangluongnhanvien", "DATA", myArr);

        }


        public static DataTable GetTinhbangluongnhanvienNB(string Madonvi, string Mabophan, int Thang, int Nam, int Trangthaisudung, int Trangthai, int Khenthuong, int Kyluat, DateTime Tungay, DateTime Denngay, int Binhthuong)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Khenthuong", SqlDbType.Int), Khenthuong);
            parameters.Add(new SqlParameter("@Kyluat", SqlDbType.Int), Kyluat);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Binhthuong", SqlDbType.Int), Binhthuong);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetTinhbangluongnhanvienNB", "DATA", myArr);

        }


        public static DataTable GetLuonghopdongtheobophan(string Madonvi, string Mabophan)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuonghopdongtheobophan", "DATA", myArr);

        }

        public static DataTable GetdataMathangcandientu(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetdataMathangcandientu", "DATA", myArr);

        }

        public static DataTable GetLuongluonghopdongnhanvienPhongban(string Madonvi, string Maphongban, int Trangthaisudung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maphongban", SqlDbType.VarChar), Maphongban);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetLuongluonghopdongnhanvienPhongban", "DATA", myArr);

        }
        public static DataTable GetDkchuyenbophan(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDkchuyenbophan", "DATA", myArr);

        }

        public static DataTable Getlichlamviecthangnhanvien(string Madonvi, int Thang, int Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getlichlamviecthangnhanvien", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_DatHangTuDong(string Madonvi, string TABLEXNT_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_DatHangTuDong", "DATA", myArr);
        }
        public static DataTable GetData_KT_DanhMucTaiKhoanKetChuyenCT(string Matkketchuyen, string madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Matkketchuyen", SqlDbType.VarChar), Matkketchuyen);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_KT_DanhMucTaiKhoanKetChuyenCT", "DATA", myArr);

        }

        public static DataTable XNT_CHECKKIEMKE(string TABLEXNT_NAME, string DB_NAME_XNT, string DB_NAME, string Makhohang
            , string Manganh, string Manhomhang, string Makehang, string Masieuthi, string Madonvi,string Makhachhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Makehang", SqlDbType.VarChar), Makehang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_CHECKKIEMKE", "DATA", myArr);

        }

        public static DataTable GetData_VT_GiaoDichThueXeCT(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VT_GiaoDichThueXeCT", "DATA", myArr);

        }
        //Xuất file XML  nghiệp vụ - Kiểm kê. --------------------
        public static DataTable Getdata_NV_VTHH_Kiemke_XuatXML(string TABLEXNT_NAME, string DB_NAME_XNT, string DB_NAME, string Makhohang, string Manganh, string Manhomhang, string Makehang, string Masieuthi, string Madonvi,string Makhachhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Makehang", SqlDbType.VarChar), Makehang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_NV_VTHH_Kiemke_XuatXML", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_XuatXML_BoHang(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_XuatXML_BoHang", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_XuatXML_BoHangct(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_XuatXML_BoHangct", "DATA", myArr);

        }
        // kết thúc xuất XML-------------------------------------------
        public static DataTable GetData_VTHH_GiaodichphuExit(string Madonvi, string Magiaodichphu, string TableName, string ColumnName)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichphu", SqlDbType.VarChar), Magiaodichphu);
            parameters.Add(new SqlParameter("@TableName", SqlDbType.VarChar), TableName);
            parameters.Add(new SqlParameter("@ColumnName", SqlDbType.VarChar), ColumnName);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_GiaodichphuExit", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_getHoTenNguoiDung(string tenDangnhap, string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tendangnhap", SqlDbType.VarChar), tenDangnhap);
            parameters.Add(new SqlParameter("@maDonVi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_getHoTenNguoiDung", "DATA", myArr);
        }

        // Lương hợp đồng theo nhân viên -----------------Name:Manhtran.
        public static DataTable Getdata_NS_LuongHopDongNhanVien(string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_NS_LuongHopDongNhanVien", "DATA", myArr);

        }


        public static DataTable Getdata_Nhanvienkhachhang(string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Nhanvienkhachhang", "DATA", myArr);

        }
        public static DataTable Getdata_VTHH_XulyAmCt(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho
            , string Manganhhang, string Manhomhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_XulyAmCt", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_XulyAmTh(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho
            , string Manganhhang, string Manhomhang, string DB_NAME_XNT, string TABLEXNT_NAME, string Makhoam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makhoban", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhoam", SqlDbType.VarChar), Makhoam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_XulyAmTh", "DATA", myArr);
        }

        public static DataTable GetCanhBaoTon(string Madonvi, string TABLEXNT_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonVi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetCanhBaoTon", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Tinhthuongnv(DateTime Tungay, DateTime Denngay, string Madonvi, string Manhomptnx, string manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@manhanvien", SqlDbType.VarChar), manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Tinhthuongnv", "DATA", myArr);
        }

        public static DataTable GetDataGiaodichquaychitietbymagiaodich(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichquaychitietbymagiaodich", "DATA", myArr);
        }

        public static DataTable GetDataGiaodichctdoitractquay(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctdoitractquay", "DATA", myArr);
        }

        public static DataTable GetDataGiaodichctdoitractgd(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctdoitractgd", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_KhohangGia(string Madonvi, string Makhohang,string Maloaigia)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.VarChar), Maloaigia);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhohangGia", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_KhohangGiaByMasieuthi(string Madonvi, string Masieuthi,string Makhohang, string Maloaigia)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.VarChar), Maloaigia);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhohangGiaByMasieuthi", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_KhohangGiaByNgay(string Madonvi,string Makhohang, string Maloaigia,DateTime Ngayapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.VarChar), Maloaigia);
            parameters.Add(new SqlParameter("@Ngayapdung", SqlDbType.DateTime), Ngayapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhohangGiaByNgay", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_Khohangbohanggia(string Madonvi, string Makhohang, string Mabohang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Mabohang", SqlDbType.VarChar), Mabohang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Khohangbohanggia", "DATA", myArr);
        }

        public static DataTable GetAllMathangkhohanggia(string Madonvi, string Makhohang, DateTime Ngayapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Ngayapdung", SqlDbType.DateTime), Ngayapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllMathangkhohanggia", "DATA", myArr);
        }

        public static DataTable GetAllMathangkhohanggiabyngayphatsinh(string Madonvi, string Makhohang, DateTime Ngayapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Ngayapdung", SqlDbType.DateTime), Ngayapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllMathangkhohanggiabyngayphatsinh", "DATA", myArr);
        }

        public static DataTable GetAllBoghangctkhohanggia(string Madonvi, string Makhohang, DateTime Ngayapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Ngayapdung", SqlDbType.DateTime), Ngayapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllBoghangctkhohanggia", "DATA", myArr);
        }

        public static DataTable GetAllBoghangctkhohanggiabyNgayphatsinh(string Madonvi, string Makhohang, DateTime Ngayapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Ngayapdung", SqlDbType.DateTime), Ngayapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllBoghangctkhohanggiabyNgayphatsinh", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_KMMOTSOSANPHAM(string Madonvi, DateTime ngayPS)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngayps", SqlDbType.DateTime), ngayPS);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_KMMOTSOSANPHAM", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_KMMOTSOSANPHAMNEW(string Madonvi, DateTime ngayPS)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngayps", SqlDbType.DateTime), ngayPS);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_KMMOTSOSANPHAMNEW", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_KMHANGBAN(string Madonvi, DateTime ngayPS)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.DateTime), ngayPS);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_KMHANGBAN", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_KMHANGKHUYENMAI(string Madonvi, DateTime ngayPS)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.DateTime), ngayPS);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_KMHANGKHUYENMAI", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_Phanquyenhangtheomanhanvien(string Madonvi, string maNhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.DateTime), maNhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phanquyenhangtheomanhanvien", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_Phanquyennvhh(string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phanquyennvhh", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_DSphanquyennvhh()
        {
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_DSphanquyennvhh", "DATA", myArr);

        }


        public static DataTable Getdata_VTHH_Phieuinxbnhieugd(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbnhieugd", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_Tracuudonhangtheonv(DateTime Tungay, DateTime Denngay, string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Tracuudonhangtheonv", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_giaodichctkm(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_giaodichctkm", "DATA", myArr);
        }
        public static DataTable GetData_Sx_QuyctktByMagiaodichphu(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichphu", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_QuyctktByMagiaodichphu", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Mathangchuadongbo(string Madonvitong, string Madonvidongbo)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvitong", SqlDbType.VarChar), Madonvitong);
            parameters.Add(new SqlParameter("@Madonvidongbo", SqlDbType.VarChar), Madonvidongbo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Mathangchuadongbo", "DATA", myArr);
        }
        public static DataTable Getdata_KT_MaxThangChotSo(string Madonvi, int Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_KT_MaxThangChotSo", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_MaNgoaiVungKiemKe(string Madonvi, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_MaNgoaiVungKiemKe", "DATA", myArr);

        }
        public static DataTable Getdata_VTHH_GiaodichPhanbo(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_GiaodichPhanbo", "DATA", myArr);
        }

        public static DataTable Getdata_LinkquysotienbyMagiaodich(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_LinkquysotienbyMagiaodich", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Chitietkhachhangdongop(string Madonvi, string Madongop, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), Madongop);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Chitietkhachhangdongop", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Giaodichbymanganhhang(string Madonvi, string Magiaodichdongop, string manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), Magiaodichdongop);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), manganh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Giaodichbymanganhhang", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_Doanhsonhanviendathang(string Madonvi, string Magiaodichdongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichdongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Doanhsonhanviendathang", "DATA", myArr);

        }

        public static DataTable GetData_VTHH_Doituongapdungkm(string Madonvi, int Kieudoituong)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Kieudoituong", SqlDbType.Int), Kieudoituong);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Doituongapdungkm", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Doituongapdungphanbo(string Madonvi, string Loaidoituongphanbo)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaidoituong", SqlDbType.VarChar), Loaidoituongphanbo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Doituongapdungphanbo", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Tuyenduongtrongngay(string maDonVi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), maDonVi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Tuyenduongtrongngay", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_MATHANG(string TABLEXNT_NAME, string Madonvi, string DB_NAME_XNT, int trangthaisudung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@trangthaisudung", SqlDbType.VarChar), trangthaisudung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_MATHANG", "DATA", myArr);
        }
        #endregion

        #region Get Data Sản xuất
        public static DataTable GetData_SX_SxDmcongthucsxct(string Madonvi, string Masieuthi, decimal Soluong, int status, string Magiaodichpk, string Mactpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Soluong", SqlDbType.Decimal), Soluong);
            parameters.Add(new SqlParameter("@Status", SqlDbType.Int), status);
            parameters.Add(new SqlParameter("@Mactpk", SqlDbType.VarChar), Mactpk);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_SX_SxDmcongthucsxct", "DATA", myArr);
        }
        #endregion

        #region Các stored liên quan đến giao dịch
        public static DataTable GetDataGiaodichctByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataByMagiaodichDaPhanbo(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataByMagiaodichDaPhanbo", "DATA", myArr);
        }
        public static DataTable GetDataMasieuthiSumSoluongByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataMasieuthiSumSoluongByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataMasieuthiSoluongleFromDongop(string Magiaodichpk, string Madonvi, string Manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataMasieuthiSoluongleFromDongop", "DATA", myArr);
        }
        public static DataTable GetDataMasieuthiSoluongleTLFromDongop(string Magiaodichpk, string Madonvi, string Manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@ListMagiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataMasieuthiSoluongleTLFromDongop", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichctByMagiaodichpkInDonGop(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctByMagiaodichpkInDonGop", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichctXNKhauByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctXNKhauByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichctHaiquanByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctHaiquanByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichctmauByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctmauByMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetDataGDcthangbanByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGDcthangbanByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichctByListMagiaodichpk(string ListMagiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@ListMagiaodichpk", SqlDbType.VarChar), ListMagiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichctByListMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataGDcthangkmByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGDcthangkmByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_GiaodichNhapMua_Phanbo(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_GiaodichNhapMua_Phanbo", "DATA", myArr);
        }
        public static DataTable GetDataCoppyGDCTbyMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataCoppyGDCTbyMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetDataGiaodichTondauctct(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichTondauctct", "DATA", myArr);
        }
        //khach hàng giá
        public static DataTable Getdata_VTHH_KhachhangGia(string Makhachhang, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhanghangGia", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Mathangapdungck(string Madonvi, int Maloaigia)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.Int), Maloaigia);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Mathangapdungck", "DATA", myArr);
        }
        //khách hàng giá theo nhóm
        public static DataTable Getdata_VTHH_KhachhangGiabyNhom(string Makhachhang, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhanghangGiabyNhom", "DATA", myArr);
        }
        //khách hàng giá theo ngành
        public static DataTable Getdata_VTHH_KhachhangGiabyNganh(string Makhachhang, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhanghangGiabyNganh", "DATA", myArr);
        }

        //khách hàng giá by key
        public static DataTable Getdata_VTHH_KhanghangGiabyKey(string Makhachhang, string Madonvi, int maloaigia, string maapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.Int), maloaigia);
            parameters.Add(new SqlParameter("@Maapdung", SqlDbType.VarChar), maapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_KhanghangGiabyKey", "DATA", myArr);
        }

        //nhóm khach hàng giá
        public static DataTable Getdata_VTHH_NhomkhanghangGia(string Manhomkh, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhomkhachhang", SqlDbType.VarChar), Manhomkh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhomkhanghangGia", "DATA", myArr);
        }
        //nhóm khách hàng giá theo nhóm
        public static DataTable Getdata_VTHH_NhomKhanghangGiabyNhom(string maNhomkh, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhomkhachhang", SqlDbType.VarChar), maNhomkh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhomKhanghangGiabyNhom", "DATA", myArr);
        }
        //nhóm khách hàng giá theo ngành
        public static DataTable Getdata_VTHH_NhomKhanghangGiabyNganh(string maNhomkh, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhomkhachhang", SqlDbType.VarChar), maNhomkh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhomKhanghangGiabyNganh", "DATA", myArr);
        }
        //Nhóm khách hàng giá theo key

        public static DataTable Getdata_VTHH_NhomkhanghangGiabyKey(string Manhomkhachhang, string Madonvi, int maloaigia, string maapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhomkhachhang", SqlDbType.VarChar), Manhomkhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.Int), maloaigia);
            parameters.Add(new SqlParameter("@Maapdung", SqlDbType.VarChar), maapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhomkhanghangGiabyKey", "DATA", myArr);
        }
        //Nhân viên giá
        public static DataTable Getdata_VTHH_NhanvienGia(string maNhanvien, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), maNhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhanvienGia", "DATA", myArr);
        }
        //Nhân viên giá theo nhóm
        public static DataTable Getdata_VTHH_NhanvienGiabyNhom(string maNhanvien, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), maNhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhanvienGiabyNhom", "DATA", myArr);
        }
        //Nhân viên giá theo ngành
        public static DataTable Getdata_VTHH_NhanvienGiabyNganh(string maNhanvien, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), maNhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhanvienGiabyNganh", "DATA", myArr);
        }
        //Nhân viên giá theo key
        public static DataTable Getdata_VTHH_NhanvienGiabyKey(string maNhanvien, string Madonvi, int maloaigia, string maapdung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), maNhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maloaigia", SqlDbType.Int), maloaigia);
            parameters.Add(new SqlParameter("@Maapdung", SqlDbType.VarChar), maapdung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_NhanvienGiabyKey", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_GDCTKhongtkbymagdpk(string Magiaodichpk, string Madonvi, string manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_GDCTKhongtkbymagdpk", "DATA", myArr);
        }

        public static DataTable GetDataSerialByMagiaodichpkAndMasieuthi(string Magiaodichpk, string Madonvi, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataSerialByMagiaodichpkAndMasieuthi", "DATA", myArr);
        }

        public static DataTable GetDataMathangSerialByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataMathangSerialByMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetDataSerialByMasieuthiAndTrangthai(string Madonvi, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataSerialByMasieuthiAndTrangthai", "DATA", myArr);
        }

        public static DataTable GetDataSerialXuatByMasieuthi(string Madonvi, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataSerialXuatByMasieuthi", "DATA", myArr);
        }

        public static DataTable GetDataAllSerial(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataAllSerial", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichNhapKhauByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichNhapKhauByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichKhohangByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichKhohangByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichDichvuByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichDichvuByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichmauByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichmauByTungayDenngay", "DATA", myArr);
        }

        public static DataTable Fill_GiaodichSanXuatByTungayDenngay(string LoaiChungtu, string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            parameters.Add(new SqlParameter("@LoaiChungtu", SqlDbType.VarChar), LoaiChungtu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichSanXuatByTungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_SinhNhatKhachhang(string Madonvi, DateTime tuNgay, DateTime denNgay, string listNgaythang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            parameters.Add(new SqlParameter("@listNgaythang", SqlDbType.VarChar), listNgaythang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_SinhNhatKhachhang", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichVinamilkByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichVinamilkByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichVinamilkCTByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichVinamilkCTByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_DathangByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_DathangByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichquayByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichquayByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Fill_GiaodichquayBySerial(string Trangthai, string Madonvi, string maNhomptnx, string tuNgay, string denNgay, string Serial)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@Serial", SqlDbType.VarChar), Serial);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichquayBySerial", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichquayctByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichquayctByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichquayctInA4ByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichquayctInA4ByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetDataGiaodichquayctByMagiaodichpkTralai(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataGiaodichquayctByMagiaodichpkTralai", "DATA", myArr);
        }
        public static DataTable GetDataLichsuByTungayDenngay(string Madonvi, string maNhomptnx, string tuNgay, string denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataLichsuByTungayDenngay", "DATA", myArr);
        }
        public static DataTable GetDataMasieuthiLikeBarcode(string Madonvi, string Barcode)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Barcode", SqlDbType.VarChar), Barcode);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataMasieuthiLikeBarcode", "DATA", myArr);
        }
        public static DataTable Getgiaodichchuathanhtoan(string makhachang, string madonvi, bool trangthai, int tichchat)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Tinhchat", SqlDbType.Int), tichchat);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Bit), trangthai);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getgiaodichchuathanhtoan", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_giaodichchuathanhtoanALL(string madonvi, bool trangthai, int tichchat, DateTime tungay, DateTime denngay, decimal tygia, string matkco, string matkno, string tenloaict)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Tinhchat", SqlDbType.Int), tichchat);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Bit), trangthai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), denngay);
            parameters.Add(new SqlParameter("@Tyga", SqlDbType.Decimal), tygia);
            parameters.Add(new SqlParameter("@Matkco", SqlDbType.VarChar), matkco);
            parameters.Add(new SqlParameter("@Matkno", SqlDbType.VarChar), matkno);
            parameters.Add(new SqlParameter("@Tenloaict", SqlDbType.NVarChar), tenloaict);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_giaodichchuathanhtoanALL", "DATA", myArr);
        }

        public static DataTable Getgiaodichchuathanhtoanhangmua(string makhachang, string madonvi, bool trangthai, int tichchat)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Tinhchat", SqlDbType.Int), tichchat);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Bit), trangthai);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getgiaodichchuathanhtoanhangmua", "DATA", myArr);
        }

        public static DataTable GetCtucongno(string makhachang, string madonvi, string manhomptnx, string matk, string loaict1, string loaict2, string loaict3)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Nhomptnx", SqlDbType.VarChar), manhomptnx);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), matk);
            parameters.Add(new SqlParameter("@Loaict1", SqlDbType.VarChar), loaict1);
            parameters.Add(new SqlParameter("@Loaict2", SqlDbType.VarChar), loaict2);
            parameters.Add(new SqlParameter("@Loaict3", SqlDbType.VarChar), loaict3);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetCtucongno", "DATA", myArr);
        }
        public static DataTable GetCongnoChuathanhtoan(string makhachang, string madonvi, bool trangthai, int tichchat, string Mangoaite)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Mangoaite", SqlDbType.VarChar), Mangoaite);
            parameters.Add(new SqlParameter("@Tinhchat", SqlDbType.Int), tichchat);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetCongnoChuathanhtoan", "DATA", myArr);
        }

        public static DataTable getdata_Ckthunglontheokhachhang(string Manhanvien, string madonvi, string magiaodichpk, string makhachhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), magiaodichpk);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("getdata_Ckthunglontheokhachhang", "DATA", myArr);
        }
        public static DataTable getdata_InCkthunglontheokhachhang(string Manhanvien, string madonvi, string magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("getdata_InCkthunglontheokhachhang", "DATA", myArr);
        }
        public static DataTable Getdata_CkTrathuongTheoNhanvien(string Manhanvien, string madonvi, string magiaodichpk,int isTonghop,DateTime tuNgay,DateTime denNgay, int trangthaick)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), magiaodichpk);
            parameters.Add(new SqlParameter("@IsTonghop", SqlDbType.Int), isTonghop);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            parameters.Add(new SqlParameter("@trangthaick", SqlDbType.Int), trangthaick);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_CkTrathuongTheoNhanvien", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Giaodichctphanbo(string Magiaodichpk, string madonvi, int loai, int isKhachhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Loai", SqlDbType.Int), loai);
            parameters.Add(new SqlParameter("@isKhachhang", SqlDbType.Int), isKhachhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Giaodichctphanbo", "DATA", myArr);
        }

        public static DataTable Getdata_CkTrathuongTheoKhachhang(string Makhachhang, string madonvi, string magiaodichpk, int trangthaick)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), magiaodichpk);
            parameters.Add(new SqlParameter("@trangthaick", SqlDbType.Int), trangthaick);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_CkTrathuongTheoKhachhang", "DATA", myArr);
        }
        public static DataTable Getdata_CkDailySonTatThanh(string Makhachhang, string madonvi, string magiaodichpk, int trangthaick)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), magiaodichpk);
            parameters.Add(new SqlParameter("@trangthaick", SqlDbType.Int), trangthaick);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_CkDailySonTatThanh", "DATA", myArr);
        }
        public static DataTable Getdata_CkNamSonTatThanh(string Makhachhang, string madonvi, string magiaodichpk,int Loai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), magiaodichpk);
            parameters.Add(new SqlParameter("@Loai", SqlDbType.Int), Loai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_CkNamSonTatThanh", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_GiaodichchuaTTbymaGDphu(string Magiaodich, string madonvi, bool trangthai, int tichchat)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Tinhchat", SqlDbType.Int), tichchat);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Bit), trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_GiaodichchuaTTbymaGDphu", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_GiaodichTrungSohoadon(string Magiaodichpk, string madonvi, string Sohoadon,string Kyhieuhoadon)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), madonvi);
            parameters.Add(new SqlParameter("@Sohoadon", SqlDbType.VarChar), Sohoadon);
            parameters.Add(new SqlParameter("@Kyhieuhoadon", SqlDbType.VarChar), Kyhieuhoadon);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_GiaodichTrungSohoadon", "DATA", myArr);
        }

        public static DataTable GetTongTienPhaiTTByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetTongTienPhaiTTByMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetAllGiaodichthanhtoan(string Madonvi, int tinhchat, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tinhchat", SqlDbType.Int), tinhchat);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tungay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetAllGiaodichthanhtoan", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_KiemkectByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_KiemkectByMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetData_VT_BaoDuongXe(string Maxe, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Maxe", SqlDbType.VarChar), Maxe);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VT_BaoDuongXe", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Giaodichgopdon(string Madonvi, string Matuyen, string Magiaodich, string magiaodichorderby)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matuyen", SqlDbType.VarChar), Matuyen);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), magiaodichorderby);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Giaodichgopdon", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Giaodichctgopdon(string Madonvi, string Matuyen, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matuyen", SqlDbType.VarChar), Matuyen);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Giaodichctgopdon", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Giaodichchuagopdon(string Madonvi, string Matuyen, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matuyen", SqlDbType.VarChar), Matuyen);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Giaodichchuagopdon", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_DSGiaodichgopdon(string Madonvi, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TuNgay", SqlDbType.VarChar), tungay);
            parameters.Add(new SqlParameter("@DenNgay", SqlDbType.VarChar), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_DSGiaodichgopdon", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_DSGiaodichGiaonhan(string Madonvi, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TuNgay", SqlDbType.VarChar), tungay);
            parameters.Add(new SqlParameter("@DenNgay", SqlDbType.VarChar), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_DSGiaodichGiaonhan", "DATA", myArr);
        }

        public static DataTable Fill_GiaodichALLByTungayDenngay(string Trangthai, string Madonvi, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichALLByTungayDenngay", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Giaodichgiaonhan(string Madonvi, string magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Giaodichgiaonhan", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Dongopbymagiaodichphu(string Madonvi, string magiaodich, string magiaodichorderby)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), magiaodich);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), magiaodichorderby);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Dongopbymagiaodichphu", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Dongopctbymagiaodichphu(string Madonvi, string magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Dongopctbymagiaodichphu", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongop(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongop", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_PhieuindongopDieuchuyen(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongopDieuchuyen", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_Phieuindongopfull(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongopfull", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_PhieuindongopXNTL(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongopXNTL", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_Manganhtheodongop(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Manganhtheodongop", "DATA", myArr);
        }

        public static DataTable VTHH_GetData_KmByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("VTHH_GetData_KmByMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongoptheonganh(string Madonvi, string madongop, string manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), manganh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongoptheonganh", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Sodonhangtheonganh(string Madonvi, string madongop, string manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), manganh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Sodonhangtheonganh", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Sodonhang(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Sodonhang", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongopbanbuon(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongopbanbuon", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_PhieuindongoptheoKHbanbuon(string Madonvi, string madongop, string maorder)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), maorder);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongoptheoKHbanbuon", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Lichsudonhang(int trangthai, string makhachhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), trangthai);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Lichsudonhang", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_PhieuindongoptheoKH(string Madonvi, string madongop, string maorder)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), maorder);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongoptheoKH", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_PhieuindongoptheoKHtheonganh(string Madonvi, string madongop, string manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), manganh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongoptheoKHtheonganh", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_PhieuindongopdanhsachKH(string Madonvi, string madongop, string maorder)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), maorder);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongopdanhsachKH", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongopmasan(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongopmasan", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Giaodichgopdonbanbuon(string Madonvi, string Matuyen, string Magiaodich, string magiaodichorderby)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matuyen", SqlDbType.VarChar), Matuyen);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), magiaodichorderby);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Giaodichgopdonbanbuon", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_DSTinhthuongnhanvien(DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.VarChar), tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.VarChar), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_DSTinhthuongnhanvien", "DATA", myArr);
        }

        public static DataTable Fill_GiaodichTondauByTungayDenngay(string Trangthai, string Madonvi, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_GiaodichTondauByTungayDenngay", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_DSgopdon(string Trangthai, string Madonvi, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@DenNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_DSgopdon", "DATA", myArr);
        }
        public static DataTable GetDataLogMart(string Madonvi, string maFormName, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maFormName", SqlDbType.VarChar), maFormName);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataLogMart", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_Soluongkhdongop(string Madonvi, string Matuyen, string Magiaodich, string magiaodichorderby)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matuyen", SqlDbType.VarChar), Matuyen);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), magiaodichorderby);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Soluongkhdongop", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Soluongkhtheomadongop(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodich", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Soluongkhtheomadongop", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_MakhachhangAllmagiaodich(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_MakhachhangAllmagiaodich", "DATA", myArr);
        }
        public static DataTable GetData_VTHH_Makhachhangmagiaodichbynganhhang(string Madonvi, string madongop, string manganhhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@maNganhhang", SqlDbType.VarChar), manganhhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Makhachhangmagiaodichbynganhhang", "DATA", myArr);
        }
        public static DataTable Fill_BangkeThueGtgtByTungayDenngay(int Loai, string Madonvi, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Loai", SqlDbType.VarChar), Loai);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@DenNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Fill_BangkeThueGtgtByTungayDenngay", "DATA", myArr);
        }
        public static DataTable Getdata_THUE_BangkeThueGtgt(int Loai, string Madonvi, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Loai", SqlDbType.Int), Loai);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@TuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@DenNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_THUE_BangkeThueGtgt", "DATA", myArr);
        }
        public static bool Vthh_MathangUpdateGiaBanbuonTheoMaHQ(string Mahaiquan,string Madonvi,decimal Giabanbuonchuavat,decimal Giabanbuoncovat)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mahaiquan", SqlDbType.VarChar), Mahaiquan);
            parameters.Add(new SqlParameter("@Giabanbuonchuavat", SqlDbType.Decimal), Giabanbuonchuavat);
            parameters.Add(new SqlParameter("@Giabanbuoncovat", SqlDbType.VarChar), Giabanbuoncovat);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("Vthh_MathangUpdateGiaBanbuonTheoMaHQ", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongoptheonganhfull(string Madonvi, string madongop, string manganghang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), manganghang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongoptheonganhfull", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuintongdonfull(string Madonvi, string madonhang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.VarChar), madonhang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuintongdonfull", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongoptheonganhthungfull(string Madonvi, string madongop, string manganh, int kieutron)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), manganh);
            parameters.Add(new SqlParameter("@Kieutron", SqlDbType.VarChar), kieutron);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongoptheonganhthungfull", "DATA", myArr);
        }
        #endregion

        #region các stoed liên quan đến Quy
        public static DataTable GetDataQuychitietByMactpk(string maCtupk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactktpk", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataQuychitietByMactpk", "DATA", myArr);
        }
        public static DataTable GetdataQuytungaydenngay(string maloaict, string maloaict1, string kieuct, string Madonvi, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maLoaict", SqlDbType.VarChar), maloaict);
            parameters.Add(new SqlParameter("@maLoaict1", SqlDbType.VarChar), maloaict1);
            parameters.Add(new SqlParameter("@kieuct", SqlDbType.VarChar), kieuct);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tungay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetdataQuytungaydenngay", "DATA", myArr);
        }
        public static DataTable Getdata_QuyctTaikhoan(string maCtupk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactupk", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_QuyctTaikhoan", "DATA", myArr);
        }

        public static DataTable GetdataQuyButruct(string maCtupk, string Madonvi, string matkno, string matkco)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactktpk", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matkno", SqlDbType.VarChar), matkno);
            parameters.Add(new SqlParameter("@Matkco", SqlDbType.VarChar), matkco);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataQuyButruchitietByMactpk", "DATA", myArr);
        }

        public static DataTable Getdata_QuyButructTaikhoan(string maCtupk, string Madonvi, string matkno, string matkco)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactupk", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matkno", SqlDbType.VarChar), matkno);
            parameters.Add(new SqlParameter("@Matkco", SqlDbType.VarChar), matkco);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_QuyButructTaikhoan", "DATA", myArr);
        }

        public static DataTable Getthuchitratruoc(string maKhachhang, string Madonvi, string loaict1, string loaict2, string loaict3, string kieuct1, string kieuct2, string matk, string nhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), maKhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaict1", SqlDbType.VarChar), loaict1);
            parameters.Add(new SqlParameter("@Loaict2", SqlDbType.VarChar), loaict2);
            parameters.Add(new SqlParameter("@Loaict3", SqlDbType.VarChar), loaict3);
            parameters.Add(new SqlParameter("@Kieuct1", SqlDbType.VarChar), kieuct1);
            parameters.Add(new SqlParameter("@Kieuct2", SqlDbType.VarChar), kieuct2);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), matk);
            parameters.Add(new SqlParameter("@Nhomptnx", SqlDbType.VarChar), nhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getthuchitratruoc", "DATA", myArr);
        }

        public static DataTable GetdataQuyDoitruct(string maCtupk, string Madonvi, int ThuchiGiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactktpk", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@ThuchiGiaodich", SqlDbType.Int), ThuchiGiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataQuydoitruchitietByMactpk", "DATA", myArr);
        }

        public static DataTable Getdata_KT_Sodutkketchuyen(string Madonvi, string maTk, int thang,int Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), maTk);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_KT_Sodutkketchuyen", "DATA", myArr);
        }

        public static DataTable Getdata_KT_DSDoitrucongnoNDT(string maloaict, string maloaict1, string kieuct, string Madonvi, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maLoaict", SqlDbType.VarChar), maloaict);
            parameters.Add(new SqlParameter("@maLoaict1", SqlDbType.VarChar), maloaict1);
            parameters.Add(new SqlParameter("@kieuct", SqlDbType.VarChar), kieuct);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tungay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_KT_DSButrucongnonhieudoituong", "DATA", myArr);
        }

        public static DataTable Getdata_KT_GhisobutrucongnoNDT(string maCtupk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactupk", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_KT_GhisobutrucongnoNDT", "DATA", myArr);
        }
        #endregion

        #region Số dư đầu kỳ
        public static DataTable Getdata_Sodudauky(string Madonvi, int Thang, int Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Sodudauky", "DATA", myArr);
        }

        public static DataTable GetDatachotsoketoan(string Madonvi, int Thang, int Nam, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDatachotsoketoan", "DATA", myArr);
        }
        #endregion

        #region Xuất nhập tồn
        //lấy tồn kho mặt hàng
        public static DataTable XNT_Gettonkhomathang(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONKHO", "DATA", myArr);
        }

        public static DataTable XNT_GETTONKHOALL(string DB_NAME_XNT, string TABLEXNT_NAME, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONKHOALL", "DATA", myArr);
        }

        public static bool XNT_NHAP(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_NHAP", myArr);
        }

        public static bool XNT_XUAT(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_XUAT", myArr);
        }

        public static bool XNT_NHAPTRALAI(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_NHAPTRALAI", myArr);
        }

        public static bool XNT_UPDATEGIAVON(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_UPDATEGIAVON", myArr);
        }
        public static bool XNT_UPDATEGIAVONCHUYENKHO(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_UPDATEGIAVONCHUYENKHO", myArr);
        }
        public static DataTable XNT_CHECKTONKHO(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_CHECKTONKHO", "DATA", myArr);
        }
        public static bool XNT_XUATBALE(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_XUATBALE", myArr);
        }
        public static bool XNT_XUATBALEAM(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_XUATBALEAM", myArr);
        }

        public static bool XNT_DIEUCHUYENKHO(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_DIEUCHUYENKHO", myArr);
        }

        public static bool XNT_NHAPTONDAU(string TABLEXNT_NAME, string Magiaodichpk, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_NHAPTONDAU", myArr);
        }
        #endregion

        #region Các stored liên quan đến giao dịch và ctugoc
        public static DataTable Getdata_GiaodichctTaikhoan(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_GiaodichctTaikhoan", "DATA", myArr);
        }

        public static DataTable Getdata_GiaodichctTaikhoanmuahang(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_GiaodichctTaikhoanmuahang", "DATA", myArr);
        }

        public static DataTable Getdata_GiaodichctTaikhoanGiavon(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_GiaodichctTaikhoanGiavon", "DATA", myArr);
        }
        public static DataTable Getdata_GiaodichctTaikhoan_Khonggiavon(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_GiaodichctTaikhoan_Khonggiavon", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_GiaodichctTaikhoanKiemke(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_GiaodichctTaikhoanKiemke", "DATA", myArr);
        }
        public static DataTable Getdata_VTHH_GiaodichctTaikhoanQuay(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_GiaodichctTaikhoanQuay", "DATA", myArr);
        }
        public static DataTable Getdata_GiaodichquayctTaikhoan(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_GiaodichquayctTaikhoan", "DATA", myArr);
        }

        //getdata tài khoản cho phiếu xuất trả
        public static DataTable Getdata_GiaodichXuatTractTaikhoan(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_GiaodichXuatTractTaikhoan", "DATA", myArr);
        }
        //Insert các cặp tài khoản vào ctugoc
        public static bool PRO_VTHH_InsertCtugocByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_VTHH_InsertCtugocByMagiaodichpk", myArr);
        }

        public static DataTable Getdata_Lainganhangtamtinh(string MaTk, string Madonvi, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@MaTK", SqlDbType.VarChar), MaTk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Lainganhangtamtinh", "DATA", myArr);
        }

        public static DataTable Getdata_Lichthanhtoanlaivay(string MaTk, string Madonvi, DateTime tungay, DateTime denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@MaTK", SqlDbType.VarChar), MaTk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Lichthanhtoanlaivay", "DATA", myArr);
        }
        #endregion

        #region Các stored chuyển ngày
        public static bool XNT_CREATETABLE(string TABLEXNT_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_CREATETABLE", myArr);
        }
        public static bool XNT_INSERTNEW(string TABLEXNT_NEW, string DB_NAME_XNT, string TABLEXNT_OLD, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NEW", SqlDbType.VarChar), TABLEXNT_NEW);
            parameters.Add(new SqlParameter("@TABLEXNT_OLD", SqlDbType.VarChar), TABLEXNT_OLD);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_INSERTNEW", myArr);
        }
        public static bool XNT_KHOASO_NHAP(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT, string Manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.VarChar), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_KHOASO_NHAP", myArr);
        }

        public static bool XNT_KHOASO_NHAPTONDAU(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT, string Manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.VarChar), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_KHOASO_NHAPTONDAU", myArr);
        }

        public static bool XNT_KHOASO_XUAT(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT, string Manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.VarChar), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_KHOASO_XUAT", myArr);
        }

        public static bool XNT_KHOASO_NHAPTRALAI(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT, string Manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.VarChar), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_KHOASO_NHAPTRALAI", myArr);
        }
        public static bool XNT_KHOASO_XUATBANLE(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT, string Manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.VarChar), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_KHOASO_XUATBANLE", myArr);
        }
        public static bool XNT_KHOASO_DIEUCHUYENKHO(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Madonvi, string Trangthai, string DB_NAME, string DB_NAME_XNT, string Manhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.VarChar), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Manhomptnx", SqlDbType.VarChar), Manhomptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("XNT_KHOASO_DIEUCHUYENKHO", myArr);
        }
        #endregion

        #region Các stored lấy số lượng tồn
        public static DataTable XNT_GETTONBOHANG(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Mabohang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Mabohang", SqlDbType.VarChar), Mabohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONBOHANG", "DATA", myArr);
        }
        public static DataTable XNT_GETTONKHO(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Masieuthi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONKHO", "DATA", myArr);
        }
        public static DataTable XNT_GETTONDATHANG(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manganh, string Manhomhang
            , string Makhachhang, string tuNgay, string denNgay, string ManhomptnxXuatKhac, string ManhomptnxNhapKhac,string ManhomPtnxXuatban,string ManhomPtnxNhapmua)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            parameters.Add(new SqlParameter("@ManhomptnxXuat", SqlDbType.VarChar), ManhomptnxXuatKhac);
            parameters.Add(new SqlParameter("@ManhomptnxNhap", SqlDbType.VarChar), ManhomptnxNhapKhac);
            parameters.Add(new SqlParameter("@ManhomPtnxXuatban", SqlDbType.VarChar), ManhomPtnxXuatban);
            parameters.Add(new SqlParameter("@ManhomPtnxNhapmua", SqlDbType.VarChar), ManhomPtnxNhapmua);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONDATHANG", "DATA", myArr);
        }
        public static DataTable XNT_GETTONDATHANG_KHOHANG(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manganh, string Manhomhang
            , string Makhachhang, string ListKhohang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@ListKhohang", SqlDbType.VarChar), ListKhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONDATHANG_KHOHANG", "DATA", myArr);
        }
        public static DataTable XNT_GETTONSOSANH_THUE(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Mahaiquan)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Mahaiquan", SqlDbType.VarChar), Mahaiquan);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONSOSANH_THUE", "DATA", myArr);
        }
        public static DataTable XNT_PHANTICHDENGHIXUATHANG(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manganh, string Manhomhang
            ,string tuNgay, string denNgay, string maNhomptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_PHANTICHDENGHIXUATHANG", "DATA", myArr);
        }
        public static DataTable XNT_GETTONDINHMUCMAXMIN(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manganh, string Manhomhang
            , string Makhachhang, DateTime tuNgay, DateTime denNgay, string ManhomptnxXuat, string ManhomptnxNhap)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            parameters.Add(new SqlParameter("@ManhomptnxXuat", SqlDbType.VarChar), ManhomptnxXuat);
            parameters.Add(new SqlParameter("@ManhomptnxNhap", SqlDbType.VarChar), ManhomptnxNhap);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONDINHMUCMAXMIN", "DATA", myArr);
        }
        public static DataTable XNT_GETTONDINHMUCMAXMINNOIBO(string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manganh, string Manhomhang
            , string Makhachhang, string tuNgay, string denNgay, string ManhomptnxXuat, string ManhomptnxNhap)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            parameters.Add(new SqlParameter("@ManhomptnxXuat", SqlDbType.VarChar), ManhomptnxXuat);
            parameters.Add(new SqlParameter("@ManhomptnxNhap", SqlDbType.VarChar), ManhomptnxNhap);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_GETTONDINHMUCMAXMINNOIBO", "DATA", myArr);
        }
        #endregion

        #region báo cáo vật tu hàng hóa
        //Tóm tắt bán lẻ
        public static DataTable BC_TOMTATBANLE(DateTime Tungay, DateTime Denngay, string Madonvi, string Manguoitao, string Mayban, int Group)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manguoitao", SqlDbType.VarChar), Manguoitao);
            parameters.Add(new SqlParameter("@Mayban", SqlDbType.VarChar), Mayban);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Group);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TOMTATBANLE", "DATA", myArr);
        }

        //Báo cáo bảng kê hàng tồn kho tổng hợp và chi tiết

        public static DataTable BC_TIENICH_TIMKIEM(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string MaPk, int Loai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mapk", SqlDbType.VarChar), MaPk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Loai", SqlDbType.Int), Loai);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TIENICH_TIMKIEM", "DATA", myArr);
        }
        public static DataTable BC_HANGTONKHOCT(string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
            , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, string soSanh, string soSanh1, int Groupid, int Trangthaivattu)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Sosanh", SqlDbType.VarChar), soSanh);
            parameters.Add(new SqlParameter("@Sosanh1", SqlDbType.VarChar), soSanh1);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Trangthaivt", SqlDbType.Int), Trangthaivattu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_HANGTONKHOCT", "DATA", myArr);
        }

        public static DataTable BC_MATHANGTONKHO(string TABLEXNT_NAME, string Makhohang, string Madonvi,string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_MATHANGTONKHO", "DATA", myArr);
        }

        public static DataTable BC_HANGTONKHOSERIAL(string TABLEXNT_NAME, string Madonvi, string Manhacungcap, string Manganhhang
            , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_HANGTONKHOSERIAL", "DATA", myArr);
        }

        public static DataTable BC_HANGTONKHOTH(string TABLEXNT_NAME, string Makhohang, string Manhacungcap, string Manganhhang, string Manhomhang
            , string Masieuthi, string Madonvi, string DB_NAME, string DB_NAME_XNT, string soSanh, string soSanh1, int Groupid, int Trangthaivattu)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Sosanh", SqlDbType.VarChar), soSanh);
            parameters.Add(new SqlParameter("@Sosanh1", SqlDbType.VarChar), soSanh1);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Trangthaivt", SqlDbType.Int), Trangthaivattu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_HANGTONKHOTH", "DATA", myArr);
        }

        public static DataTable BC_HANGTONKHOCTGDLUUTAM(string TABLEXNT_NAME, DateTime Ngayphatsinh, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
            , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, string soSanh, string soSanh1, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Ngayphatsinh", SqlDbType.DateTime), Ngayphatsinh);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Sosanh", SqlDbType.VarChar), soSanh);
            parameters.Add(new SqlParameter("@Sosanh1", SqlDbType.VarChar), soSanh1);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_HANGTONKHOCTGDLUUTAM", "DATA", myArr);
        }
        //Xuất bán le 
        public static DataTable BC_XUATBANLECT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANLECT", "DATA", myArr);
        }
        public static DataTable BC_XUATBANLEAMCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Groupid, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANLEAMCT", "DATA", myArr);
        }
        public static DataTable BC_XUATBANLESERIAL(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANLESERIAL", "DATA", myArr);
        }
        public static DataTable BC_XUATBANLETH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANLETH", "DATA", myArr);
        }
        public static DataTable BC_XUATBANLEAMTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Groupid, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANLEAMTH", "DATA", myArr);
        }
        //Báo cáo nhập hàng
        public static DataTable BC_NHAPHANGCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string mavuviec, int Groupid, int Tachkhuyenmai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Mavuviec", SqlDbType.VarChar), mavuviec);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Tachkhuyenmai", SqlDbType.Int), Tachkhuyenmai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANGCT", "DATA", myArr);
        }

        public static DataTable BC_NHAPHANGSERIAL(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANGSERIAL", "DATA", myArr);
        }

        public static DataTable BC_NHAPHANGTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Mavuviec, int Groupid, int Tachkhuyenmai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Mavuviec", SqlDbType.VarChar), Mavuviec);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Tachkhuyenmai", SqlDbType.Int), Tachkhuyenmai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANGTH", "DATA", myArr);
        }
        public static DataTable BC_NHAPHANG_MAHAIQUANTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Masieuthi,int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANG_MAHAIQUANTH", "DATA", myArr);
        }
        //Báo cáo xuất nhập tồn nhiều phát sinh
        public static DataTable XNT_BC_XNT(int Tonghopchitiet, string TABLEXNT_NAME, string TABLEXNT_OLD, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
           , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid, DateTime Tungay, DateTime Denngay, int Trangthai
           , string N_MUA, string N_DIEUCHINH, string N_NOIBO, string N_TRALAI, string N_KIEMKE, string N_BANBUONTRALAI, string X_BANBUON, string X_BANLE, string X_NOIBO, string X_CHUYENKHO
           , string X_DIEUCHINH, string X_TRALAI, string X_KHAC, string X_HUY, string X_KIEMKE)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tonghopchitiet", SqlDbType.VarChar), Tonghopchitiet);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@TABLEXNT_OLD", SqlDbType.VarChar), TABLEXNT_OLD);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@N_MUA", SqlDbType.VarChar), N_MUA);
            parameters.Add(new SqlParameter("@N_DIEUCHINH", SqlDbType.VarChar), N_DIEUCHINH);
            parameters.Add(new SqlParameter("@N_NOIBO", SqlDbType.VarChar), N_NOIBO);
            parameters.Add(new SqlParameter("@N_TRALAI", SqlDbType.VarChar), N_TRALAI);
            parameters.Add(new SqlParameter("@N_KIEMKE", SqlDbType.VarChar), N_KIEMKE);
            parameters.Add(new SqlParameter("@N_BANBUONTRALAI", SqlDbType.VarChar), N_BANBUONTRALAI);
            parameters.Add(new SqlParameter("@X_BANBUON", SqlDbType.VarChar), X_BANBUON);
            parameters.Add(new SqlParameter("@X_BANLE", SqlDbType.VarChar), X_BANLE);
            parameters.Add(new SqlParameter("@X_NOIBO", SqlDbType.VarChar), X_NOIBO);
            parameters.Add(new SqlParameter("@X_CHUYENKHO", SqlDbType.VarChar), X_CHUYENKHO);
            parameters.Add(new SqlParameter("@X_DIEUCHINH", SqlDbType.VarChar), X_DIEUCHINH);
            parameters.Add(new SqlParameter("@X_TRALAI", SqlDbType.VarChar), X_TRALAI);
            parameters.Add(new SqlParameter("@X_KHAC", SqlDbType.VarChar), X_KHAC);
            parameters.Add(new SqlParameter("@X_HUY", SqlDbType.VarChar), X_HUY);
            parameters.Add(new SqlParameter("@X_KIEMKE", SqlDbType.VarChar), X_KIEMKE);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_BC_XNTTUNGAYDENNGAY", "DATA", myArr);
        }

        //Báo cáo nhập hàng điều chỉnh
        public static DataTable BC_NHAPHANGDIEUCHINHCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANGDIEUCHINHCT", "DATA", myArr);
        }

        public static DataTable BC_NHAPHANGDIEUCHINHSerial(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANGDIEUCHINHSERIAL", "DATA", myArr);
        }

        public static DataTable BC_NHAPHANGDIEUCHINHTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPHANGDIEUCHINHTH", "DATA", myArr);
        }

        //Báo cáo nhập hàng xuất chuyển kho
        public static DataTable BC_CHUYENKHOCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makhoxuat, string makhonhap, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makhoxuat", SqlDbType.VarChar), Makhoxuat);
            parameters.Add(new SqlParameter("@Makhonhap", SqlDbType.VarChar), makhonhap);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_CHUYENKHOCT", "DATA", myArr);
        }
        public static DataTable BC_CHUYENKHOTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makhoxuat, string makhonhap, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makhoxuat", SqlDbType.VarChar), Makhoxuat);
            parameters.Add(new SqlParameter("@Makhonhap", SqlDbType.VarChar), makhonhap);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_CHUYENKHOTH", "DATA", myArr);
        }

        //Báo cáo xuất bán buôn
        public static DataTable BC_XUATBANBUONCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string Magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONCT", "DATA", myArr);
        }

        public static DataTable BC_Doanhsonhanvienbanhang(DateTime Tungay, DateTime Denngay, string Madonvi, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, string Magiaodichpk, string Manhanvien, string Magiaodichdongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_Doanhsonhanvienbanhang", "DATA", myArr);
        }

        public static DataTable BC_Doanhsonhanvienbanhanggiaohang(DateTime Tungay, DateTime Denngay, string Madonvi, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, string Magiaodichpk, string Manhanvien, string Magiaodichdongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_Doanhsonhanvienbanhanggiaohang", "DATA", myArr);
        }

        public static DataTable BC_XUATBANBUONCTTACHKM(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string Magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONCTTACHKM", "DATA", myArr);
        }
        public static DataTable BC_XUATBANBUON_MAHAIQUANTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Masieuthi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUON_MAHAIQUANTH", "DATA", myArr);
        }
        public static DataTable BC_XUATBANBUONXKCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string Magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONXKCT", "DATA", myArr);
        }

        public static DataTable BC_XUATBANBUONTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string Magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONTH", "DATA", myArr);
        }
        public static DataTable BC_XUATBANBUONTH_INKHO(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string Magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), Magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONTH_INKHO", "DATA", myArr);
        }
        public static DataTable BC_XUATBANBUONSERIAL(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONSERIAL", "DATA", myArr);
        }

        public static DataTable BC_XUATBANBUONCTTHEOVATTU(DateTime Tungay, DateTime Denngay, string Madonvi, string Makho, string Manhacungcap, string makhachhang, string Manganhhang, string Manhomhang, string Masieuthi, string madongop, string Manvdathang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Manvdathang", SqlDbType.VarChar), Manvdathang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATBANBUONCTTHEOVATTU", "DATA", myArr);
        }

        public static DataTable BC_XUATLECTTHEOVATTU(DateTime Tungay, DateTime Denngay, string Madonvi, string Manvdathang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manvdathang", SqlDbType.VarChar), Manvdathang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATLECTTHEOVATTU", "DATA", myArr);
        }
        // Báo cáo xuất hàng điều chỉnh

        public static DataTable BC_VTHH_XUATHANGDIEUCHINHCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_XUATHANGDIEUCHINHCT", "DATA", myArr);
        }

        public static DataTable BC_VTHH_XUATHANGDIEUCHINHTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_XUATHANGDIEUCHINHTH", "DATA", myArr);
        }
        //Báo cáo xuất hủy
        public static DataTable BC_XUATHUY_TH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATHUY_TH", "DATA", myArr);
        }
        public static DataTable BC_XUATHUY_CT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATHUY_CT", "DATA", myArr);
        }

        //Báo cáo xuất trả nhà cung cấp
        public static DataTable BC_XUATTRANCC_TH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATTRANCC_TH", "DATA", myArr);
        }
        public static DataTable BC_XUATTRANCC_CT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_XUATTRANCC_CT", "DATA", myArr);
        }

        public static DataTable BC_LAILOTH(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhohang, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_LAILOTH", "DATA", myArr);
        }


        public static DataTable XNT_BC_XNTTHUGON(string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
           , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_BC_XNTTUNGAYDENNGAYTHUGON", "DATA", myArr);
        }
        public static DataTable XNT_BC_XNTTHUGONSL(string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
           , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_BC_XNTTUNGAYDENNGAYTHUGONSL", "DATA", myArr);
        }
        public static DataTable XNT_BC_XNTTHUGONTAMTINH(string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
           , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_BC_XNTTHUGONTAMTINH", "DATA", myArr);
        }
        public static DataTable XNT_BC_XNTTHUGONGIABAN(string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
           , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_BC_XNTTHUGONGIABAN", "DATA", myArr);
        }
        public static DataTable XNT_BC_XNTTUNGAYDENNGAYTHUGON_HQ(string TABLEXNT_NAME, string Makhohang, string Madonvi, string Manhacungcap, string Manganhhang
           , string Manhomhang, string Masieuthi, string DB_NAME, string DB_NAME_XNT, int Groupid, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("XNT_BC_XNTTUNGAYDENNGAYTHUGON_HQ", "DATA", myArr);
        }
        public static DataTable BC_NHAPBANBUONTLTH(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPBANBUONTLTH", "DATA", myArr);
        }

        public static DataTable BC_NHAPBANBUONTLCT(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPBANBUONTLCT", "DATA", myArr);
        }

        public static DataTable BC_NHAPBANBUONTLCTTheodongop(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string magiaodichdongop, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), magiaodichdongop);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPBANBUONTLCTTheodongop", "DATA", myArr);
        }

        public static DataTable BC_NHAPBANBUONTLCTTheodongopthungle(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Makhachhang, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, string magiaodichdongop, int thung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Magiaodichdongop", SqlDbType.VarChar), magiaodichdongop);
            parameters.Add(new SqlParameter("@thungle", SqlDbType.Int), thung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPBANBUONTLCTTheodongopthungle", "DATA", myArr);
        }

        public static DataTable BC_NHAPBANBUONTLSERIAL(DateTime Tungay, DateTime Denngay, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string Manguoinhap, string Masieuthi, int Trangthai, string Magiaodichpk, string Manhanvien, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), Manguoinhap);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_NHAPBANBUONTLSERIAL", "DATA", myArr);
        }

        //Thẻ kho vật tư hàng hóa
        public static DataTable BC_VTHH_THEKHO(DateTime Tungay, DateTime Denngay, string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Manganhhang, string Manhomhang
            , string Masieuthi, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_THEKHO", "DATA", myArr);
        }
        //sổ chi tiết vật tư
        public static DataTable BC_VTHH_SOCHITIETVATTU(DateTime Tungay, DateTime Denngay, string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Manganhhang, string Manhomhang
            , string Masieuthi, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SOCHITIETVATTU", "DATA", myArr);
        }

        public static DataTable BC_VTHH_THEKHOTHEOGIAODICHTONG(DateTime Tungay, DateTime Denngay, string DB_NAME_XNT, string TABLEXNT_NAME, string Makhohang, string Manganhhang, string Manhomhang
           , string Masieuthi, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_THEKHOTHEOGIAODICHTONG", "DATA", myArr);
        }

        public static DataTable BC_VTHH_SOCHITIETBANHANG(DateTime Tungay, DateTime Denngay, string Makhachhang, string Makhohang, string Manganhhang, string Manhomhang, string Masieuthi, string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SOCHITIETBANHANG", "DATA", myArr);
        }
        public static DataTable BC_VTHH_SOCHITIETBANHANG_HQ(DateTime Tungay, DateTime Denngay, string Makhachhang, string Makhohang, string Manganhhang, string Manhomhang, string Masieuthi, string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SOCHITIETBANHANG_HQ", "DATA", myArr);
        }
        public static DataTable BC_VTHH_S16_DNN(DateTime Tungay, DateTime Denngay, string Makhachhang, string Makhohang, string Manganhhang, string Manhomhang, string Masieuthi, string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_S16_DNN", "DATA", myArr);
        }
        public static DataTable BC_VTHH_SOCHITIETMUAHANG(DateTime Tungay, DateTime Denngay, string Makhachhang, string Makhohang, string Manganhhang, string Manhomhang, string Masieuthi, string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SOCHITIETMUAHANG", "DATA", myArr);
        }
        public static DataTable BC_VTHH_SOCHITIETMUAHANG_MAHQ(DateTime Tungay, DateTime Denngay, string Makhachhang, string Makhohang, string Manganhhang, string Manhomhang, string Masieuthi, string Madonvi, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SOCHITIETMUAHANG_MAHQ", "DATA", myArr);
        }
        public static DataTable BC_VTHH_SONHATKYBANHANG(DateTime Tungay, DateTime Denngay,string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SONHATKYBANHANG", "DATA", myArr);
        }
        public static DataTable BC_VTHH_SONHATKYMUAHANG(DateTime Tungay, DateTime Denngay, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_SONHATKYMUAHANG", "DATA", myArr);
        }
        public static DataTable BC_VTHH_DONCHUAXUAT(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhachhang, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Manhanvienbh", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_DONCHUAXUAT", "DATA", myArr);
        }

        public static DataTable BC_VTHH_KHUYENMAIXUATBAN(DateTime Tungay, DateTime Denngay, string Madonvi, string Manganhhang, string Manhomhang, string Masieuthi, string Manhanvien, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_KHUYENMAIXUATBAN", "DATA", myArr);
        }
        public static DataTable BC_VTHH_KHUYENMAIXUATBAN_CT(DateTime Tungay, DateTime Denngay, string Madonvi, string Manganhhang, string Manhomhang, string Masieuthi, string Manhanvien, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_KHUYENMAIXUATBAN_CT", "DATA", myArr);
        }
        //public static DataTable BC_TONGHOPXUATBANTRALAI(DateTime Tungay, DateTime Denngay, string Madonvi, string Makho, string Manganhhang, string Manhomhang)
        //{
        //    ListDictionary parameters = new ListDictionary();
        //    parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
        //    parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
        //    parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
        //    parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
        //    parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
        //    parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
        //    DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
        //    parameters.CopyTo(myArr, 0);
        //    return ExecuteSPReader("BC_TONGHOPXUATBANTRALAI", "DATA", myArr);
        //}

        public static DataTable BC_TONGHOPXUATBANTRALAI(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhachhang, string Manhanvien, string Magiaodich, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TONGHOPXUATBANTRALAI", "DATA", myArr);
        }
        public static DataTable BC_TONGHOPXUATBANTRALAI_GHBH(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhachhang
            , string Manhanvien,string Manhanviengh, string Magiaodich, int Groupid,string Manganh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Manhanviengh", SqlDbType.VarChar), Manhanviengh);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganh);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TONGHOPXUATBANTRALAI_GHBH", "DATA", myArr);
        }
        public static DataTable BC_CHITIET_XUATBANTRALAI(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhachhang, string Manhanvien, string Magiaodich, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_CHITIET_XUATBANTRALAI", "DATA", myArr);
        }

        public static DataTable BC_TONGHOPXUATBANTRALAITHEODG(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhachhang, string Manhanvien, string Magiaodich, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TONGHOPXUATBANTRALAITHEODG", "DATA", myArr);
        }

        public static DataTable BC_CHITIET_XUATBANTRALAITHEODG(DateTime Tungay, DateTime Denngay, string Madonvi, string Makhachhang, string Manhanvien, string Magiaodich, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_CHITIET_XUATBANTRALAITHEODG", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_ExportexcelKH(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_ExportexcelKH", "DATA", myArr);
        }

        public static DataTable BC_Chenhlechgiavon(string TABLEXNT_NAME, string TABLEXNT_NAME2, string Makhohang, string Manhacungcap, string Manganhhang, string Manhomhang, int Trangthaivattu
            , string Masieuthi, string Madonvi, string DB_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME2", SqlDbType.VarChar), TABLEXNT_NAME2);
            parameters.Add(new SqlParameter("@Makhohang", SqlDbType.VarChar), Makhohang);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@DB_NAME", SqlDbType.VarChar), DB_NAME);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Trangthaivt", SqlDbType.Int), Trangthaivattu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_Chenhlechgiavon", "DATA", myArr);
        }

        public static DataTable Getdata_Vattukhongphatsinhgiaodich(string TABLEXNT_NAME, string Madonvi, string Manhacungcap, string Manganhhang
            , string Manhomhang, string DB_NAME_XNT, DateTime Tungay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mancc", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganh", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhom", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Vattukhongphatsinhgiaodich", "DATA", myArr);
        }
        #endregion

        #region Báo có kế toán
        //Sổ tài khoản chữ T
        public static DataTable BC_KT_SoTKChuT(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk, string Madonvi, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_SoTKChuT", "DATA", myArr);
        }
        //Sổ nhật ký chung
        public static DataTable BC_KT_SoNhatKyChung(DateTime Tungay, DateTime Denngay, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_SoNhatKyChung", "DATA", myArr);
        }

        //Sổ cái
        public static DataTable BC_KT_SoCai(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matkno, string Matkco, string Matkdauky, string Madonvi, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matkno", SqlDbType.VarChar), Matkno);
            parameters.Add(new SqlParameter("@Matkco", SqlDbType.VarChar), Matkco);
            parameters.Add(new SqlParameter("@Matkdauky", SqlDbType.VarChar), Matkdauky);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_SoCai", "DATA", myArr);
        }

        //Sổ Chi tiết tk
        public static DataTable BC_KT_SoChiTietTK(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk, string Madonvi, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_SoChiTietTK", "DATA", myArr);
        }

        public static DataTable BC_KT_CONGNOTH(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk
            , string Madonvi, string madoituong, string Thang, string Nam, string Mangoaite)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            parameters.Add(new SqlParameter("@Mangoaite", SqlDbType.VarChar), Mangoaite);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNOTH", "DATA", myArr);
        }
        public static DataTable BC_KT_CONGNOTH_ROOT(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk
            , string Madonvi, string madoituong, string Thang, string Nam, string Mangoaite)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            parameters.Add(new SqlParameter("@Mangoaite", SqlDbType.VarChar), Mangoaite);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNOTH_ROOT", "DATA", myArr);
        }
        public static DataTable BC_KT_CONGNO_NHANVIEN_TH(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNO_NHANVIEN_TH", "DATA", myArr);
        }
        public static DataTable BC_KT_CONGNOCT(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam, string Mangoaite)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            parameters.Add(new SqlParameter("@Mangoaite", SqlDbType.VarChar), Mangoaite);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNOCT", "DATA", myArr);
        }
        public static DataTable BC_KT_S14_DNN(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam, string Mangoaite)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            parameters.Add(new SqlParameter("@Mangoaite", SqlDbType.VarChar), Mangoaite);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_S14_DNN", "DATA", myArr);
        }
        public static DataTable BC_KT_Doichieucongno(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_Doichieucongno", "DATA", myArr);
        }
        public static DataTable BC_KT_DoichieucongnoTrungThanh(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_DoichieucongnoTrungThanh", "DATA", myArr);
        }
        public static DataTable BC_KT_DoichieucongnoTatThanhDL(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_DoichieucongnoTatThanhDL", "DATA", myArr);
        }
        public static DataTable BC_KT_DoichieucongnoTatThanhDLTH(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_DoichieucongnoTatThanhDLTH", "DATA", myArr);
        }
        public static DataTable BC_KT_DoichieucongnoTatThanhSALE(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_DoichieucongnoTatThanhSALE", "DATA", myArr);
        }
        public static DataTable BC_VTHH_DoanhsoTrungThanh(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_VTHH_DoanhsoTrungThanh", "DATA", myArr);
        }
        public static DataTable BC_KT_CONGNOCT_ROOT(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk
            , string Matk, string Madonvi, string madoituong, string Thang, string Nam, string Mangoaite)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            parameters.Add(new SqlParameter("@Mangoaite", SqlDbType.VarChar), Mangoaite);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNOCT_ROOT", "DATA", myArr);
        }
        public static DataTable BC_KT_CONGNO_NHANVIEN_CT(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNO_NHANVIEN_CT", "DATA", myArr);
        }
        public static DataTable BC_KT_CONGNOALLTH(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNOALLTH", "DATA", myArr);
        }

        public static DataTable BC_KT_CONGNOALLCT(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNOALLCT", "DATA", myArr);
        }
        public static DataTable BC_PHIEUTHUCHI_TH(DateTime Tungay, DateTime Denngay, string Madonvi, string Maloaict, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maloaict", SqlDbType.VarChar), Maloaict);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_PHIEUTHUCHI_TH", "DATA", myArr);
        }
        public static DataTable BC_PHIEUTHUCHI_CT(DateTime Tungay, DateTime Denngay, string Madonvi, string Maloaict, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maloaict", SqlDbType.VarChar), Maloaict);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_PHIEUTHUCHI_CT", "DATA", myArr);
        }

        public static DataTable BC_TONGHOPKHOANMUCCHIPHI(DateTime Tungay, DateTime Denngay, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TONGHOPKHOANMUCCHIPHI", "DATA", myArr);
        }

        public static DataTable BC_KT_KHOANMUCCHIPHI_TH(DateTime Tungay, DateTime Denngay, string Madonvi, string Makmcp, string Matk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makmcp", SqlDbType.VarChar), Makmcp);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_KHOANMUCCHIPHI_TH", "DATA", myArr);
        }

        public static DataTable BC_KT_KHOANMUCCHIPHI_CT(DateTime Tungay, DateTime Denngay, string Madonvi, string Makmcp, string Matk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Makmcp", SqlDbType.VarChar), Makmcp);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_KHOANMUCCHIPHI_CT", "DATA", myArr);
        }

        public static DataTable BC_KETQUAKINHDOANH(DateTime Tungay, DateTime Denngay, string Madonvi, DateTime Tungaydk, DateTime Denngaydk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KETQUAKINHDOANH", "DATA", myArr);
        }

        public static DataTable BC_BANGCANDOIPHATSINH(DateTime Tungay, DateTime Denngay, string Madonvi, DateTime Tungaydk, DateTime Denngaydk, int Nam, int Thang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_BANGCANDOIPHATSINH", "DATA", myArr);
        }

        public static DataTable BC_QUYTIENMATHTKT_TH(DateTime Tungay, DateTime Denngay, string Mataikhoan, string Madonvi)
        {
            int thang = Tungay.Month;
            int Nam = Tungay.Year;
            DataTable dtThangKs = new DataTable();
            DateTime tungaydk = DateTime.Parse(Nam.ToString() + "-" + thang.ToString() + "-01");
            thang = thang - 1;
            if (thang == 0)
            {
                thang = 12;
                Nam = Nam - 1;
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                if (thang == 12)
                {
                    tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            else
            {
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int thangchotso = 0;
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thangchotso);
                //nếu tháng chốt sổ không liền trước tháng hiện tại xem báo cáo thì gán lại
                if (thangchotso < thang) thang = thangchotso;
                if (thang == 0)
                {
                    Nam = Nam - 1;
                    dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                    int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                    if (thang == 12)
                    {
                        tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                    }
                    else
                    {
                        tungaydk = DateTime.Parse((Nam).ToString() + "-" + (thang + 1).ToString() + "-01");
                    }
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Tungay.AddDays(-1));
            parameters.Add(new SqlParameter("@Mataikhoan", SqlDbType.VarChar), Mataikhoan);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_QUYTIENMATHTKT_TH", "DATA", myArr);
        }

        public static DataTable BC_KT_QUYTIENMATHTKT_THTP(DateTime Tungay, DateTime Denngay, string Mataikhoan, string Madonvi)
        {
            int thang = Tungay.Month;
            int Nam = Tungay.Year;
            DataTable dtThangKs = new DataTable();
            DateTime tungaydk = DateTime.Parse(Nam.ToString() + "-" + thang.ToString() + "-01");
            thang = thang - 1;
            if (thang == 0)
            {
                thang = 12;
                Nam = Nam - 1;
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                if (thang == 12)
                {
                    tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            else
            {
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int thangchotso = 0;
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thangchotso);
                //nếu tháng chốt sổ không liền trước tháng hiện tại xem báo cáo thì gán lại
                if (thangchotso < thang) thang = thangchotso;
                if (thang == 0)
                {
                    Nam = Nam - 1;
                    dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                    int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                    if (thang == 12)
                    {
                        tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                    }
                    else
                    {
                        tungaydk = DateTime.Parse((Nam).ToString() + "-" + (thang + 1).ToString() + "-01");
                    }
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Tungay.AddDays(-1));
            parameters.Add(new SqlParameter("@Mataikhoan", SqlDbType.VarChar), Mataikhoan);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_QUYTIENMATHTKT_THTP", "DATA", myArr);
        }

        public static DataTable Getdata_KT_Tonquy(DateTime Tungay, DateTime Denngay, string Mataikhoan, string Madonvi, string Matknganhang)
        {
            int thang = Tungay.Month;
            int Nam = Tungay.Year;
            DataTable dtThangKs = new DataTable();
            DateTime tungaydk = DateTime.Parse(Nam.ToString() + "-" + thang.ToString() + "-01");
            thang = thang - 1;
            if (thang == 0)
            {
                thang = 12;
                Nam = Nam - 1;
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                if (thang == 12)
                {
                    tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            else
            {
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int thangchotso = 0;
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thangchotso);
                //nếu tháng chốt sổ không liền trước tháng hiện tại xem báo cáo thì gán lại
                if (thangchotso < thang) thang = thangchotso;
                if (thang == 0)
                {
                    Nam = Nam - 1;
                    dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                    int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                    if (thang == 12)
                    {
                        tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                    }
                    else
                    {
                        tungaydk = DateTime.Parse((Nam).ToString() + "-" + (thang + 1).ToString() + "-01");
                    }
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Tungay.AddDays(-1));
            parameters.Add(new SqlParameter("@Mataikhoan", SqlDbType.VarChar), Mataikhoan);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Matknganhang", SqlDbType.VarChar), Matknganhang);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_KT_Tonquy", "DATA", myArr);
        }

        public static DataTable BC_KT_BANGKEPHIEU_THUCHI(DateTime Tungay, DateTime Denngay, string Maloaict, string Madonvi, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Maloaict", SqlDbType.VarChar), Maloaict);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_BANGKEPHIEU_THUCHI", "DATA", myArr);
        }

        public static DataTable BC_KT_BANGKEPHIEU_THUCHINGANHANG(DateTime Tungay, DateTime Denngay, string Maloaict, string Madonvi, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Maloaict", SqlDbType.VarChar), Maloaict);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_BANGKEPHIEU_THUCHINGANHANG", "DATA", myArr);
        }
        public static DataTable BC_QUYTIENMATHTKT_CT(DateTime Tungay, DateTime Denngay, string Mataikhoan, string Madonvi)
        {
            int thang = Tungay.Month;
            int Nam = Tungay.Year;
            DataTable dtThangKs = new DataTable();
            DateTime tungaydk = DateTime.Parse(Nam.ToString() + "-" + thang.ToString() + "-01");
            thang = thang - 1;
            if (thang == 0)
            {
                thang = 12;
                Nam = Nam - 1;
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                if (thang == 12)
                {
                    tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }
            else
            {
                dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                int thangchotso = 0;
                int.TryParse(dtThangKs.Rows[0][0].ToString(), out thangchotso);
                //nếu tháng chốt sổ không liền trước tháng hiện tại xem báo cáo thì gán lại
                if (thangchotso < thang) thang = thangchotso;
                if (thang == 0)
                {
                    Nam = Nam - 1;
                    dtThangKs = DB.Getdata_KT_MaxThangChotSo(Madonvi, Nam);
                    int.TryParse(dtThangKs.Rows[0][0].ToString(), out thang);
                    if (thang == 12)
                    {
                        tungaydk = DateTime.Parse((Nam + 1).ToString() + "-" + (1).ToString() + "-01");
                    }
                    else
                    {
                        tungaydk = DateTime.Parse((Nam).ToString() + "-" + (thang + 1).ToString() + "-01");
                    }
                }
                else
                {
                    tungaydk = DateTime.Parse(Nam.ToString() + "-" + (thang + 1).ToString() + "-01");
                }
            }

            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Tungay.AddDays(-1));
            parameters.Add(new SqlParameter("@Mataikhoan", SqlDbType.VarChar), Mataikhoan);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_QUYTIENMATHTKT_CT", "DATA", myArr);
        }

        public static DataTable BC_KT_CONGNO_TH_NVKH(DateTime Tungay, DateTime Denngay, DateTime Tungaydk, DateTime Denngaydk, string Matk, string Madonvi, string madoituong, string Thang, string Nam)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Matk", SqlDbType.VarChar), Matk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituong", SqlDbType.VarChar), madoituong);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.VarChar), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar), Nam);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_CONGNO_TH_NVKH", "DATA", myArr);
        }

        public static bool VTHH_TINHGIAVON(string Madonvi, DateTime Tungay, DateTime Denngay, string Pttinhgia, string TABLEXNT_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Pttinhgia", SqlDbType.VarChar), Pttinhgia);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("VTHH_TINHGIAVON", myArr);
        }

        public static bool VTHH_TINHGIAVON_TACHKHO(string Madonvi, DateTime Tungay, DateTime Denngay, string Pttinhgia, string TABLEXNT_NAME, string DB_NAME_XNT)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Pttinhgia", SqlDbType.VarChar), Pttinhgia);
            parameters.Add(new SqlParameter("@DB_NAME_XNT", SqlDbType.VarChar), DB_NAME_XNT);
            parameters.Add(new SqlParameter("@TABLEXNT_NAME", SqlDbType.VarChar), TABLEXNT_NAME);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("VTHH_TINHGIAVON_TACHKHO", myArr);
        }

        public static DataTable BC_KT_Tienguinganhangtheosotaikhoan(DateTime Tungay, DateTime Denngay, string Madonvi, string matk, string matknganhang, DateTime Tungaydk, DateTime Denngaydk, int Nam, int Thang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mataikhoan", SqlDbType.VarChar), matk);
            parameters.Add(new SqlParameter("@Matknganhang", SqlDbType.VarChar), matknganhang);
            parameters.Add(new SqlParameter("@Tungaydk", SqlDbType.DateTime), Tungaydk);
            parameters.Add(new SqlParameter("@Denngaydk", SqlDbType.DateTime), Denngaydk);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_KT_Tienguinganhangtheosotaikhoan", "DATA", myArr);
        }

        public static DataTable Getdata_KT_Kiemtrachotso(string Madonvi, string kieuchotso, int Nam, int Thang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Kieuchotso", SqlDbType.VarChar), kieuchotso);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), Nam);
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int), Thang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_KT_Kiemtrachotso", "DATA", myArr);
        }
        #endregion

        #region Phiếu in vinamilk
        public static DataTable Getdata_VTHH_Phieuinxbkmvinamilk(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbkmvinamilk", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_Phieuinxbvinamilk(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbvinamilk", "DATA", myArr);

        }
        #endregion

        #region Phiếu in masan
        public static DataTable Getdata_VTHH_Phieuinxbkmmasan(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbkmmasan", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_Phieuinxbmasan(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbmasan", "DATA", myArr);

        }

        public static DataTable Getdata_VTHH_Phieuinxbvita(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbvita", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Phieuinxbkmvita(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbkmvita", "DATA", myArr);
        }
        #endregion

        #region Phiếu in nuti
        public static DataTable Getdata_VTHH_Phieuinxbnuti(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbnuti", "DATA", myArr);
        }

        public static DataTable Getdata_VTHH_Phieuinxbkmnuti(string Madonvi, string Magiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodich);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_VTHH_Phieuinxbkmnuti", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_Phieuindongopnuti(string Madonvi, string madongop)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_Phieuindongopnuti", "DATA", myArr);
        }

        public static DataTable GetData_VTHH_PhieuindongoptheoKHnuti(string Madonvi, string madongop, string maorder)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madongop", SqlDbType.VarChar), madongop);
            parameters.Add(new SqlParameter("@Magiaodichorderby", SqlDbType.VarChar), maorder);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_VTHH_PhieuindongoptheoKHnuti", "DATA", myArr);
        }
        #endregion

        #region Báo cáo biểu đồ
        public static DataTable BC_COLUMCHARNHAPHANGTH(string tuthang, string denthang, string tunam, string dennam, string nam, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, int Trangthai, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tuthang", SqlDbType.Int), tuthang);
            parameters.Add(new SqlParameter("@Denthang", SqlDbType.Int), denthang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), nam);
            parameters.Add(new SqlParameter("@Tunam", SqlDbType.Int), tunam);
            parameters.Add(new SqlParameter("@Dennam", SqlDbType.Int), dennam);

            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_COLUMCHARNHAPHANGTH", "DATA", myArr);
        }

        public static DataTable BC_COLUMCHARTXUATBANBUONTH(string tuthang, string denthang, string tunam, string dennam, string nam, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string makhachhang, string Manganhhang, string Manhomhang, int Trangthai, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tuthang", SqlDbType.Int), tuthang);
            parameters.Add(new SqlParameter("@Denthang", SqlDbType.Int), denthang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), nam);
            parameters.Add(new SqlParameter("@Tunam", SqlDbType.Int), tunam);
            parameters.Add(new SqlParameter("@Dennam", SqlDbType.Int), dennam);

            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), makhachhang);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_COLUMCHARTXUATBANBUONTH", "DATA", myArr);
        }

        public static DataTable BC_COLUMCHARBANLETH(string tuthang, string denthang, string tunam, string dennam, string nam, string Madonvi, string MaPTNX, string Makho, string Manhacungcap, string Manganhhang, string Manhomhang, string manguoitao, int Trangthai, int Groupid)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tuthang", SqlDbType.Int), tuthang);
            parameters.Add(new SqlParameter("@Denthang", SqlDbType.Int), denthang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int), nam);
            parameters.Add(new SqlParameter("@Tunam", SqlDbType.Int), tunam);
            parameters.Add(new SqlParameter("@Dennam", SqlDbType.Int), dennam);

            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@MaPTNX", SqlDbType.VarChar), MaPTNX);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.VarChar), Makho);
            parameters.Add(new SqlParameter("@Manhacungcap", SqlDbType.VarChar), Manhacungcap);
            parameters.Add(new SqlParameter("@Manganhhang", SqlDbType.VarChar), Manganhhang);
            parameters.Add(new SqlParameter("@Manhomhang", SqlDbType.VarChar), Manhomhang);
            parameters.Add(new SqlParameter("@Manguoinhap", SqlDbType.VarChar), manguoitao);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Groupid", SqlDbType.Int), Groupid);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_COLUMCHARBANLETH", "DATA", myArr);
        }
        #endregion

        #region Vẩn tải
        public static DataTable Get_VT_Lichxe(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Get_VT_Lichxe", "DATA", myArr);

        }

        #endregion

        #region Sản xuất

        public static DataTable GetDataBaogiactByMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataBaogiactByMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetData_Sx_DondatctByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_DondatctByMapkAndMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_DondatctNCCByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_DondatctNCCByMapkAndMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_LenhsxctByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_LenhsxctByMapkAndMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_LenhsxctByMasieuthiAndMadonvi(string Masieuthi, string Madonvi,string Mactpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mactpk", SqlDbType.VarChar), Mactpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_LenhsxctByMasieuthiAndMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_DenghilinhlieuctByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_DenghilinhlieuctByMapkAndMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_DutinhNVLctByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_DutinhNVLctByMapkAndMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_DutinhNVLct_Denghi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_DutinhNVLct_Denghi", "DATA", myArr);
        }
        public static DataTable GetData_Sx_MaThanhphamByListMagiaodichpk(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_MaThanhphamByListMagiaodichpk", "DATA", myArr);
        }
        public static DataTable GetData_Sx_TinhToanDutinhNVL(string DBXNT_NAME, string Madonvi, string TBNXT_NAME, string Dondat, string Thanhpham, string Khohang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@DBXNT_NAME", SqlDbType.VarChar), DBXNT_NAME);
            parameters.Add(new SqlParameter("@TBNXT_NAME", SqlDbType.VarChar), TBNXT_NAME);
            parameters.Add(new SqlParameter("@Dondat", SqlDbType.VarChar), Dondat);
            parameters.Add(new SqlParameter("@Thanhpham", SqlDbType.VarChar), Thanhpham);
            parameters.Add(new SqlParameter("@Khohang", SqlDbType.VarChar), Khohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_TinhToanDutinhNVL", "DATA", myArr);
        }
        public static DataTable GetData_Sx_TinhToanXuatkhoNVL(string DBXNT_NAME, string Madonvi, string TBNXT_NAME, string Dondat, string Thanhpham, string Khohang, decimal Soluong)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@DBXNT_NAME", SqlDbType.VarChar), DBXNT_NAME);
            parameters.Add(new SqlParameter("@TBNXT_NAME", SqlDbType.VarChar), TBNXT_NAME);
            parameters.Add(new SqlParameter("@Dondat", SqlDbType.VarChar), Dondat);
            parameters.Add(new SqlParameter("@Thanhpham", SqlDbType.VarChar), Thanhpham);
            parameters.Add(new SqlParameter("@Khohang", SqlDbType.VarChar), Khohang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Soluong", SqlDbType.Decimal), Soluong);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_TinhToanXuatkhoNVL", "DATA", myArr);
        }
        public static DataTable GetDataMathangSanxuat(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataMathangSanxuat", "DATA", myArr);
        }

        public static DataTable GetData_Sx_Dondat_TungayDenngay(string Madonvi, int Trangthai, DateTime Tungay, DateTime Denngay, string Maptnx)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Maptnx", SqlDbType.VarChar), Maptnx);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_Dondat_TungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_Sx_Lenhsx_TungayDenngay(string Madonvi, int Trangthai, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_Lenhsx_TungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_Sx_LenhsxThanhPham_TungayDenngay(string Madonvi, int Trangthai, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_LenhsxThanhPham_TungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_Sx_LenhsxNVL_TungayDenngay(string Madonvi, int Trangthai, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_LenhsxNVL_TungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_Sx_Dutinhnvl_TungayDenngay(string Madonvi, int Trangthai, DateTime Tungay, DateTime Denngay, int Loaigiaodich)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Loaigiaodich", SqlDbType.Int), Loaigiaodich);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_Dutinhnvl_TungayDenngay", "DATA", myArr);
        }
        public static DataTable PRO_Sx_NvXacnhan_GetData(string Madonvi, string Maxacnhan, string Manghiepvu)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manghiepvu", SqlDbType.VarChar), Manghiepvu);
            parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("PRO_Sx_NvXacnhan_GetData", "DATA", myArr);
        }
        public static DataTable PRO_Sx_NvXacnhan_Create(string Madonvi, string Maxacnhan, string Manghiepvu)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manghiepvu", SqlDbType.VarChar), Manghiepvu);
            parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("PRO_Sx_NvXacnhan_Create", "DATA", myArr);
        }
        //public static DataTable PRO_Sx_NvXacNhan_Nguoidungxacnhan(string Madonvi, string Maxacnhan, string Manghiepvu, string Manhanvien, int Trangthai, string Ghichu)
        //{
        //    ListDictionary parameters = new ListDictionary();
        //    parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
        //    parameters.Add(new SqlParameter("@Manghiepvu", SqlDbType.VarChar), Manghiepvu);
        //    parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
        //    parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
        //    parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
        //    parameters.Add(new SqlParameter("@Ghichu", SqlDbType.NVarChar), Ghichu);
        //    DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
        //    parameters.CopyTo(myArr, 0);
        //    return ExecuteSPReader("PRO_Sx_NvXacNhan_Nguoidungxacnhan", "DATA", myArr);
        //}

        public static int PRO_Sx_NvXacNhan_Nguoidungxacnhan(string Madonvi, string Maxacnhan, string Manghiepvu, string Manhanvien, int Trangthai, string Ghichu)
        {
            if (string.IsNullOrEmpty(Manghiepvu))
                return 5;
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manghiepvu", SqlDbType.VarChar), Manghiepvu);
            parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Ghichu", SqlDbType.NVarChar), Ghichu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return int.Parse(ExecuteSPReaderReturnIntValue("PRO_Sx_NvXacNhan_Nguoidungxacnhan", "@ReturnVal", myArr).ToString());
        }

        public static int PRO_Sx_NvXacNhan_Checkphieu(string Madonvi, string Maxacnhan, string Manghiepvu)
        {
            if (string.IsNullOrEmpty(Manghiepvu))
                return 1;
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manghiepvu", SqlDbType.VarChar), Manghiepvu);
            parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return int.Parse(ExecuteSPReaderReturnIntValue("PRO_Sx_NvXacNhan_Checkphieu", "@ReturnVal", myArr).ToString());
        }

        public static DataTable PRO_Sx_NvXacNhan_Checknguoidung(string Madonvi, string Maxacnhan, string Manghiepvu, string Manhanvien)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manghiepvu", SqlDbType.VarChar), Manghiepvu);
            parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
            parameters.Add(new SqlParameter("@Manhanvien", SqlDbType.VarChar), Manhanvien);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("PRO_Sx_NvXacNhan_Checknguoidung", "DATA", myArr);
        }

        public static DataTable GetData_Sx_SxDmXacnhanct(string Madonvi, string Maxacnhan)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maxacnhan", SqlDbType.VarChar), Maxacnhan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_SxDmXacnhanct", "DATA", myArr);
        }
        public static DataTable GetData_Sx_SxKyGiathanhct(string Madonvi, string Maky, int Thangdky, int Namdky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            parameters.Add(new SqlParameter("@Thangdky", SqlDbType.Int), Thangdky);
            parameters.Add(new SqlParameter("@Namdky", SqlDbType.Int), Namdky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_SxKyGiathanhct", "DATA", myArr);
        }
        public static DataTable GetData_Sx_GiaodichDodangdky(string Madonvi, int Flag)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Flag", SqlDbType.Int), Flag);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_GiaodichDodangdky", "DATA", myArr);
        }
        public static DataTable GetData_Sx_SxKyGiathanh(string Madonvi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_SxKyGiathanh", "DATA", myArr);
        }
        public static DataTable GetData_Sx_ThanhphamTrongKyGiaThanh(string Trangthai, string Madonvi, string maNhomptnx, DateTime tuNgay, DateTime denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.DateTime), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.DateTime), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_ThanhphamTrongKyGiaThanh", "DATA", myArr);
        }

        public static DataTable GetData_Sx_Denghilinhlieu_TungayDenngay(string Madonvi, int Trangthai, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_Denghilinhlieu_TungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_Sx_ThanhphamDaKhaibaoDtthcp(string Madonvi, string Madoituongtaphop, string Masieuthi, int _Case)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madoituongtaphop", SqlDbType.VarChar), Madoituongtaphop);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Case", SqlDbType.Int), _Case);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_ThanhphamDaKhaibaoDtthcp", "DATA", myArr);
        }
        public static DataTable Getdata_SxPhanbochiphichung(string Madonvi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_SxPhanbochiphichung", "DATA", myArr);
        }
        public static DataTable Getdata_SxPhanbochiphichungSaveRef(string Madonvi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_SxPhanbochiphichungSaveRef", "DATA", myArr);
        }
        public static DataTable Getdata_SxPhanbochiphichungct(string Madonvi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_SxPhanbochiphichungct", "DATA", myArr);
        }
        public static DataTable Getdata_SxDoituongThcp_TrungKyGiaThanh(string Madonvi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_SxDoituongThcp_TrungKyGiaThanh", "DATA", myArr);
        }
        public static DataTable GetData_Sx_ThanhphamDodangTrongKy(int Trangthai, string Madonvi, string maNhomptnx, string Maky, int Thangdky, int Namdky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            parameters.Add(new SqlParameter("@Thangdky", SqlDbType.Int), Thangdky);
            parameters.Add(new SqlParameter("@Namdky", SqlDbType.Int), Namdky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_ThanhphamDodangTrongKy", "DATA", myArr);
        }
        public static DataTable GetData_Sx_LenhsxNVL_ByMagiaodichpk(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_LenhsxNVL_ByMagiaodichpk", "DATA", myArr);
        }

        public static DataTable GetData_Sx_BangtinhGiathanhTrongKy(int Trangthai, string Madonvi, string maNhomptnx, string Maky, int Thangdky, int Namdky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            parameters.Add(new SqlParameter("@Thangdky", SqlDbType.Int), Thangdky);
            parameters.Add(new SqlParameter("@Namdky", SqlDbType.Int), Namdky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Sx_BangtinhGiathanhTrongKy", "DATA", myArr);
        }
        public static DataTable Getdata_Sx_DutinhNVLctByMa(string Ma, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Ma);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_Sx_DutinhNVLctByMa", "DATA", myArr);
        }

        public static DataTable Getdata_SxDataImportKetchuyenChiphi(string Madonvi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("Getdata_SxDataImportKetchuyenChiphi", "DATA", myArr);
        }
        public static bool PRO_Sx_UpdateGiaNhapKho(string Madonvi, decimal Giathanh, string Masieuthi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Giathanh", SqlDbType.Decimal), Giathanh);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_Sx_UpdateGiaNhapKho", myArr);
        }
        public static bool PRO_Sx_UpdateGiaXuatKho(string Madonvi, decimal Giathanh, string Masieuthi, string Maky)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Giathanh", SqlDbType.Decimal), Giathanh);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Maky", SqlDbType.VarChar), Maky);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_Sx_UpdateGiaXuatKho", myArr);
        }
        public static bool PRO_VTHH_UpdateGiaodichct_ChiphiMuahang(string Madonvi, decimal Chiphikhac, string Masieuthi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Chiphikhac", SqlDbType.Decimal), Chiphikhac);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_VTHH_UpdateGiaodichct_ChiphiMuahang", myArr);
        }
        public static bool PRO_VTHH_UpdateGiaodichct_PhanboChietkhau(string Madonvi, decimal Tienck,decimal Tiencknt, string Masieuthi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tienck", SqlDbType.Decimal), Tienck);
            parameters.Add(new SqlParameter("@Tiencknt", SqlDbType.Decimal), Tiencknt);
            parameters.Add(new SqlParameter("@Masieuthi", SqlDbType.VarChar), Masieuthi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_VTHH_UpdateGiaodichct_PhanboChietkhau", myArr);
        }
        public static bool PRO_Sx_UpdateTrangthaiphieu(string Madonvi, string TableName, string Magiaodichpk, string Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tablename", SqlDbType.VarChar), TableName);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_Sx_UpdateTrangthaiphieu", myArr);
        }
        public static bool PRO_Sx_Updatestatus(string Madonvi, string TableName, string ColumMapk, string Mapk, string Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tablename", SqlDbType.VarChar), TableName);
            parameters.Add(new SqlParameter("@Colummapk", SqlDbType.VarChar), ColumMapk);
            parameters.Add(new SqlParameter("@Mapk", SqlDbType.VarChar), Mapk);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.VarChar), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_Sx_Updatestatus", myArr);
        }
        public static bool PRO_Sx_UpdateTrangthaibom(string Madonvi, string Magiaodichpk, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mactsx", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReaderReturnBool("PRO_Sx_UpdateTrangthaibom", myArr);
        }

        public static DataTable GetData_DathangctByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_DathangctByMapkAndMadonvi", "DATA", myArr);
        }

        public static DataTable GetData_DenghixuathangctByMapkAndMadonvi(string Magiaodichpk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_DenghixuathangctByMapkAndMadonvi", "DATA", myArr);
        }

        #endregion

        #region Báo cáo sản xuất
        public static DataTable BC_SX_TIENDOSANXUAT(string Madonvi, string Magiaodichpk, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_SX_TIENDOSANXUAT", "DATA", myArr);
        }
        public static DataTable BC_SX_XUATKHOTHEOLENHSX(string Madonvi, string Magiaodichpk, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_SX_XUATKHOTHEOLENHSX", "DATA", myArr);
        }
        public static DataTable BC_SX_XUATKHOTHEODONDAT(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_SX_XUATKHOTHEODONDAT", "DATA", myArr);
        }
        #endregion
        #region Nhân sự
        public static DataTable GetData_NS_Bangchamcongct_By_Mabangchamcong(string Mabangchamcong, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mabangchamcong", SqlDbType.VarChar), Mabangchamcong);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_NS_Bangchamcongct_By_Mabangchamcong", "DATA", myArr);
        }
        public static DataTable GetData_NS_Bangchamcongct_By_Mabophan(string Mabophan, int Trangthaisudung)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mabophan", SqlDbType.VarChar), Mabophan);
            parameters.Add(new SqlParameter("@Trangthaisudung", SqlDbType.Int), Trangthaisudung);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_NS_Bangchamcongct_By_Mabophan", "DATA", myArr);
        }
        public static DataTable GetDataBangluongTungayDenngay(string Madonvi,DateTime Tungay, DateTime Denngay, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataBangluongTungayDenngay", "DATA", myArr);
        }
        public static DataTable GetDataBangChamcongTungayDenngay(string Madonvi, DateTime Tungay, DateTime Denngay, int Trangthai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataBangChamcongTungayDenngay", "DATA", myArr);
        }
        
        #endregion

        #region Tài sản

        public static DataTable GetData_Ts_LoaitaisanByLoaihang(string Madonvi, int Loaihang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaihang", SqlDbType.Int), Loaihang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_LoaitaisanByLoaihang", "DATA", myArr);
        }

        public static DataTable GetData_Ts_NhomtaisanByLoaihang(string Madonvi, int Loaihang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaihang", SqlDbType.Int), Loaihang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_NhomtaisanByLoaihang", "DATA", myArr);
        }

        public static DataTable GetData_Ts_TsTaisanByMadonvi(string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_TsTaisanByMadonvi", "DATA", myArr);
        }
        public static DataTable GetData_Ts_TsGiaodich_By_Magiaodichpk(string Madonvi,string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_TsGiaodich_By_Magiaodichpk", "DATA", myArr);
        }
        public static DataTable GetData_Ts_TsGiaodichct_By_Magiaodichpk(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_TsGiaodichct_By_Magiaodichpk", "DATA", myArr);
        }
        public static DataTable GetData_Ts_GiaodichByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, string tuNgay, string denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_GiaodichByTungayDenngay", "DATA", myArr);
        }

        public static DataTable GetData_Ts_KhauhaoctByTaisan(string Madonvi, string tuNgay, string denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.VarChar), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_KhauhaoctByTaisan", "DATA", myArr);
        }

        public static DataTable GetData_Ts_KhauhaoByTungayDenngay(string Trangthai, string Madonvi, string maNhomptnx, string tuNgay, string denNgay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@maNhomptnx", SqlDbType.VarChar), maNhomptnx);
            parameters.Add(new SqlParameter("@maDonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@trangThai", SqlDbType.VarChar), Trangthai);
            parameters.Add(new SqlParameter("@tuNgay", SqlDbType.VarChar), tuNgay);
            parameters.Add(new SqlParameter("@denNgay", SqlDbType.VarChar), denNgay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_KhauhaoByTungayDenngay", "DATA", myArr);
        }
        public static DataTable GetData_Ts_TsKhauhao_By_Magiaodichpk(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_TsKhauhao_By_Magiaodichpk", "DATA", myArr);
        }
        public static DataTable GetData_Ts_TsKhauhaoct_By_Magiaodichpk(string Madonvi, string Magiaodichpk)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Magiaodichpk", SqlDbType.VarChar), Magiaodichpk);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Ts_TsKhauhaoct_By_Magiaodichpk", "DATA", myArr);
        }
        public static DataTable BC_Ts_Sotaisancodinh(string Madonvi, int Loaihang, string Tungay, string Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaihang", SqlDbType.Int), Loaihang);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_Ts_Sotaisancodinh", "DATA", myArr);
        }
        public static DataTable BC_TS_Sotheodoitaisantainoisudung(string Madonvi, int Loaihang, string Tungay, string Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaihang", SqlDbType.Int), Loaihang);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TS_Sotheodoitaisantainoisudung", "DATA", myArr);
        }
        public static DataTable BC_TS_Thetaisancodinh(string Madonvi, int Loaihang, string Mataisan, string Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaihang", SqlDbType.Int), Loaihang);
            parameters.Add(new SqlParameter("@Mataisan", SqlDbType.Date), Mataisan);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_TS_Thetaisancodinh", "DATA", myArr);
        }
        
        #endregion

        #region Xây dựng

        public static DataTable GetDataDenghittByMadenghi(string maCtupk, string Madonvi)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madenghi", SqlDbType.VarChar), maCtupk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataDenghittByMadenghi", "DATA", myArr);
        }

        public static DataTable GetDataDenghittByMakhachhang(string Makhachhang, string Madonvi, DateTime Ngaychungtu)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.VarChar), Makhachhang);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Ngaychungtu", SqlDbType.DateTime), Ngaychungtu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetDataDenghittByMakhachhang", "DATA", myArr);
        }
        public static DataTable GetData_XD_DutoanctByMadutoan(string Madonvi, string Madutoan)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madutoan", SqlDbType.VarChar), Madutoan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_DutoanctByMadutoan", "DATA", myArr);
        }

        // Lấy dữ liệu theo  bảng công trình
        public static DataTable GetData_XD_Dulieucongtrinh(string Madonvi, string Macongtrinh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madutoan", SqlDbType.VarChar), Macongtrinh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_Dulieucongtrinh", "DATA", myArr);
        }

        public static DataTable GetData_XD_DutoanTungayDenngay(string Madonvi, DateTime Tungay, DateTime Denngay, int Trangthai, int Loai)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int), Trangthai);
            parameters.Add(new SqlParameter("@Loai", SqlDbType.Int), Loai);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_DutoanTungayDenngay", "DATA", myArr);
        }

        public static DataTable GetData_XD_Tonghopvattudutoan(string Madonvi, string Madutoan)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madutoan", SqlDbType.VarChar), Madutoan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_Tonghopvattudutoan", "DATA", myArr);
        }
        public static DataTable GetData_XD_Tonghopvattudutoantheocongtrinh(string Madonvi, string Madutoan)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madutoan", SqlDbType.VarChar), Madutoan);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_Tonghopvattudutoantheocongtrinh", "DATA", myArr);
        }

        public static DataTable GetData_XD_ThicongctByMaOrCongtrinh(string Madonvi, string Mathicong,string Macongtrinh)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Mathicong", SqlDbType.VarChar), Mathicong);
            parameters.Add(new SqlParameter("@Macongtrinh", SqlDbType.VarChar), Macongtrinh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_ThicongctByMaOrCongtrinh", "DATA", myArr);
        }

        public static DataTable GetData_XD_Tonghopvattuthicongtheocongtrinh(string Madonvi, string Mathicong)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Madutoan", SqlDbType.VarChar), Mathicong);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_XD_Tonghopvattuthicongtheocongtrinh", "DATA", myArr);
        }

        
        
        #endregion

        internal static DataTable GetdataDenghitungaydenngay(string Madonvi, DateTime Tungay, DateTime Denngay)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetdataDenghitungaydenngay", "DATA", myArr);
        }

        internal static DataTable GetData_Bangketien_Mactpk(string Mactpk,string Madonvi, string Loaict)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mactpk", SqlDbType.DateTime), Mactpk);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Loaict", SqlDbType.VarChar), Loaict);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("GetData_Bangketien_Mactpk", "DATA", myArr);
        }

        internal static DataTable BC_Donhanggiaohangthanhcong(DateTime Tungay, DateTime Denngay, string Madonvi, string Manhanviendathang)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Manhanviendathang", SqlDbType.VarChar), Manhanviendathang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_Donhanggiaohangthanhcong", "DATA", myArr);
        }

        internal static DataTable BC_Bangketien(DateTime Tungay, DateTime Denngay, string Madonvi, string Tendangnhap)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonvi", SqlDbType.VarChar), Madonvi);
            parameters.Add(new SqlParameter("@Tendangnhap", SqlDbType.VarChar), Tendangnhap);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.DateTime), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.DateTime), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return ExecuteSPReader("BC_Bangketien", "DATA", myArr);
        }
    }
}
