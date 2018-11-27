using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustRipeFarm;
using MySql.Data.MySqlClient;

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTestStockHandler
    {
        [TestMethod]
        public void TestAddNewStock()
        {
            MysqlDb dbC = new MysqlDb();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Stock aStock = new Stock();
            aStock.Type = 2;
            aStock.Quantity = 99;
            aStock.SupplierId = 4;
            aStock.PurchaseDate = new DateTime(2018, 10, 25, 0, 0, 0);
            aStock.ExpiryDate = new DateTime(2019, 1, 24, 0, 0, 0);

            StockHandler labrHand = new StockHandler();
            int resp2 = labrHand.addNewStock(dbC.getConn(), aStock);
            Assert.IsNotNull(resp2);
        }
    }
}
