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
    public partial class FormCropcs : Form
    {

        List<Crop> CropList;

        public string state = "";
        public Crop cr;

        

        public FormCropcs()
        {
            InitializeComponent();
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
            if (state == "Edit")
            {
                updateCrop();
            }
            else
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
            }
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

        private void FormCropcs_Load(object sender, EventArgs e)
        {
            InsertSQL crop = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = cr.Name;
                textBox2.Text = cr.Type;
                textBox3.Text = cr.Quantity_plot.ToString();
                textBox4.Text = cr.Remark.ToString();
            }

        }
    }
}