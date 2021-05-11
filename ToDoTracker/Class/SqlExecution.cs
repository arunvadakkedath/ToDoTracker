using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ToDoTracker
{
    public static class SqlExecution
    {
        private static int TimeOut = 0;
        public static string DBName = "";

        static SqlExecution()
        {
            TimeOut = Convert.ToInt32(DBConnection.GetTimeout());
        }

        private static string GetSPCallingInfo(string SPName, List<SqlParameter> ListParam)
        {
            string str = "";
            str += SPName;
            foreach (SqlParameter SP in ListParam)
            {
                str += "|" + SP.ParameterName + "=" + SP.Value;
            }
            return str;
        }

        private static string GetSpReturnInfo(DBData DBObj)
        {
            string str = "";
            str += "ProcReturn=" + DBObj.ProcReturn.ToString() + "|ProcMessage=" + DBObj.ProcMessage;
            return str;
        }

        public static DataTable GetDataTable(string SqlQuery, List<SqlParameter> ListSP)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = DBConnection.GetConnectionSql(DBName))
                {
                    con.FireInfoMessageEventOnUserErrors = true;
                    using (SqlCommand cmd = new SqlCommand(SqlQuery))
                    {
                        cmd.Connection = con;
                        cmd.CommandText = SqlQuery;
                        cmd.CommandTimeout = TimeOut;

                        if (SqlQuery.ToUpper().Contains("Proc_".ToUpper()))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;
                        }

                        cmd.Parameters.Clear();
                        AddParameters(ListSP, cmd);
                        cmd.Parameters.Add("@P_ProcMessage", SqlDbType.VarChar, 2000).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@P_ProcReturn", SqlDbType.Int).Direction = ParameterDirection.Output;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        DBData DBObj = new DBData();
                        DBObj.ProcMessage = Convert.ToString(cmd.Parameters["@P_ProcMessage"].Value);
                        if (cmd.Parameters["@P_ProcReturn"].Value != DBNull.Value)
                        {
                            DBObj.ProcReturn = Convert.ToInt32(cmd.Parameters["@P_ProcReturn"].Value);
                        }
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DBData ExecuteNonQuery(string SqlQuery, List<SqlParameter> ListSP)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnectionSql(DBName))
                {
                    con.FireInfoMessageEventOnUserErrors = true;
                    using (SqlCommand cmd = new SqlCommand(SqlQuery))
                    {
                        cmd.Connection = con;
                        cmd.CommandText = SqlQuery;
                        cmd.CommandTimeout = TimeOut;

                        if (SqlQuery.ToUpper().Contains("Proc_".ToUpper()))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;
                        }

                        cmd.Parameters.Clear();
                        AddParameters(ListSP, cmd);
                        cmd.Parameters.Add("@P_ProcMessage", SqlDbType.VarChar, 2000).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@P_ProcReturn", SqlDbType.Int).Direction = ParameterDirection.Output;

                        int res = cmd.ExecuteNonQuery();

                        DBData DBObj = new DBData();
                        DBObj.ProcMessage = Convert.ToString(cmd.Parameters["@P_ProcMessage"].Value);
                        if (cmd.Parameters["@P_ProcReturn"].Value != DBNull.Value)
                        {
                            DBObj.ProcReturn = Convert.ToInt32(cmd.Parameters["@P_ProcReturn"].Value);
                        }
                        return DBObj;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static DataSet GetDataSet(string SqlQuery, List<SqlParameter> ListSP)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection con = DBConnection.GetConnectionSql(DBName))
                {
                    con.FireInfoMessageEventOnUserErrors = true;
                    using (SqlCommand cmd = new SqlCommand(SqlQuery))
                    {
                        cmd.Connection = con;
                        cmd.CommandText = SqlQuery;
                        cmd.CommandTimeout = TimeOut; ;

                        if (SqlQuery.ToUpper().Contains("Proc_".ToUpper()))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                        }
                        else
                        {
                            cmd.CommandType = CommandType.Text;
                        }

                        cmd.Parameters.Clear();
                        AddParameters(ListSP, cmd);
                        cmd.Parameters.Add("@P_ProcMessage", SqlDbType.VarChar, 2000).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@P_ProcReturn", SqlDbType.Int).Direction = ParameterDirection.Output;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds);
                        }

                        DBData DBObj = new DBData();
                        DBObj.ProcMessage = Convert.ToString(cmd.Parameters["@P_ProcMessage"].Value);
                        if (cmd.Parameters["@P_ProcReturn"].Value != DBNull.Value)
                        {
                            DBObj.ProcReturn = Convert.ToInt32(cmd.Parameters["@P_ProcReturn"].Value);
                        }
                    }
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void AddParameters(List<SqlParameter> ListSP, SqlCommand cmd)
        {
            if (ListSP.Count > 0)
            {
                foreach (SqlParameter SP in ListSP)
                {
                    cmd.Parameters.Add(SP);
                }
            }
        }

    }
}
