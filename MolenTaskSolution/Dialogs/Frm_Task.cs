using Microsoft.Data.SqlClient;
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
using Task = MolenTaskSolution.Models.Task;

namespace MolenTaskSolution.Dialogs
{
    public partial class Frm_Task : Form
    {
        dbmolenContext db = new dbmolenContext();


        bool updating = false;
        Task ?task = null;
        public Frm_Task(int id) // get taskid
        {
            InitializeComponent();
            updating = true;
            task = db.Tasks.Where(t => t.TasksId == id).FirstOrDefault();
            if (task == null)
                return ;
            UpdateFieldForEdit();

        }

        private void UpdateFieldForEdit()
        {
            Update_UI();
            tbxTaskDescription.Text = task.Description;
            txbTaskName.Text = task.TaskName;
        }

        public Frm_Task()
        {
            InitializeComponent();
        }

        private void Frm_Task_Load(object sender, EventArgs e)
        {
            Update_UI();
        }

        public void Update_UI()
        {
            var projectName = from p in db.Projects
                              select p.ProjectName;

            var ownerName = from u in db.Users
                            select u.UserName;

            cbProjectSelectFromTask.DataSource = projectName.ToList();
            cbOwnerSelectFromTask.DataSource = ownerName.ToList();
        }



        public void btnSave_Click(object sender, EventArgs e)
        {
            if (updating)
            {
                UpdateTask();
                this.Close();
                MessageBox.Show("Task is edited successfully..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            var newTask = new Task();

            var itemProject = cbProjectSelectFromTask.SelectedItem.ToString();
            var selectedUser = cbOwnerSelectFromTask.SelectedItem.ToString();

            var projectId = (from p in db.Projects
                             where p.ProjectName == itemProject
                             select p.ProjectId).First();

            var taskOwner = (from u in db.Users
                             where u.UserName == selectedUser
                             select u).First();

            newTask.ProjectId = projectId;
            newTask.TaskName = txbTaskName.Text;
            newTask.Description = tbxTaskDescription.Text;
            newTask.TaskOwner = taskOwner;
            newTask.Status = cbStatusTask.Text;
            newTask.DateAdded = DateTime.Now;
            newTask.StartDate = dateTimePickerStart.Value.Date;
            newTask.CompletionDate = dateTimePickerCompletion.Value.Date;
            try
            {
                db.Tasks.Add(newTask);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Task is created successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateTask()
        {
            var selectedProjectForTask = cbProjectSelectFromTask.SelectedItem.ToString();
            var selectedUserForTask = cbOwnerSelectFromTask.SelectedItem.ToString();

            var projectIdForTask = (from p in db.Projects
                                    where p.ProjectName == selectedProjectForTask
                                    select p.ProjectId).First();

            var taskOwnerForTask = (from u in db.Users
                                    where u.UserName == selectedUserForTask
                                    select u).First();
            task.ProjectId = projectIdForTask;
            task.Description = tbxTaskDescription.Text;
            task.TaskName = txbTaskName.Text;
            task.TaskOwner = taskOwnerForTask;
            task.Status = cbStatusTask.Text;
            db.SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
