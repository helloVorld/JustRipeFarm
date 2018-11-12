using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustRipeFarm;
using MySql.Data.MySqlClient;

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTestLabourerHandler
    {
        [TestMethod]
        public void TestAddNewLabourer()
        {
            DbConnecter dbC = new DbConnecter();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Labourer labrA = new Labourer();
            labrA.Name = "Bob";
            labrA.Age = 39;
            labrA.Gender = "male";

            LabourerHandler labrHand = new LabourerHandler();
            int resp2 = labrHand.addNewLabourer(dbC.getConn(), labrA);
            Assert.IsNotNull(resp2);
        }
    }
}
