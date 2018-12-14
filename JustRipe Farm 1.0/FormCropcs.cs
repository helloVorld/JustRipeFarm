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
    public partial class FormCropcs : Form
    {
        public FormCropcs()
        {
            InitializeComponent();
        }

        private void checkCrop(string name, string type, int quantity_plot, string remark)
        {
            //if (String.IsNullOrEmpty(name))
            //{
            //    if (String.IsNullOrEmpty(type))
            //    {
            //        if (String.IsNullOrEmpty(Convert.ToString(quantity_plot)))
            //        {
            //            if (String.IsNullOrEmpty(remark))
            //            {
            //                MessageBox.Show("Please check remark again");
            //            }
            //            MessageBox.Show("Please check quantity plot again");
            //        }
            //        MessageBox.Show("Please check type again");
            //    }
            //    MessageBox.Show("Please check name again");
            //}
            //else
            //{
            //    Crop crop = new Crop();
            //    crop.Name = textBox1.Text;
            //    crop.Type = textBox2.Text;
            //    crop.Quantity_plot = Convert.ToInt32(textBox3.Text);
            //    crop.Remark = textBox4.Text;

            //    InsertSQL add = new InsertSQL();
            //    int editrecord = add.addNewCrop(crop);
            //    MessageBox.Show(" Your seccusful");
            //    this.Close();
            //}
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void valid()
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                if (String.IsNullOrEmpty(textBox2.Text))
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
            else
            {
                addCrop();
            }
            //checkCrop(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);
        }

        public void addCrop()
        {
            Crop crop = new Crop();
            crop.Name = textBox1.Text;
            crop.Type = textBox2.Text;
            crop.Quantity_plot = Convert.ToInt32(textBox3.Text);
            crop.Remark = textBox4.Text;

            InsertSQL add = new InsertSQL();
            int editrecord = add.addNewCrop(crop);
            MessageBox.Show(" Your seccusful");
            this.Close();
        }

        public void updateCrop()
        {
            Crop crop = new Crop();
            crop.Name = textBox1.Text;
            crop.Type = textBox2.Text;
            crop.Quantity_plot = Convert.ToInt32(textBox3.Text);
            crop.Remark = textBox4.Text;

            UpdateSQL add = new UpdateSQL();
            int editrecord = add.updateCrop(crop);
            MessageBox.Show(" Your seccusful");
            this.Close();
        }
    }
}

        //private void checkCrop(string name, string type, int quantity_plot, string remark)
        //{

        //    bool ck1 = String.IsNullOrEmpty(name);
        //    bool ck2 = String.IsNullOrEmpty(type);
        //    bool ck3 = String.IsNullOrEmpty(quantity_plot.ToString());
        //    bool ck4 = String.IsNullOrEmpty(remark);

        //    if (ck1 == true && ck2 == true && ck3 == ck1 && ck4 == true )
        //    {
        //        //InsertSQL Hnd = new InsertSQL();
        //        //int addrecord = Hnd.addNewCrop(box);
        //        //MessageBox.Show(addrecord + " Your record is added");
        //    }
        //    else
        //    {
        //        ErrorMsg.UpdateOptionNoSelect();
        //    }
        //}

