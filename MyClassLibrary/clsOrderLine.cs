using System;

namespace MyClassLibrary
{
    public class clsOrderLine
    {
        //Private data member for the OrderLineID property
        private Int32 mOrderLineID;
        //Private data member for the OrderID property
        private String mOrderID;
        //Private data member for the ProductID property
        private String mProductID;

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

        public string OrderID
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

        public string ProductID
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

        public bool Find(int OrderLineID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order ID to search for
            DB.AddParameter("@OrderLineID", OrderLineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the ata from the database to the private data memebrs
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["OrderID"]);
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["OrderID"]);
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

        public bool Valid(string OrderID, string ProductID)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //if the OrderID is blank
            if (OrderID.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the ProductID blank
            if (ProductID.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //return the value of OK
            return OK;
        }
    }

}