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
            this.lbDevide = new System.Windows.Forms.Label();
            this.lbCreateTeam = new System.Windows.Forms.Label();
            this.lbRemoveMember = new System.Windows.Forms.Label();
            this.cbSelectMember = new System.Windows.Forms.ComboBox();
            this.lbTaskStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDevide
            // 
            this.lbDevide.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbDevide.Location = new System.Drawing.Point(48, 195);
            this.lbDevide.Name = "lbDevide";
            this.lbDevide.Size = new System.Drawing.Size(358, 2);
            this.lbDevide.TabIndex = 25;
            this.lbDevide.Click += new System.EventHandler(this.lbDevide_Click);
            // 
            // lbCreateTeam
            // 
            this.lbCreateTeam.AutoSize = true;
            this.lbCreateTeam.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCreateTeam.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCreateTeam.Location = new System.Drawing.Point(48, 18);
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
            this.lbRemoveMember.Location = new System.Drawing.Point(48, 205);
            this.lbRemoveMember.Name = "lbRemoveMember";
            this.lbRemoveMember.Size = new System.Drawing.Size(229, 35);
            this.lbRemoveMember.TabIndex = 42;
            this.lbRemoveMember.Text = "Remove Members";
            // 
            // cbSelectMember
            // 
            this.cbSelectMember.FormattingEnabled = true;
            this.cbSelectMember.Items.AddRange(new object[] {
            "Cancelled",
            "Completed",
            "In Progress",
            "On Hold"});
            this.cbSelectMember.Location = new System.Drawing.Point(48, 85);
            this.cbSelectMember.Name = "cbSelectMember";
            this.cbSelectMember.Size = new System.Drawing.Size(220, 28);
            this.cbSelectMember.TabIndex = 44;
            // 
            // lbTaskStatus
            // 
            this.lbTaskStatus.AutoSize = true;
            this.lbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTaskStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTaskStatus.Location = new System.Drawing.Point(47, 62);
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
            this.label1.Location = new System.Drawing.Point(48, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Select a project to assign";
            // 
            // cbSelectProject
            // 
            this.cbSelectProject.FormattingEnabled = true;
            this.cbSelectProject.Items.AddRange(new object[] {
            "Cancelled",
            "Completed",
            "In Progress",
            "On Hold"});
            this.cbSelectProject.Location = new System.Drawing.Point(48, 151);
            this.cbSelectProject.Name = "cbSelectProject";
            this.cbSelectProject.Size = new System.Drawing.Size(220, 28);
            this.cbSelectProject.TabIndex = 44;
            this.cbSelectProject.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(47, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select a team member";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(48, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 28);
            this.comboBox1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(48, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Select a project to assign";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "In Progress",
            "On Hold",
            "Completed",
            "Cancelled"});
            this.comboBox2.Location = new System.Drawing.Point(48, 335);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 28);
            this.comboBox2.TabIndex = 44;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(313, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(213, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(313, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "REMOVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Frm_RolAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSelectProject);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectMember);
            this.Controls.Add(this.lbTaskStatus);
            this.Controls.Add(this.lbRemoveMember);
            this.Controls.Add(this.lbCreateTeam);
            this.Controls.Add(this.lbDevide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Name = "Frm_RolAssign";
            this.Text = "Frm_RolAssign";
            this.Load += new System.EventHandler(this.Frm_RolAssign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbDevide;
        private Label lbCreateTeam;
        private Label lbRemoveMember;
        public ComboBox cbSelectMember;
        private Label lbTaskStatus;
        private Label label1;
        public ComboBox cbSelectProject;
        private Label label2;
        public ComboBox comboBox1;
        private Label label3;
        public ComboBox comboBox2;
        public Button btnAdd;
        public Button button1;
        public Button button2;
    }
}