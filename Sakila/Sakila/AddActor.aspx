<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddActor.aspx.cs" Inherits="Sakila.AddActor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br>
            Last Name: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br>
            <asp:Button ID="btnAddActor" runat="server" Text="Add Actor" OnClick="btnAddActor_Click" />
        </div>
    </form>
</body>
</html>
