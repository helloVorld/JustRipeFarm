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
            if (state == "Edit")
            {
                UpdateEmployee();
            }
            else
            {
                if (String.IsNullOrEmpty(firstNameText.Text))
                {
                    if (String.IsNullOrEmpty(lastNameText.Text))
                    {
                        if (String.IsNullOrEmpty(usernameText.Text))
                        {
                            if (String.IsNullOrEmpty(passwordText.Text))
                            {
                                if (String.IsNullOrEmpty(dobText.Text))
                                {
                                    if (String.IsNullOrEmpty(mobileText.Text))
                                    {
                                        if (String.IsNullOrEmpty(emailText.Text))
                                        {
                                            if (String.IsNullOrEmpty(adminText.Text))
                                            {
                                                if (String.IsNullOrEmpty(statusText.Text))
                                                {
                                                    if (String.IsNullOrEmpty(remarkText.Text))
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
                    addEmployee();
                }
            }
        }

        public void addEmployee()
        {
            Employee emp = new Employee();
            emp.First_name = firstNameText.Text;
            emp.Last_name = lastNameText.Text;
            emp.Username = usernameText.Text;
            emp.Password = passwordText.Text;
            emp.Dob = Convert.ToDateTime(dobText.Text);
            emp.Mobile = mobileText.Text;
            emp.Email = emailText.Text;
            emp.Admin = Convert.ToBoolean(adminText.Text);
            emp.Status = statusText.Text;
            emp.Remark = remarkText.Text;

            InsertSQL add = new InsertSQL();
            int editrecord = add.addNewEmployee(emp);
            MessageBox.Show(" Your seccusful");
            this.Close();
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
            empi.Admin = Boolean.Parse(adminText.Text);
            empi.Status = statusText.Text;
            empi.Remark = remarkText.Text;

            UpdateSQL empHnd = new UpdateSQL();
            int Updaterecord = empHnd.UpdateEmployee(empi);
            MessageBox.Show(Updaterecord + " Your record is added");
            this.Close();
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
