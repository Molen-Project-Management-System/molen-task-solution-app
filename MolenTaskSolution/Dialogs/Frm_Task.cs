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
        //SqlConnection con = new SqlConnection("Server=144.126.158.15,1433;Database=molendb; User ID=administrator; Password=Qwert1234");
        public Frm_Task()
        {
            InitializeComponent();
        }

        private void Frm_Task_Load(object sender, EventArgs e)
        {
            var projectName = from p in db.Projects
                              select p.ProjectName;

            var ownerName = from u in db.Users
                            select u.UserName;

            cbProjectSelectFromTask.DataSource = projectName.ToList();
            cbOwnerSelectFromTask.DataSource = ownerName.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand com = new SqlCommand("insert into task");
            var newTask = new Task();

            var itemProject = cbProjectSelectFromTask.SelectedItem.ToString();

            var projectId = (from p in db.Projects
                            where p.ProjectName == itemProject
                            select p.ProjectId).First();

            // when you have the result from LinQ expression you will always have the list of result set

            newTask.ProjectId = projectId;
            //newTask.TasksId = int.Parse(tbtaskId.Text);
            newTask.TaskName = txbTaskName.Text;
            newTask.Description = tbxTaskDescription.Text;
            newTask.Status = cbStatusTask.Text;
            newTask.DateAdded = DateTime.Now;
            newTask.StartDate = dateTimePickerStart.Value.Date;
            newTask.CompletionDate = dateTimePickerCompletion.Value.Date;
            try
            {
                db.Tasks.Add(newTask);
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
