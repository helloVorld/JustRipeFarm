using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustRipeFarm;
using MySql.Data.MySqlClient;

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTestCropHandler
    {
        [TestMethod]
        public void TestAddNewCrop()
        {
            DbConnecter dbC = new DbConnecter();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Crop aCrop = new Crop();
            aCrop.Name = "Banana";
            aCrop.Quantity = 40;
            aCrop.GrowthStage = "A";

            CropHandler cropHand = new CropHandler();
            int resp2 = cropHand.addNewCrop(dbC.getConn(), aCrop);
            Assert.AreEqual(1,resp2);
        }
    }
}
