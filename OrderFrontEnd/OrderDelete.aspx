<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="OrderDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    Are You Sure You Want To DeleteThis Order?<br />
    <br />
    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="110px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="110px" />
</asp:Content>

