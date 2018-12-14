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
    public partial class FormFertiliser : Form
    {
        public FormFertiliser()
        {
            InitializeComponent();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    if (String.IsNullOrEmpty(textBox3.Text))
                    {
                        MessageBox.Show("Please check last name again");
                    }
                    MessageBox.Show("Please check last name again");
                }
                MessageBox.Show("Please check first name again");
            }
            else
            {
                addFertiliser();
            }
            //updateFertiliser();
        }

        private void addFertiliser()
        {
            Fertiliser f1 = new Fertiliser();
            f1.Name = textBox1.Text;
            f1.Quantity_kg = Convert.ToInt32(textBox2.Text);
            f1.Remark = textBox3.Text;

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewFertiliser(f1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void updateFertiliser()
        {
            Fertiliser f1 = new Fertiliser();
            f1.Name = textBox1.Text;
            f1.Quantity_kg = Convert.ToInt32(textBox2.Text);
            f1.Remark = textBox3.Text;

            UpdateSQL add = new UpdateSQL();
            int editrecord = add.updateFertiliser(f1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }
    }
}

//            bool ck1 = String.IsNullOrEmpty(name);
//            bool ck2 = String.IsNullOrEmpty(quantity_kg.ToString());
//            bool ck3 = String.IsNullOrEmpty(remark);

//            if (ck1 == true && ck2==true && ck3 == true)
//            {
//                Fertiliser f1 = new Fertiliser();
//                f1.Name = textBox1.Text;
//                f1.Quantity_kg = Convert.ToInt32(textBox2.Text);
//                f1.Remark = textBox3.Text;

//                InsertSQL add = new InsertSQL();
//                int addrecord = add.addNewFertiliser(f1);
//                MessageBox.Show(addrecord + " Your record is added");
//            }
//            else
//            {
//                MessageBox.Show("Unvalid, Check Again");
//            }
//        }

//private void btnCancel_Click(object sender, EventArgs e)
//{
//    this.Close();
//}

//private void btnDone_Click(object sender, EventArgs e)
//{
//    CheckFertiliser(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
//}
//    }
//}
