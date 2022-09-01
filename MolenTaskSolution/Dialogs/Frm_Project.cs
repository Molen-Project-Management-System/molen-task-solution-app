using MolenTaskSolution.Auth;
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
    public partial class Frm_Project : Form
    {
        Project ?project = null;
        dbmolenContext db = new dbmolenContext();
        bool updating = false;
        public Frm_Project(int id) // get taskid
        {
            InitializeComponent();
            updating = true;
            project = db.Projects.Where(p => p.ProjectId == id).FirstOrDefault();
            if (project == null)
                return;
            UpdateFieldForEdit();
        }
        public Frm_Project()
        {
            InitializeComponent();
        }


        private void UpdateFieldForEdit()
        {
            txbProjectName.Text = project.ProjectName;
            txbProjectDescription.Text = project.Description;
            cbStatusProject.Text = project.Status;
            dateTimePickerStart.Value = Convert.ToDateTime(project.StartDate);
            dateTimePickerCompletion.Value = Convert.ToDateTime(project.CompletionDate);
            dateTimePickerStart.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (updating)
            {
                if (CheckValues())
                    return;
                UpdateProject();
                this.Close();
                MessageBox.Show("Project is edited successfully..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CheckValues())
                return;
            var project = new Project();
            var projectStatus = cbStatusProject.Text;
            var projectOwnerId = Frm_Login.User_Id;
            project.ProjectName = txbProjectName.Text;
            project.Description = txbProjectDescription.Text;
            project.ProjectOwnerId = projectOwnerId;
            project.Status = projectStatus;
            project.DateAdded = DateTime.Now;
            dateTimePickerStart.MinDate = DateTime.Today.Date;
            project.StartDate = dateTimePickerStart.Value.Date;
            if(dateTimePickerCompletion.MinDate < dateTimePickerStart.Value.Date)
            {
                MessageBox.Show("Please provide further date than StartDate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            project.CompletionDate = dateTimePickerCompletion.Value.Date;
            try
            {
                db.Projects.Add(project);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Project is created successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void UpdateProject()
        {
            project.ProjectName = txbProjectName.Text;
            project.Description = txbProjectDescription.Text;
            project.Status = cbStatusProject.Text;
            project.CompletionDate = dateTimePickerCompletion.Value.Date;
            db.SaveChanges();
        }

        private bool CheckValues()
        {
            var projectName = txbProjectName.Text;
            var projectDescription = txbProjectDescription.Text;
            var projectStatus = cbStatusProject.Text;
            if (projectStatus == "" || projectName == "" || projectDescription == "")
            {
                MessageBox.Show("Fields cannot be empty. Please give it a initial value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
