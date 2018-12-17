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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace JustRipeFarm
{
    public partial class FormCustomer : Form
    {
        List<Customer> CustomerList;

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
            if (state == "Edit")
            {
                updateCustomer();
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    if (String.IsNullOrEmpty(textBox2.Text))
                    {
                        if (String.IsNullOrEmpty(textBox3.Text))
                        {
                            if (String.IsNullOrEmpty(textBox4.Text))
                            {
                                MessageBox.Show("Please check again");
                            }
                            MessageBox.Show("Please check again");
                        }
                        MessageBox.Show("Please check again");
                    }
                    MessageBox.Show("Please check again");
                }
                else
                {
                    addCustomer();
                }
            }
        }

        private void addCustomer()
        {
            Customer c1 = new Customer();
            c1.Name = textBox1.Text;
            c1.Email = textBox2.Text;
            c1.Phone = textBox3.Text;
            c1.Remark = textBox4.Text;

            InsertSQL add = new InsertSQL();
            int editrecord = add.addNewCustomer(c1);
            MessageBox.Show(" Your seccusful");
            this.Close();
        }

        public void updateCustomer()
        {
            //CheckCustomer(textBox1.Text, textBox2.Text, textBox3.Text, textBox2.Text);
            Customer custU = new Customer();
            custU.Id = cust.Id;
            custU.Name = textBox1.Text;
            custU.Email = textBox2.Text;
            custU.Phone = textBox3.Text;
            custU.Remark = textBox4.Text;

            UpdateSQL custHnd = new UpdateSQL();
            int updateRecord = custHnd.updateCustomer(custU);
            MessageBox.Show(updateRecord + " Your record is updated");
            this.Close();
        }


        private void FormCustomer_Load(object sender, EventArgs e)
        {
            InsertSQL customer1 = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = cust.Name;
                textBox2.Text = cust.Email;
                textBox3.Text = cust.Phone;
                textBox4.Text = cust.Remark;
            }
        }



        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

        //bool check = false;
        //string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-za-Z]{2,9})$";
        //string number = @"^(\+[0-9]{9})$";

        //bool ck1 = String.IsNullOrEmpty(name);
        //bool ck2 = String.IsNullOrEmpty(email);
        //bool ck3 = String.IsNullOrEmpty(phone);
        //bool ck4 = String.IsNullOrEmpty(remark);
        ////bool ck5 = Regex.IsMatch(email, pattern);
        ////bool ck6 = Regex.IsMatch(phone, number);

        //if (ck1 == true && ck2 == true && ck3 == ck1 && ck4 == true)// && ck5 == true && ck6 == true)
        //{
        //    InsertSQL custHnd = new InsertSQL();
        //    int addrecord = custHnd.addNewCustomer(cust);
        //    MessageBox.Show(addrecord + " Your record is added");
        //}
        //else{
        //    ErrorMsg.UpdateOptionNoSelect();
        //}
        //if (String.IsNullOrEmpty(name))
        //{
        //    if (String.IsNullOrEmpty(email))
        //    {
        //        if (String.IsNullOrEmpty(phone))
        //        {
        //            if (String.IsNullOrEmpty(remark))
        //            {
        //                check = false;
        //                //MessageBox.Show("Please check again");
        //                ErrorMsg.UpdateOptionNoSelect();
        //            }
        //        }

        //    }

        //}
        //else if (Regex.IsMatch(email, pattern))
        //{
        //    if (Regex.IsMatch(phone, number))
        //    {

        //    }
        //}


        //else
        //{
        //    InsertSQL custHnd = new InsertSQL();
        //    int addrecord = custHnd.addNewCustomer(cust);
        //    MessageBox.Show(addrecord + " Your record is added");

        //}
        //try
        //{
        //    var test = new MailAddress(emailText.Text);
        //}
        //catch (FormatException ex)
        //{
        //    MessageBox.Show("Wrong Email Format");
        //}
