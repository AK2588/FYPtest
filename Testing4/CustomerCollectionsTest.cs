using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing4
{
    [TestClass]
    public class CustomerCollectionsTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";


            AllCustomers.ThisCustomer = TestItem;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.ID = 1;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.ID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.Password = "Pass";
            TestItem.Username = "Username";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Address = "LE2 3AB";

            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
           
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByUsername("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);


        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("xxxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDatFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByUsername("ExampleCustomer");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].ID != 1)
                {
                    OK = false;

                } 
                if (FilteredCustomers.CustomerList[1].ID != 4)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
}
