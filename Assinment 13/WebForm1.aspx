<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assinment_13.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="New Item" Value="New Item">
                        <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="New Item" Value="New Item"></asp:MenuItem>
                </Items>
                <DynamicHoverStyle BackColor="LightBlue" ForeColor="DarkBlue" />
                <DynamicMenuItemStyle HorizontalPadding="10px" VerticalPadding="5px" />
                <DynamicMenuStyle BackColor="White" BorderWidth="1px" BorderColor="Gray" />
                <StaticMenuStyle BackColor="White" BorderWidth="1px" BorderColor="Gray" />
                <StaticHoverStyle BackColor="LightBlue" ForeColor="DarkBlue" />
                <StaticMenuItemStyle HorizontalPadding="10px" VerticalPadding="5px" />
            </asp:Menu>

            

            <asp:TreeView ID="TreeView1" runat="server">
                <Nodes>
                    <asp:TreeNode Text="Rahul" Value="Rahul">
                        <asp:TreeNode Text="Anurag" Value="Anurag"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <LeafNodeStyle Font-Italic="True" ForeColor="DarkGreen" />
                <ParentNodeStyle Font-Bold="True" ForeColor="DarkBlue" />
            </asp:TreeView>


        </div>
    </form>
</body>
</html>
