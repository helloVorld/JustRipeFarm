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
            //AddEmployee();
            UpdateEmployee();
        }

        public void AddEmployee()
        {
            Employee emp = new Employee();
            emp.First_name = firstNameText.Text;
            emp.Last_name = lastNameText.Text;
            emp.Username = usernameText.Text;
            emp.Password = passwordText.Text;
            emp.Dob = Int32.Parse(dobText.Text);
            emp.Mobile = mobileText.Text;
            emp.Email = emailText.Text;
            emp.Admin = Int32.Parse(adminText.Text);
            emp.Status = statusText.Text;
            emp.Remark = remarkText.Text;

            InsertSQL empHnd = new InsertSQL();
            int addrecord = empHnd.addNewEmployee(emp);
            MessageBox.Show(addrecord + " Your record is added");
        }



        public void UpdateEmployee()
        {
            Employee empi = new Employee();
            //empi.Id = emp.Id;
            empi.First_name = firstNameText.Text;
            empi.Last_name = lastNameText.Text;
            empi.Username = usernameText.Text;
            empi.Password = passwordText.Text;
            empi.Dob = Int32.Parse(dobText.Text);
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
