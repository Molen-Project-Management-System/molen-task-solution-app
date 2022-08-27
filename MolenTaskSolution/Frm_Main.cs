using MolenTaskSolution.Auth;
using MolenTaskSolution.Pages;
using System.Data.SqlClient;

namespace MolenTaskSolution
{
    public partial class Frm_Main : Form
    {

        public Frm_Main()
        {
            InitializeComponent();
        }

        //private void btnUsers_Click(object sender, EventArgs e)
        //{
        //    page_UsersFrmMain.BringToFront();
        //}

        private void page_UsersFrmMain_Load(object sender, EventArgs e)
        {
  
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Frm_Login loginFrm = new Frm_Login();
            loginFrm.Show();
            this.Close();
        }

        private void page_Users1_Load(object sender, EventArgs e)
        {

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            mainPage_Task.BringToFront();
        }

        private void mainPage_Task_Load(object sender, EventArgs e)
        {
            Page_Task newTaskMainPage = new Page_Task();
            newTaskMainPage.Show();
        }
    }
}