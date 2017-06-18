using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewCustomerOrders_Click(object sender, EventArgs e)
    {

        //this line of code redirects to the OrderHistory page
        Response.Redirect("OrderHistory.aspx");
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //this line of code redirects to the AnOrder page
        Response.Redirect("AnOrder.aspx");
    }

}