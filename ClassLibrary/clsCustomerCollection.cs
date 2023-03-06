using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mthisCustomer = new clsCustomer();
        
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);

        }
        
        public List<clsCustomer> CustomerList 
        { 
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public clsCustomer ThisCustomer { 
            get
            {
                return mthisCustomer;
            }
            set
            {
                mthisCustomer = value;
            }
        }
        public int Count {
            get
            {
                return mCustomerList.Count;
            } 
            set
            {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", mthisCustomer.Username);
            DB.AddParameter("@Password", mthisCustomer.Password);
            DB.AddParameter("@Address", mthisCustomer.Address);
            DB.AddParameter("@DateAdded", mthisCustomer.DateAdded);
            DB.AddParameter("@Active", mthisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mthisCustomer.ID);
            DB.AddParameter("@Username", mthisCustomer.Username);
            DB.AddParameter("@Password", mthisCustomer.Password);
            DB.AddParameter("@Address", mthisCustomer.Address);
            DB.AddParameter("@DateAdded", mthisCustomer.DateAdded);
            DB.AddParameter("@Active", mthisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mthisCustomer.ID);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByUsername(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.Execute("sproc_tblCustomer_FilterByUsername");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();
                Customer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountActive"]);
                Customer.Username = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUsername"]);
                Customer.Password = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                Customer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["AccountCreationDate"]);
                Customer.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);

                mCustomerList.Add(Customer);
                Index++;
            }
        }
    }
}