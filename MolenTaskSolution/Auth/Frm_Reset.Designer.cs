namespace MolenTaskSolution.Auth
{
    partial class Frm_Reset
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txCurrentPassword = new System.Windows.Forms.TextBox();
            this.txNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangePassword.Location = new System.Drawing.Point(58, 469);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(340, 42);
            this.btnChangePassword.TabIndex = 39;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txCurrentPassword
            // 
            this.txCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txCurrentPassword.Location = new System.Drawing.Point(58, 99);
            this.txCurrentPassword.Name = "txCurrentPassword";
            this.txCurrentPassword.PasswordChar = '*';
            this.txCurrentPassword.Size = new System.Drawing.Size(340, 39);
            this.txCurrentPassword.TabIndex = 45;
            // 
            // txNewPassword
            // 
            this.txNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txNewPassword.Location = new System.Drawing.Point(58, 234);
            this.txNewPassword.Name = "txNewPassword";
            this.txNewPassword.PasswordChar = '*';
            this.txNewPassword.Size = new System.Drawing.Size(340, 39);
            this.txNewPassword.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(58, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(58, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Confirm New Password";
            // 
            // txConfirmPassword
            // 
            this.txConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txConfirmPassword.Location = new System.Drawing.Point(58, 352);
            this.txConfirmPassword.Name = "txConfirmPassword";
            this.txConfirmPassword.PasswordChar = '*';
            this.txConfirmPassword.Size = new System.Drawing.Size(340, 39);
            this.txConfirmPassword.TabIndex = 46;
            // 
            // Frm_Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 578);
            this.Controls.Add(this.txCurrentPassword);
            this.Controls.Add(this.txConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "Frm_Reset";
            this.Text = "Frm_Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChangePassword;
        private TextBox txCurrentPassword;
        private TextBox txNewPassword;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txConfirmPassword;
    }
}