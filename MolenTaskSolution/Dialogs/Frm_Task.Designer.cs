namespace MolenTaskSolution.Dialogs
{
    partial class Frm_Task
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
            this.tbxTaskDescription = new System.Windows.Forms.TextBox();
            this.txbTaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.cbOwnerSelectFromTask = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerCompletion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lbTaskStatus = new System.Windows.Forms.Label();
            this.cbStatusTask = new System.Windows.Forms.ComboBox();
            this.cbProjectSelectFromTask = new System.Windows.Forms.ComboBox();
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
            this.btnSave.Location = new System.Drawing.Point(322, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 21;
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
            this.btnCancel.Location = new System.Drawing.Point(213, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxTaskDescription
            // 
            this.tbxTaskDescription.Location = new System.Drawing.Point(140, 94);
            this.tbxTaskDescription.Multiline = true;
            this.tbxTaskDescription.Name = "tbxTaskDescription";
            this.tbxTaskDescription.Size = new System.Drawing.Size(276, 161);
            this.tbxTaskDescription.TabIndex = 13;
            // 
            // txbTaskName
            // 
            this.txbTaskName.Location = new System.Drawing.Point(141, 61);
            this.txbTaskName.Name = "txbTaskName";
            this.txbTaskName.Size = new System.Drawing.Size(276, 27);
            this.txbTaskName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFileName.Location = new System.Drawing.Point(41, 68);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(93, 20);
            this.lbFileName.TabIndex = 12;
            this.lbFileName.Text = "Task Name*";
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOwner.Location = new System.Drawing.Point(41, 269);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(55, 20);
            this.lbOwner.TabIndex = 11;
            this.lbOwner.Text = "Owner";
            // 
            // cbOwnerSelectFromTask
            // 
            this.cbOwnerSelectFromTask.FormattingEnabled = true;
            this.cbOwnerSelectFromTask.Location = new System.Drawing.Point(140, 261);
            this.cbOwnerSelectFromTask.Name = "cbOwnerSelectFromTask";
            this.cbOwnerSelectFromTask.Size = new System.Drawing.Size(276, 28);
            this.cbOwnerSelectFromTask.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Project*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Completion date*";
            // 
            // dateTimePickerCompletion
            // 
            this.dateTimePickerCompletion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCompletion.Location = new System.Drawing.Point(285, 384);
            this.dateTimePickerCompletion.Name = "dateTimePickerCompletion";
            this.dateTimePickerCompletion.Size = new System.Drawing.Size(131, 27);
            this.dateTimePickerCompletion.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Date*";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(140, 384);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(131, 27);
            this.dateTimePickerStart.TabIndex = 18;
            // 
            // lbTaskStatus
            // 
            this.lbTaskStatus.AutoSize = true;
            this.lbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTaskStatus.Location = new System.Drawing.Point(41, 303);
            this.lbTaskStatus.Name = "lbTaskStatus";
            this.lbTaskStatus.Size = new System.Drawing.Size(53, 20);
            this.lbTaskStatus.TabIndex = 11;
            this.lbTaskStatus.Text = "Status";
            // 
            // cbStatusTask
            // 
            this.cbStatusTask.FormattingEnabled = true;
            this.cbStatusTask.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed",
            "Cancelled"});
            this.cbStatusTask.Location = new System.Drawing.Point(140, 295);
            this.cbStatusTask.Name = "cbStatusTask";
            this.cbStatusTask.Size = new System.Drawing.Size(276, 28);
            this.cbStatusTask.TabIndex = 17;
            // 
            // cbProjectSelectFromTask
            // 
            this.cbProjectSelectFromTask.FormattingEnabled = true;
            this.cbProjectSelectFromTask.Location = new System.Drawing.Point(141, 28);
            this.cbProjectSelectFromTask.Name = "cbProjectSelectFromTask";
            this.cbProjectSelectFromTask.Size = new System.Drawing.Size(276, 28);
            this.cbProjectSelectFromTask.TabIndex = 17;
            // 
            // Frm_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 578);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerCompletion);
            this.Controls.Add(this.cbStatusTask);
            this.Controls.Add(this.cbProjectSelectFromTask);
            this.Controls.Add(this.cbOwnerSelectFromTask);
            this.Controls.Add(this.tbxTaskDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTaskName);
            this.Controls.Add(this.lbTaskStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFileName);
            this.Name = "Frm_Task";
            this.Text = "Frm_Task";
            this.Load += new System.EventHandler(this.Frm_Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label lbFileName;
        private Label lbOwner;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label lbTaskStatus;
        public Button btnSave;
        public Button btnCancel;
        public TextBox tbxTaskDescription;
        public TextBox txbTaskName;
        public ComboBox cbOwnerSelectFromTask;
        public DateTimePicker dateTimePickerCompletion;
        public DateTimePicker dateTimePickerStart;
        public ComboBox cbStatusTask;
        public ComboBox cbProjectSelectFromTask;
    }
}