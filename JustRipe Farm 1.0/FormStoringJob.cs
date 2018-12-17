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
    public partial class FormStoringJob : Form
    {
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<SowingJob> sowingLists;
        List<HarvestingJob> harvestLists;
        List<Employee> employeeList;
        List<Box> boxList;
        public string state = "";
        public StoringJob sj1;

        public FormStoringJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addStoringJob()
        {
            StoringJob sj = new StoringJob();
            sj.Description = textBox1.Text;
            string idStr = cbHarvest.Text.Split('.')[0];
            sj.Harvest_id = int.Parse(idStr);
            string idStr1 = cbCrop.Text.Split('.')[0];
            sj.Crop_id = int.Parse(idStr1);
            string idStr2 = cbBox.Text.Split('.')[0];
            sj.Box_id = int.Parse(idStr2);
            sj.Quantity = int.Parse(textBox5.Text);
            string idStr3 = cbVehicle.Text.Split('.')[0];
            sj.Vehicle_id = int.Parse(idStr3);
            string idStr4 = cbEmployee.Text.Split('.')[0];
            sj.Employee_id = int.Parse(idStr4);
            sj.Date_start = Convert.ToDateTime(dtpStart.Text);
            sj.Date_end = Convert.ToDateTime(dtpEnd.Text);

            InsertSQL addHnd = new InsertSQL();
            int addrecord = addHnd.addNewStoringJob(sj);
            MessageBox.Show(addrecord + " Your record is added");
            this.Close();
        }

        private void updateStoringJob()
        {
            StoringJob sj = new StoringJob();
            sj.Id = sj1.Id;
            sj.Description = textBox1.Text;
            string idStr = cbHarvest.Text.Split('.')[0];
            sj.Harvest_id = int.Parse(idStr);
            string idStr1 = cbCrop.Text.Split('.')[0];
            sj.Crop_id = int.Parse(idStr1);
            string idStr2 = cbBox.Text.Split('.')[0];
            sj.Box_id = int.Parse(idStr2);
            sj.Quantity = int.Parse(textBox5.Text);
            string idStr3 = cbVehicle.Text.Split('.')[0];
            sj.Vehicle_id = int.Parse(idStr3);
            string idStr4 = cbEmployee.Text.Split('.')[0];
            sj.Employee_id = int.Parse(idStr4);
            sj.Date_start = Convert.ToDateTime(dtpStart.Text);
            sj.Date_end = Convert.ToDateTime(dtpEnd.Text);

            UpdateSQL update = new UpdateSQL();
            update.updateStoringJob(sj);
            MessageBox.Show(" Your record is added");
            this.Close();
        }

        private void FormStoringJob_Load(object sender, EventArgs e)
        {
            InsertSQL StoringJob = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = sj1.Description;
                cbHarvest.Text = sj1.Harvest_id.ToString();
                cbCrop.Text = sj1.Crop_id.ToString();
                cbBox.Text = sj1.Box_id.ToString();
                textBox5.Text = sj1.Quantity.ToString();
                cbVehicle.Text = sj1.Vehicle_id.ToString();
                cbEmployee.Text = sj1.Employee_id.ToString();
                dtpStart.Value = sj1.Date_start;
                dtpEnd.Value = sj1.Date_end;

                TestSQL ts = new TestSQL();
                cropLists = ts.GetCropList();
                employeeList = ts.GetEmployeeList();
                vehicleList = ts.GetVehicleList();
                boxList = ts.GetBoxList();
                harvestLists = ts.GetHarvestingJobList();

                SowingJob sj11 = new SowingJob();

                foreach (HarvestingJob harvest in harvestLists)
                {

                    string showText = harvest.Id + ". " + harvest.Description;
                    cbCrop.Items.Add(showText);

                }

                foreach (Box box in boxList)
                {

                    string showText = box.Id + ". " + box.Name;
                    cbCrop.Items.Add(showText);

                }

                foreach (Crop crop1 in cropLists)
                {

                    string showText = crop1.Id + ". " + crop1.Name;
                    cbCrop.Items.Add(showText);

                }

                foreach (Vehicle vehicle in vehicleList)
                {

                    string showText = vehicle.Id + ". " + vehicle.Name;
                    cbVehicle.Items.Add(showText);

                }

                foreach (Employee employee in employeeList)
                {
                    if (employee.Admin == false)
                    {
                        string showText = employee.Id + ". " + employee.Username;
                        cbEmployee.Items.Add(showText);
                    }

                }

                
            
            }
        }

        public void checkAssignJobandAdd()
        {

            TestSQL ts = new TestSQL();
            cropLists = ts.GetCropList();
            employeeList = ts.GetEmployeeList();
            farmLists = ts.GetFarmList();
            vehicleList = ts.GetVehicleList();
            harvestLists = ts.GetHarvestingJobList();

            DateTime start_date = Convert.ToDateTime("12/12/2018");
            DateTime end_date = Convert.ToDateTime("12/12/2018");
            DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            int duration = 0; int todayduration = 0;
            foreach (Employee employee in employeeList)
            {
                foreach (HarvestingJob harvest in harvestLists)
                {
                    start_date = Convert.ToDateTime(harvest.Date_start.ToString());
                    end_date = Convert.ToDateTime(harvest.Date_end.ToString());
                    duration = Convert.ToInt32((end_date - start_date).TotalDays);
                    todayduration = Convert.ToInt32((currentDate - start_date).TotalDays);
                    if (duration < todayduration)
                    {
                        cbEmployee.Items.Add(employee.Id.ToString());
                        //add();
                        MessageBox.Show("yes");
                    }
                    else
                    {
                        MessageBox.Show("no");
                    }
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            addStoringJob();

            if (state == "Edit")
            {
                updateStoringJob();
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    if (String.IsNullOrEmpty(cbHarvest.Text))
                    {
                        if (String.IsNullOrEmpty(cbCrop.Text))
                        {
                            if (String.IsNullOrEmpty(cbBox.Text))
                            {
                                if (String.IsNullOrEmpty(textBox5.Text))
                                {
                                    if (String.IsNullOrEmpty(cbVehicle.Text))
                                    {
                                        if (String.IsNullOrEmpty(cbEmployee.Text))
                                        {
                                            if (String.IsNullOrEmpty(dtpStart.Text))
                                            {
                                                if (String.IsNullOrEmpty(dtpEnd.Text))
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
                    //checkAssignJobandAdd();
                    addStoringJob();
                }
            }
        }       
    }
}
