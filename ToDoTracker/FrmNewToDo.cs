using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTracker
{
    public partial class FrmNewToDo : Form
    {
        public FrmNewToDo()
        {
            InitializeComponent();
        }

        private void FrmNewToDo_Load(object sender, EventArgs e)
        {
            DTPDueDate.MinDate = DateTime.Now;
            DGVToDoList.DataSource = GetData().DefaultView;
           
        }

        private DataTable GetData()
        {
            try
            {
                IToDo IObj = Factory.GetObj().ToDoObj();
                DataTable Dt = IObj.ShowToDo();
                return Dt;
            }
            catch(Exception Ex)
            {
                return null;
            }
            finally
            {

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtTitle.Text != "")
                {
                    IToDo IObj = Factory.GetObj().ToDoObj();
                    IObj.Title = TxtTitle.Text;
                    IObj.Description = TxtDescription.Text;
                    IObj.DueDate = DTPDueDate.Value.ToString("yyyy-MM-dd");
                    IObj.Status = CBStatus.Text;
                    DBData DBObj = IObj.AddUpdateToDo();
                    DGVToDoList.DataSource = GetData().DefaultView;
                    DoCancel();
                    MessageBox.Show(DBObj.ProcMessage);
                }
                else
                {
                    MessageBox.Show("Please add title..!");
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBSNo.Text != null)
                {
                    IToDo IObj = Factory.GetObj().ToDoObj();
                    IObj.SNo = TBSNo.Text == null ? 0 : Convert.ToInt32(TBSNo.Text);
                    IObj.Title = TxtTitle.Text;
                    IObj.Description = TxtDescription.Text;
                    IObj.DueDate = DTPDueDate.Value.ToString("yyyy-MM-dd");
                    IObj.Status = CBStatus.Text;
                    DBData DBObj = IObj.AddUpdateToDo();
                    DGVToDoList.DataSource = GetData().DefaultView;
                    DoCancel();
                    MessageBox.Show(DBObj.ProcMessage);
                }
                else
                {
                    MessageBox.Show("Please double click on a row to select a record for updation..!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBSNo.Text != null)
                {
                    IToDo IObj = Factory.GetObj().ToDoObj();
                    IObj.SNo = TBSNo.Text == null ? 0 : Convert.ToInt32(TBSNo.Text);
                    DBData DBObj = IObj.DeleteToDo();
                    DGVToDoList.DataSource = GetData().DefaultView;
                    DoCancel();
                    MessageBox.Show(DBObj.ProcMessage);
                }
                else
                {
                    MessageBox.Show("Please double click on a row to delete a record..!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DoCancel();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DoCancel()
        {
            TBSNo.Text = null;
            TxtTitle.Text = "";
            TxtDescription.Text = "";
            DTPDueDate.Text = "";
            CBStatus.Text = "";
        }
        private void DGVToDoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TBSNo.Text = DGVToDoList.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtTitle.Text = DGVToDoList.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtDescription.Text = DGVToDoList.Rows[e.RowIndex].Cells[2].Value.ToString();
                DTPDueDate.Value = Convert.ToDateTime(DGVToDoList.Rows[e.RowIndex].Cells[3].Value) == DateTime.Today ? DateTime.Now
                    : Convert.ToDateTime(DGVToDoList.Rows[e.RowIndex].Cells[3].Value);
                CBStatus.Text = DGVToDoList.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

    }
}
