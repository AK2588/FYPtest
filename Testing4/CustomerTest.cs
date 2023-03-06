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
        public void TestCustomerNoFound()
        {
            // Create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerNo = 4;
            // Invoke method
            Found = ACustomer.Find(CustomerNo);
            // Check customer No
            if (ACustomer.ID != 4)
            {
                OK = false;
            }
            // test result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerUsernameFound()
        {
            // Create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerNo = 4;
            // Invoke method
            Found = ACustomer.Find(CustomerNo);
            // Check customer name
            if (ACustomer.Username != "ExampleCustomer")
            {
                OK = false;
            }
            // test result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            // Create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerNo = 4;
            // Invoke method
            Found = ACustomer.Find(CustomerNo);
            // Check customer password
            if (ACustomer.Password != "ExamplePass")
            {
                OK = false;
            }
            // test result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDateAddedFound()
        {
            // Create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerNo = 4;
            // Invoke method
            Found = ACustomer.Find(CustomerNo);
            // Check customer date added
            if (ACustomer.DateAdded != Convert.ToDateTime("02/02/2022"))
            {
                OK = false;
            }
            // test result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerActiveFound()
        {
            // Create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerNo = 4;
            // Invoke method
            Found = ACustomer.Find(CustomerNo);
            // Check customer active
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            // test result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            // Create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // boolean variable to store result
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerNo = 1;
            // Invoke method
            Found = ACustomer.Find(CustomerNo);
            // Check customer address
            if (ACustomer.Address != "Address")
            {
                OK = false;
            }
            // test result is correct
            Assert.IsTrue(OK);
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
