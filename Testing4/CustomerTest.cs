using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{

    [TestClass]
    public class CustomerTest
    {


        [TestMethod]
        public void TestConstruct()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }

      

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // Boolean variable to store results of validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 CustomerNo = 1;
            // Invoke the method
            Found = ACustomer.Find(CustomerNo);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }
        
        [TestMethod]
        public void ActivePropertyOK()
        {
            // Create an instance of the class
            clsCustomer Customer = new clsCustomer();
            // Create test data to assign to property
            Boolean TestData = true;
            // Assign data to property
            Customer.Active = TestData;
            // Test to see that values are the same
            Assert.AreEqual(Customer.Active, TestData);
        }

        [TestMethod]
        public void DateAccountCreatedPropertyOK()
        {
            // Create an instance of the class
            clsCustomer Customer = new clsCustomer();
            // Create test data
            DateTime TestData = DateTime.Now.Date;
            // Assign data
            Customer.DateAdded = TestData;
            // Test Equal
            Assert.AreEqual(Customer.DateAdded, TestData);
        }

        [TestMethod]
        public void IDPropertyOK()
        {
            // Create instance
            clsCustomer Customer = new clsCustomer();
            // Create test data
            int TestData = 1;
            // Assign data
            Customer.ID = TestData;
            // Test Equal
            Assert.AreEqual(Customer.ID, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            // Create instance
            clsCustomer Customer = new clsCustomer();
            // Create test data
           String TestData = "Harry0198";
            // Assign data
            Customer.Username = TestData;
            // Test Equal
            Assert.AreEqual(Customer.Username, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // Create instance
            clsCustomer Customer = new clsCustomer();
            // Create test data
            String TestData = "SomePass";
            // Assign data
            Customer.Password = TestData;
            // Test Equal
            Assert.AreEqual(Customer.Password, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            // Create instance
            clsCustomer Customer = new clsCustomer();
            // Create test data
            String TestData = "Address";
            // Assign data
            Customer.Address = TestData;
            // Test Equal
            Assert.AreEqual(Customer.Address, TestData);
        }
    }
}
