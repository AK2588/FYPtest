using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaffValidation
    {
        //good test data
        //create some test data to pass the method
        string StaffID = "1";
        string StaffUsername = "ExampleUser";
        string StaffPassword = "ExamplePass";
        string Role = "Sales";
        string Admin = "true";
        string StartDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinLessOne()
        {
            //create an instance of class
            clsStaff AnStaff= new clsStaff();
            //string var for error
            String Error = "";
            //create some test data
            string StaffID = ""; //error
            //invoke
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMin()
        {
            //create an instancec of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "0"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "00";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "00000";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "000000";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "000";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "0000000";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffID = "";
            StaffID = StaffID.PadRight(500, '0'); //should fail
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtemeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create var
            DateTime TestDate = DateTime.Now.Date;
            //change the date to less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert to string
            string DateCreated = TestDate.ToString();
            //invoke
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //covnert the date variable to string varaible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //covnert the date variable to string varaible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 100 years in future
            TestDate = TestDate.AddYears(100);
            //covnert the date variable to string varaible
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set date added to non date val
            string StartDate = "this is not a date";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffUsername = "";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffUsername = "0";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffUsername = "01";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffUsername = "0123456789012345678";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffUsername = "01234567890123456789";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffUsername = "01234567890";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffPassword = "";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffPassword = "0";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffPassword = "01";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffPassword = "0123456789012345678";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffPassword = "01234567890123456789";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string StaffPassword = "012345678901";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Role = "";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Role = "0";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Role = "01";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Role = "0123456789012345678";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Role = "01234567890123456789";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Role = "012345678901234567890";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminTrueData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Admin = "true";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminFalseData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Admin = "false";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AdminBadData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //the following should fail
            string Admin = "ohnobad77";
            //invoke the method
            Error = AnStaff.Valid(StaffID, StaffUsername, StaffPassword, Role, Admin, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
