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
    public partial class FormPesticideJob : Form
    {
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<SowingJob> sowingLists;
        List<HarvestingJob> harvestLists;
        List<Employee> employeeList;
        List<Pesticide> pesticideList;
        List<PesticideJob> pesticideLists;

        public string state = "";
        public PesticideJob pjj1;
        public FormPesticideJob()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPesticideJob()
        {
            PesticideJob pj = new PesticideJob();
            pj.Description = textBox1.Text;
            string idStr = cbPesticide.Text.Split('.')[0];
            pj.Pesticide_id = int.Parse(idStr);
            pj.Quantity_kg = int.Parse(textBox3.Text);
            string idStr1 = cbSoj.Text.Split('.')[0];
            pj.SowingJob_id = int.Parse(idStr1);
            string idStr2 = cbFarm.Text.Split('.')[0];
            pj.Farm_id = int.Parse(idStr2);
            string idStr3 = cbVehicle.Text.Split('.')[0];
            pj.Vehicle_id = int.Parse(idStr3);
            string idStr4 = cbCrop.Text.Split('.')[0];
            pj.Crop_id = int.Parse(idStr4);
            string idStr5 = cbEmployee.Text.Split('.')[0];
            pj.Employee_id = int.Parse(idStr5);
            pj.Date_start = Convert.ToDateTime(dtpStart.Text);
            pj.Date_end = Convert.ToDateTime(dtpEnd.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewPesticideJob(pj);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void updatePesticideJob()
        {
            PesticideJob pj = new PesticideJob();
            pj.Description = textBox1.Text;
            string idStr = cbPesticide.Text.Split('.')[0];
            pj.Pesticide_id = int.Parse(idStr);
            pj.Quantity_kg = int.Parse(textBox3.Text);
            string idStr1 = cbSoj.Text.Split('.')[0];
            pj.SowingJob_id = int.Parse(idStr1);
            string idStr2 = cbFarm.Text.Split('.')[0];
            pj.Farm_id = int.Parse(idStr2);
            string idStr3 = cbVehicle.Text.Split('.')[0];
            pj.Vehicle_id = int.Parse(idStr3);
            string idStr4 = cbCrop.Text.Split('.')[0];
            pj.Crop_id = int.Parse(idStr4);
            string idStr5 = cbEmployee.Text.Split('.')[0];
            pj.Employee_id = int.Parse(idStr5);
            pj.Date_start = Convert.ToDateTime(dtpStart.Text);
            pj.Date_end = Convert.ToDateTime(dtpEnd.Text);

            UpdateSQL hdl = new UpdateSQL();
            hdl.updatePesticideJob(pj);
            MessageBox.Show("Success!!");
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                updatePesticideJob();
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    if (String.IsNullOrEmpty(cbPesticide.Text))
                    {
                        if (String.IsNullOrEmpty(textBox3.Text))
                        {
                            if (String.IsNullOrEmpty(cbSoj.Text))
                            {
                                if (String.IsNullOrEmpty(cbFarm.Text))
                                {
                                    if (String.IsNullOrEmpty(cbCrop.Text))
                                    {
                                        if (String.IsNullOrEmpty(cbVehicle.Text))
                                        {
                                            if (String.IsNullOrEmpty(cbEmployee.Text))
                                            {
                                                if (String.IsNullOrEmpty(dtpStart.Text))
                                                {
                                                    if (String.IsNullOrEmpty(dtpStart.Text))
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
                    MessageBox.Show("Please fill up the box");
                }
                else
                {
                    addPesticideJob();
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
            pesticideLists = ts.GetPesticideJobList();

            DateTime start_date = Convert.ToDateTime("12/12/2018");
            DateTime end_date = Convert.ToDateTime("12/12/2018");
            DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
            int duration = 0; int todayduration = 0;
            foreach (Employee employee in employeeList)
            {
                foreach (PesticideJob pesticide in pesticideLists)
                {
                    start_date = Convert.ToDateTime(pesticide.Date_start.ToString());
                    end_date = Convert.ToDateTime(pesticide.Date_end.ToString());
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

        private void FormPesticideJob_Load(object sender, EventArgs e)
        {
            InsertSQL pesticideJob = new InsertSQL();

            if (state == "Edit")
            {
                textBox1.Text = pjj1.Description;
                cbPesticide.Text = pjj1.Pesticide_id.ToString();
                textBox3.Text = pjj1.Quantity_kg.ToString();
                cbSoj.Text = pjj1.SowingJob_id.ToString();
                cbFarm.Text = pjj1.Farm_id.ToString();
                cbCrop.Text = pjj1.Crop_id.ToString();
                cbVehicle.Text = pjj1.Vehicle_id.ToString();
                cbEmployee.Text = pjj1.Employee_id.ToString();
                dtpStart.Value = pjj1.Date_start;
                dtpEnd.Value = pjj1.Date_end;

                TestSQL ts = new TestSQL();
                cropLists = ts.GetCropList();
                employeeList = ts.GetEmployeeList();
                farmLists = ts.GetFarmList();
                vehicleList = ts.GetVehicleList();
                pesticideList = ts.GetPesticideList();
                sowingLists = ts.GetSowingJobList();
                employeeList = ts.GetEmployeeList();

                SowingJob sj11 = new SowingJob();

                foreach (SowingJob sow in sowingLists)
                {

                    cbSoj.Items.Add(sow.Id);

                }

                foreach (Crop crop1 in cropLists)
                {

                    string showText = crop1.Id + ". " + crop1.Name;
                    cbCrop.Items.Add(showText);

                }

                foreach (Pesticide pest in pesticideList)
                {

                    string showText = pest.Id + ". " + pest.Name;
                    cbVehicle.Items.Add(showText);

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

                foreach (Farm farm in farmLists)
                {
                    string showText = farm.Id + ". " + farm.Description;
                    cbFarm.Items.Add(showText);
                }
            
            }
        }
    }
}
