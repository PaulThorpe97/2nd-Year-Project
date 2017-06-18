using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;

public partial class BOOrderDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderID;
    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    void DeleteOrder()
    {
        //function to delete selected record
        //create a new instance of the OrderCollection
        clsOrderCollection OrderCollection = new clsOrderCollection();
        //find the record to delete
        OrderCollection.ThisOrder.Find(OrderID);
        //Delete the record
        OrderCollection.Delete();
    }

    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteOrder();
        //this line of code redirects to the OrderDefault page
        Response.Redirect("OrderHistory.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the OrderHistory page
        Response.Redirect("OrderHistory.aspx");
    }
}