<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JobMeWebUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="registerContainer">
        Enter your Username: <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>
        Enter your Password: <asp:TextBox ID="PasswordBox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="submitCred" runat="server" OnClick="LogInUser" Text="Register" />
    </div>
</asp:Content>
