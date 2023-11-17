<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assinment_12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Tree view Demo<br />
            <asp:TreeView ID="TreeView1" runat="server">
                <Nodes>
                    <asp:TreeNode Text="Products" Value="Products">
                        <asp:TreeNode Text="Product1" Value="Product1"></asp:TreeNode>
                        <asp:TreeNode Text="Product2" Value="Product2"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Services" Value="Services"></asp:TreeNode>
                </Nodes>
            </asp:TreeView>
            <br />
            Menu Demo<br />
            <br />
            <asp:Menu ID="Menu1" runat="server">
                <Items>
                    <asp:MenuItem Text="Home" Value="Home">
                        <asp:MenuItem Text="File" Value="File"></asp:MenuItem>
                        <asp:MenuItem Text="Edit" Value="Edit"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Tools" Value="Tools"></asp:MenuItem>
                    <asp:MenuItem Text="Contact" Value="Contact"></asp:MenuItem>
                </Items>
            </asp:Menu>

        </div>
    </form>
</body>
</html>
