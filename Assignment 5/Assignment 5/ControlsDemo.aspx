<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlsDemo.aspx.cs" Inherits="Assignment_5.ControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Controls Demo</h2>
            <!-- DropDownList -->
            <asp:Label ID="lblCountries" runat="server" Text="Select Country: "></asp:Label>
            <asp:DropDownList ID="ddlCountries" runat="server">
                <asp:ListItem Text="Select One" Value="" />
                <asp:ListItem Text="United States" Value="US" />
                <asp:ListItem Text="Canada" Value="CA" />
                <asp:ListItem Text="United Kingdom" Value="UK" />
                <asp:ListItem Text="Australia" Value="AU" />
            </asp:DropDownList><br />

            <!-- CheckBoxList -->
            <asp:Label ID="lblInterests" runat="server" Text="Select Interests: "></asp:Label>
            <asp:CheckBoxList ID="cblInterests" runat="server">
                <asp:ListItem Text="Sports" Value="Sports" />
                <asp:ListItem Text="Music" Value="Music" />
                <asp:ListItem Text="Reading" Value="Reading" />
                <asp:ListItem Text="Travel" Value="Travel" />
            </asp:CheckBoxList><br />

            <!-- RadioButtonList -->
            <asp:Label ID="lblGender" runat="server" Text="Select Gender: "></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Text="Male" Value="Male" />
                <asp:ListItem Text="Female" Value="Female" />
                <asp:ListItem Text="Other" Value="Other" />
            </asp:RadioButtonList><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
