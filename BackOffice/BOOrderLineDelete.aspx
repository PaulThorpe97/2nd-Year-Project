﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.master" AutoEventWireup="true" CodeFile="BOOrderLineDelete.aspx.cs" Inherits="BOOrderLineDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    Are You Sure You Want To DeleteThis Order?</p>
    <p>
    <asp:Button ID="btnOLYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="110px" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnOLNo" runat="server" OnClick="btnNo_Click" Text="No" Width="110px" />
    </p>
</asp:Content>
