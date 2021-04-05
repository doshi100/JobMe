<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="JobMeWebUI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="registerContainer">
        Enter a Username: <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>
        Enter your First Name: <asp:TextBox ID="FirstNameBox" runat="server"></asp:TextBox>
        Enter a Password: <asp:TextBox ID="PasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="submitCred" runat="server" OnClick="AddUser" Text="Register" />
    </div>
</asp:Content>
