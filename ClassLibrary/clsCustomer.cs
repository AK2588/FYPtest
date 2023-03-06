using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // CustomerID private member variable
        private Int32 mID;
        private DateTime mDateAdded;
        private bool mActive;
        private string mUsername;
        private string mPassword;
        private string mAddress;
        public clsCustomer()
        {
        }

        public string Valid(string customerId, string customerUsername, string customerPassword, string customerAddress, string accountCreationDate, string accountActive)
        {
            // Create string var to store error
            String Error = "";
            // temp vars
            DateTime DateTemp;
            // if customerid is blank
            if (customerId.Length == 0)
            {
                // record error
                Error = Error + "The customer id may not be blank : ";
            }
            // if customerId is greater than 6 chars
            if (customerId.Length > 6)
            {
                // record error
                Error = Error + "The customer id must be less than 6 characters :";
            }
            
            // copy datetime val
            try
            {
                DateTemp = Convert.ToDateTime(accountCreationDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    // record error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date :";
            }
            if (customerPassword.Length == 0)
            {
                //record the error
                Error = Error + "The customerPassword may not be blank : ";
            }
            //if the customerPassword is too long
            if (customerPassword.Length > 50)
            {
                //record the error
                Error = Error + "The customerPassword must be less than 50 characters : ";
            }
            //is the customerUsername blank
            if (customerUsername.Length == 0)
            {
                //record the error
                Error = Error + "The customerUsername may not be blank : ";
            }
            //if the customerUsername is too long
            if (customerUsername.Length > 50)
            {
                //record the error
                Error = Error + "The customerUsername must be less than 50 characters : ";
            }
            //is the customerAddress blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The customerAddress may not be blank : ";
            }
            //if the customerAddress is too long
            if (customerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The customerAddress must be less than 50 characters : ";
            }
            if (accountActive.ToLower().Equals("true") || accountActive.ToLower().Equals("false"))
            {
            } else
            {
                Error = Error + "The account active must be true or false : ";

            }


            //return any error messages
            return Error;
        }

        public bool Find(int customerNo)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add param for customer id
            DB.AddParameter("@CustomerID", customerNo);
            // execute stored proc
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // If one record is found
            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["CustomerUsername"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountActive"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreationDate"]);
                // Return true indicating everything worked ok
                return true;
            }
            else
            {
                // return false indicating a proble
                return false;
            }
        }

        // CustomerID public property
        public Int32 ID
        {
            get
            {
                // this line of code sends data out of the property
                return mID;
            }
            set
            {
                // this line of code allows data into the property
                mID = value;
            }
        }

        public bool Active 
        { 
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }
       
        public string Username 
        { 
            get
            {
                return mUsername;
            } 
            set 
            {
                mUsername = value;
            } 
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Address
        { 
            get
            {
                return mAddress;
            }
            set 
            {
                mAddress = value;
            }
        }
    }
}