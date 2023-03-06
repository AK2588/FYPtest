using System;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibrary
{
    
    public class clsStockCollection
    {
        
        List<clsStock> mStockList = new List<clsStock>();

        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        
        
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {


            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@GameName", mThisStock.GameName);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Availability", mThisStock.Availability);
            DB.AddParameter("@ReleaseDate", mThisStock.ReleaseDate);
            DB.AddParameter("@AgeRating", mThisStock.AgeRating);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@GameID", mThisStock.GameID);
            DB.AddParameter("@GameName", mThisStock.GameName);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Availability", mThisStock.Availability);
            DB.AddParameter("@ReleaseDate", mThisStock.ReleaseDate);
            DB.AddParameter("@AgeRating", mThisStock.AgeRating);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@GameID", mThisStock.GameID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByGameName(string GameName)
        {
            //filters the record based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the game name parameter to the database
            DB.AddParameter("@GameName", GameName);
            //exectute the stored procedure
            DB.Execute("sproc_tblStock_FilterByGameName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populated the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AnStock = new clsStock();
                //read in the fields from the current record
                AnStock.GameID = Convert.ToInt32(DB.DataTable.Rows[Index]["GameID"]);
                AnStock.GameName = Convert.ToString(DB.DataTable.Rows[Index]["GameName"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnStock.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AnStock.AgeRating = Convert.ToInt32(DB.DataTable.Rows[Index]["AgeRating"]);
                //add the record to the private data member
                mStockList.Add(AnStock);
                //point at the next record
                Index++;
            }
        }












    }

        








}