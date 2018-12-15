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
    public partial class FormEditPassword : Form
    {

        public Employee employee;

        public FormEditPassword()
        {
            InitializeComponent();
        }

        private void FormEmployee(object sender, EventArgs e)
        {
            textBox1.Text = employee.Username;
            textBox2.Text = employee.Password;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void button5_Click(object sender, EventArgs e)
        {
            checkProfile(textBox1.Text,textBox2.Text);
        }

        private void checkProfile(string username, string password)
        {
            if (String.IsNullOrEmpty(username))
            {
                if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please check user again");
                }
                MessageBox.Show("Please check password again");
            }
            else
            {
                Employee employee = new Employee();
                employee.Username = textBox1.Text;
                employee.Password = textBox2.Text;
                employee.Password = textBox3.Text;

                if (textBox3.Text == textBox2.Text)
                {
                    UpdateSQL update = new UpdateSQL();
                    int editrecord = update.editPassword(employee);
                    MessageBox.Show(" Your seccusful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not valid and confirm password");
                }
                //checkConfirmPassword(textBox3.Text);
            }
        }

        private void checkConfirmPassword(string password)
        {
            
        }


    }
}
