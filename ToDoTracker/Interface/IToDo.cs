using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    public interface IToDo
    {
        #region Properties
        int SNo { get; set; }

        string Title { get; set; }

        string Description { get; set; }

        string DueDate { get; set; }

        string Status { get; set; }
        #endregion

        #region Method
        DBData AddUpdateToDo();

        DBData DeleteToDo();

        DataTable ShowToDo();

        DataTable ReadAllToDo();
        #endregion
    }
}
