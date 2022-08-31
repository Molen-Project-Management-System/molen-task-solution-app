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

        public static string? User_Name;
        public static int? User_Id;
        public static string? User_Password;
        public static string? User_Email;
        public static string? User_Role;
        public static bool isLogin = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginTxEmail.Text == "")
            {
                required1.Text = "This is required";
                loginTxEmail.Focus();
                return;
            }
            if (loginTxPassword.Text == "")
            {
                required2.Text = "This is required";
                loginTxPassword.Focus();
                return;
            }
            var user =  (from s in db.Users 
                        where s.Email == loginTxEmail.Text select s).FirstOrDefault();
            
            
            if(user?.Password == loginTxPassword.Text)
            {
                isLogin = true;

                User_Name = user.UserName;
                User_Id = user.UserId;
                User_Role = user.Role; ;
                
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


    }
}
