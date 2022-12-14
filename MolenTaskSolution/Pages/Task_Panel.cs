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
        dbmolenContext db = new dbmolenContext();

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
            var username = from u in db.Users
                           where u.UserName != null
                           select u.UserName;
            cbxUsers.DataSource = username.ToList();

            var query = (from t in db.Tasks
                         join u in db.Users on t.TaskOwnerId equals u.UserId
                         join p in db.Projects on t.ProjectId equals p.ProjectId
                         select new
                         {
                             t.TasksId,
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

        private  void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwTaskPanel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewRow dr = dgwTaskPanel.SelectedRows[0];
                var selectedTaskId = Convert.ToInt32(dr.Cells[0].Value);              

                var taskDel = (from t in db.Tasks
                               where t.TasksId == selectedTaskId
                               select t).FirstOrDefault();
                if (taskDel == null)
                    return;
                try
                {
                    db.Tasks.Remove(taskDel);
                    var result = db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgwTaskPanel.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgwTaskPanel.SelectedRows[0];

                var selectedTaskId = Convert.ToInt32(dr.Cells[0].Value);

                var temp = (from t in db.Tasks
                            where t.TasksId == selectedTaskId
                            select t).FirstOrDefault();
                if (temp == null)
                    return;
                Frm_Task TaskFrm = new Frm_Task(selectedTaskId);
                TaskFrm.ShowDialog();
            }
            else
                MessageBox.Show("Please select the entire row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbxUsersTaskPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUsers.Text == "All")
                Update_UI();
            else
            {
                var username = from u in db.Users
                               where u.UserName == cbxUsers.Text
                               select u.UserName;

                var query = (from t in db.Tasks
                             join u in db.Users on t.TaskOwnerId equals u.UserId
                             join p in db.Projects on t.ProjectId equals p.ProjectId
                             select new
                             {
                                 t.TasksId,
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
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
