<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editpage.aspx.cs" Inherits="WebApplication1.Editpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>This is a Edit Page</h1>
   <form id="form1" runat="server">
    <asp:Label ID="lblID" runat="server" Font-Bold="True"></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server" Placeholder="Enter Name"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtEmail" runat="server" Placeholder="Enter Email"></asp:TextBox>
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    <br />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
</form>

</body>
</html>
