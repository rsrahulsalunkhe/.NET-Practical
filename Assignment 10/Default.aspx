<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_10._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shopping Cart Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Shopping Cart Demo</h2>

            <asp:DataList ID="dlProducts" runat="server" RepeatColumns="3" OnItemCommand="dlProducts_ItemCommand">
                <ItemTemplate>
                    <div style="border: 1px solid #ccc; padding: 10px; margin: 10px;">
                        <h4><%# Eval("ProductName") %></h4>
                        Price: $<%# Eval("Price") %>
                        <br />
                        <asp:Button ID="btnAddToCart" runat="server" CommandName="AddToCart" CommandArgument='<%# Eval("ProductID") %>' Text="Add to Cart" />
                    </div>
                </ItemTemplate>
            </asp:DataList>

            <hr />

            <h3>Shopping Cart</h3>

            <asp:Repeater ID="rptCart" runat="server">
                <ItemTemplate>
                    <div>
                        <strong><%# Eval("ProductName") %></strong>
                        <br />
                        Price: $<%# Eval("Price") %>
                        <br />
                        Quantity: <%# Eval("Quantity") %>
                        <br />
                        Total: $<%# Eval("Total") %>
                        <br />
                        <asp:Button ID="btnRemoveFromCart" runat="server" CommandName="RemoveFromCart" CommandArgument='<%# Eval("ProductID") %>' Text="Remove from Cart" />
                        <hr />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
