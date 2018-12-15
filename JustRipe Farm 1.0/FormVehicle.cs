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
    public partial class FormVehicle : Form
    {
        public string state = "";
        public Vehicle v1;
        public FormVehicle()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            addVehicle();
        }

        public void addVehicle()
        {
            Vehicle vech = new Vehicle();
            vech.Name = nameText.Text;
            vech.Serial_number = serialNumText.Text;
            vech.Buy_date = this.buyDateTimePicker.Value;
            vech.Last_service_date = this.serviceDateTimePicker.Value;
            vech.Remark = remarkText.Text;

            InsertSQL vechHnd = new InsertSQL();
            int addrecord = vechHnd.addNewVehicle(vech);
            MessageBox.Show(addrecord + "Your record is added");
        }

        public void updateVehicle()
        {
            Vehicle vech = new Vehicle();
            vech.Name = nameText.Text;
            vech.Serial_number = serialNumText.Text;
            vech.Buy_date = this.buyDateTimePicker.Value;
            vech.Last_service_date = this.serviceDateTimePicker.Value;
            vech.Remark = remarkText.Text;

            UpdateSQL vechHnd = new UpdateSQL();
            int addrecord = vechHnd.updateVehicle(vech);
            MessageBox.Show(addrecord + "Your record is added");
        }

        private void buyDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
