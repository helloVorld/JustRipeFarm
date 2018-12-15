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
    public partial class FormPesticide : Form
    {
        public string state = "";
        public Pesticide p1;
        public FormPesticide()
        {
            InitializeComponent();
        }

        public void UpdatePesticide()
        {
            Pesticide p1 = new Pesticide();
            p1.Name = textBox1.Text;
            p1.Quantity_kg = Int32.Parse(textBox2.Text);
            p1.Remark = textBox3.Text;

            UpdateSQL ord = new UpdateSQL();
            int changerecord = ord.updatePesticide(p1);
            MessageBox.Show("Successful!");
        }

        private void addPesticide(string name, int quantuty_kg, string remark)
        {
            Pesticide p1 = new Pesticide();
            p1.Name = textBox1.Text;
            p1.Quantity_kg = Int32.Parse(textBox2.Text);
            p1.Remark = textBox3.Text;

            InsertSQL add = new InsertSQL();
            int changerecord = add.addNewPesticide(p1);
            MessageBox.Show(changerecord + " Your record is added");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //addPesticide(textBox1.Text, textBox2.Text, textBox3.Text);
            //UpdateOrder();

            if (state == "Edit")
            {
                UpdatePesticide();
            }
        }

        private void FormPesticide_Load(object sender, EventArgs e)
        {
            InsertSQL pesticide = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = p1.Name;
                textBox2.Text = p1.Quantity_kg.ToString();
                textBox3.Text = p1.Remark;
            }

        }
    }
}
