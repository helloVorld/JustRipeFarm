using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using JustRipeFarm.ClassEntity;


namespace JustRipeFarm
{
    public partial class AdminDashboard : Form
    {
        public List<PanelButton> menuSetup;
        public List<Panel> panelsControl = new List<Panel>();
        public List<PanelItem> pnItems;
        public bool showOperation = false;
        public bool showTreatment = false;
        public bool showInventory = false;
        public string currentPanel = "panelHome";
        public bool isAdmin = true;
        public DataTable currentDataSet = new DataTable();
        public bool datagridDidPress = false;
        public int currentID;
        List<string> currentUpdateOption = new List<string>();
        List<string> currentSearchOption = new List<string>();
        public Employee currentEmployee;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Resize += AdminDashboard_Resize;
        }


        private void AdminDashboard_Resize(object sender, EventArgs e)
        {
            formWidthLbl.Text = this.Width.ToString();
            formHeightLbl.Text = this.Height.ToString();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // back to login screen
            JRF.Logout(this);
        }

        public void loadMenuBtn()
        {
            //List<string> menuList = JRF.getMenuButtonName();
            //foreach (string str in menuList)
            //{
            //    Button bt = new Button();
            //    bt.Name = str;
            //    bt.Text = str;
                
            //    menuFLP.Controls.Add(bt);
            //    bt.Click += new System.EventHandler(this.menuBtn_Click);
            //}

            menuSetup = JRF.GetBtnPanelName();
            pnItems = JRF.GetPanelItems();
            foreach (PanelButton mS in menuSetup)
            {
                Button bt = new Button();
                bt.Name = mS.BtnName;
                bt.Text = mS.BtnName;
                bt.Click += new System.EventHandler(this.menuBtn_Click);
                menuFLP.Controls.Add(bt);
                
            }
            if (!isAdmin)
            {
                menuFLP.Controls[1].Hide();
                menuFLP.Controls[10].Hide();
                menuFLP.Controls[11].Hide();
                menuFLP.Controls[12].Hide();
            }
            
            //menuFLP.AutoScroll = true;
            buttonShowControl(showOperation, showTreatment, showInventory);
        }

        public void menuBtn_Click(object sender, EventArgs e)
        {
            // Menu Button click to display spe
            string panelName = "panelHome";
            Button btn = sender as Button;
            Console.WriteLine("JRF : FLP button => "+btn.Name+ " clicked");

            //switch (btn.Name)
            //{
            //    case "Home"     : panelName = "panelHome";      break;
            //    case "Orders"   : panelName = "panelOrder"; break;
            //    case "Products" : panelName = "panelProduct";      break;
            //    case "Operation": panelName = "panelOperation"; break;
            //    case "Farm"     : panelName = "panelFarm";   break;
            //    case "Employee" : panelName = "panelEmployee";  break;
            //    case "Customer" : panelName = "panelCustomer";  break;
            //    case "Store"    : panelName = "panelStoreroom";     break;
            //    case "Inventory": panelName = "panelInventory"; break;
            //    default         : panelName = "panelHome";      break;
            //}
            //panelDisplay(panelName);

            // decide is common panel or not 
            bool useCommonPanel = false;
            
            foreach (PanelButton bpn in menuSetup)
            {
                if (bpn.BtnName == btn.Name)
                {
                    panelName = bpn.PanelName;
                    useCommonPanel = bpn.IsCommonPanel;
                }
            }

            if (useCommonPanel)
            {
                // load common panel
                lblUpdateField.Show();
                cbUpdateField.Show();
                btnUpdateField.Show();
                btnReset.Show();
                switchPanelItem(btn.Name);
                panelDisplay("panelCommon");
            }
            else
            {
                // load created panel 
                panelDisplay(panelName);
            }
            datagridDidPress = false;


            // control menu button visibility
            if (btn.Name == "Operation")
            {
                toggleOperation();
            }
            else if (btn.Name == "Treatment")
            {
                toggleTreatment();
            }
            else if (btn.Name == "Inventory")
            {
                toggleInventory();
            }

            buttonShowControl(showOperation, showTreatment, showInventory);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 500;
            label1.Hide();
            label2.Hide();
            formWidthLbl.Hide();
            formHeightLbl.Hide();
            
            loadMenuBtn();
            panelsControl.Add(panelHome);
            panelsControl.Add(panelCommon);
            panelsControl.Add(panelOperation);
            panelsControl.Add(panelInventory);
            
            panelDisplay("panelHome");
            displayForAdmin(isAdmin);

            lblUsername.Text = currentEmployee.First_name + " " + currentEmployee.Last_name;
        }

