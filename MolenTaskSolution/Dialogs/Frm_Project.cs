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

        private void UpdateFieldForEdit()
        {
            txbProjectName.Text = project.ProjectName;
            txbProjectDescription.Text = project.Description;
            cbStatusProject.Text = project.Status;
            dateTimePickerStart.Value = Convert.ToDateTime(project.StartDate);
            dateTimePickerCompletion.Value = Convert.ToDateTime(project.CompletionDate);
        }

        private void Update_UI()
        {
            
        }

        public Frm_Project()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (updating)
            {
                UpdateProject();
                this.Close();
                MessageBox.Show("Task is edited successfully..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var project = new Project();

            var projectOwnerId = Frm_Login.User_Id;

            project.ProjectName = txbProjectName.Text;
            project.Description = txbProjectDescription.Text;
            project.ProjectOwnerId = projectOwnerId;
            project.Status = cbStatusProject.Text;
            project.DateAdded = DateTime.Now;
            project.StartDate = dateTimePickerStart.Value.Date;
            project.CompletionDate = dateTimePickerCompletion.Value.Date;
            try
            {
                db.Projects.Add(project);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Task is created successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateProject()
        {
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
