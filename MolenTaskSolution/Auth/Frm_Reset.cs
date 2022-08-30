using MolenTaskSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MolenTaskSolution.Auth
{
    public partial class Frm_Reset : Form
    {
        dbmolenContext db = new dbmolenContext();

        User ?user = null;
        public Frm_Reset(int userId)
        {
            InitializeComponent();
            user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
            if (user == null)
                return;
        }
        public Frm_Reset()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var currentPassword = txCurrentPassword.Text;
            if (user.Password == currentPassword)
            {
                var newPassword = txNewPassword.Text;
                var confirmPassword = txConfirmPassword.Text;
                if (newPassword == confirmPassword)
                {
                    UpdatePassword(newPassword);
                    this.Close();
                    MessageBox.Show("Password changed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Passwords doesn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCurrentPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Your current password is wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCurrentPassword.Focus();
            }
        }

        private void UpdatePassword(string newPassword)
        {
            user.Password = newPassword;
            db.SaveChanges();
        }
    }
}
