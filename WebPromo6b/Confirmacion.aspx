<%@ Page Title="Confirmacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirmacion.aspx.cs" Inherits="WebPromo6b.Confirmacion" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="jumbotron">
                    <h1 class="display-4">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="text-success font-weight-bold"></asp:Label>
                    </h1>
                    <hr class="my-4">
                    <div class="mt-4">
                        <asp:Image ID="imgCelebracion" runat="server" ImageUrl="https://www.needpix.com/photo/download/92651/stickman-stick-figure-matchstick-man-winner-free-vector-graphics-free-pictures-free-photos-free-images-royalty-free" Visible="false" CssClass="img-fluid" />
                    </div>
                    <div class="mt-4">
                        <asp:Button ID="btnVolver" runat="server" Text="Cerrar" CssClass="btn btn-primary btn-lg" OnClick="btnVolver_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>