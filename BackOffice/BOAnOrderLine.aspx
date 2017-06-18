<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.master" AutoEventWireup="true" CodeFile="BOAnOrderLine.aspx.cs" Inherits="BOAnOrderLine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        OrderID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOLOrderID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;</p>
    <p>
        ProductID&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtOLProductID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;</p>
    <p>
        <asp:Label ID="lblOLError" runat="server" Text="lblError"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnOLOk" runat="server" Height="32px" OnClick="btnOLOk_Click" Text="Ok" Width="80px" />
        <asp:Button ID="btnOLCancel" runat="server" Height="32px" style="margin-top: 0px" Text="Cancel" Width="80px" OnClick="btnOLCancel_Click" />
    </p>
</asp:Content>

