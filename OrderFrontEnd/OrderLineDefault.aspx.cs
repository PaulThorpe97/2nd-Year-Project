using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;

public partial class OrderLineDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnOLCancel_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the OrderConfirm page
        Response.Redirect("OrderSummary.aspx");
    }



    protected void btnOLAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderLineID"] = -1;
        //this line of code redirects to the OrderConfirm page
        Response.Redirect("AnOrderLine.aspx");
    }
}