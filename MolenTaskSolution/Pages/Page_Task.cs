using Microsoft.Data.SqlClient;
using MolenTaskSolution.Dialogs;
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

namespace MolenTaskSolution.Pages
{
    public partial class Page_Task : UserControl
    {
        public Page_Task()
        {
            InitializeComponent();
        }
        dbmolenContext db = new dbmolenContext();
        
        //DataSet daset = new DataSet();

        private void Page_Task_Load(object sender, EventArgs e)
        {
            var username = from u in db.Users
                           where u.UserName != null
                           select u.UserName;

            var query = (from t in db.Tasks
                         join u in db.Users on t.TaskOwnerId equals u.UserId
                         join p in db.Projects on t.ProjectId equals p.ProjectId
                         select new
                         {
                             p.ProjectName,
                             t.TaskName,
                             u.UserName,
                             t.Status,
                             t.StartDate,
                             t.CompletionDate
                         }
                         );
            var tasks = query.ToList();
            dgwTaskPanel.DataSource = tasks;

            cbxUsersTaskPanel.DataSource = username.ToList();

            //Save_User();
        }
        private void Save_User()
        {
            //SqlConnection con = new SqlConnection("Server=144.126.158.15,1433;Database=molendb; User ID=administrator; Password=Qwert1234");
            //string sqlQuery = "SELECT Projects.ProjectName, Tasks.TaskName, Users.UserName, Tasks.Status,Tasks.StartDate, Tasks.CompletionDate FROM [Tasks] JOIN [Projects] ON Tasks.ProjectID = Projects.ProjectID JOIN [Users] ON Tasks.TaskOwnerID = Users.UserID";
            //SqlCommand com = new SqlCommand(sqlQuery, con);
            //con.Open();
            //SqlDataAdapter adtr = new SqlDataAdapter(com);
            //adtr.SelectCommand = com;
            //DataTable dt = new DataTable();
            //adtr.Fill(dt);
            //dgwTaskPanel.DataSource = dt;
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Task TaskFrm = new Frm_Task();
            TaskFrm.Show();
        }

        private void cbxUsersTaskPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
