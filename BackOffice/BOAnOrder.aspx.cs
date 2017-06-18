using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeWars;

public partial class AnOrder : System.Web.UI.Page
{
    //variable to sore the primary key
    Int32 OrderID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //populate the list of orders
            DisplayOrders();
            //if this is not a new record
            if (OrderID != -1)
            {
                //display thr current data for the record
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection OrderCollection = new clsOrderCollection();
        //find the record to update
        OrderCollection.ThisOrder.Find(OrderID);
        //display the data for this record
        txtProductID.Text = OrderCollection.ThisOrder.ProductID.ToString();
        txtProductSize.Text = OrderCollection.ThisOrder.ProductSize;
        txtQuantity.Text = OrderCollection.ThisOrder.Quantity.ToString();
        txtHouseNo.Text = OrderCollection.ThisOrder.HouseNo;
        txtStreet.Text = OrderCollection.ThisOrder.Street;
        txtTown.Text = OrderCollection.ThisOrder.Town;
        txtPostcode.Text = OrderCollection.ThisOrder.Postcode;
        chkStandardDelivery.Checked = OrderCollection.ThisOrder.StandardDelivery;
        chkNextDayDelivery.Checked = OrderCollection.ThisOrder.NextDayDelivery;
        txtOrderDate.Text = OrderCollection.ThisOrder.OrderDate.ToString();
    }

    //function for adding new record
    void Add()
    {
        //create an instance of the Order Collection
        clsOrderCollection OrderCollection = new clsOrderCollection();
        //validate the data on the web form
        Boolean OK = OrderCollection.ThisOrder.Valid(txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostcode.Text, txtOrderDate.Text);
        //if the data is ok then add it to the object
        if (OK == true)
        {
            //get the data entered by the user
            OrderCollection.ThisOrder.ProductID = Convert.ToInt32(txtProductID.Text);
            OrderCollection.ThisOrder.ProductSize = txtProductSize.Text;
            OrderCollection.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            OrderCollection.ThisOrder.HouseNo = txtHouseNo.Text;
            OrderCollection.ThisOrder.Street = txtStreet.Text;
            OrderCollection.ThisOrder.Town = txtTown.Text;
            OrderCollection.ThisOrder.Postcode = txtPostcode.Text;
            OrderCollection.ThisOrder.StandardDelivery = chkStandardDelivery.Checked;
            OrderCollection.ThisOrder.NextDayDelivery = chkNextDayDelivery.Checked;
            OrderCollection.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            //add the record
            OrderCollection.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered";
        }
    }

    //function for updating records
    void Update()
    {
        //create an instance of the Order Collection
        clsOrderCollection OrderCollection = new clsOrderCollection();
        //validate the data on the web form
        Boolean OK = OrderCollection.ThisOrder.Valid(txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostcode.Text, txtOrderDate.Text);
        //if the data is ok then add it to the object
        if (OK == true)
        {
            //find the record to update
            OrderCollection.ThisOrder.Find(OrderID);
            //get the data entered by the user
            OrderCollection.ThisOrder.ProductID = Convert.ToInt32(txtProductID.Text);
            OrderCollection.ThisOrder.ProductSize = txtProductSize.Text;
            OrderCollection.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            OrderCollection.ThisOrder.HouseNo = txtHouseNo.Text;
            OrderCollection.ThisOrder.Street = txtStreet.Text;
            OrderCollection.ThisOrder.Town = txtTown.Text;
            OrderCollection.ThisOrder.Postcode = txtPostcode.Text;
            OrderCollection.ThisOrder.StandardDelivery = chkStandardDelivery.Checked;
            OrderCollection.ThisOrder.NextDayDelivery = chkNextDayDelivery.Checked;
            OrderCollection.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            //update the record
            OrderCollection.Update();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered";
        }
    }

    //event handler for the ok button
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (OrderID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //all done so direct to OrderConfirm page
            Response.Redirect("OrderDefault.aspx");
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //direct to OrderConfirm page
        Response.Redirect("AnOrder.aspx");
    }
}