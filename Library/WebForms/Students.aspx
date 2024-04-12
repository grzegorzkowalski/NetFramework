<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebForms.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <style>
     .myClass {
         color: red; /* Example style */
         font-size: 20px; /* Example style */
     }
 </style>
     <div class="myClass">
         <asp:Literal ID="Literal1" runat="server" >Test</asp:Literal>
     </div>
     <div>
         <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
     </div>
     <div>
         <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
     </div>
     <div>
         <asp:TextBox ID="FacultyNumber" runat="server"></asp:TextBox>
     </div>
     <div>
         <asp:DropDownList ID="University" runat="server">
             <asp:ListItem>Choose university</asp:ListItem>
             <asp:ListItem>UW</asp:ListItem>
             <asp:ListItem>UJ</asp:ListItem>
             <asp:ListItem>KUL</asp:ListItem>
             <asp:ListItem>WWSI</asp:ListItem>
         </asp:DropDownList>
     </div>
     <div>
         <asp:DropDownList ID="Speciality" runat="server">
             <asp:ListItem>Choose course</asp:ListItem>
             <asp:ListItem>History</asp:ListItem>
             <asp:ListItem>Biology</asp:ListItem>
             <asp:ListItem>Chemistry</asp:ListItem>
             <asp:ListItem>English</asp:ListItem>
         </asp:DropDownList>
     </div>
     <div>
         <asp:ListBox ID="lstItems" runat="server" SelectionMode="Multiple"></asp:ListBox>
     </div>
     <div>
         <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
     </div>
    </form>
</body>
</html>
