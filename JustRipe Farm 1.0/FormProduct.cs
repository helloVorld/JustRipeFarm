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
    public partial class FormProduct : Form
    {
        public string state = "";
        public Product prod;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                update();
            }
            else
            {
                if (String.IsNullOrEmpty(nameText.Text))
                {
                    if (String.IsNullOrEmpty(typeText.Text))
                    {
                        if (String.IsNullOrEmpty(quantityNumericUpDown.Text))
                        {
                            if (String.IsNullOrEmpty(weightText.Text))
                            {
                                if (String.IsNullOrEmpty(boxIdText.Text))
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
                    add();
                }
            }
        }

        private void add()
        {
            Product prod = new Product();
            prod.Name = nameText.Text;
            prod.Type = typeText.Text;
            prod.Quantity_box = Convert.ToInt32(quantityNumericUpDown.Value);
            prod.Weight = decimal.Parse(weightText.Text);
            prod.Box_id = Int32.Parse(boxIdText.Text);

            InsertSQL prodHnd = new InsertSQL();
            int addrecord = prodHnd.addNewProduct(prod);
            MessageBox.Show("Your record is added");
        }

        private void update()
        {
            Product prod = new Product();
            prod.Name = nameText.Text;
            prod.Type = typeText.Text;
            prod.Quantity_box = Convert.ToInt32(quantityNumericUpDown.Value);
            prod.Weight = decimal.Parse(weightText.Text);
            prod.Box_id = Int32.Parse(boxIdText.Text);

            UpdateSQL prodHnd = new UpdateSQL();
            int addrecord = prodHnd.updateProduct(prod);
            MessageBox.Show("Your record is added");
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            InsertSQL product = new InsertSQL();

            if (state == "Edit")
            {
                nameText.Text = prod.Name;
                typeText.Text = prod.Type;
                quantityNumericUpDown.Text = prod.Quantity_box.ToString();
                weightText.Text = prod.Weight.ToString();
                boxIdText.Text = prod.Box_id.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
