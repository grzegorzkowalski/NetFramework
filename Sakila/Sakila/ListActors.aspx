<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListActors.aspx.cs" Inherits="Sakila.ListActors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewActors" runat="server" AutoGenerateColumns="False" OnRowEditing="GridViewActors_RowEditing" OnRowDeleting="GridViewActors_RowDeleting" OnRowUpdating="GridViewActors_RowUpdating" OnRowCancelingEdit="GridViewActors_RowCancelingEdit">
                <Columns>
                    <asp:BoundField DataField="actor_id" HeaderText="Actor ID" ReadOnly="True" SortExpression="actor_id" />
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Label ID="lblFirstName" runat="server" Text='<%# firstName %>'></asp:Label>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <%# Eval("first_name") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="last_name" HeaderText="Surname" ReadOnly="False" SortExpression="actor_id" />
                    <asp:BoundField DataField="last_update" HeaderText="Last update" ReadOnly="True" SortExpression="actor_id" />
                    <asp:CommandField ShowEditButton="True" ShowCancelButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
