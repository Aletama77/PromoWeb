<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPromo6b._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex flex-column gap-3 align-items-center h-100 justify-content-center mt-5">
        <p class="text-center mt-5 fs-2">Si tiene algún código especial... <br />siéntase libre de ingresarlo.</p>
        <asp:TextBox ID="voucherTextBox" placeholder="X-X-X-X-X-X" runat="server" CssClass="text-center p-1 fs-1" />
        <asp:Button ID="reclamarVoucherButton" Text="Probar suerte" CssClass="mt-5 btn-success fs-4 p-1" runat="server"  /> 
    </div>
</asp:Content>
