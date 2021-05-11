using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ToDoTracker
{
    public class DBConnection
    {
        public static string GetTimeout()
        {
            try
            {
                return "9000";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static SqlConnection GetConnectionSql(string DBName)
        {
            try
            {
                SqlConnection con;
                if (DBName == "")
                {
                    con = new SqlConnection(GlobalClass.UserDBConnectionString);
                }
                else
                {
                    con = new SqlConnection(GlobalClass.TransactionalDBConnectionString);
                }
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
