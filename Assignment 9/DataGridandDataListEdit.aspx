<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridandDataListEdit.aspx.cs" Inherits="Assignment_9.DataGridandDataListEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DataGrid and DataList Edit Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>DataGrid Edit Demo</h2>

            <asp:DataGrid ID="dataGridDemo" runat="server" AutoGenerateColumns="False" 
                AllowSorting="True" OnSortCommand="dataGridDemo_SortCommand"
                OnEditCommand="dataGridDemo_EditCommand" OnCancelCommand="dataGridDemo_CancelCommand"
                OnUpdateCommand="dataGridDemo_UpdateCommand" OnItemDataBound="dataGridDemo_ItemDataBound">
                <Columns>
                    <asp:TemplateColumn HeaderText="Name" SortExpression="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="Age" SortExpression="Age">
                        <ItemTemplate>
                            <asp:Label ID="lblAge" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtAge" runat="server" Text='<%# Bind("Age") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateColumn>
                    <asp:TemplateColumn HeaderText="City" SortExpression="City">
                        <ItemTemplate>
                            <asp:Label ID="lblCity" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateColumn>
                    <asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update"></asp:EditCommandColumn>
                </Columns>
            </asp:DataGrid>

            <h2>DataList Edit Demo</h2>

            <asp:DataList ID="dataListDemo" runat="server" RepeatDirection="Vertical"
                OnEditCommand="dataListDemo_EditCommand" OnCancelCommand="dataListDemo_CancelCommand"
                OnUpdateCommand="dataListDemo_UpdateCommand" OnItemDataBound="dataListDemo_ItemDataBound">
                <ItemTemplate>
                    <div>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblAge" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblCity" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                        <br />
                        <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit" Text="Edit"></asp:LinkButton>
                    </div>
                </ItemTemplate>
                <EditItemTemplate>
                    <div>
                        <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                        <br />
                        <asp:TextBox ID="txtAge" runat="server" Text='<%# Bind("Age") %>'></asp:TextBox>
                        <br />
                        <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                        <br />
                        <asp:LinkButton ID="btnUpdate" runat="server" CommandName="Update" Text="Update"></asp:LinkButton>
                        <asp:LinkButton ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </div>
                </EditItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
