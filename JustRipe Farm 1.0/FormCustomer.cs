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

        public void updateCustomer()
        {
            Customer custU = new Customer();
            custU.Name = nameText.Text;
            custU.Email = emailText.Text;
            custU.Phone = phoneText.Text;
            custU.Remark = remarkText.Text;

            UpdateSQL custHnd = new UpdateSQL();
            int updateRecord = custHnd.updateCustomer(custU);
            MessageBox.Show(updateRecord + " Your record is updated");
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

        //private bool CheckCustomer(emailText.Text)
        //{
        //    bool check = false;
        //    check = (String.IsNullOrEmpty(nameText.Text) ? true : false;
        //    if (String.IsNullOrEmpty(nameText.Text))
        //    {
        //        MessageBox.Show("Please check again");
        //    }
            
        //    if (string.IsNullOrEmpty(emailText.Text))
        //    {
        //        MessageBox.Show("Please check again");
        //    }
            
            
                
            
        //}
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
