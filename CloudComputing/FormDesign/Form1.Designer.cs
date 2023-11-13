namespace CloudComputing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            xDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            radiusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { xDataGridViewTextBoxColumn, yDataGridViewTextBoxColumn, radiusDataGridViewTextBoxColumn, isActiveDataGridViewCheckBoxColumn });
            dataGridView1.Location = new Point(293, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(674, 279);
            dataGridView1.TabIndex = 0;
            // 
            // xDataGridViewTextBoxColumn
            // 
            xDataGridViewTextBoxColumn.DataPropertyName = "X";
            xDataGridViewTextBoxColumn.HeaderText = "X";
            xDataGridViewTextBoxColumn.MinimumWidth = 8;
            xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            xDataGridViewTextBoxColumn.Width = 150;
            // 
            // yDataGridViewTextBoxColumn
            // 
            yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            yDataGridViewTextBoxColumn.HeaderText = "Y";
            yDataGridViewTextBoxColumn.MinimumWidth = 8;
            yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            yDataGridViewTextBoxColumn.Width = 150;
            // 
            // radiusDataGridViewTextBoxColumn
            // 
            radiusDataGridViewTextBoxColumn.DataPropertyName = "Radius";
            radiusDataGridViewTextBoxColumn.HeaderText = "Radius";
            radiusDataGridViewTextBoxColumn.MinimumWidth = 8;
            radiusDataGridViewTextBoxColumn.Name = "radiusDataGridViewTextBoxColumn";
            radiusDataGridViewTextBoxColumn.Width = 150;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewCheckBoxColumn.MinimumWidth = 8;
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 844);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cloud Computing - J.Łuka, Ł.Grochowski, M.Bielicki";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn radiusDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}