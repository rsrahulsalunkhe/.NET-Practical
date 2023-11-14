<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterControl.aspx.cs" Inherits="Assignment_7.RepeaterControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Repeater Control Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Repeater Control Demo</h2>

            <asp:Repeater ID="repeaterDemo" runat="server">
                <HeaderTemplate>
                    <table border="1">
                        <tr>
                            <th>Name</th>
                            <th>Age</th>
                            <th>City</th>
                        </tr>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("Age") %></td>
                        <td><%# Eval("City") %></td>
                    </tr>
                </ItemTemplate>

                <SeparatorTemplate>
                    <tr><td colspan="3"><hr /></td></tr>
                </SeparatorTemplate>

                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
