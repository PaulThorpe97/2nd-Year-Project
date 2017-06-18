using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;


public partial class OrderHistory : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrderHistory.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderHistory.DataValueField = "OrderID";
        //set the data field to display
        lstOrderHistory.DataTextField = "Postcode";
        //Bind the data to the list
        lstOrderHistory.DataBind();
    }

    //event handler for the delete button
    protected void btnOrderIDDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderHistory.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrderHistory.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //this line of code redirects to the OrderDelete page
            Response.Redirect("OrderDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblOHError.Text = "Please select a record to delete from the list";
        }
        
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the OrderDefault page
        Response.Redirect("OrderDefault.aspx");
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderHistory.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderHistory.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("AnOrder.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblOHError.Text = "Please select a record to edit from the list";
        }
    }
}