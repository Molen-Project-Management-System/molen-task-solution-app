using MolenTaskSolution.Auth;
using MolenTaskSolution.Dialogs;
using MolenTaskSolution.Models;
using MolenTaskSolution.Pages;
using System.Data.SqlClient;

namespace MolenTaskSolution
{
    public partial class Frm_Main : Form
    {
        dbmolenContext db = new dbmolenContext();
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void page_UsersFrmMain_Load(object sender, EventArgs e)
        {


        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            updateInfo();

            if (!panelPages.Controls.Contains(Project_Panel.Instance))
            {
                panelPages.Controls.Add(Project_Panel.Instance);
                Project_Panel.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                Project_Panel.Instance.BringToFront();
            }
        }

        private void updateInfo()
        {
            if (Frm_Login.isLogin == true)
            {
                lbUserName.Text = Frm_Login.User_Name;
                lbUserRole.Text = Frm_Login.User_Role;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            if (!panelPages.Controls.Contains(Task_Panel.Instance))
            {
                panelPages.Controls.Add(Task_Panel.Instance);
                Task_Panel.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                Task_Panel.Instance.BringToFront();
            }
            lbPageName.Text = btnTasks.Text;
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task_Panel.Instance.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!panelPages.Controls.Contains(User_Panel.Instance))
            {
                panelPages.Controls.Add(User_Panel.Instance);
                User_Panel.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                User_Panel.Instance.BringToFront();
            }
            lbPageName.Text = btnUsers.Text;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            //if (!panelPages.Controls.Contains(Project_Panel.Instance))
            //{
            //    panelPages.Controls.Add(Project_Panel.Instance);
            //    Project_Panel.Instance.Dock = DockStyle.Fill;
            //}
            //else
            //{
            //    Project_Panel.Instance.BringToFront();
            //}
            //lbPageName.Text = btnProjects.Text;
        }

        private void accountStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountStripMenuItem2_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            Frm_User frm = new Frm_User(userID.Value);
            frm.Show();
            


        }

        private void accountStripMenuItem3_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            Frm_Reset user = new Frm_Reset(userID.Value);
            user.Show();
        }
    }
}