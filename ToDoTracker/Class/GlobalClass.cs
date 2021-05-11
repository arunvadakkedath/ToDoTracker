using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTracker
{
    public static class GlobalClass
    {
        public static string UserID;
        public static string UserName;
        public static string LoginName;
        public static string UserGroupID;
        public static string UserGroup;

        public static string ComputerName;
        public static string ComputerIP;
        public static string ExeName;
        public static string UIName;
        public static string StartUpPath;
        public static string LogPath;

        public static string SqlInstance;
        public static string SqlLoginName;
        public static string SqlPassword;

        public static string TransactionalDB;
        public static string UserDB;
        public static string TransactionalDBConnectionString;
        public static string UserDBConnectionString;

        public static DataTable DtMenu;
        public static string SelectedMenuName;
        public static int RollNoLength;

        public static bool IsHelp;
        public static DataTable DtHelp;

    }
}
