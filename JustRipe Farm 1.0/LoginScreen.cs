﻿using System;
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
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
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
            dashboard.Show();
            this.Close();
        }
    }
}
