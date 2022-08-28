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
    }
}