        public void panelDisplay(string panelName)
        {
            
            foreach (Panel pN in panelsControl)
            {
                if (pN.Name != panelName)
                {
                    pN.Hide();
                }
                else
                {
                    pN.Width = 650;
                    pN.Height = 400;
                    pN.Location = new Point(130, 60);
                    pN.Show();
                }

            }
            tbId.Text = "";
        }

        // Menu button display ====>>
        public void showOperationBtn(bool show, bool treatShow)
        {
            if (show)
            {
                for (int i = 4; i <= 7; i++)
                {
                    menuFLP.Controls[i].Show();
                }
                if (treatShow)
                {
                    for (int i = 8; i <= 9; i++)
                    {
                        menuFLP.Controls[i].Show();
                    }
                }
                else
                {
                    for (int i = 8; i <= 9; i++)
                    {
                        menuFLP.Controls[i].Hide();
                    }
                }
            }
            else
            {

                for (int i = 4; i <= 9; i++)
                {
                    menuFLP.Controls[i].Hide();
                }
            }
        }

        public void showInventoryBtn(bool show)
        {
            if (show)
            {
                for (int i = 15; i <= 19; i++)
                {
                    menuFLP.Controls[i].Show();
                }

            }
            else
            {

                for (int i = 15; i <= 19; i++)
                {
                    menuFLP.Controls[i].Hide();
                }
            }
        }

        public void buttonShowControl(bool operation, bool treatment, bool inventory)
        {
            showOperationBtn(operation, treatment);
            showInventoryBtn(inventory);
        }

        public void toggleOperation()
        {
            this.showOperation = showOperation ? false : true;
        }

        public void toggleTreatment()
        {
            this.showTreatment = showTreatment ? false : true;
        }

        public void toggleInventory()
        {
            this.showInventory = showInventory ? false : true;
        }
        // Menu button display <<====

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            goToForm(currentPanel, "New");
            Console.WriteLine("Common panel =>"+currentPanel+" => New ");
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (datagridDidPress)
            {
                Button btn = sender as Button;
                goToForm(currentPanel, "Edit");
                Console.WriteLine("Common panel =>" + currentPanel + " => Edit ");
            }
            else
            {
                ErrorMsg.PlsSelectRow();
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset all combo box field
        }

        private void btnUpdateField_Click(object sender, EventArgs e)
        {
            // testing purposes 
            foreach(DataRow dr in currentDataSet.Rows)
            {
                string t1 = dr[1].ToString();
                Console.WriteLine("data table row => " + t1);
            }
            
            if (datagridDidPress)
            {
                try
                {
                    string cbText = cbUpdateField.SelectedItem.ToString();
                    Console.WriteLine("CB update => " + cbText);

                    if (JRF.GotInListStr(currentUpdateOption, cbText))
                    {
                        // proceed MySql operation
                        Console.WriteLine("update panel => " + currentPanel+ "=> "+currentID);
                        switch (currentPanel)
                        {
                            case "Order":
                                int haha = JobOp.UpdateOrder(currentID, cbText);
                                try
                                {
                                    currentDataSet = JRFdataset.Table.getAllOrders().Tables[0];
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No Data");
                                }

                                MessageBox.Show("Update Done");
                                dgvDbTable.DataSource = currentDataSet;
                                dgvDbTable.Refresh();
                                break;
                            default:break;
                        }
                        
                    }
                    else
                    {
                        ErrorMsg.UpdateOptionInvalid();
                    }
                }
                catch(Exception ex)
                {
                    ErrorMsg.UpdateOptionNoSelect();
                }
                                
            }
            else
            {
                ErrorMsg.PlsSelectRow();
            }

        }

        public void displayForAdmin(bool isAdmin)
        {
            if (isAdmin)
            {

            }
            else
            {
                btnNewItem.Hide();
                btnEditItem.Hide();
                btnUpdateField.Hide();
                lblUpdateField.Hide();
                cbUpdateField.Hide();
            }
        }


