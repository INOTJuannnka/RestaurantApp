using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RestaurantLibrary;
using System.Collections.Generic;

namespace UnitTestRestaurant
{
    [TestClass]
    public class UnitTest1
    {
        private clsSystem system;

        public void Setup()
        {
            clsSystem system = new clsSystem();
        }

        [TestMethod]
        public void CreateMenu_ValidParameters_MenuCreated()
        {
            List<String> foodNames = new List<String>();
            List<double> foodPrices = new List<double>();
            foodNames.Add("Burger");
            foodNames.Add("Pizza");
            foodNames.Add("Pasta");
            foodPrices.Add(10);
            foodPrices.Add(10);
            foodPrices.Add(10);
            system.createMenu(foodNames, foodPrices);

            List<String> menuFood = system.getMenuFood();
            List<double> menuPrice = system.getMenuPrice();

            Assert.AreEqual(foodNames, menuFood);
            Assert.AreEqual(foodPrices, menuPrice);
        }

        [TestMethod]
        public void SetTableState_ValidParameters_TableStateSet()
        {
            system.CreateTable();

            int tableIndex = 0;
            int tableState = 1;

            system.setTableState(tableIndex, tableState);

            int retrievedTableState = system.GetTableState(tableIndex);

            Assert.AreEqual(tableState, retrievedTableState);
        }

        [TestMethod]
        public void GetFldEmployer_ValidIndex_EmployerReturned()
        {
            string employerName = "John";
            string employerLastName = "Doe";

            system.NewEmployer(employerName, employerLastName);

            int employerIndex = 0;

            string retrievedEmployer = system.GetFldEmployer(employerIndex);

            string expectedEmployer = $"{employerName} {employerLastName}";

            Assert.AreEqual(expectedEmployer, retrievedEmployer);
        }

        [TestMethod]
        public void CreateTable_NoParameters_TableCreated()
        {
            bool created = system.CreateTable();

            Assert.IsTrue(created);
        }

        [TestMethod]
        public void DeleteTable_TableExists_TableDeleted()
        {
            system.CreateTable();

            bool deleted = system.DeleteTable();

            Assert.IsTrue(deleted);
        }

        [TestMethod]
        public void UpgradeTableState_ValidParameters_TableStateUpgraded()
        {
            system.CreateTable();
            system.setTableState(0, 1);

            string tableID = system.GetFldTable(0);
            int newTableState = 2;

            bool upgraded = system.UpgradeTableState(tableID, newTableState);

            Assert.IsTrue(upgraded);
            Assert.AreEqual(newTableState, system.GetTableState(0));
        }

        [TestMethod]
        public void NewEmployer_ValidParameters_EmployerCreated()
        {
            string employerName = "John";
            string employerLastName = "Doe";

            bool created = system.NewEmployer(employerName, employerLastName);

            Assert.IsTrue(created);
        }

        [TestMethod]
        public void UpdateEmployer_ValidParameters_EmployerUpdated()
        {
            string employerName = "John";
            string employerLastName = "Doe";
            string updatedName = "Jane";
            string updatedLastName = "Smith";

            system.NewEmployer(employerName, employerLastName);
            string employerID = system.GetFldEmployer(0);

            bool updated = system.UpdateEmployer(employerID, updatedName, updatedLastName);

            Assert.IsTrue(updated);
            Assert.AreEqual($"{updatedName} {updatedLastName}", system.GetFldEmployer(0));
        }

        [TestMethod]
        public void DeleteEmployer_ValidID_EmployerDeleted()
        {
            string employerName = "John";
            string employerLastName = "Doe";

            system.NewEmployer(employerName, employerLastName);
            string employerID = system.GetFldEmployer(0);

            bool deleted = system.DeleteEmployer(employerID);

            Assert.IsTrue(deleted);
            CollectionAssert.DoesNotContain(system.GetEmployer(), employerID);
        }

        [TestMethod]
        public void GenerateBill_ValidParameters_BillGenerated()
        {
            double billAmount = 50.0;
            List<string> billItems = new List<string> { "Burger", "Pizza" };
            List<double> billPrices = new List<double> { 10.99, 12.99 };
            string empID = "123";
            string tableID = "1";

            system.GenerateBill(billAmount, billItems, billPrices, empID, tableID);

            clsBill bill = system.GetFldMyBill(0);

            Assert.AreEqual(billAmount, bill.GetBillAmount());
            CollectionAssert.AreEqual(billItems, bill.GetBillItemList());
            CollectionAssert.AreEqual(billPrices, bill.GetBillItemPrice());
            Assert.AreEqual(empID, bill.GetEmpID());
        }

        [TestMethod]
        public void UpdateBill_ValidParameters_BillUpdated()
        {
            double initialBillAmount = 50.0;
            List<string> initialBillItems = new List<string> { "Burger", "Pizza" };
            List<double> initialBillPrices = new List<double> { 10.99, 12.99 };
            string initialEmpID = "123";
            string initialTableID = "1";

            double updatedBillAmount = 60.0;
            List<string> updatedBillItems = new List<string> { "Burger", "Pizza", "Pasta" };
            List<double> updatedBillPrices = new List<double> { 10.99, 12.99, 15.99 };
            string updatedEmpName = "Jane";

            system.GenerateBill(initialBillAmount, initialBillItems, initialBillPrices, initialEmpID, initialTableID);
            system.UpdateBill(0, updatedBillAmount, updatedBillItems, updatedBillPrices, updatedEmpName);

            clsBill bill = system.GetFldMyBill(0);

            Assert.AreEqual(updatedBillAmount, bill.GetBillAmount());
            CollectionAssert.AreEqual(updatedBillItems, bill.GetBillItemList());
            CollectionAssert.AreEqual(updatedBillPrices, bill.GetBillItemPrice());
            Assert.AreEqual(updatedEmpName, bill.GetEmpID());
        }

        [TestMethod]
        public void ShowBillHistory_NoParameters_BillHistoryReturned()
        {
            List<clsBill> billHistory = system.ShowBillHistory();

            Assert.IsNotNull(billHistory);
        }
    }
}
