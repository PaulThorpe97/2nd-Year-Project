using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsOrderLineCollection
    {
        //private data member fo the list
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        //private data member ThisOrderLine
        clsOrderLine mThisOrderLine = new clsOrderLine();

        //public property for the ThisOrderLine
        public clsOrderLine ThisOrderLine
        {
            get
            {
                //return the private data
                return mThisOrderLine;
            }
            set
            {
                //set the private data
                mThisOrderLine = value;
            }
        }

        //public property for the OrderLine list
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                //return the private data
                return mOrderLineList;
            }
            set
            {
                //set the private data
                mOrderLineList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the private data
                return mOrderLineList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisorder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parmeters for the stored procedure
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_Update");
        }

        //constructer for the class
        public clsOrderLineCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void FilterByOrderID(string OrderID)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderID");
            //Ppopulate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderLineList = new List<clsOrderLine>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrderLine AnOrderLine = new clsOrderLine();
                //read in the fields from the current record
                AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.OrderID = Convert.ToString(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.ProductID = Convert.ToString(DB.DataTable.Rows[Index]["ProductID"]);
                //add the record to the private data member
                mOrderLineList.Add(AnOrderLine);
                //point at the next record
                Index++;
            }
        }
    }
}