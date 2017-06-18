<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        ProductID&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;</p>
    <p>
        ProductSize&nbsp;
        <asp:TextBox ID="txtProductSize" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;</p>
    <p>
        Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        HouseNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtHouseNo" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Street&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
        &nbsp;&nbsp;</p>
    <p>
        Town&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;</p>
    <p>
        Postcode&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;</p>
    <p>
        StandardDelivery
        <asp:CheckBox ID="chkStandardDelivery" runat="server" />
        &nbsp;</p>
    <p>
        Next Day Delivery<asp:CheckBox ID="chkNextDayDelivery" runat="server" />
        &nbsp;</p>
    <p>
        OrderDate&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;</p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnOk" runat="server" Height="32px" Text="Ok" Width="80px" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" Height="32px" Text="Cancel" Width="80px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

