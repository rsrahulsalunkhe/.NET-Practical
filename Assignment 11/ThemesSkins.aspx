<%@ Page Language="C#" Theme="Theme1" AutoEventWireup="true" CodeBehind="ThemesSkins.aspx.cs" Inherits="Assignment_11.ThemesSkins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Themes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registraction Form</h1>
            <asp:Label ID="Label1" runat="server" Text="First Name : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>    
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
