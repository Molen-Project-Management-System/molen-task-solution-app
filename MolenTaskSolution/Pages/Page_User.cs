using Microsoft.Data.SqlClient;
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
    public partial class Page_User : UserControl
    {
        public Page_User()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=144.126.158.15,1433;Database=molendb; User ID=administrator; Password=Qwert1234");
        DataSet daset = new DataSet();

        private void Page_User_Load(object sender, EventArgs e)
        {
            Save_User();
        } 
        private void Save_User()
        {
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from User", con);
            adtr.Fill(daset, "con");
            dgwUserPanel.DataSource = daset.Tables["User"];
            con.Close();
        }
    }
}
