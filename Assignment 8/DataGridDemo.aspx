<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridDemo.aspx.cs" Inherits="Assignment_8.DataGridDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DataGrid Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>DataGrid Demo</h2>

            <asp:DataGrid ID="dataGridDemo" runat="server" AutoGenerateColumns="False"
                AllowPaging="True" AllowSorting="True" OnPageIndexChanged="dataGridDemo_PageIndexChanged"
                OnSortCommand="dataGridDemo_SortCommand" OnItemDataBound="dataGridDemo_ItemDataBound">
                <Columns>
                    <asp:BoundColumn HeaderText="Name" DataField="Name" SortExpression="Name" />
                    <asp:BoundColumn HeaderText="Age" DataField="Age" SortExpression="Age" />
                    <asp:BoundColumn HeaderText="City" DataField="City" SortExpression="City" />
                </Columns>
                <PagerStyle Mode="NumericPages" />
            </asp:DataGrid>
        </div>
    </form>
</body>
</html>
