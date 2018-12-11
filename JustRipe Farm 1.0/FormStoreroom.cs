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
        public FormStoreroom()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
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
            // Console.WriteLine(availability);
            InsertSQL storeHnd = new InsertSQL();
            int addrecord = storeHnd.addNewStore(store);
            MessageBox.Show(addrecord + "Your record is added");
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

        }
    }
}