        public void switchPanelItem(string btnName)
        {
            currentPanel = btnName;
            
            // reset combo box items
            cbUpdateField.Items.Clear();
            cbFilter1.Items.Clear();

            // hide combobox filter
            cbFilter2.Hide();
            cbFilter3.Hide();
            cbFilter4.Hide();

            switch (btnName)
            {
                case "Order"   :
                    lblPanelTitle.Text = pnItems[0].PnTitle;
                    lblId.Text = pnItems[0].Id;
                    lblUpdateField.Text = pnItems[0].UpdateField;
                    btnNewItem.Text = pnItems[0].BtnNew;
                    btnEditItem.Text = pnItems[0].BtnEdit;
                    btnUpdateField.Text = pnItems[0].BtnUpdate;
                    currentUpdateOption = JRF.OrderStatusOption();
                    foreach ( string str in currentUpdateOption)
                    {
                        cbUpdateField.Items.Add(str);
                    }
                    
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllOrders().Tables[0];
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Product" :
                    lblPanelTitle.Text = pnItems[1].PnTitle;
                    lblId.Text = pnItems[1].Id;
                    lblUpdateField.Text = pnItems[1].UpdateField;
                    btnNewItem.Text = pnItems[1].BtnNew;
                    btnEditItem.Text = pnItems[1].BtnEdit;
                    btnUpdateField.Text = pnItems[1].BtnUpdate;

                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllProduct().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    break;
                case "Sowing"   :
                    lblPanelTitle.Text = pnItems[2].PnTitle;
                    lblId.Text = pnItems[2].Id;
                    lblUpdateField.Text = pnItems[2].UpdateField;
                    btnNewItem.Text = pnItems[2].BtnNew;
                    btnEditItem.Text = pnItems[2].BtnEdit;
                    btnUpdateField.Text = pnItems[2].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllSowing().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Harvesting":
                    lblPanelTitle.Text = pnItems[3].PnTitle;
                    lblId.Text = pnItems[3].Id;
                    lblUpdateField.Text = pnItems[3].UpdateField;
                    btnNewItem.Text = pnItems[3].BtnNew;
                    btnEditItem.Text = pnItems[3].BtnEdit;
                    btnUpdateField.Text = pnItems[3].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllHarvesting().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Storage" :
                    lblPanelTitle.Text = pnItems[4].PnTitle;
                    lblId.Text = pnItems[4].Id;
                    lblUpdateField.Text = pnItems[4].UpdateField;
                    btnNewItem.Text = pnItems[4].BtnNew;
                    btnEditItem.Text = pnItems[4].BtnEdit;
                    btnUpdateField.Text = pnItems[4].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllStorage().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Fertilising" :
                    lblPanelTitle.Text = pnItems[5].PnTitle;
                    lblId.Text = pnItems[5].Id;
                    lblUpdateField.Text = pnItems[5].UpdateField;
                    btnNewItem.Text = pnItems[5].BtnNew;
                    btnEditItem.Text = pnItems[5].BtnEdit;
                    btnUpdateField.Text = pnItems[5].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllFertilising().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Pest Control" :
                    lblPanelTitle.Text = pnItems[6].PnTitle;
                    lblId.Text = pnItems[6].Id;
                    lblUpdateField.Text = pnItems[6].UpdateField;
                    btnNewItem.Text = pnItems[6].BtnNew;
                    btnEditItem.Text = pnItems[6].BtnEdit;
                    btnUpdateField.Text = pnItems[6].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllPests().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Farm"    :
                    lblPanelTitle.Text = pnItems[7].PnTitle;
                    lblId.Text = pnItems[7].Id;
                    lblUpdateField.Text = pnItems[7].UpdateField;
                    btnNewItem.Text = pnItems[7].BtnNew;
                    btnEditItem.Text = pnItems[7].BtnEdit;
                    btnUpdateField.Text = pnItems[7].BtnUpdate;
                    lblUpdateField.Hide();
                    cbUpdateField.Hide();
                    btnUpdateField.Hide();
                    btnReset.Hide();
                    currentSearchOption = JobOp.getFarmList();
                    foreach (string str in currentSearchOption)
                    {
                        cbFilter1.Items.Add(str);
                    }
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllFarm().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Employee":
                    lblPanelTitle.Text = pnItems[8].PnTitle;
                    lblId.Text = pnItems[8].Id;
                    lblUpdateField.Text = pnItems[8].UpdateField;
                    btnNewItem.Text = pnItems[8].BtnNew;
                    btnEditItem.Text = pnItems[8].BtnEdit;
                    btnUpdateField.Text = pnItems[8].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllEmployee().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Customer":
                    lblPanelTitle.Text = pnItems[9].PnTitle;
                    lblId.Text = pnItems[9].Id;
                    lblUpdateField.Text = pnItems[9].UpdateField;
                    btnNewItem.Text = pnItems[9].BtnNew;
                    btnEditItem.Text = pnItems[9].BtnEdit;
                    btnUpdateField.Text = pnItems[9].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllCustomer().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Storeroom"   :
                    lblPanelTitle.Text = pnItems[10].PnTitle;
                    lblId.Text = pnItems[10].Id;
                    lblUpdateField.Text = pnItems[10].UpdateField;
                    btnNewItem.Text = pnItems[10].BtnNew;
                    btnEditItem.Text = pnItems[10].BtnEdit;
                    btnUpdateField.Text = pnItems[10].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllStoreroom().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Vehicle":
                    lblPanelTitle.Text = pnItems[11].PnTitle;
                    lblId.Text = pnItems[11].Id;
                    lblUpdateField.Text = pnItems[11].UpdateField;
                    btnNewItem.Text = pnItems[11].BtnNew;
                    btnEditItem.Text = pnItems[11].BtnEdit;
                    btnUpdateField.Text = pnItems[11].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllVehicle().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Crop" :
                    lblPanelTitle.Text = pnItems[12].PnTitle;
                    lblId.Text = pnItems[12].Id;
                    lblUpdateField.Text = pnItems[12].UpdateField;
                    btnNewItem.Text = pnItems[12].BtnNew;
                    btnEditItem.Text = pnItems[12].BtnEdit;
                    btnUpdateField.Text = pnItems[12].BtnUpdate;
                    currentDataSet = JRFdataset.Table.getAllCrop().Tables[0];
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllCrop().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Fertiliser":
                    lblPanelTitle.Text = pnItems[13].PnTitle;
                    lblId.Text = pnItems[13].Id;
                    lblUpdateField.Text = pnItems[13].UpdateField;
                    btnNewItem.Text = pnItems[13].BtnNew;
                    btnEditItem.Text = pnItems[13].BtnEdit;
                    btnUpdateField.Text = pnItems[13].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllFertiliser().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Pesticide" :
                    lblPanelTitle.Text = pnItems[14].PnTitle;
                    lblId.Text = pnItems[14].Id;
                    lblUpdateField.Text = pnItems[14].UpdateField;
                    btnNewItem.Text = pnItems[14].BtnNew;
                    btnEditItem.Text = pnItems[14].BtnEdit;
                    btnUpdateField.Text = pnItems[14].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllPesticide().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case "Box"  :
                    lblPanelTitle.Text = pnItems[15].PnTitle;
                    lblId.Text = pnItems[15].Id;
                    lblUpdateField.Text = pnItems[15].UpdateField;
                    btnNewItem.Text = pnItems[15].BtnNew;
                    btnEditItem.Text = pnItems[15].BtnEdit;
                    btnUpdateField.Text = pnItems[15].BtnUpdate;
                    try
                    {
                        currentDataSet = JRFdataset.Table.getAllBox().Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Data");
                    }
                    dgvDbTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
            default: break;
            }
            dgvDbTable.DataSource = currentDataSet;
            dgvDbTable.ScrollBars = ScrollBars.Both;

        }

