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

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Frm_Project frm = new Frm_Project();
            frm.Show();
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (this.dgwProjectPanel.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgwProjectPanel.SelectedRows[0];
                var selectedProjectId = Convert.ToInt32(dr.Cells[0].Value);
                Frm_Project frm = new Frm_Project(selectedProjectId);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Please select the entire row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var query = (from p in db.Projects
                         join u in db.Users on p.ProjectOwnerId equals u.UserId  
                         select new
                         {
                             p.ProjectName,
                             u.UserName,
                             p.Status,
                             p.StartDate,
                             p.CompletionDate,
                         });
            var projects = query.ToList();
            dgwProjectPanel.DataSource = projects;
        }
    }
}
