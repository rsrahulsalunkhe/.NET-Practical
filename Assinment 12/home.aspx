<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Assinment_12.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Welcome to Home page !!!</p>
    <p>
        <asp:TreeView ID="TreeView1" runat="server">
        </asp:TreeView>
    </p>
</asp:Content>
