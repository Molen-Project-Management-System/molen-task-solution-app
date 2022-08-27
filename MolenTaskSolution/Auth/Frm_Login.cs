using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using MolenTaskSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace MolenTaskSolution.Auth
{
    public partial class Frm_Login : Form
    {
        dbmolenContext db = new dbmolenContext();
        Thread? th;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user =  (from s in db.Users 
                        where s.Email == loginFrmTextBoxEmail.Text select s).FirstOrDefault();
            if(user?.Password == loginFrmTextBoxPassword.Text)
            {
                this.Close();
                th = new Thread(openMainForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("Either your username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openMainForm(object? obj)
        {
            Application.Run(new Frm_Main());
        }

        private void loginFrmTexBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
