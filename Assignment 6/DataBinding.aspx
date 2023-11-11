<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBinding.aspx.cs" Inherits="Assignment_6.DataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Binding Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Data Binding Demo</h2>
            <asp:Label ID="lblHashtable" runat="server" Text="DataBinding using Hashtable"></asp:Label>
            <asp:GridView ID="gvHashtable" runat="server" AutoGenerateColumns="True"></asp:GridView><br />

            <asp:Label ID="lblArrayList" runat="server" Text="DataBinding using ArrayList"></asp:Label>
            <asp:GridView ID="gvArrayList" runat="server" AutoGenerateColumns="True"></asp:GridView><br />

            <asp:Label ID="lblDataTable" runat="server" Text="DataBinding using DataTable"></asp:Label>
            <asp:GridView ID="gvDataTable" runat="server" AutoGenerateColumns="True"></asp:GridView>
        </div>
    </form>
</body>
</html>
