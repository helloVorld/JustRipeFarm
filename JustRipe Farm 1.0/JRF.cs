using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipeFarm
{
    public class JRF
    {
        public static string dbServer = "localhost";
        public static string dbUser = "jrfadmin";
        public static string dbName = "justripefarmdb";
        public static string dbPassword = "jrf123";


        public static void Logout(Form form)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            form.Close();
        }

        //public static List<string> getMenuButtonName()
        //{
        //    List<string> menuList = new List<string>();
        //    menuList.Add("Home");
        //    menuList.Add("Orders");
        //    menuList.Add("Products");
        //    menuList.Add("Operation");
        //    menuList.Add("Farm");
        //    menuList.Add("Employee");
        //    menuList.Add("Customer");
        //    menuList.Add("Store");
        //    menuList.Add("Inventory");

        //    return menuList;
        //}

        public static List<PanelButton> GetBtnPanelName()
        {
            List<PanelButton> menuList = new List<PanelButton>();
            menuList.Add(new PanelButton("Home", "panelHome",false));
            menuList.Add(new PanelButton("Order", "panelOrder",true));
            menuList.Add(new PanelButton("Product", "panelProduct",true));
            menuList.Add(new PanelButton("Operation", "panelOperation", false));
            menuList.Add(new PanelButton("Sowing", "panelOpSow", true));
            menuList.Add(new PanelButton("Harvesting", "panelOpHarvest", true));
            menuList.Add(new PanelButton("Storage", "panelOpStore", true));
            menuList.Add(new PanelButton("Treatment", "panelTreatment", false));
            menuList.Add(new PanelButton("Fertilising", "panelOpFerti", true));
            menuList.Add(new PanelButton("Pest Control", "panelOpPesti", true));
            menuList.Add(new PanelButton("Farm", "panelFarm", true));
            menuList.Add(new PanelButton("Employee", "panelEmployee", true));
            menuList.Add(new PanelButton("Customer", "panelCustomer", true));
            menuList.Add(new PanelButton("Storeroom", "panelStore", true));
            menuList.Add(new PanelButton("Inventory", "panelInventory", false));
            menuList.Add(new PanelButton("Vehicle", "panelInvVehicle", true));
            menuList.Add(new PanelButton("Crop", "panelInvCrop", true));
            menuList.Add(new PanelButton("Fertiliser", "panelInvFerti", true));
            menuList.Add(new PanelButton("Pesticide", "panelInvPest", true));
            menuList.Add(new PanelButton("Box", "panelInvBox", true));

            return menuList;
        }

        public static List<PanelItem> GetPanelItems()
        {
            List<PanelItem> panelItems = new List<PanelItem>();

            // order
            PanelItem piOrd = new PanelItem("Order");
            piOrd.PnName = "panelOrder";
            piOrd.BtnUpdate = "Update Status";
            piOrd.UpdateField = "Status";
            panelItems.Add(piOrd);

            // product
            PanelItem piPro = new PanelItem("Product");
            piPro.PnName = "panelProduct";
            
            panelItems.Add(piPro);

            // Job -> sowing
            PanelItem piSow = new PanelItem("Sowing");
            piSow.PnName = "panelOpSow";
            panelItems.Add(piSow);

            // Job -> harvesting
            PanelItem piHar = new PanelItem("Harvesting");
            piHar.PnName = "panelOpHarvest";
            piHar.BtnUpdate = "Update Status";
            piHar.UpdateField = "Status";
            panelItems.Add(piHar);

            // Job -> strorage
            PanelItem piSto = new PanelItem("Storage");
            piSto.PnName = "panelOpStore";
            piSto.BtnUpdate = "Update Status";
            piSto.UpdateField = "Status";
            panelItems.Add(piSto);

            // Job -> Treatment -> fertilising
            PanelItem piFer = new PanelItem("Fertilising");
            piFer.PnName = "panelOpFerti";
            piFer.BtnUpdate = "Update Status";
            piFer.UpdateField = "Status";
            panelItems.Add(piFer);

            // Job -> Treatment -> pest control
            PanelItem piPes = new PanelItem("Pest Control");
            piPes.PnName = "panelOpPesti";
            piPes.BtnUpdate = "Update Status";
            piPes.UpdateField = "Status";
            panelItems.Add(piPes);

            // farm
            PanelItem piFar = new PanelItem("Farm");
            piFar.PnName = "paneFarm";
            piFar.BtnUpdate = "Update Status";
            piFar.UpdateField = "Status";
            panelItems.Add(piFar);

            // employee
            PanelItem piEmp = new PanelItem("Employee");
            piEmp.PnName = "panelEmployee";
            piEmp.BtnUpdate = "Update Status";
            piEmp.UpdateField = "Status";
            panelItems.Add(piEmp);

            // customer
            PanelItem piCus = new PanelItem("Customer");
            piCus.PnName = "panelCustomer";
            piCus.BtnUpdate = "Update Status";
            piCus.UpdateField = "Status";
            panelItems.Add(piCus);

            // storeroom
            PanelItem piISto = new PanelItem("Storeroom");
            piISto.PnName = "panelStore";
            piISto.BtnUpdate = "Update Status";
            piISto.UpdateField = "Status";
            panelItems.Add(piISto);

            // inventory -> vehicle
            PanelItem piIVeh = new PanelItem("Vehicle");
            piIVeh.PnName = "panelInvVehicle";
            piIVeh.BtnUpdate = "Update Status";
            piIVeh.UpdateField = "Status";
            panelItems.Add(piIVeh);

            // inventory -> crop
            PanelItem piICro = new PanelItem("Crop");
            piICro.PnName = "panelInvCrop";
            piICro.BtnUpdate = "Update Status";
            piICro.UpdateField = "Status";
            panelItems.Add(piICro);

            // inventory -> fertiliser
            PanelItem piIFer = new PanelItem("Fertiliser");
            piIFer.PnName = "panelInvFerti";
            piIFer.BtnUpdate = "Update Status";
            piIFer.UpdateField = "Status";
            panelItems.Add(piIFer);

            // inventory -> pesticide
            PanelItem piIPes = new PanelItem("Pesticide");
            piIPes.PnName = "panelInvPest";
            piIPes.BtnUpdate = "Update Status";
            piIPes.UpdateField = "Status";
            panelItems.Add(piIPes);

            // inventory -> box
            PanelItem piIBox = new PanelItem("Box");
            piIBox.PnName = "panelInvBox";
            piIBox.BtnUpdate = "Update Status";
            piIBox.UpdateField = "Status";
            panelItems.Add(piIBox);

            return panelItems;
        }

        public static List<string> OrderStatusOption()
        {
            List<string> statusOp = new List<string>();
            
            statusOp.Add("Pending");
            statusOp.Add("In Progress");
            statusOp.Add("Complete");
            statusOp.Add("Canceled");

            return statusOp;
        }

        public static bool GotInListStr(List<string> lists, string searchText)
        {

            foreach(string str in lists)
            {
                if (searchText == str)
                {
                    return true;
                }
            }

            return false;

        }

        public static List<string> JobStatusOption()
        {
            List<string> statusOp = new List<string>();

            statusOp.Add("Pending");
            statusOp.Add("Postponed");
            statusOp.Add("Complete");
            statusOp.Add("Canceled");

            return statusOp;
        }

    }
}
