using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //PRIVATE DATA member for the Staff ID property
        private Int32 mStaffID;
        private DateTime mStartDate;
        private String mUsername;
        private String mPassword;
        private String mRole;
        private Boolean mAdmin;

        public clsStaff() { }

        public bool Admin
        {
            get
            {
                return mAdmin;
            }
            set
            {
                mAdmin = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        public string Valid(string staffID, string staffUsername, string staffPassword, string role, string admin, string startDate)
        {
            //Create string var to store error
            String Error = "";
            //temp vars
            DateTime DateTemp;
            //if staffID is blank
            if (staffID.Length == 0)
            {
                //record error
                Error = Error + "The Staff ID may not be blank: ";
            }
            //if staffID is greater than 6 chars
            if (staffID.Length > 6)
            {
                //record error
                Error = Error + "The Staff ID must be less than 6 characters: ";
            }

            //copy datetime val
            try
            {
                DateTemp = Convert.ToDateTime(startDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The date cannot be in the future: ";
                }
            }

            catch
            {
                Error = Error + "The date was not a valid date: ";
            }
            if (staffPassword.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Password may not be blank: ";
            }
            //if the staff password is too long
            if (staffPassword.Length > 20)
            {
                //record the error
                Error = Error = "The Staff Password must be less than 20: ";
            }
            //if the staff username is blank
            if (staffUsername.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Username may not be blank: ";
            }
            //if the staff username is too long 
            if (staffUsername.Length > 20)
            {
                //record the error
                Error = Error + "The Staff Username must be less than 20: ";
            }
            //if the staff role is blank
            if (role.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Role may not be blank: ";
            }
            //if the staff role is too long
            if (role.Length > 20)
            {
                Error = Error + "The Staff Role must be less than 20: ";
            }
            if (admin.ToLower().Equals("true") || admin.ToLower().Equals("false"))
            {

            } else
            {
                Error = Error + "The account active must be true or false : ";
            }

            //return any error message
            return Error;
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
            } }
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
        public string Role
        {
            get
            {
                return mRole;
            }
            set
            {
                mRole = value;
            }
        }

        public bool Find(int staffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@StaffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterbyStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["StaffUsername"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                //return that everything worked OK
                return true;

            }
            //if no else was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }


}