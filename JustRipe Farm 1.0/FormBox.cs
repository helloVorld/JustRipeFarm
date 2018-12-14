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

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
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
            addBox();
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
