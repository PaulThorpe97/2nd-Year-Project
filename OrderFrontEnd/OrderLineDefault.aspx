<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd.master" AutoEventWireup="true" CodeFile="OrderLineDefault.aspx.cs" Inherits="OrderLineDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    <asp:ListBox ID="lstOrderLineProduct" runat="server" Height="200px" Width="300px"></asp:ListBox>
    </p>
    <p>
        &nbsp;Enter An Order ID</p>
    <p>
    <asp:TextBox ID="txtOLProductName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
    <asp:Button ID="btnOLProductApply" runat="server" Text="Apply" Width="110px" />
    <asp:Button ID="btnOLDisplayAll" runat="server" Text="DisplayAll" Width="110px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnOLAdd" runat="server" Text="Add" Width="76px" style="height: 26px" OnClick="btnOLAdd_Click" />
        &nbsp;<asp:Button ID="btnOLCancel" runat="server" Text="Cancel" Width="84px" Height="26px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

