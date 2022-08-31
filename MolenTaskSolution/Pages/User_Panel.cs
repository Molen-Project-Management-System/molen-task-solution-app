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
    public partial class User_Panel : UserControl
    {
        private static User_Panel? _instance;
        public static User_Panel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_Panel();
                return _instance;
            }
        }
        public User_Panel()
        {
            InitializeComponent();
        }
        dbmolenContext db = new dbmolenContext();


        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void User_Panel_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Update_UI();
            }
        }

        void Update_UI()
        {
            var userId = Frm_Login.User_Id;

            var user = (from u in db.Users
                       where u.UserId == userId
                       select u).FirstOrDefault();

            if (user.Role == "Project Leader" || user.Role == "admin")
            {
                var username = user.UserName;

                var query = (from u in db.Users
                             join p in db.Projects on u.UserId equals p.ProjectOwnerId
                             select new
                             {
                                 u.UserId,
                                 p.ProjectName,
                                 p.Status,
                                 u.UserName,
                                 u.Gender,
                                 u.Email,
                                 u.Role,
                             }
                             );
                var users = query.ToList();
                dgwUserPanel.DataSource = users;
            }
            else
            {
                updateTableBasedOnRole(userId);
            }
        }

        private void updateTableBasedOnRole(int? userId)
        {
            var project = db.Projects.Where(p => p.ProjectOwnerId == userId).FirstOrDefault();
            var projectName = project.ProjectName;

            var query = (from u in db.Users
                       join p in db.Projects on u.UserId equals p.ProjectOwnerId
                       where p.ProjectName == projectName
                       select new
                       {
                           u.UserId,
                           p.ProjectName,
                           p.Status,
                           u.UserName,
                           u.Gender,
                           u.Email,
                           u.Role,
                       });

            var userRolBased = query.ToList();
            dgwUserPanel.DataSource = userRolBased;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Frm_RolAssign TaskFrm = new Frm_RolAssign();
            TaskFrm.Show();
        }
    }
}
