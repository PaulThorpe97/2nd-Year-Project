<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.master" AutoEventWireup="true" CodeFile="BOOrderHistory.aspx.cs" Inherits="BOOrderHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:ListBox ID="lstOrderHistory" runat="server" Height="200px" Width="300px"></asp:ListBox>
&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="lblOHError" runat="server" Text="[lblError]"></asp:Label>
    <br />
    <br />
    Enter An OrderID<br />
    <asp:TextBox ID="txtOrderHistory" runat="server" Width="178px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnOrderIDApply" runat="server" Text="Apply" Width="110px"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnHome" runat="server" Text="Home" Width="110px" OnClick="btnHome_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnOrderIDDelete" runat="server"  Text="Delete" Width="110px" OnClick="btnOrderIDDelete_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="110px" />
</asp:Content>

