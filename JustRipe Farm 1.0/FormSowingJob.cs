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
    public partial class FormSowingJob : Form
    {
        //CheckingSQL csql = new CheckingSQL();
        // prepare variable for storing list<class>
        List<Crop> cropLists;
        List<Vehicle> vehicleList;
        List<Farm> farmLists;
        List<SowingJob> sowingJob;
        List<Employee> employeeList;
        public string state = "";
        public SowingJob sowj;

        public FormSowingJob()
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
                if (String.IsNullOrEmpty(tbDescription.Text))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(cbCrop.Text)))
                    {
                        if (String.IsNullOrEmpty(Convert.ToString(nUDQty.Text)))
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(cbFarm.Text)))
                            {
                                if (String.IsNullOrEmpty(Convert.ToString(nUDArea.Text)))
                                {
                                    if (String.IsNullOrEmpty(Convert.ToString(cbVehicle.Text)))
                                    {
                                        if (String.IsNullOrEmpty(Convert.ToString(cbEmployee.Text)))
                                        {
                                            if (String.IsNullOrEmpty(Convert.ToString(dtpDate.Text)))
                                            {
                                                if (String.IsNullOrEmpty(Convert.ToString(dtpDateEnd.Text)))
                                                {
                                                    MessageBox.Show("Please fill up all the box");
                                                }
                                                MessageBox.Show("Please fill up all the box");
                                            }
                                            MessageBox.Show("Please fill up all the box");
                                        }
                                        MessageBox.Show("Please fill up all the box");
                                    }
                                    MessageBox.Show("Please fill up all the box");
                                }
                                MessageBox.Show("Please fill up all the box");
                            }
                            MessageBox.Show("Please fill up all the box");
                        }
                        MessageBox.Show("Please fill up all the box");
                    }
                    MessageBox.Show("Please fill up all the box");
                }
                else
                {
                    checkAsignJobandAdd();
                }
            }
        }
        public void add()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = Int32.Parse(cbCrop.Text);
            s1.Quantity_prop = Int32.Parse(nUDQty.Text);
            s1.Farm_id = Int32.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = Int32.Parse(cbVehicle.Text);
            s1.Employee_id = Int32.Parse(cbEmployee.Text);
            s1.Date_start = this.dtpDate.Value;
            s1.Date_end = this.dtpDateEnd.Value;
            

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewSowingJob(s1);
            MessageBox.Show("Seccuess!!");
            this.Close();
        }

        public void update()
        {
            SowingJob s1 = new SowingJob();
            s1.Description = tbDescription.Text;
            s1.Crop_id = int.Parse(cbCrop.Text);
            s1.Quantity_prop = int.Parse(nUDQty.Text);
            s1.Farm_id = int.Parse(cbFarm.Text);
            s1.Used_area = nUDArea.Text;
            s1.Vehicle_id = int.Parse(cbVehicle.Text);
            string idStr = cbEmployee.Text.Split('.')[0];
            s1.Employee_id = int.Parse(idStr);
            //s1.Employee_id = int.Parse(cbEmployee.Text);
            s1.Date_start = this.dtpDate.Value;
            s1.Date_end = this.dtpDateEnd.Value;
           

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
            InsertSQL sowing = new InsertSQL();
            //productLists = order1.GetPorductList();

            if (state == "Edit")
            {
                tbDescription.Text = sowj.Description;
                cbCrop.Text = sowj.Crop_id.ToString();
                nUDQty.Text = sowj.Quantity_prop.ToString();
                cbFarm.Text = sowj.Farm_id.ToString();
                nUDArea.Text = sowj.Used_area.ToString();
                cbVehicle.Text = sowj.Vehicle_id.ToString();
                cbEmployee.Text = sowj.Employee_id.ToString();
                dtpDate.Value = sowj.Date_start;
                dtpDateEnd.Value = sowj.Date_end;
            }


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
            SowingJob sj11 = new SowingJob();

            //    // 5.
            foreach (Crop crop in cropLists)
            {

                cbCrop.Items.Add(crop.Id );
                cbCrop.Items.Add(crop.Name);

            }

            foreach (Vehicle vehicle in vehicleList)
            {

                cbVehicle.Items.Add(vehicle.Id);
                cbVehicle.Items.Add(vehicle.Name);

            }

            foreach (Employee employee in employeeList)
            {
                if (employee.Admin == false)
                {
                    string showText = employee.Id + ". " + employee.Username;
                    cbEmployee.Items.Add(showText);

                    //cbEmployee.Items.Add(employee.Id);
                    //cbEmployee.Items.Add(employee.Username);
                }

            }

            foreach (Farm farm in farmLists)
            {

                cbFarm.Items.Add(farm.Id);
                cbFarm.Items.Add(farm.Description);
            }
        }


        public void checkAsignJobandAdd()
        {
            //string tableName = "sowingJob";
            //string query = "SELECT * FROM " + tableName;
            //MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());

            //TestSQL ts = new TestSQL();
            //cropLists = ts.GetCropList();
            //employeeList = ts.GetEmployeeList();
            //farmLists = ts.GetFarmList();
            //vehicleList = ts.GetVehicleList();

            //DateTime start_date = Convert.ToDateTime("12/12/2018");
            //DateTime end_date = Convert.ToDateTime("12/12/2018");
            //DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToString("MMM/dd/yyyy"));
            //int duration = 0; int todayduration = 0;
            //foreach (Employee employee in employeeList)
            //{
            //    MySqlDataReader drrr = csql.getsowinginfo(employee.Id.ToString());
            //    if (drrr.Read())
            //    {
            //        start_date = Convert.ToDateTime(drrr[8].ToString());
            //        end_date = Convert.ToDateTime(drrr[7].ToString());
            //        duration = Convert.ToInt32((end_date - start_date).TotalDays);
            //        todayduration = Convert.ToInt32((currentDate - start_date).TotalDays);
            //        if (duration < todayduration)
            //        {
            //            cbEmployee.Items.Add(employee.Id.ToString());
            //            add();
            //        }
            //    }
            //}
        }

        private void nUDQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCrop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
//public void checkAsignJobandAdd()
//{
//    //string tableName = "sowingJob";
//    //string query = "SELECT * FROM " + tableName;
//    //MySqlCommand cmd = new MySqlCommand(query, MysqlDbc.Instance.getConn());



//    DateTime start_date = Convert.ToDateTime("12/12/2018");
//    DateTime end_date = Convert.ToDateTime("12/12/2018");
//    DateTime currentDate = Convert.ToDateTime(DateTime.Now.ToString("MMM/dd/yyyy"));
//    int duration = 0; int todayduration = 0;
//    MySqlDataReader dr2 = csql.getempname();
//    while (dr2.Read())
//    {
//        MySqlDataReader drrr = csql.getsowinginfo(dr2[7].ToString());
//        if (drrr.Read())
//        {
//            start_date = Convert.ToDateTime(drrr[8].ToString());
//            end_date = Convert.ToDateTime(drrr[7].ToString());
//            duration = Convert.ToInt32((end_date - start_date).TotalDays);
//            todayduration = Convert.ToInt32((currentDate - start_date).TotalDays);
//            if (duration < todayduration)
//            {
//                cbEmployee.Items.Add(dr2[1].ToString());
//                add();
//            }
//        }
//    }
//}