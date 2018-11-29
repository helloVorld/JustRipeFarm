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
            // Menu Button click to display spe
            string panelName = "panelHome";
            Button btn = sender as Button;
            Console.WriteLine("JRF : FLP button => "+btn.Name+ " clicked");
            
            switch (btn.Name)
            {
                case "Home"     : panelName = "panelHome";      break;
                case "Orders"   : panelName = "panelOperation"; break;
                case "Products" : panelName = "panelFarm";      break;
                case "Operation": panelName = "panelStoreroom"; break;
                case "Farm"     : panelName = "panelProduct";   break;
                case "Employee" : panelName = "panelEmployee";  break;
                case "Customer" : panelName = "panelCustomer";  break;
                case "Store"    : panelName = "panelOrder";     break;
                case "Inventory": panelName = "panelInventory"; break;
                default         : panelName = "panelHome";      break;
            }
            panelDisplay(panelName);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 500;
            panelDisplay("panelHome");


        }

        public void panelDisplay(string panelName)
        {
            Panel[] panelsControl = new Panel[9] {panelHome,panelOperation,panelFarm
                ,panelStoreroom,panelProduct,panelEmployee
                ,panelCustomer,panelOrder,panelInventory};

            foreach (Panel pN in panelsControl)
            {
                if (pN.Name != panelName)
                {
                    pN.Hide();
                }
                else
                {
                    pN.Width = 650;
                    pN.Height = 400;
                    pN.Location = new Point(130, 60);
                    pN.Show();
                }

            }

        }

        //public void setDisplay()
        //{

        //}

    }
}
