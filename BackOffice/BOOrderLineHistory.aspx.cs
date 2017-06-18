using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;

public partial class BOOrderLineHistory : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //event handler for the delete button
    protected void btnOrderLineIDDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderLineID;
        //if a record has been selected from the list
        if (lstOrderLineHistory.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderLineID = Convert.ToInt32(lstOrderLineHistory.SelectedValue);
            //store the data in the session object
            Session["OrderLineID"] = OrderLineID;
            //this line of code redirects to the OrderLineDelete page
            Response.Redirect("OrderLineDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblOLHError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnOLHome_Click(object sender, EventArgs e)
    {
        //this line of code redirects to the OrderDefault page
        Response.Redirect("OrderDefault.aspx");
    }

}