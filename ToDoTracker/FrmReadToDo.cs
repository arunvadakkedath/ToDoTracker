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
    public partial class FrmReadToDo : Form
    {
        public FrmReadToDo()
        {
            InitializeComponent();
            DGVShowToDo.DataSource = GetData().DefaultView;
        }

        private DataTable GetData()
        {
            try
            {
                IToDo IObj = Factory.GetObj().ToDoObj();
                DataTable Dt = IObj.ReadAllToDo();
                return Dt;
            }
            catch (Exception Ex)
            {
                return null;
            }
            finally
            {

            }
        }

        private void DGVShowToDo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in DGVShowToDo.Rows)
            {       
                if (Myrow.Cells[4].Value.ToString().ToUpper().Trim() == "Not Started".ToUpper().Trim())
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                else if(Myrow.Cells[4].Value.ToString().ToUpper().Trim() == "Started".ToUpper().Trim())
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if(Myrow.Cells[4].Value.ToString().ToUpper().Trim() == "Completed".ToUpper().Trim())
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {

                }
            }
        }
    }
}
