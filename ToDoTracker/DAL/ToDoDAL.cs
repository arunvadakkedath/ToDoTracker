using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ToDoTracker
{
    public class ToDoDAL
    {
        private static ToDoDAL DalObj = null;
        private ToDoDAL() { }
        public static ToDoDAL GetObj()
        {
            if (DalObj == null)
                DalObj = new ToDoDAL();
            return DalObj;
        }

        private void SetParameter(ref List<SqlParameter> ListParam, string Condition, IToDo Obj)
        {
            try
            {
                ListParam.Add(new SqlParameter("@P_Condition", Condition));
                ListParam.Add(new SqlParameter("@P_SNo", Obj.SNo));
                ListParam.Add(new SqlParameter("@P_Title", Obj.Title));
                ListParam.Add(new SqlParameter("@P_Description", Obj.Description));
                ListParam.Add(new SqlParameter("@P_DueDate", Obj.DueDate));
                ListParam.Add(new SqlParameter("@P_Status", Obj.Status));

                ListParam.Add(new SqlParameter("@P_CreatedBy", GlobalClass.UserID));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetData(string Condition, IToDo Obj)
        {
            try
            {
                List<SqlParameter> ListParam = new List<SqlParameter>();
                SetParameter(ref ListParam, Condition, Obj);

                GlobalClass.UserDBConnectionString = GlobalClass.TransactionalDBConnectionString;
                GlobalClass.TransactionalDB = GlobalClass.TransactionalDBConnectionString;
                SqlExecution.DBName = GlobalClass.TransactionalDBConnectionString;
                DataTable Dtp = SqlExecution.GetDataTable("Proc_ToDo", ListParam);
                return Dtp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetDataDs(string Condition, IToDo Obj)
        {
            try
            {
                List<SqlParameter> ListParam = new List<SqlParameter>();
                SetParameter(ref ListParam, Condition, Obj);

                GlobalClass.UserDBConnectionString = GlobalClass.TransactionalDBConnectionString;
                GlobalClass.TransactionalDB = GlobalClass.TransactionalDBConnectionString;
                SqlExecution.DBName = GlobalClass.TransactionalDBConnectionString;
                DataSet Dsp = SqlExecution.GetDataSet("Proc_ToDo", ListParam);
                return Dsp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DBData SaveData(string Condition, IToDo Obj)
        {
            try
            {
                List<SqlParameter> ListParam = new List<SqlParameter>();
                SetParameter(ref ListParam, Condition, Obj);

                GlobalClass.UserDBConnectionString = GlobalClass.TransactionalDBConnectionString;
                GlobalClass.TransactionalDB = GlobalClass.TransactionalDBConnectionString;
                SqlExecution.DBName = GlobalClass.TransactionalDBConnectionString;
                DBData DBObj = SqlExecution.ExecuteNonQuery("Proc_ToDo", ListParam);
                return DBObj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
