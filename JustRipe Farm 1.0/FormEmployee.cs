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
    public partial class FormEmployee : Form
    {
        public string state = "";
        public Employee emp;
        public FormEmployee()
        {
            InitializeComponent();
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            AddEmployee(firstNameText.Text, lastNameText.Text, usernameText.Text, passwordText.Text,
                    Convert.ToDateTime(dobText.Text), mobileText.Text, emailText.Text, Convert.ToInt32(adminText.Text), statusText.Text, remarkText.Text);
            //UpdateEmployee();
        }

        public void AddEmployee(string first_name, string last_name, string username, string password,
                                DateTime dob, string mobile, string email, int admin, string status, string remark)
        {
            if (String.IsNullOrEmpty(first_name))
            {
                if (String.IsNullOrEmpty(last_name))
                {
                    if (String.IsNullOrEmpty(username))
                    {
                        if (String.IsNullOrEmpty(password))
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(dob)))
                            {
                                if (String.IsNullOrEmpty(mobile))
                                {
                                    if (String.IsNullOrEmpty(email))
                                    {
                                        if (String.IsNullOrEmpty(Convert.ToString(admin)))
                                        {
                                            if (String.IsNullOrEmpty(status))
                                            {
                                                if (String.IsNullOrEmpty(remark))
                                                {
                                                    MessageBox.Show("Please fill in all the data!!");
                                                }
                                                MessageBox.Show("Please fill in all the data!!");
                                            }
                                            MessageBox.Show("Please fill in all the data!!");
                                        }
                                        MessageBox.Show("Please fill in all the data!!");
                                    }
                                    MessageBox.Show("Please fill in all the data!!");
                                }
                                MessageBox.Show("Please fill in all the data!!");
                            }
                            MessageBox.Show("Please fill in all the data!!");
                        }
                        MessageBox.Show("Please check phone again");
                    }
                    MessageBox.Show("Please check email again");
                }
                MessageBox.Show("Please check name again");
            }
            else
            {
                Employee emp = new Employee();
                emp.First_name = firstNameText.Text;
                emp.Last_name = lastNameText.Text;
                emp.Username = usernameText.Text;
                emp.Password = passwordText.Text;
                emp.Dob = Convert.ToDateTime(dobText.Text);
                emp.Mobile = mobileText.Text;
                emp.Email = emailText.Text;
                emp.Admin = Convert.ToInt32(adminText.Text);
                emp.Status = statusText.Text;
                emp.Remark = remarkText.Text;

                InsertSQL add = new InsertSQL();
                int editrecord = add.addNewEmployee(emp);
                MessageBox.Show(" Your seccusful");
                this.Close();
            }
            //Employee emp = new Employee();
            //emp.First_name = firstNameText.Text;
            //emp.Last_name = lastNameText.Text;
            //emp.Username = usernameText.Text;
            //emp.Password = passwordText.Text;
            //emp.Dob = DateTime.Parse(dobText.Text);
            //emp.Mobile = mobileText.Text;
            //emp.Email = emailText.Text;
            //emp.Admin = Int32.Parse(adminText.Text);
            //emp.Status = statusText.Text;
            //emp.Remark = remarkText.Text;

            //InsertSQL empHnd = new InsertSQL();
            //int addrecord = empHnd.addNewEmployee(emp);
            //MessageBox.Show(addrecord + " Your record is added");
        }



        public void UpdateEmployee()
        {
            Employee empi = new Employee();
            //empi.Id = emp.Id;
            empi.First_name = firstNameText.Text;
            empi.Last_name = lastNameText.Text;
            empi.Username = usernameText.Text;
            empi.Password = passwordText.Text;
            empi.Dob = DateTime.Parse(dobText.Text);
            empi.Mobile = mobileText.Text;
            empi.Email = emailText.Text;
            empi.Admin = Int32.Parse(adminText.Text);
            empi.Status = statusText.Text;
            empi.Remark = remarkText.Text;

            UpdateSQL empHnd = new UpdateSQL();
            int Updaterecord = empHnd.UpdateEmployee(empi);
            MessageBox.Show(Updaterecord + " Your record is added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                firstNameText.Text = emp.First_name;
                lastNameText.Text = emp.Last_name;
                usernameText.Text = emp.Username;
                passwordText.Text = emp.Password;
                dobText.Text = emp.Dob.ToString();
                mobileText.Text = emp.Mobile;
                emailText.Text = emp.Email;
                adminText.Text = emp.Admin.ToString();
                statusText.Text = emp.Status;
                remarkText.Text = emp.Remark;
            }
        }
    }
}
