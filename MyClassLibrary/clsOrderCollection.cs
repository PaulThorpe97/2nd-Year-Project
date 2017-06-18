using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsOrderCollection
    {
        //private data member fo the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member ThisOrder
        clsOrder mThisOrder = new clsOrder();

        //public property for the ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //public property for the Order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the private data
                return mOrderList.Count;
            }
            set
            {
               //we shal worry about this later
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisorder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", ThisOrder.ProductID);
            DB.AddParameter("@ProductSize", ThisOrder.ProductSize);
            DB.AddParameter("@Quantity", ThisOrder.Quantity);
            DB.AddParameter("@HouseNo", ThisOrder.HouseNo);
            DB.AddParameter("@Street", ThisOrder.Street);
            DB.AddParameter("@Town", ThisOrder.Town);
            DB.AddParameter("@Postcode", ThisOrder.Postcode);
            DB.AddParameter("@StandardDelivery", ThisOrder.StandardDelivery);
            DB.AddParameter("@NextDayDelivery", ThisOrder.NextDayDelivery);
            DB.AddParameter("@OrderDate", ThisOrder.OrderDate);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parmeters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@ProductSize", mThisOrder.ProductSize);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@HouseNo", mThisOrder.HouseNo);
            DB.AddParameter("@Street", mThisOrder.Street);
            DB.AddParameter("@Town", mThisOrder.Town);
            DB.AddParameter("@Postcode", mThisOrder.Postcode);
            DB.AddParameter("@StandardDelivery", mThisOrder.StandardDelivery);
            DB.AddParameter("@NextDayDelivery", mThisOrder.NextDayDelivery);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");

        }

        //constructer for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArrary(DB);
            
        }

        public void FilterByPostcode(string Postcode)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Postcode", Postcode);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByPostcode");
            //Ppopulate the array list with the data table
            PopulateArrary(DB);
        }

        void PopulateArrary(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.ProductSize = Convert.ToString(DB.DataTable.Rows[Index]["ProductSize"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnOrder.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AnOrder.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AnOrder.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AnOrder.StandardDelivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["StandardDelivery"]);
                AnOrder.NextDayDelivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["NextDayDelivery"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
 }
