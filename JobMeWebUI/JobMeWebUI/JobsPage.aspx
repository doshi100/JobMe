<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="JobsPage.aspx.cs" Inherits="JobMeWebUI.JobsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="OfferHeaderContainer">
        <span class="header center">Job offers</span>
        <div class="CreateJobOfferContainer">
            <span class="header publishText">Publish A new job Offer</span>
            <div class="CreateJob">
                <div>Employer's Phone Number: <asp:TextBox ID="PhoneNumberText" runat="server"></asp:TextBox></div> 
                <div>Employer's Company: <asp:TextBox ID="CompanyText" runat="server"></asp:TextBox></div>
                <div>Employee's Position: <asp:TextBox ID="Position" runat="server"></asp:TextBox></div> 
                <asp:Button ID="publishJobB" Text="Publish Job" OnClick="publishJob" runat="server" />
            </div>
        </div>
    </div>
    <div class="jobsContainer">
        <asp:GridView ID="jobOffersGrid" runat="server" CssClass="TableGrid" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Phone" HeaderText="Employer's Phone Number" />
                <asp:BoundField DataField="Company" HeaderText="Employer's Company" />
                <asp:BoundField DataField="FirstName" HeaderText="Employer's Name" />
                <asp:BoundField DataField="Position" HeaderText="Job Position" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
