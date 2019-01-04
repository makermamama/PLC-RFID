using System;
using System.Data;
using System.Data.OleDb;

namespace RFID_RW.db
{
    class Access
    {
        public static String Unwrite = "未写入";

        public static String Havewrite = "已写入";

        public const  String WriteFail = " 写入失败";

        public static String UnCheck = "未检测";

        public static String HaveCheck = "已检测";

        public static String FailCheck = "检测标签数据不匹配";

        public static int Start = 0;

        public static int end  = 10000*10000;

        private static OleDbConnection conn;


        public static void LeadRFIDTag(DataTable Tags)
        {
            OleDbConnection cn = GetDbConnection();
            OleDbTransaction transaction = cn.BeginTransaction();

            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.Transaction = transaction;
                foreach (DataRow row in Tags.Rows)
                {
                    String sql = String.Format("INSERT INTO TRFID (Fdata,FStatus,FCheck)VALUES('{0}','{1}','{2}')", row["Fdata"], row["FStatus"],row["FCheck"]);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        public static DataSet GetTopfiveHundred()
        {
            System.Data.OleDb.OleDbConnection cn = GetDbConnection();
            try
            {
                DataSet dt = new DataSet();
                string selectCommandText = String.Format("select top 10 * from [TRFID] where ( FStatus ='{0}'or FCheck ='{3}') and ID >= {1} and ID <= {2} ORDER BY Fdata ", Unwrite, Start, end, UnCheck);
                OleDbDataAdapter oda = new OleDbDataAdapter(selectCommandText, cn);
                oda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        /// <summary>
        /// 跟新写入数据状态
        /// </summary>
        /// <param name="msg"></param>
        /// <param name=""></param>
        public static void  UpdataOneWirte(String msg,String Status)
        {
            OleDbConnection cn = GetDbConnection();
            OleDbTransaction transaction = cn.BeginTransaction();
            try
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.Transaction = transaction;
                String sql = String.Format("update TRFID set FStatus = '{0}' where Fdata = '{1}'", Status, msg);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        /// <summary>
        /// 跟新写入数据状态
        /// </summary>
        /// <param name="msg"></param>
        /// <param name=""></param>
        public static void UpdataOneCheck(String msg, String Status)
        {
            OleDbConnection cn = GetDbConnection();
            OleDbTransaction transaction = cn.BeginTransaction();
            try
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.Transaction = transaction;
                String sql = String.Format("update TRFID set FCheck = '{0}' where Fdata = '{1}'", Status, msg);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        public static int GetIdByData(String Data)
        {
            OleDbConnection cn = GetDbConnection();
            OleDbTransaction transaction = cn.BeginTransaction();
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cmd.Transaction = transaction;
                String sql = String.Format("select ID from [TRFID] where Fdata ='{0}'", Data);
                cmd.CommandText = sql;
                Object bean = cmd.ExecuteScalar();
                transaction.Commit();
                if (bean != null)
                {
                    return (int)bean;
                }
                else {
                    return 0;
                } 
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        public static int getCount(int Start,int end)
        {
            OleDbConnection cn = GetDbConnection();
            try
            {
                int totalRows = 0;
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                String sql = String.Format("select count(*) from [TRFID] where  ID >= {0} and ID <= {1}", Start, end);
                cmd.CommandText = sql;
                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                    totalRows = int.Parse(dr[0].ToString());

                return totalRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        private static OleDbConnection GetDbConnection()
        {
            if (conn == null)
            {
                String dir = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "PLC.mdb";
                conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir);
            }

            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

            return conn;
        }
    }
}
