<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assinment_15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
            <br />
            <asp:DataList ID="DataList1" runat="server" DataKeyField="EmpId" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    EmpId:
                    <asp:Label ID="EmpIdLabel" runat="server" Text='<%# Eval("EmpId") %>' />
                    <br />
                    EmpName:
                    <asp:Label ID="EmpNameLabel" runat="server" Text='<%# Eval("EmpName") %>' />
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
