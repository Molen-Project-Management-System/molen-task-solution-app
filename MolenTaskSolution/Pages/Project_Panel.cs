using MolenTaskSolution.Auth;
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
    public partial class Project_Panel : UserControl
    {
        private static Project_Panel? _instance;
        public static Project_Panel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Project_Panel();
                return _instance;
            }
        }

        
        public Project_Panel()
        {
            InitializeComponent();
        }
        dbmolenContext db = new dbmolenContext();
        private bool checkUserAuth(int userID)
        {
            var userRole = (from u in db.Users
                            where u.UserId == userID
                            select u.Role).FirstOrDefault().ToString();
            if (userRole == "Project Leader" || userRole == "Manager")
                return false;
            else
                return true;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Frm_Project frm = new Frm_Project();
            frm.Show();
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            if (checkUserAuth(userID.Value))
            {
                MessageBox.Show("You have no Permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (this.dgwProjectPanel.SelectedRows.Count > 0)
                {
                    
                    DataGridViewRow dr = dgwProjectPanel.SelectedRows[0];
                    var selectedProjectId = Convert.ToInt32(dr.Cells[0].Value);
                    Frm_Project frm = new Frm_Project(selectedProjectId);
                    frm.Show();
                }
                else
                    MessageBox.Show("Please select the entire row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Project_Panel_Load(object sender, EventArgs e)
        {
            // Is this control or one of its parents in design mode
            
            if (!this.DesignMode)
            {
                Update_UI();
            }
        }

        private void Update_UI()
        {
            // Kalan gun sayisi eklenecek ve task sayisi
            var startDate = (from p in db.Projects
                           select p.StartDate).ToList();

            var completionDate = (from p in db.Projects
                           select p.StartDate).ToList();


            var currentDate = DateTime.Now;
            var query = (from p in db.Projects
                         join u in db.Users on p.ProjectOwnerId equals u.UserId  
                         select new
                         {
                             p.ProjectId,
                             p.ProjectName,
                             u.UserName,
                             p.Status,
                             p.StartDate,
                             p.CompletionDate,
                             currentDate
                         });
            var projects = query.ToList();
            dgwProjectPanel.DataSource = projects;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Update_UI();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            if (checkUserAuth(userID.Value))
            {
                MessageBox.Show("You have no Permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgwProjectPanel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("You will remove all members from this project. Do you really want to continue?", "EF CRUD Operation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                DataGridViewRow dr = dgwProjectPanel.SelectedRows[0];
                var selectedProjectId = Convert.ToInt32(dr.Cells[0].Value);
                MessageBox.Show("Hello");
                return;

                var projectDel = (from p in db.Projects
                               where p.ProjectId == selectedProjectId
                               select p).FirstOrDefault();
                if (projectDel == null)
                    return;
                try
                {
                    db.Projects.Remove(projectDel);
                    var result = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
