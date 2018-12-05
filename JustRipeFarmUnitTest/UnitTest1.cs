using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustRipeFarm;
using MySql.Data.MySqlClient;
using JustRipeFarm.ClassEntity;

//string sql = "INSERT INTO crop (name, type, quantity_plot, remark) "
//                    + " Values ('" + crop.Name + "', '" + crop.Type + "', " + crop.Quantity_plot + " , '"
//                    + crop.Remark + "')";

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool resp = MysqlDbc.Instance.connect();

            //---------------
            //Success Insert:
            //---------------
            //Crop crop1 = new Crop();
            //crop1.Name = "TEST";
            //crop1.Type = "TEST1";
            //crop1.Quantity_plot = 10;
            //crop1.Remark = "Testing";

            //CropHandler cropHand = new CropHandler();
            //int resp2 = cropHand.addNewCrop(MysqlDbc.Instance.getConn(), crop1);
            //Assert.IsNotNull(resp2);

            //Vehicle v1 = new Vehicle();
            //v1.Name = "Toyota";
            //v1.Serial_number = 000001;
            //v1.Buy_date = new DateTime(2018, 11, 2);
            //v1.Last_service_date = new DateTime(2018, 10, 1);
            //v1.Remark = "New Band";

            //VehicleHandler cropHand = new VehicleHandler();
            //int resp2 = cropHand.addNewVehicle(MysqlDbc.Instance.getConn(), v1);
            //Assert.IsNotNull(resp2);

            //Farm f1 = new Farm();
            //f1.Description = "Farm 1";
            //f1.Area = "Top-Left";
            //f1.Utilize_area = "1/4 of farm";

            //FarmHandler farmHand = new FarmHandler();
            //int resp2 = farmHand.addNewFarm(MysqlDbc.Instance.getConn(), f1);
            //Assert.IsNotNull(resp2);





            //--------------
            //Failed Insert:
            //--------------
            //Employee e1 = new Employee();
            //e1.First_name = "Adrian";
            //e1.Last_name = "Tango";
            //e1.Username = "adriantango";
            //e1.Password = "abcd999";
            //e1.Dob = 123;
            //e1.Mobile = "01212345678";
            //e1.Email = "test@gmail.com";
            //e1.Admin = 1;
            //e1.Status = "Active";
            //e1.Remark = "Stupidest Employee, but he is admin.";

            //EmployeeHandler employeeHand = new EmployeeHandler();
            //int resp2 = employeeHand.addNewEmployee(MysqlDbc.Instance.getConn(), e1);
            //Assert.IsNotNull(resp2);

            //Box b1 = new Box();
            //b1.Name = "AppleBox";
            //b1.Width = 10.8;    //Convert.ToDecimal(90.8);
            //b1.Height = 18.0;
            //b1.Length = 12.0;
            //b1.Max_weight = 19.0;
            //b1.Quantity = 1;
            //b1.Status = "active";

            //BoxHandler boxHand = new BoxHandler();
            //int resp2 = boxHand.addNewBox(MysqlDbc.Instance.getConn(), b1);
            //Assert.IsNotNull(resp2);

            //BoxStorage bs1 = new BoxStorage();
            //bs1.StoringJob_id = 1;
            //bs1.Product_id = 1;
            //bs1.Box_id = 1;
            //bs1.NettWeight = 10.9;
            //bs1.Storeroom_id = 1;
            //bs1.Add_date = new DateTime(2018, 10, 10);
            //bs1.Best_before = new DateTime(2018, 11, 11);
            //bs1.Out_date = new DateTime(2019, 1, 1);
            //bs1.Order_id = 1;

            //BoxStorageHandler Hand = new BoxStorageHandler();
            //int resp2 = Hand.addNewBoxStorage(MysqlDbc.Instance.getConn(), bs1);
            //Assert.IsNotNull(resp2);
        }
    }
}
