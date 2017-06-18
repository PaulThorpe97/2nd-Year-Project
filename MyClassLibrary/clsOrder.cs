using System;

namespace MyClassLibrary
{
    public class clsOrder
    {
        //Private data member for the OrderID property
        private Int32 mOrderID;
        //Private data member for the CustomerID property
        private Int32 mCustomerID;
        //Private data member for the HouseNo property
        private String mHouseNo;
        //Private data member for the NextDayDelivery property
        private Boolean mNextDayDelivery;
        //Private data member for the OrderDate property
        private DateTime mOrderDate;
        //Private data member for the OrderLineID property
        private Int32 mOrderLineID;
        //Private data member for the Postcode property
        private String mPostcode;
        //Private data member for the CustomerID property
        private Int32 mProductID;
        //Private data member for the ProductSize property
        private String mProductSize;
        //Private data member for the Quantity property
        private Int32 mQuantity;
        //Private data member for the StandardDelivery property
        private Boolean mStandardDelivery;
        //Private data member for the Street property
        private String mStreet;
        //Private data member for the Town property
        private String mTown;
        public int CustomerID
        {
            get
            {
                // return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        public string HouseNo
        {
            get
            {
                // return the private data
                return mHouseNo;
            }
            set
            {
                //set the value of the private data member
                mHouseNo = value;
            }
        }
        public bool NextDayDelivery
        {
            get
            {
                // return the private data
                return mNextDayDelivery;
            }
            set
            {
                //set the value of the private data member
                mNextDayDelivery = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                // return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }
        public int OrderID
        {
            get
            {
                // return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }
            
        public int OrderLineID
        {
            get
            {
                // return the private data
                return mOrderLineID;
            }
            set
            {
                //set the value of the private data member
                mOrderLineID = value;
            }
        }
        public string Postcode
        {
            get
            {
                // return the private data
                return mPostcode;
            }
            set
            {
                //set the value of the private data member
                mPostcode = value;
            }
        }
        public int ProductID
        {
            get
            {
                // return the private data
                return mProductID;
            }
            set
            {
                //set the value of the private data member
                mProductID = value;
            }
        }
        public string ProductSize
        {
            get
            {
                // return the private data
                return mProductSize;
            }
            set
            {
                //set the value of the private data member
                mProductSize = value;
            }
        }
        public int Quantity
        {
            get
            {
                // return the private data
                return mQuantity;
            }
            set
            {
                //set the value of the private data member
                mQuantity = value;
            }
        }
        public bool StandardDelivery
        { 
            get
            {
                // return the private data
                return mStandardDelivery;
            }
            set
            {
                //set the value of the private data member
                mStandardDelivery = value;
            }
        }
        public string Street
        {
            get
            {
                // return the private data
                return mStreet;
            }
            set
            {
                //set the value of the private data member
                mStreet = value;
            }
        }
        public string Town
        {
            get
            {
                // return the private data
                return mTown;
            }
            set
            {
                //set the value of the private data member
                mTown = value;
            }
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order ID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the ata from the database to the private data memebrs
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mNextDayDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["NextDayDelivery"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductSize = Convert.ToString(DB.DataTable.Rows[0]["ProductSize"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mStandardDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["StandardDelivery"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string HouseNo, string Street, string Town, string Postcode, string OrderDate)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (HouseNo.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the HouseNo is greater than 6 characters
            if (HouseNo.Length >6)
            {
                //set the flag OK to false
                OK = false;
            }
            //try the date validation assuming the data is a valid date
            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                //check t see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //see the flag OK to false
                    OK = false;
                }
                //check t see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //see the flag OK to false
                    OK = false;
                }
            }
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //if the postcode blank
            if (Postcode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Postcode is too long
            if (Postcode.Length > 9)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Street blank
            if (Street.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Street is too long
            if (Street.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Town blank
            if (Town.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Town is too long
            if (Town.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //return the value of OK
            return OK;
        }
    }

}
















