<%@ Page Title="" Language="C#" MasterPageFile="~/BackOffice.master" AutoEventWireup="true" CodeFile="BOOrderLineHistory.aspx.cs" Inherits="BOOrderLineHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    <asp:ListBox ID="lstOrderLineHistory" runat="server" Height="200px" Width="300px"></asp:ListBox>
    </p>
    <p>
        <asp:Label ID="lblOLHError" runat="server" Text="[lblError]"></asp:Label>
    </p>
    <p>
        Enter An OrderLineID</p>
    <p>
    <asp:TextBox ID="txtOrderLineHistory" runat="server" Width="178px"></asp:TextBox>
    </p>
    <p>
    <asp:Button ID="btnOrderLineIDApply" runat="server" Text="Apply" Width="110px"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnOLHome" runat="server" Text="Home" Width="110px"/>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnOrderLineIDDelete" runat="server" Text="Delete" Width="110px" OnClick="btnOrderLineIDDelete_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

