<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="connection.aspx.cs" Inherits="WebApplication1.connection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Form</h1>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        
        <%--Work--%>
        </p>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    OnRowDeleting="GridView1_RowDeleting" 
    OnRowEditing="GridView1_RowEditing"
    OnRowUpdating="GridView1_RowUpdating" 
    OnRowCancelingEdit="GridView1_RowCancelingEdit"
    DataKeyNames="id">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" />
        <asp:BoundField DataField="name" HeaderText="Name" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:CommandField ShowDeleteButton="True" />
         <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>


        
    </form>
</body>
</html>
