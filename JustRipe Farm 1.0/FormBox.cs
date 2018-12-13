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
    public partial class FormBox : Form
    {
        public FormBox()
        {
            InitializeComponent();
        }

        private void CheckBox(string name, double width, double height, double length, double max_weight, int quantity, string status)
        {

            if (String.IsNullOrEmpty(name))
            {
                if (String.IsNullOrEmpty(Convert.ToString(width)))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(height)))
                    {
                        if (String.IsNullOrEmpty(Convert.ToString(length)))
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(max_weight)))
                            {
                                if (String.IsNullOrEmpty(Convert.ToString(quantity)))
                                {
                                    if (String.IsNullOrEmpty(status))
                                    {
                                        MessageBox.Show("Please check status again");
                                    }
                                    MessageBox.Show("Please check quantity again");
                                }
                                MessageBox.Show("Please check max wight again");
                            }
                            MessageBox.Show("Please check length again");
                        }
                        MessageBox.Show("Please check height again");
                    }
                    MessageBox.Show("Please check width again");
                }
                MessageBox.Show("Please check name again");
            }
            else
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
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            CheckBox(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox6.Text), textBox7.Text);
        }
    }

    //    bool ck1 = String.IsNullOrEmpty(name);
    //    bool ck2 = String.IsNullOrEmpty(width.ToString());
    //    bool ck3 = String.IsNullOrEmpty(height.ToString());
    //    bool ck4 = String.IsNullOrEmpty(length.ToString());
    //    bool ck5 = String.IsNullOrEmpty(max_weight.ToString());
    //    bool ck6 = String.IsNullOrEmpty(quantity.ToString());
    //    bool ck7 = String.IsNullOrEmpty(status);

    //    if (ck1 == true && ck2 == true && ck3 == ck1 && ck4 == true && ck5 == true && ck6 == true && ck7 == true)
    //    {
    //        Box box = new Box();
    //        box.Name = textBox1.Text;
    //        box.Width = Convert.ToDouble(textBox2.Text);
    //        box.Height = Convert.ToDouble(textBox3.Text);
    //        box.Length = Convert.ToDouble(textBox4.Text);
    //        box.Max_weight = Convert.ToDouble(textBox5.Text);
    //        box.Quantity = Convert.ToInt32(textBox6.Text);
    //        box.Status = textBox7.Text;

    //        InsertSQL addHnd = new InsertSQL();
    //        int addrecord = addHnd.addNewBox(box);
    //        MessageBox.Show(addrecord + " Your record is added");
    //    }
    //    else
    //    {
    //        ErrorMsg.UpdateOptionNoSelect();
    //    }
}

//        private void btnCancel_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnDone_Click(object sender, EventArgs e)
//        {
//            CheckBox(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox6.Text), textBox7.Text);
//        }
//    }
//}
