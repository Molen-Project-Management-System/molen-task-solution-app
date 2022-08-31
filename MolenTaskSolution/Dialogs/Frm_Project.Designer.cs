namespace MolenTaskSolution.Dialogs
{
    partial class Frm_Project
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCompletion = new System.Windows.Forms.DateTimePicker();
            this.cbStatusProject = new System.Windows.Forms.ComboBox();
            this.txbProjectDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.lbTaskStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(321, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(212, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(140, 392);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(131, 27);
            this.dateTimePickerStart.TabIndex = 35;
            // 
            // dateTimePickerCompletion
            // 
            this.dateTimePickerCompletion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCompletion.Location = new System.Drawing.Point(284, 392);
            this.dateTimePickerCompletion.Name = "dateTimePickerCompletion";
            this.dateTimePickerCompletion.Size = new System.Drawing.Size(132, 27);
            this.dateTimePickerCompletion.TabIndex = 36;
            // 
            // cbStatusProject
            // 
            this.cbStatusProject.FormattingEnabled = true;
            this.cbStatusProject.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed",
            "Cancelled"});
            this.cbStatusProject.Location = new System.Drawing.Point(139, 303);
            this.cbStatusProject.Name = "cbStatusProject";
            this.cbStatusProject.Size = new System.Drawing.Size(276, 28);
            this.cbStatusProject.TabIndex = 32;
            // 
            // txbProjectDescription
            // 
            this.txbProjectDescription.Location = new System.Drawing.Point(139, 136);
            this.txbProjectDescription.Multiline = true;
            this.txbProjectDescription.Name = "txbProjectDescription";
            this.txbProjectDescription.Size = new System.Drawing.Size(276, 161);
            this.txbProjectDescription.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start Date*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Completion date*";
            // 
            // txbProjectName
            // 
            this.txbProjectName.Location = new System.Drawing.Point(41, 66);
            this.txbProjectName.Name = "txbProjectName";
            this.txbProjectName.Size = new System.Drawing.Size(375, 27);
            this.txbProjectName.TabIndex = 31;
            // 
            // lbTaskStatus
            // 
            this.lbTaskStatus.AutoSize = true;
            this.lbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTaskStatus.Location = new System.Drawing.Point(40, 311);
            this.lbTaskStatus.Name = "lbTaskStatus";
            this.lbTaskStatus.Size = new System.Drawing.Size(53, 20);
            this.lbTaskStatus.TabIndex = 26;
            this.lbTaskStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description";
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProjectName.Location = new System.Drawing.Point(41, 43);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(111, 20);
            this.lbProjectName.TabIndex = 29;
            this.lbProjectName.Text = "Project Name*";
            // 
            // Frm_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 578);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerCompletion);
            this.Controls.Add(this.cbStatusProject);
            this.Controls.Add(this.txbProjectDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.lbTaskStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProjectName);
            this.Name = "Frm_Project";
            this.Text = "Frm_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnSave;
        public Button btnCancel;
        public DateTimePicker dateTimePickerStart;
        public DateTimePicker dateTimePickerCompletion;
        public ComboBox cbStatusProject;
        public TextBox txbProjectDescription;
        private Label label4;
        private Label label1;
        public TextBox txbProjectName;
        private Label lbTaskStatus;
        private Label label3;
        private Label lbProjectName;
    }
}