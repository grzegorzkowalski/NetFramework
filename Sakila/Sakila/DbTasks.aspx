<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbTasks.aspx.cs" Inherits="Sakila.DbTasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownListCategories" runat="server" DataTextField="name" DataValueField="category_id" AutoPostBack="True" OnSelectedIndexChanged="DropDownListCategories_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Literal ID="categoryName" runat="server"></asp:Literal>
        </p>
    </form>
</body>
</html>
