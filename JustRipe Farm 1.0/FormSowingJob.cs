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
            add();
        }
        public void add()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = int.Parse(cbCrop.SelectedValue.ToString());//int.Parse(cbCrop.Text);
            s1.Quantity_prop = int.Parse(nUDQty.Text);
            s1.Farm_id = int.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = int.Parse(cbVehicle.Text);
            s1.Employee_id = int.Parse(cbEmployee.Text);
            s1.Date_start = Convert.ToDateTime(dtpDate.Text);
            s1.Date_end = Convert.ToDateTime(dtpDateEnd.Text);
            s1.Time_start = Convert.ToDateTime(dtpTimeStart.Text);
            s1.Time_end = Convert.ToDateTime(dtpTimeEnd.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewSowingJob(s1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        public void update()
        {
            int id;
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = //int.Parse(cbCrop.SelectedValue.ToString(), out id);//Convert.ToInt32(cbCrop.Text);
            s1.Quantity_prop = int.Parse(nUDQty.Text);
            s1.Farm_id = int.Parse(cbFarm.SelectedText);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = int.Parse(cbVehicle.SelectedText);
            s1.Employee_id = int.Parse(cbEmployee.SelectedText);
            s1.Date_start = Convert.ToDateTime(dtpDate.Text);
            s1.Date_end = Convert.ToDateTime(dtpDateEnd.Text);
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
            employeeList = ts.GetEmployeeList();
            farmLists = ts.GetFarmList();
            vehicleList = ts.GetVehicleList();

            // 5.
            foreach (Crop crop in cropLists)
            {
                
                cbCrop.Items.Add(crop.Id.ToString() + ". " + crop.Name);
      
            }

            foreach (Vehicle vehicle in vehicleList)
            {

                cbVehicle.Items.Add(vehicle.Id.ToString() + ". " + vehicle.Name);
             

            }

            foreach (Employee employee in employeeList)
            {
                if (employee.Admin == false)
                {
                   
                    cbEmployee.Items.Add(employee.Id.ToString() + ". " + employee.Username);
                    
                }

            }

            foreach (Farm farm in farmLists)
            {
               
                cbFarm.Items.Add(farm.Id.ToString() + ". " + farm.Description);
                
            }

        }

        private void nUDQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCrop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
