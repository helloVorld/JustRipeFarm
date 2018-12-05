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
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
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
            MessageBox.Show(addrecord + "Your record is added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
