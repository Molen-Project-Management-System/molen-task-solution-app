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

namespace MolenTaskSolution.Dialogs
{
    public partial class Frm_User : Form
    {
        dbmolenContext db = new dbmolenContext();
        User ?user = null;
        public Frm_User(int userId) // get taskid
        {
            InitializeComponent();
            user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
            if (user == null)
                return;
            UpdateFieldForEdit();
            
        }

        private void UpdateFieldForEdit()
        {
            txName.Text = user.UserName;
            cbGender.Text = user.Gender;
            txEmail.Text = user.Email;
            if (user.Role != "Project Leader" || user.Role != "admin")
            {
                cbRole.Text = user.Role;
                cbRole.Enabled = false;
            }
            dtpAddedDate.Enabled = false;
        }

        public Frm_User()
        {
            InitializeComponent();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.UserName = txName.Text;
            user.Email = txEmail.Text;
            user.Gender = cbGender.Text;
            db.SaveChanges();
            this.Close();
            MessageBox.Show("User information is updated successfully..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
