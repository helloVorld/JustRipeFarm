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
using MySql.Data.MySqlClient;

namespace JustRipeFarm
{
    public partial class FormBox : Form
    {
        public Box bb1;
        public string state = "";

        public FormBox()
        {
            InitializeComponent();
        }

        private void addBox()
        {
            Box box = new Box();
            box.Name = textBox1.Text;
            box.Width = Convert.ToDouble(textBox2.Text);
            box.Height = Convert.ToDouble(textBox3.Text);
            box.Length = Convert.ToDouble(textBox4.Text);
            box.Max_weight = Convert.ToDouble(textBox5.Text);
            box.Quantity = Convert.ToInt32(textBox6.Text);
            box.Status = textBox7.Text;

            InsertSQL addHnd = new InsertSQL();
            int addrecord = addHnd.addNewBox(box);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void updateBox()
        {
            Box box = new Box();
            box.Name = textBox1.Text;
            box.Width = Convert.ToDouble(textBox2.Text);
            box.Height = Convert.ToDouble(textBox3.Text);
            box.Length = Convert.ToDouble(textBox4.Text);
            box.Max_weight = Convert.ToDouble(textBox5.Text);
            box.Quantity = Convert.ToInt32(textBox6.Text);
            box.Status = textBox7.Text;

            UpdateSQL addHnd = new UpdateSQL();
            int addrecord = addHnd.updateBox(box);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void FormBox_Load(object sender, EventArgs e)
        {
            InsertSQL box = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = bb1.Name;
                textBox2.Text = bb1.Width.ToString();
                textBox3.Text = bb1.Height.ToString();
                textBox4.Text = bb1.Length.ToString();
                textBox5.Text = bb1.Max_weight.ToString();
                textBox6.Text = bb1.Quantity.ToString();
                textBox7.Text = bb1.Status;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                updateBox();
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(textBox2.Text)))
                    {
                        if (String.IsNullOrEmpty(Convert.ToString(textBox3.Text)))
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(textBox4.Text)))
                            {
                                if (String.IsNullOrEmpty(Convert.ToString(textBox5.Text)))
                                {
                                    if (String.IsNullOrEmpty(Convert.ToString(textBox6.Text)))
                                    {
                                        if (String.IsNullOrEmpty(textBox7.Text))
                                        {
                                            MessageBox.Show("please fill up all the box");
                                        }
                                        MessageBox.Show("please fill up all the box");
                                    }
                                    MessageBox.Show("please fill up all the box");
                                }
                                MessageBox.Show("Please fill up all the box");
                            }
                            MessageBox.Show("please fill up all the box");
                        }
                        MessageBox.Show("please fill up all the box");
                    }
                    MessageBox.Show("please fill up all the box");
                }
                else
                {
                    addBox();
                }
            }
        }
    }
}