        public void goToForm(string btnName,string newOrEdit)
        {
            switch (btnName)
            {
                case "Order":
                    FormOrder fo = new FormOrder();
                    fo.state = newOrEdit;
                    if (newOrEdit == "Edit")
                    {
                        // MySQL Need Check 
                        fo.ord = JRFdataset.Table.GetOrderFromID(currentID);
                    }
                    fo.Show();
                    
                    break;
                case "Product":
                    FormProduct fp = new FormProduct();
                    fp.state = newOrEdit;
                    if (newOrEdit == "Edit")
                    {
                        // MySQL Need Check 
                        //fp.prod = 
                    }
                    fp.Show();
                    break;
                case "Sowing":
                    FormSowingJob fsj = new FormSowingJob();
                    fsj.state = newOrEdit;
                    if (newOrEdit == "Edit")
                    {
                        // MySQL Need Check 
                        // fsj.sowj = 
                    }
                    fsj.Show();
                    break;
                case "Harvesting":
                    FormHarvestingJob hj = new FormHarvestingJob();
                    hj.Show();

                    break;
                case "Storage":
                    FormStoreroom sj1 = new FormStoreroom();
                    sj1.Show();

                    break;
                case "Fertilising":
                    FormFertilisingJob fj1 = new FormFertilisingJob();
                    fj1.Show();
                    
                    break;
                case "Pest Control":
                    FormPesticide fp1 = new FormPesticide();
                    fp1.Show();
                    
                    break;
                case "Farm":
                    FormFarm ff = new FormFarm();
                    ff.state = newOrEdit;
                    if (newOrEdit == "Edit")
                    {
                        // MySQL Need Check 
                        ff.farmfarm = JRFdataset.Table.GetFarmFromID(currentID);
                    }
                    ff.Show();

                    break;
                case "Employee":
                    FormEmployee fe = new FormEmployee();
                    fe.Show();

                    break;
                case "Customer":
                    FormCustomer fc = new FormCustomer();
                    fc.state = newOrEdit;
                    if (newOrEdit == "Edit")
                    {
                        // MySQL Need Check 
                        fc.cust = JRFdataset.Table.GetCustoemrFromID(currentID);
                    }
                    fc.Show();

                    break;
                case "Storeroom":
                    FormStoreroom fstor = new FormStoreroom();

                    fstor.Show();

                    break;
                case "Vehicle":
                    FormVehicle fv = new FormVehicle();
                    fv.Show();
                    
                    break;
                case "Crop":
                    FormCropcs c1 = new FormCropcs();
                    c1.Show();
                    break;
                case "Fertiliser":
                    FormFertiliser f1 = new FormFertiliser();
                    f1.Show();
                    
                    break;
                case "Pesticide":
                    FormPesticide p1 = new FormPesticide();
                    p1.state = newOrEdit;
                    if (newOrEdit == "Edit")
                    {
                        // MySQL Need Check 
                        //p1.ps = JRFdataset.Table.GetCustoemrFromID(currentID);
                    }
                    p1.Show();
                    break;
                case "Box":
                    FormBox b1 = new FormBox();
                    b1.Show();


                    break;
                default: break;
            }
        }

