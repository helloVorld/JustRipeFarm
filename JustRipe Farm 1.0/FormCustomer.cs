using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustRipeFarm.ClassEntity;

namespace JustRipeFarm
{
    public partial class FormCustomer : Form
    {
        public string state = "";
        public Customer cust;
        public FormCustomer()
    
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                nameText.Text = cust.Name;
                emailText.Text = cust.Email;
                phoneText.Text = cust.Phone;
                remarkText.Text = cust.Remark;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            CheckCustomer(nameText.Text, emailText.Text, phoneText.Text, emailText.Text);
            Customer cust = new Customer();
            cust.Name = nameText.Text;
            cust.Email = emailText.Text;
            cust.Phone = phoneText.Text;
            cust.Remark = remarkText.Text;
            InsertSQL custHnd = new InsertSQL();
            int addrecord = custHnd.addNewCustomer(cust);
            MessageBox.Show(addrecord + " Your record is added");
        }

        private void CheckCustomer(string name,string email,string phone,string remark)
        {
            
                if (String.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please check again");
                }
            //try
            //{
            //    var test = new MailAddress(emailText.Text);
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Wrong Email Format");
            //}



        }
    }
}
