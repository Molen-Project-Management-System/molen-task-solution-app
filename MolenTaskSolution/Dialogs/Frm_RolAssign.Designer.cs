namespace MolenTaskSolution.Dialogs
{
    partial class Frm_RolAssign
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
            this.lbDevide = new System.Windows.Forms.Label();
            this.lbCreateTeam = new System.Windows.Forms.Label();
            this.lbRemoveMember = new System.Windows.Forms.Label();
            this.cbStatusTask = new System.Windows.Forms.ComboBox();
            this.lbTaskStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.btnSave.Location = new System.Drawing.Point(678, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(578, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbDevide
            // 
            this.lbDevide.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbDevide.Location = new System.Drawing.Point(372, 49);
            this.lbDevide.Name = "lbDevide";
            this.lbDevide.Size = new System.Drawing.Size(2, 350);
            this.lbDevide.TabIndex = 25;
            // 
            // lbCreateTeam
            // 
            this.lbCreateTeam.AutoSize = true;
            this.lbCreateTeam.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCreateTeam.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCreateTeam.Location = new System.Drawing.Point(12, 18);
            this.lbCreateTeam.Name = "lbCreateTeam";
            this.lbCreateTeam.Size = new System.Drawing.Size(162, 35);
            this.lbCreateTeam.TabIndex = 42;
            this.lbCreateTeam.Text = "Create Team";
            // 
            // lbRemoveMember
            // 
            this.lbRemoveMember.AutoSize = true;
            this.lbRemoveMember.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRemoveMember.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbRemoveMember.Location = new System.Drawing.Point(414, 18);
            this.lbRemoveMember.Name = "lbRemoveMember";
            this.lbRemoveMember.Size = new System.Drawing.Size(229, 35);
            this.lbRemoveMember.TabIndex = 42;
            this.lbRemoveMember.Text = "Remove Members";
            // 
            // cbStatusTask
            // 
            this.cbStatusTask.FormattingEnabled = true;
            this.cbStatusTask.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed",
            "Cancelled"});
            this.cbStatusTask.Location = new System.Drawing.Point(12, 101);
            this.cbStatusTask.Name = "cbStatusTask";
            this.cbStatusTask.Size = new System.Drawing.Size(220, 28);
            this.cbStatusTask.TabIndex = 44;
            // 
            // lbTaskStatus
            // 
            this.lbTaskStatus.AutoSize = true;
            this.lbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTaskStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTaskStatus.Location = new System.Drawing.Point(11, 78);
            this.lbTaskStatus.Name = "lbTaskStatus";
            this.lbTaskStatus.Size = new System.Drawing.Size(165, 20);
            this.lbTaskStatus.TabIndex = 43;
            this.lbTaskStatus.Text = "Select a team member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Select a project to assign";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(12, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 28);
            this.comboBox1.TabIndex = 44;
            // 
            // Frm_RolAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatusTask);
            this.Controls.Add(this.lbTaskStatus);
            this.Controls.Add(this.lbRemoveMember);
            this.Controls.Add(this.lbCreateTeam);
            this.Controls.Add(this.lbDevide);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "Frm_RolAssign";
            this.Text = "Frm_RolAssign";
            this.Load += new System.EventHandler(this.Frm_RolAssign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnSave;
        public Button btnCancel;
        private Label lbDevide;
        private Label lbCreateTeam;
        private Label lbRemoveMember;
        public ComboBox cbStatusTask;
        private Label lbTaskStatus;
        private Label label1;
        public ComboBox comboBox1;
    }
}