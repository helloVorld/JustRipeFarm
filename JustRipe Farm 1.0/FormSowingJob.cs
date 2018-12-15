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
    public partial class FormSowingJob : Form
    {
        // prepare variable for storing list<class>
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<Employee> employeeList;
        public string state = "";
        public SowingJob sowj;

        public FormSowingJob()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //get all fields data
        }
        public void add()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = Convert.ToInt32(cbCrop.Text);
            s1.Quantity_prop = int.Parse(nUDQty.Text);
            s1.Farm_id = int.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = int.Parse(cbVehicle.Text);
            s1.Employee_id = int.Parse(cbEmployee.Text);
            s1.Date_start = Convert.ToDateTime(dtpDate.Text);
            s1.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            s1.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewSowingJob(s1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        public void update()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = Convert.ToInt32(cbCrop.Text);
            s1.Quantity_prop = int.Parse(nUDQty.Text);
            s1.Farm_id = int.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = int.Parse(cbVehicle.Text);
            s1.Employee_id = int.Parse(cbEmployee.Text);
            s1.Date_start = Convert.ToDateTime(dtpDate.Text);
            s1.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            s1.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            UpdateSQL add = new UpdateSQL();
            int addrecord = add.UpdateSowingJob(s1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSowingJob_Load(object sender, EventArgs e)
        {
            // when form loads, get all fields data from mysql
            // then store to a bunch of list<class>
            // then all combo boxes gets data from the list<class>

            // mysql :
            // 1. get crop list from crop table
            // 2. get farm list from farm table
            // 3. get vehicle list from vehicle table
            // 4. get employee list from employee table

            // combo box
            // 5. load crop list to combo box 
            // 6. load farm list to combo box 
            // 7. load vehicle list to combo box 
            // 8. load employee list to combo box 

            // 1. 
            TestSQL ts = new TestSQL();
            cropLists = ts.GetCropList();
            vehicleList = ts.GetVehicleList();

            // 5.
            foreach (Crop crop in cropLists)
            {
                cbCrop.Items.Add(crop.Id+". "+crop.Name);
            }

        }

        private void nUDQty_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
