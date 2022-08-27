namespace MolenTaskSolution.Pages
{
    partial class Page_Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Task));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBoxTask = new System.Windows.Forms.TextBox();
            this.btnSearchTask = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxUsersTaskPanel = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwTaskPanel = new System.Windows.Forms.DataGridView();
            this.taskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaskPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBoxTask
            // 
            this.searchBoxTask.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBoxTask.Location = new System.Drawing.Point(15, 19);
            this.searchBoxTask.Name = "searchBoxTask";
            this.searchBoxTask.Size = new System.Drawing.Size(262, 27);
            this.searchBoxTask.TabIndex = 2;
            this.searchBoxTask.Text = "Search..";
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTask.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTask.Image")));
            this.btnSearchTask.Location = new System.Drawing.Point(283, 18);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(0, 27);
            this.btnSearchTask.TabIndex = 3;
            this.btnSearchTask.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBox1.DropDownWidth = 220;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Status (All)",
            "On Hold",
            "In Progress",
            "Completed"});
            this.comboBox1.Location = new System.Drawing.Point(321, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // cbxUsersTaskPanel
            // 
            this.cbxUsersTaskPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.cbxUsersTaskPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxUsersTaskPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbxUsersTaskPanel.FormattingEnabled = true;
            this.cbxUsersTaskPanel.Items.AddRange(new object[] {
            "Employee(All)"});
            this.cbxUsersTaskPanel.Location = new System.Drawing.Point(544, 18);
            this.cbxUsersTaskPanel.Name = "cbxUsersTaskPanel";
            this.cbxUsersTaskPanel.Size = new System.Drawing.Size(220, 28);
            this.cbxUsersTaskPanel.TabIndex = 4;
            this.cbxUsersTaskPanel.SelectedIndexChanged += new System.EventHandler(this.cbxUsersTaskPanel_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(987, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 36;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1116, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwTaskPanel
            // 
            this.dgwTaskPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTaskPanel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwTaskPanel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwTaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwTaskPanel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTaskPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTaskPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTaskPanel.GridColor = System.Drawing.SystemColors.Control;
            this.dgwTaskPanel.Location = new System.Drawing.Point(15, 82);
            this.dgwTaskPanel.Name = "dgwTaskPanel";
            this.dgwTaskPanel.RowHeadersWidth = 51;
            this.dgwTaskPanel.RowTemplate.Height = 29;
            this.dgwTaskPanel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgwTaskPanel.Size = new System.Drawing.Size(1224, 641);
            this.dgwTaskPanel.TabIndex = 49;
            // 
            // taskBindingSource1
            // 
            this.taskBindingSource1.DataSource = typeof(MolenTaskSolution.Models.Task);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(858, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 35);
            this.button3.TabIndex = 50;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Page_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgwTaskPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxUsersTaskPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearchTask);
            this.Controls.Add(this.searchBoxTask);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Page_Task";
            this.Size = new System.Drawing.Size(1259, 804);
            this.Load += new System.EventHandler(this.Page_Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaskPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox searchBoxTask;
        private PictureBox btnSearchTask;
        private ComboBox comboBox1;
        private ComboBox cbxUsersTaskPanel;
        private Button button2;
        private Button button1;
        private BindingSource taskBindingSource;
        private BindingSource projectBindingSource;
        private DataGridView dgwTaskPanel;
        private BindingSource taskBindingSource1;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;

    }
}