        private void dgvDbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDbTable.Select();

            int currentRowIndex;
            try
            {
                currentRowIndex = dgvDbTable.CurrentRow.Index;
                dgvDbTable.Rows[currentRowIndex].Selected = true;
                string id = dgvDbTable.CurrentRow.Cells[0].Value.ToString();
                Console.WriteLine("DGV : selected row id: " + id);
                tbId.Text = id;
                currentID = Int32.Parse(id);
                datagridDidPress = true;
            }
            catch(Exception ex)
            {
                currentRowIndex = 0;
            }

            
        }

        private void panelOperation_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("panel operation loaded");
            
            lblTodaySowing.Text = JobOp.GetJobCountFor(true,"sowingjob").ToString();
            lblPendingSowing.Text = JobOp.GetJobCountFor(false, "sowingjob").ToString();

            lblTodayHarvest.Text = JobOp.GetJobCountFor(true, "harvestingjob").ToString();
            lblPendingHarvest.Text = JobOp.GetJobCountFor(false, "harvestingjob").ToString();

            lblTodayStore.Text = JobOp.GetJobCountFor(true, "storingjob").ToString();
            lblPendingStore.Text = JobOp.GetJobCountFor(false, "storingjob").ToString();

            lblTodayFertilising.Text = JobOp.GetJobCountFor(true, "fertilisingjob").ToString();
            lblPendingFertilising.Text = JobOp.GetJobCountFor(false, "fertilisingjob").ToString();

            lblTodayPest.Text = JobOp.GetJobCountFor(true, "pesticidejob").ToString();
            lblPendingPest.Text = JobOp.GetJobCountFor(false, "pesticidejob").ToString();


        }

        private void cbFilter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            //int indexx = cbx.SelectedIndex;
            string selectstr = cbx.SelectedItem.ToString();
            
            foreach (DataGridViewRow rrr in dgvDbTable.Rows)
            {
                int index = rrr.Index;
                string cellStr = dgvDbTable.Rows[index].Cells[1].Value.ToString();
                Console.WriteLine("cbfilter => " + selectstr + "<=>" + cellStr);
                if (selectstr == cellStr)
                {
                    dgvDbTable.CurrentCell = dgvDbTable.Rows[index].Cells[1];
                    dgvDbTable.Rows[index].Selected = true;
                }
            }

            //DataGridView dgv = sender as DataGridView;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditProfile editprofile = new FormEditProfile();
            editprofile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditPassword editpassword = new FormEditPassword();
            editpassword.Show();
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {
            userLbl.Hide();
            if (isAdmin)
            {
                gbOrders.Show();
                lblTodayAllJob.Text = JobOp.GetAllJobCountFor(true).ToString();

                lblPendingAllJob.Text = JobOp.GetAllJobCountFor(false).ToString();

                lblTodayAllOrder.Text = JobOp.GetOrderCountFor("orders").ToString();
                //lblTodayAllOrder.Text = "";
                lblPendingAllOrder.Text = "";
            }
            else
            {
                gbOrders.Hide();
                lblTodayAllJob.Text = JobOp.GetAllJobCountFor(true, currentEmployee.Id).ToString();

                lblPendingAllJob.Text = JobOp.GetAllJobCountFor(false, currentEmployee.Id).ToString();

                
            }
            
        }

        public void updateFieldStr(String tableName,int rowId, string field, string updateItem)
        {

        }
    }
    
}

