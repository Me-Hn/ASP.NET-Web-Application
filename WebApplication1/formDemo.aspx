<%@ Page Title="Form Demo" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="formDemo.aspx.cs" Inherits="WebApplication1.formDemo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="demo">Registration From</h1>




    <div class="main">
    <form class="form">
        <div class="input-span">
            <label for="name" class="label">Name</label>
            <input type="text" name="name" id="name" placeholder="Enter your name" />
        </div>
        <div class="input-span">
            <label for="email" class="label">Email</label>
            <input type="email" name="email" id="email" placeholder="Enter your email" />
        </div>
        <input class="submit" type="submit" value="Register" />
    </form>
        </div> 


</asp:Content>
