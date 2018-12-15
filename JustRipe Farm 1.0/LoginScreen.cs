using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustRipeFarm.ClassEntity;
namespace JustRipeFarm
{
    public partial class LoginScreen : Form
    {
        Employee em = new Employee();

        public LoginScreen()
        {
            InitializeComponent();
            checkMySql();
        }

        public void checkMySql()
        {
            
            if (MysqlDbc.Instance.getConn().Ping())
            {
                dbStatusLbl.Text = "MySql Online";
            }
            else
            {
                dbStatusLbl.Text = "MySql Offline";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = textBox1.Text;
            string pass = textBox2.Text;

            Login login = new Login(user, pass);


            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                em = login.checkUserLogin();

                if (em.Admin == true)
                {
                    goToDashBoard(true);
                }
                else if(em.Admin == false)
                {
                    goToDashBoard(false);
                }
                else
                {
                    MessageBox.Show("No User in my system!!");
                }
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }

            //Mainscreen mainscreen = new Mainscreen();
            //mainscreen.Show();
            //this.Close();
        }

        private void labDashBtn_Click(object sender, EventArgs e)
        {
            //LabourerDashboard labourerDash = new LabourerDashboard();
            //labourerDash.Show();
            //this.Close();
            goToDashBoard(false);
        }

        private void adminDashBtn_Click(object sender, EventArgs e)
        {
            //AdminDashboard adminDash = new AdminDashboard();
            //adminDash.Show();
            //this.Close();
            goToDashBoard(true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void goToDashBoard(bool isAdmin)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.isAdmin = isAdmin;
            dashboard.currentEmployee = em;
            dashboard.Show();
            this.Close();
        }

        //Login login = new Login("admin", "1234");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

