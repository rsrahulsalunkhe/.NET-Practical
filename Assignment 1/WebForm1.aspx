<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Display the Page Life Cycle events -->
            <asp:Label ID="myLabel" runat="server" Text="Page Life Cycle Events:" ForeColor="Green" Font-Bold="true"></asp:Label>
            <br /><br />
            <!-- A button to trigger the Button_Click event -->
            <asp:Button ID="Button1" runat="server" Text="Click me!" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
