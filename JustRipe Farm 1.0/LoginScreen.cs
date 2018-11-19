using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm
{
    public partial class LoginScreen : Form
    {
        
        public LoginScreen()
        {
            InitializeComponent();
            checkMySql();
        }

        public void checkMySql()
        {
            DbConnector dbConn = new DbConnector();
            String status = dbConn.connect();
            Console.WriteLine("JRP Check => "+status);
            if (status.Equals("Done"))
            {
                dbStatusLbl.Text = "MySql online";
            }
            else
            {
                dbStatusLbl.Text = "MySql offline";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
        }

        private void labDashBtn_Click(object sender, EventArgs e)
        {
            LabourerDashboard labourerDash = new LabourerDashboard();
            labourerDash.Show();
            this.Close();
        }

        private void adminDashBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDash = new AdminDashboard();
            adminDash.Show();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
