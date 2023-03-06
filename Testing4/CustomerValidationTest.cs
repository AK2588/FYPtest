using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class CustomerValidationTest
    {

        string CustomerID = "12";
        string CustomerUsername = "ExampleUsername";
        string CustomerPassword = "ExamplePass";
        string CustomerAddress = "CustomerAddress";
        string DateCreated = DateTime.Now.Date.ToString();
        string AccountActive = "true";

        [TestMethod]
        public void ValidMethodOK()
        {
            // create instance of class
            clsCustomer ACustomer = new clsCustomer();
            // string var to store error
            String Error = "";
            // invoke method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            // test to see result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerIdMinLessOne()
        {
            // Create an instance of clsas
            clsCustomer ACustomer = new clsCustomer();
            // String var for error
            String Error = "";
            // create some test data
            string CustomerID = ""; // error
            // invoke
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            // test to ree result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aaaaaaa"; //this should fal
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, 'a'); // should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMin()
        {
            // create instance
            clsCustomer ACustomer = new clsCustomer();
            // string var to store error
            String Error = "";
            // create var
            DateTime TestDate = DateTime.Now.Date;
            // chnage date to less than 100 years
            TestDate = TestDate.AddYears(-100);
            // convert to string
            string DateCreated = TestDate.ToString();
            // invoke
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            // Test to see result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateCreatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateCreatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateCreatedInvalidData()
        {
            // creae inst
            clsCustomer ACustomer = new clsCustomer();
            // string var to store error
            String Error = "";
            // set date added to non date val
            string DateCreated = "this is not a date!";
            // invoke
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            // test to see result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerUsername = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerUsername = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerUsername = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerUsername = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerUsername = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void UsernameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerUsername = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerPassword = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerPassword = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerAddress = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActiveMethodTrueData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AccountActive = "true";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ActiveMethodFalseData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AccountActive = "false";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActiveMethodBadData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AccountActive = "asgedu45";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerUsername, CustomerPassword, CustomerAddress, DateCreated, AccountActive);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }


}
