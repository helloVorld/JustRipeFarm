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
    public partial class AdminDashboard : Form
    {
        
        public AdminDashboard()
        {
            InitializeComponent();
            loadMenuBtn();
            //setDisplay();
            this.Resize += AdminDashboard_Resize;
        }

        private void AdminDashboard_Resize(object sender, EventArgs e)
        {
            formWidthLbl.Text = this.Width.ToString();
            formHeightLbl.Text = this.Height.ToString();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // back to login screen
            JRF.Logout(this);
        }

        public void loadMenuBtn()
        {
            List<string> menuList = JRF.getMenuButtonName();
            foreach (string str in menuList)
            {
                Button bt = new Button();
                bt.Name = str;
                bt.Text = str;
                
                menuFLP.Controls.Add(bt);
                bt.Click += new System.EventHandler(this.menuBtn_Click);
            }
        }

        public void menuBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Console.WriteLine("JRF : FLP button => "+btn.Name+ " clicked");
        }

        //public void setDisplay()
        //{

        //}

    }
}
