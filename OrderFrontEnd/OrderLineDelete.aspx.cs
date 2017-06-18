using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;

public partial class OrderLineDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderLineID;
    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the OrderLine to be deleted from the session object
        OrderLineID = Convert.ToInt32(Session["OrderLineID"]);
    }
    void DeleteOrder()
    {
        //function to delete selected record
        //create a new instance of the OrderCollection
        clsOrderLineCollection OrderLineCollection = new clsOrderLineCollection();
        //find the record to delete
        OrderLineCollection.ThisOrderLine.Find(OrderLineID);
        //Delete the record
        OrderLineCollection.Delete();
    }


    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        {
            //delete the record
            DeleteOrder();
            //this line of code redirects to the OrderDefault page
            Response.Redirect("OrderLineHistory.aspx");
        }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the OrderHistory page
        Response.Redirect("OrderLineHistory.aspx");
    }
}