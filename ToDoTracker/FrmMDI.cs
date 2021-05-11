using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ToDoTracker
{
    public partial class FrmMDI : Form
    {
        #region Constructor
        public FrmMDI()
        {
            InitializeComponent();

            GlobalClass.TransactionalDBConnectionString = ConfigurationManager.ConnectionStrings["UserConnection"].ConnectionString;
            GlobalClass.UserID = "1";
        }
        #endregion

        #region Event
        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new FrmNewToDo();
            if (this.MdiChildren.Length == 0)
            {
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Normal;
                obj.Show();
            }
            else if (IsFormOpen("FrmNewToDo"))
            {
                obj.BringToFront();
            }
            else
            {
                DisposeAllButThis(obj);
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Normal;
                obj.Show();
                //MessageBox.Show("Only one form can open at one time.");
            }
        }

        private void readAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new FrmReadToDo();
            if (this.MdiChildren.Length == 0)
            {
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Normal;
                obj.Show();
            }
            else if (IsFormOpen("FrmReadToDo"))
            {
                obj.BringToFront();
            }
            else
            {
                DisposeAllButThis(obj);
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Normal;
                obj.Show();
                //MessageBox.Show("Only one form can open at one time.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmMDI_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Method
        private bool IsFormOpen(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }
        #endregion




    }
}
