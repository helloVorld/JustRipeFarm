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
    public partial class FormStoreroom : Form
    {
        public string state = "";
        public Storeroom sr1;
        public FormStoreroom()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                updateStock();
            }
            else
            {
                if (String.IsNullOrEmpty(descriptionText.Text))
                {
                    if (String.IsNullOrEmpty(storeNumericUpDown.Text))
                    {
                        if (String.IsNullOrEmpty(tempText.Text))
                        {
                            MessageBox.Show("Please fill up the box");
                        }
                        MessageBox.Show("Please fill up the box");
                    }
                    MessageBox.Show("Please fill up the box");
                }
                else
                {
                    addStock();
                }
            }
        }

        public void addStock()
        {
            Storeroom store = new Storeroom();
            store.Description = descriptionText.Text;
            store.StoringQty = Convert.ToInt32(storeNumericUpDown.Value);
            store.Temperature = Int32.Parse(tempText.Text);
            bool avail = false;
            int availability = availabilityBox.SelectedIndex;
            if (availability == 1)
            {
                avail = true;
            }
            store.Availability = avail;
            InsertSQL storeHnd = new InsertSQL();
            int addrecord = storeHnd.addNewStore(store);
            MessageBox.Show(addrecord + " Your record is added");
        }

        public void updateStock()
        {
            Storeroom store = new Storeroom();
            store.Description = descriptionText.Text;
            store.StoringQty = Convert.ToInt32(storeNumericUpDown.Value);
            store.Temperature = Int32.Parse(tempText.Text);
            bool avail = false;
            int availability = availabilityBox.SelectedIndex;
            if (availability == 1)
            {
                avail = true;
            }
            store.Availability = avail;
            UpdateSQL storeHnd = new UpdateSQL();
            storeHnd.updateStore(store);
            MessageBox.Show(" Your record is added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void availabilityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormStoreroom_Load(object sender, EventArgs e)
        {
            InsertSQL storeroom = new InsertSQL();

            if (state == "Edit")
            {
                descriptionText.Text = sr1.Description;
                storeNumericUpDown.Text = sr1.StoringQty.ToString();
                tempText.Text = sr1.Temperature.ToString();
            }
        }
    }
}
