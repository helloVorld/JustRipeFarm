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
    public partial class FormFertiliser : Form
    {
        List<Fertiliser> FertiliserList;

        public string state = "";
        public Fertiliser f1;


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
            if (state == "Edit")
            {
                updateFertiliser();
            }
            else
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
            }

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

        private void FormFertiliser_Load(object sender, EventArgs e)
        {
            InsertSQL crop = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = f1.Name;
                textBox2.Text = f1.Quantity_kg.ToString();
                textBox3.Text = f1.Remark;
            }
        }
    }
}
