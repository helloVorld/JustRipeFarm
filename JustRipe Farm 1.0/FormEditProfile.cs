﻿using System;
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
    public partial class FormEditProfile : Form
    {
        public Employee employee;

        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void FormEmployee(object sender, EventArgs e)
        {
            textBox1.Text = employee.First_name;
            textBox2.Text = employee.Last_name;
            dateTimePicker1.Text = employee.Dob.ToString("yyyy-MM-dd");
            textBox3.Text = employee.Mobile;
            textBox4.Text = employee.Email;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CheckProfile(string first_name, string last_name, DateTime dob, string mobile, string email)
        {
            
                Employee employee = new Employee();
                employee.First_name = textBox1.Text;
                employee.Last_name = textBox2.Text;
                employee.Dob = Convert.ToDateTime(dateTimePicker1.Text);
                employee.Remark = textBox3.Text;
                employee.Email = textBox4.Text;
                UpdateSQL update = new UpdateSQL();
                int editrecord = update.editEmployee(employee);
                MessageBox.Show(" Your seccusful");
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    if (String.IsNullOrEmpty(dateTimePicker1.Text))
                    {
                        if (String.IsNullOrEmpty(textBox3.Text))
                        {
                            if (String.IsNullOrEmpty(textBox4.Text))
                            {
                                MessageBox.Show("Please fill up the box");
                            }
                            MessageBox.Show("Please fill up the box");
                        }
                        MessageBox.Show("Please fill up the box");
                    }
                    MessageBox.Show("Please fill up the box");
                }
                MessageBox.Show("Please fill up the box");
            }
            else
            {
                CheckProfile(textBox1.Text, textBox2.Text, Convert.ToDateTime(dateTimePicker1.Text), textBox3.Text, textBox4.Text);
            }
        }
    }
}

