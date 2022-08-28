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
        public static string? User_Password;
        public static string? User_Email;
        public static string? User_Role;
        public static bool isLogin = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user =  (from s in db.Users 
                        where s.Email == loginFrmTextBoxEmail.Text select s).FirstOrDefault();
            if(user?.Password == loginFrmTextBoxPassword.Text)
            {
                isLogin = true;
                var userName = (from n in db.Users
                                where n.Email == loginFrmTextBoxEmail.Text
                                select n.UserName).FirstOrDefault();

                User_Name = userName;

                var userRole = (from r in db.Users
                                where r.Email == loginFrmTextBoxEmail.Text
                                select r.Role).FirstOrDefault();

                User_Role = userRole;

                
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
