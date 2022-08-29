using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MolenTaskSolution.Pages
{
    public partial class Task_Panel : UserControl
    {
        private static Task_Panel ?_instance;
        public static Task_Panel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Task_Panel();
                return _instance;
            }
        }
        public Task_Panel()
        {
            InitializeComponent();
        }
        dbmolenContext model = new dbmolenContext();
        
        //DataSet daset = new DataSet();

        private void Page_Task_Load(object sender, EventArgs e)
        {
            // Is this control or one of its parents in design mode
            
            if (!this.DesignMode)
            {
                Update_UI();
            }
        }
        void Update_UI()
        {
            //SqlConnection con = new SqlConnection("Server=144.126.158.15,1433;Database=dbmolen; User ID=administrator; Password=Qwert1234");
            //string sqlQuery = "SELECT Projects.ProjectName, Tasks.TaskName, Users.UserName, Tasks.Status,Tasks.StartDate, Tasks.CompletionDate FROM [Tasks] JOIN [Projects] ON Tasks.ProjectID = Projects.ProjectID JOIN [Users] ON Tasks.TaskOwnerID = Users.UserID";
            //SqlCommand com = new SqlCommand(sqlQuery, con);
            //con.Open();
            //SqlDataAdapter adtr = new SqlDataAdapter(com);
            //adtr.SelectCommand = com;
            //DataTable dt = new DataTable();
            //adtr.Fill(dt);
            //dgwTaskPanel.DataSource = dt;
            //con.Close();
            var username = from u in model.Users
                           where u.UserName != null
                           select u.UserName;

            var query = (from t in model.Tasks
                         join u in model.Users on t.TaskOwnerId equals u.UserId
                         join p in model.Projects on t.ProjectId equals p.ProjectId
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
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            Frm_Task TaskFrm = new Frm_Task();
            TaskFrm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Update_UI();
        }


        // use this part for update
        private void dgwTaskPanel_DoubleClick(object sender, EventArgs e)
        {
            //if (dgwTaskPanel.CurrentRow.Index != -1)
            //{
            //    var taskId = from u in db.Tasks
            //                   select u.TasksId;

                
            //}

        }

        private  void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwTaskPanel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string selectedName="";
                foreach (DataGridViewRow row in dgwTaskPanel.SelectedRows)  
                {


                    selectedName = Convert.ToString(row.Cells[1].Value);
                    
                }
              
               // MessageBox.Show(selectedName);

                SqlConnection con = new SqlConnection("Server=144.126.158.15,1433;Database=dbmolen; User ID=administrator; Password=Qwert1234");
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Tasks  WHERE TaskName = '"+selectedName+"';", con); 
                command.ExecuteNonQuery();
                con.Close();



               


               /* var deleteTasks =
                     from t in model.Tasks
                     where t.TaskName == selectedName
                         select t;

                var silinecek_task = model.Tasks.Where(t => t.TaskName == selectedName).FirstOrDefault(); 
                // islem sirasina gore selectedName forloopun disina cikip yeni deger alincaya kadar null atiyor. 
                try
                {
                    model.Tasks.Remove(silinecek_task);
                    model.SaveChanges();

                }catch(Exception ex)
                {
                    MessageBox.Show("olmadimi yoksa");
                }*/




                //////////


                /* if (this.dgwTaskPanel.SelectedRows.Count > 0)
                 {
                     dgwTaskPanel.Rows.RemoveAt(this.dgwTaskPanel.SelectedRows[0].Index);
                 }*/


                //var removedTask = dgwTaskPanel.SelectedRows[0].DataBoundItem;

            }

        }

      


    
    }
}
