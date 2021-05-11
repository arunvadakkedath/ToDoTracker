using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ToDoTracker
{
    public class ToDo : IToDo
    {
        #region Properties
        public int SNo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        #endregion

        #region Method
        public DBData AddUpdateToDo()
        {
            return ToDoDAL.GetObj().SaveData("AddUpdateToDo", this);
        }

        public DBData DeleteToDo()
        {
            return ToDoDAL.GetObj().SaveData("DeleteToDo", this);
        }

        public DataTable ShowToDo()
        {
            return ToDoDAL.GetObj().GetData("ShowToDo", this);
        }

        public DataTable ReadAllToDo()
        {
            return ToDoDAL.GetObj().GetData("ReadAllToDo", this);
        }
        #endregion
    }
}
