using System;

namespace ClassLibrary
{
    public class clsStock
    {
 
    

        private Int32 mGameID;
        public int GameID
        {
            get
            {
                return mGameID;
            }

            set
            {
                mGameID = value;
            }
        }



        private string mGameName;
        public string GameName
        {
            get
            {
                return mGameName;
            }

            set
            {
                mGameName = value;
            }
        }



        private Int32 mPrice;
        public int Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }



        //private date added data member
        private bool mAvailability;
        //public property for date added
        public bool Availability
        {
            get
            {
                //return the private data
                return mAvailability;
            }
            set
            {
                //set the private data
                mAvailability = value;
            }
        }



        private DateTime mReleaseDate;
        public DateTime ReleaseDate
        {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }



        private Int32 mAgeRating;
        public int AgeRating
        {
            get
            {
                return mAgeRating;
            }
            set
            {
                mAgeRating = value;
            }
        }





                    public bool Find(int GameID)
        {
                // Create an instance of the data connection
                clsDataConnection DB = new clsDataConnection();
                // add param for customer id
                 DB.AddParameter("@GameID", GameID);
                // execute stored proc
                DB.Execute("sproc_tblStock_FilterbyGameID");
                // If one record is found
                if (DB.Count == 1)
                {
                mGameID = Convert.ToInt32(DB.DataTable.Rows[0]["GameID"]);
                mGameName = Convert.ToString(DB.DataTable.Rows[0]["GameName"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mAgeRating = Convert.ToInt32(DB.DataTable.Rows[0]["AgeRating"]);


                // Return true indicating everything worked ok
                return true;
            }
                else
            {
                    // return false indicating a proble
                    return false;
            }
        }





        public string Valid(string gameName, string releaseDate)
        {
            //create a string variable to store the error
            String Error = "";
            //if the GameName is blank
            if (gameName.Length == 0)
            {
                //record the error
                Error = Error + "The game name may not be blank : ";
            }
            //if the house number is greater than 50
            if (gameName.Length > 50)
            {
                Error = Error + "The game name must be less than 50 characters : ";
            }

            //copy the releaseDate value to the DateTemp variable
            ReleaseDate = Convert.ToDateTime(releaseDate);
            if (ReleaseDate < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than todays date
            if (ReleaseDate > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }


            //return any error messages
            return Error;
        }





    }








    }
