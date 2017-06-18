<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="OrderDefault.aspx.cs" Inherits="OrderDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:ListBox ID="lstOrderProduct" runat="server" Height="200px" Width="300px"></asp:ListBox>
    <br />
    <br />
    Please Enter A Product Name<br />
    <asp:TextBox ID="txtOProductName" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="btnOProductApply" runat="server" Text="Apply" Width="110px"/>
    <asp:Button ID="btnODisplayAll" runat="server" Text="DisplayAll" Width="110px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
    <asp:Button ID="btnAdd" runat="server" Text="Add" Width="76px" style="height: 26px" OnClick="btnAdd_Click1" />
    </p>
    <p>
        <asp:Button ID="btnViewCustomerOrders" runat="server" Text="View Order History" OnClick="btnViewCustomerOrders_Click" />
    </p>
    <p>
        &nbsp;</p>
    <br />
    </asp:Content>

