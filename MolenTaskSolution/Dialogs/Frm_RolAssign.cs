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
    public partial class Frm_RolAssign : Form
    {
        dbmolenContext db = new dbmolenContext();
      
        public Frm_RolAssign(int userID)
        {
            InitializeComponent();
        }

        public Frm_RolAssign()
        {
            InitializeComponent();
        }

        private void Frm_RolAssign_Load(object sender, EventArgs e)
        {
            Update_UI();
        }

        private void Update_UI()
        {
            var projectName = from p in db.Projects
                              select p.ProjectName;

            var ownerName = from u in db.Users
                            select u.UserName;

            cbSelectProject.DataSource = projectName.Distinct().ToList();
            cbSelectMember.DataSource = ownerName.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            var selectedUser = cbSelectMember.SelectedItem.ToString();

            var userId = (from u in db.Users
                          where u.UserName == selectedUser
                          select u.UserId).FirstOrDefault();
            int user_Id = Convert.ToInt32(userId);

            var selectedProject = cbSelectProject.SelectedItem.ToString();

            var project = db.Projects.Where(p => p.ProjectName == selectedProject).FirstOrDefault();

            if(project == null)
            {
                var newProject = new Project();
                newProject.ProjectName = project.ProjectName;
                newProject.Description = project.Description;
                newProject.ProjectOwnerId = user_Id;
                newProject.Status = project.Status;
                newProject.StartDate = project.StartDate;
                newProject.CompletionDate = project.CompletionDate;
                newProject.DateAdded = project.DateAdded;
                try
                {
                    db.Projects.Add(newProject);
                    db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Project has been succesfully assigned to a member!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                MessageBox.Show("There is no project yet. Please first create a new project.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Project createProject = new Frm_Project();
                createProject.Show();
                this.Close();
            }

            //var newTask = new Task();

            //var itemProject = cbProjectSelectFromTask.SelectedItem.ToString();
            //var selectedUser = cbOwnerSelectFromTask.SelectedItem.ToString();

            //var projectId = (from p in db.Projects
            //                 where p.ProjectName == itemProject
            //                 select p.ProjectId).First();

            //var taskOwner = (from u in db.Users
            //                 where u.UserName == selectedUser
            //                 select u).First();

            //newTask.ProjectId = projectId;
            //newTask.TaskName = txbTaskName.Text;
            //newTask.Description = tbxTaskDescription.Text;
            //newTask.TaskOwner = taskOwner;
            //newTask.Status = cbStatusTask.Text;
            //newTask.DateAdded = DateTime.Now;
            //newTask.StartDate = dateTimePickerStart.Value.Date;
            //newTask.CompletionDate = dateTimePickerCompletion.Value.Date;



            //if (updating)
            //{
            //    UpdateTask();
            //    this.Close();
            //    MessageBox.Show("Task is edited successfully..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {


        }

        private void btnMemberAdd_Click(object sender, EventArgs e)
        {

        }

        private void lbDevide_Click(object sender, EventArgs e)
        {

        }
    }
}
