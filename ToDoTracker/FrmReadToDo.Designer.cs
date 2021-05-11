namespace ToDoTracker
{
    partial class FrmReadToDo
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
            this.DGVShowToDo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVShowToDo
            // 
            this.DGVShowToDo.AllowUserToAddRows = false;
            this.DGVShowToDo.AllowUserToDeleteRows = false;
            this.DGVShowToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVShowToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowToDo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVShowToDo.Location = new System.Drawing.Point(0, 33);
            this.DGVShowToDo.Name = "DGVShowToDo";
            this.DGVShowToDo.ReadOnly = true;
            this.DGVShowToDo.RowHeadersVisible = false;
            this.DGVShowToDo.Size = new System.Drawing.Size(534, 535);
            this.DGVShowToDo.TabIndex = 78;
            this.DGVShowToDo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVShowToDo_CellFormatting);
            // 
            // FrmReadToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 568);
            this.Controls.Add(this.DGVShowToDo);
            this.Name = "FrmReadToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReadToDo";
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowToDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DGVShowToDo;

        public System.Windows.Forms.DataGridViewCellFormattingEventHandler DGVShowToDo_CellContentClick { get; set; }
    }
}