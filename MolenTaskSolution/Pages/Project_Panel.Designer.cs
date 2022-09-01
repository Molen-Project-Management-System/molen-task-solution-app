namespace MolenTaskSolution.Pages
{
    partial class Project_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project_Panel));
            this.dgwProjectPanel = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnSearchTask = new System.Windows.Forms.PictureBox();
            this.searchBoxTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProjectPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProjectPanel
            // 
            this.dgwProjectPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProjectPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProjectPanel.Location = new System.Drawing.Point(15, 85);
            this.dgwProjectPanel.Name = "dgwProjectPanel";
            this.dgwProjectPanel.RowHeadersWidth = 51;
            this.dgwProjectPanel.RowTemplate.Height = 29;
            this.dgwProjectPanel.Size = new System.Drawing.Size(1224, 681);
            this.dgwProjectPanel.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.BackColor = System.Drawing.Color.Olive;
            this.btnEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditProject.ForeColor = System.Drawing.Color.White;
            this.btnEditProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProject.Location = new System.Drawing.Point(858, 14);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(123, 35);
            this.btnEditProject.TabIndex = 59;
            this.btnEditProject.Text = "EDIT";
            this.btnEditProject.UseVisualStyleBackColor = false;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProject.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProject.Location = new System.Drawing.Point(987, 14);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(123, 35);
            this.btnDeleteProject.TabIndex = 57;
            this.btnDeleteProject.Text = "DELETE";
            this.btnDeleteProject.UseVisualStyleBackColor = false;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProject.ForeColor = System.Drawing.Color.White;
            this.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.Location = new System.Drawing.Point(1116, 14);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(123, 35);
            this.btnAddProject.TabIndex = 58;
            this.btnAddProject.Text = "ADD";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.cbxStatus.DropDownWidth = 220;
            this.cbxStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "All",
            "On Hold",
            "In Progress",
            "Completed",
            "Cancelled"});
            this.cbxStatus.Location = new System.Drawing.Point(342, 19);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(217, 28);
            this.cbxStatus.TabIndex = 56;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTask.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTask.Image")));
            this.btnSearchTask.Location = new System.Drawing.Point(283, 18);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(0, 27);
            this.btnSearchTask.TabIndex = 54;
            this.btnSearchTask.TabStop = false;
            // 
            // searchBoxTask
            // 
            this.searchBoxTask.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBoxTask.Location = new System.Drawing.Point(15, 19);
            this.searchBoxTask.Name = "searchBoxTask";
            this.searchBoxTask.Size = new System.Drawing.Size(262, 27);
            this.searchBoxTask.TabIndex = 53;
            this.searchBoxTask.Text = "Search..";
            // 
            // Project_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwProjectPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.btnSearchTask);
            this.Controls.Add(this.searchBoxTask);
            this.Name = "Project_Panel";
            this.Size = new System.Drawing.Size(1254, 804);
            this.Load += new System.EventHandler(this.Project_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProjectPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgwProjectPanel;
        private PictureBox pictureBox1;
        private Button btnEditProject;
        private Button btnDeleteProject;
        private Button btnAddProject;
        private ComboBox cbxStatus;
        private PictureBox btnSearchTask;
        private TextBox searchBoxTask;
    }
}
