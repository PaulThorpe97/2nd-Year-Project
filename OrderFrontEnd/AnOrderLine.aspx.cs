using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;

public partial class AnOrderLine : System.Web.UI.Page
{
    //variable to sore the primary key
    Int32 OrderLineID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be processed
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
        if (IsPostBack == false)
        {
            //populate the list of orders
            DisplayOrders();
            //if this is not a new record
            if (OrderLineID != -1)
            {
                //display thr current data for the record
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderLineCollection OrderLineCollection = new clsOrderLineCollection();
        //find the record to update
        OrderLineCollection.ThisOrderLine.Find(OrderLineID);
        //display the data for this record
        txtOLOrderID.Text = OrderLineCollection.ThisOrderLine.OrderID;
        txtOLProductID.Text = OrderLineCollection.ThisOrderLine.ProductID;
    }

    //function for adding new record
    void Add()
    {
        //create an instance of the OrderLine Collection
        clsOrderLineCollection OrderLineCollection = new clsOrderLineCollection();
        //validate the data on the web form
        Boolean OK = OrderLineCollection.ThisOrderLine.Valid(txtOLOrderID.Text, txtOLProductID.Text);
        //if the data is ok then add it to the object#
        if (OK == true)
        {
            //get the data entered by the user
            OrderLineCollection.ThisOrderLine.OrderID = txtOLOrderID.Text;
            OrderLineCollection.ThisOrderLine.ProductID = txtOLProductID.Text;
            //add the record
            OrderLineCollection.Add();
        }
        else
        {
            //report an error
            lblOLError.Text = "There were problems with the data entered";
        }
    }

    //function for updating records
    void Update()
    {
        //create an instance of the Order Collection
        clsOrderLineCollection OrderLineCollection = new clsOrderLineCollection();
        //validate the data on the web form
        Boolean OK = OrderLineCollection.ThisOrderLine.Valid(txtOLOrderID.Text, txtOLProductID.Text);
        //if the data is ok then add it to the object
        if (OK == true)
        {
            //find the record to update
            OrderLineCollection.ThisOrderLine.Find(OrderLineID);
            //get the data entered by the user
            OrderLineCollection.ThisOrderLine.OrderID = txtOLOrderID.Text;
            OrderLineCollection.ThisOrderLine.ProductID = txtOLProductID.Text;
            //update the record
            OrderLineCollection.Update();
        }
        else
        {
            //report an error
            lblOLError.Text = "There were problems with the data entered";
        }
    }

    protected void btnOLOk_Click(object sender, EventArgs e)
    {
        if (OrderLineID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //all done so direct to OrderConfirm page
            Response.Redirect("OrderLineDefault.aspx");
        }
    }

    protected void btnOLCancel_Click(object sender, EventArgs e)
    {
        //direct to OrderConfirm page
        Response.Redirect("AnOrderLine.aspx");
    }
}