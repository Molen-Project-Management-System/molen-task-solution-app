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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            if (checkUserAuth(userID.Value))
            {
                MessageBox.Show("You have no Permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            else
            {
                Frm_RolAssign frm = new Frm_RolAssign();
                frm.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            if (checkUserAuth(userID.Value))
            {
                MessageBox.Show("You have no Permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dgwUserPanel.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row!");
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow dr = dgwUserPanel.SelectedRows[0];
                    var selectedUserId = Convert.ToInt32(dr.Cells[0].Value);

                    var userDel = (from u in db.Users
                                   where u.UserId == selectedUserId
                                   select u).FirstOrDefault();
                    if (userDel == null)
                        return;
                    try
                    {
                        db.Users.Remove(userDel);
                        var result = db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var userID = Frm_Login.User_Id;
            if (checkUserAuth(userID.Value))
            {
                MessageBox.Show("You have no Permission!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Update_UI();
        }
    }
}
