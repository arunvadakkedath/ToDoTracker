namespace ToDoTracker
{
    partial class FrmNewToDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBNewToDo = new System.Windows.Forms.GroupBox();
            this.TBSNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.DGVToDoList = new System.Windows.Forms.DataGridView();
            this.GBNewToDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVToDoList)).BeginInit();
            this.SuspendLayout();
            // 
            // GBNewToDo
            // 
            this.GBNewToDo.Controls.Add(this.TBSNo);
            this.GBNewToDo.Controls.Add(this.label5);
            this.GBNewToDo.Controls.Add(this.BtnCancel);
            this.GBNewToDo.Controls.Add(this.BtnDelete);
            this.GBNewToDo.Controls.Add(this.BtnUpdate);
            this.GBNewToDo.Controls.Add(this.BtnAdd);
            this.GBNewToDo.Controls.Add(this.CBStatus);
            this.GBNewToDo.Controls.Add(this.label4);
            this.GBNewToDo.Controls.Add(this.DTPDueDate);
            this.GBNewToDo.Controls.Add(this.label3);
            this.GBNewToDo.Controls.Add(this.TxtDescription);
            this.GBNewToDo.Controls.Add(this.Label2);
            this.GBNewToDo.Controls.Add(this.TxtTitle);
            this.GBNewToDo.Controls.Add(this.Label1);
            this.GBNewToDo.Location = new System.Drawing.Point(5, 0);
            this.GBNewToDo.Name = "GBNewToDo";
            this.GBNewToDo.Size = new System.Drawing.Size(517, 274);
            this.GBNewToDo.TabIndex = 0;
            this.GBNewToDo.TabStop = false;
            this.GBNewToDo.Text = "NewToDo";
            // 
            // TBSNo
            // 
            this.TBSNo.BackColor = System.Drawing.Color.Gainsboro;
            this.TBSNo.Enabled = false;
            this.TBSNo.Location = new System.Drawing.Point(101, 15);
            this.TBSNo.MaxLength = 15;
            this.TBSNo.Name = "TBSNo";
            this.TBSNo.ReadOnly = true;
            this.TBSNo.Size = new System.Drawing.Size(201, 20);
            this.TBSNo.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 136;
            this.label5.Text = "SNo";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(330, 244);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(72, 30);
            this.BtnCancel.TabIndex = 135;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(254, 244);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(72, 30);
            this.BtnDelete.TabIndex = 134;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(178, 244);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 30);
            this.BtnUpdate.TabIndex = 133;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(101, 244);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(73, 30);
            this.BtnAdd.TabIndex = 132;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.SystemColors.Control;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Not Started",
            "Started",
            "Completed"});
            this.CBStatus.Location = new System.Drawing.Point(101, 204);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(201, 21);
            this.CBStatus.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 130;
            this.label4.Text = "Status";
            // 
            // DTPDueDate
            // 
            this.DTPDueDate.Location = new System.Drawing.Point(101, 168);
            this.DTPDueDate.MaxDate = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            this.DTPDueDate.MinDate = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            this.DTPDueDate.Name = "DTPDueDate";
            this.DTPDueDate.Size = new System.Drawing.Size(201, 20);
            this.DTPDueDate.TabIndex = 129;
            this.DTPDueDate.Value = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "DueDate";
            // 
            // TxtDescription
            // 
            this.TxtDescription.BackColor = System.Drawing.Color.White;
            this.TxtDescription.Location = new System.Drawing.Point(101, 90);
            this.TxtDescription.MaxLength = 200;
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(350, 60);
            this.TxtDescription.TabIndex = 127;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 91);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 16);
            this.Label2.TabIndex = 126;
            this.Label2.Text = "Description";
            // 
            // TxtTitle
            // 
            this.TxtTitle.BackColor = System.Drawing.Color.White;
            this.TxtTitle.Location = new System.Drawing.Point(101, 50);
            this.TxtTitle.MaxLength = 200;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(350, 20);
            this.TxtTitle.TabIndex = 125;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(7, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 16);
            this.Label1.TabIndex = 124;
            this.Label1.Text = "Title";
            // 
            // DGVToDoList
            // 
            this.DGVToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVToDoList.Location = new System.Drawing.Point(5, 280);
            this.DGVToDoList.Name = "DGVToDoList";
            this.DGVToDoList.ReadOnly = true;
            this.DGVToDoList.Size = new System.Drawing.Size(517, 226);
            this.DGVToDoList.TabIndex = 1;
            this.DGVToDoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVToDoList_CellContentClick);
            // 
            // FrmNewToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(525, 508);
            this.Controls.Add(this.DGVToDoList);
            this.Controls.Add(this.GBNewToDo);
            this.Name = "FrmNewToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewToDo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNewToDo_Load);
            this.GBNewToDo.ResumeLayout(false);
            this.GBNewToDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVToDoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBNewToDo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtTitle;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtDescription;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPDueDate;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBStatus;
        internal System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGVToDoList;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnUpdate;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TBSNo;
    }
}