<%@ Page Title="Seleccionar Premio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SeleccionPremio.aspx.cs" Inherits="WebPromo6b.SeleccionPremio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container py-5">
        <h1 class="text-center mb-5 display-4 fw-bold">Elegí tu premio</h1>

        <div class="row g-4 justify-content-center">
            <!-- Premio 1 -->
            <div class="col-xl-4 col-lg-6 col-md-6">
                <div class="card h-100 border-0 shadow-sm" style="border-radius: 15px;">
                    <div class="bg-light p-4 d-flex align-items-center justify-content-center" style="height: 200px; border-top-left-radius: 15px; border-top-right-radius: 15px;">
  
                        <asp:ImageButton ID="imgPremio1" runat="server" CssClass="img-fluid mh-100" style="max-height: 180px; width: auto;" AlternateText="Premio 1" OnClick="imgPremio1_Click" />
                    </div>
                    <div class="card-body text-center p-4">
                        <h3 class="card-title fw-semibold mb-3">
                            <asp:Label ID="lblNombre1" runat="server" Text=""></asp:Label>
                        </h3>
                        <p class="card-text text-muted">
                            <asp:Label ID="lblDescripcion1" runat="server" Text=""></asp:Label>
                        </p>
                    </div>
                </div>
            </div>

            <!-- Premio 2 -->
            <div class="col-xl-4 col-lg-6 col-md-6">
                <div class="card h-100 border-0 shadow-sm" style="border-radius: 15px;">
                    <div class="bg-light p-4 d-flex align-items-center justify-content-center" style="height: 200px; border-top-left-radius: 15px; border-top-right-radius: 15px;">
                        <asp:ImageButton ID="imgPremio2" runat="server" CssClass="img-fluid mh-100" style="max-height: 180px; width: auto;" AlternateText="Premio 2" OnClick="imgPremio2_Click" />
                    </div>
                    <div class="card-body text-center p-4">
                        <h3 class="card-title fw-semibold mb-3">
                            <asp:Label ID="lblNombre2" runat="server" Text=""></asp:Label>
                        </h3>
                        <p class="card-text text-muted">
                            <asp:Label ID="lblDescripcion2" runat="server" Text=""></asp:Label>
                        </p>
                    </div>
                </div>
            </div>

            <!-- Premio 3 -->
            <div class="col-xl-4 col-lg-6 col-md-6">
                <div class="card h-100 border-0 shadow-sm" style="border-radius: 15px;">
                    <div class="bg-light p-4 d-flex align-items-center justify-content-center" style="height: 200px; border-top-left-radius: 15px; border-top-right-radius: 15px;">
                        <asp:ImageButton ID="imgPremio3" runat="server" CssClass="img-fluid mh-100" style="max-height: 180px; width: auto;" AlternateText="Premio 3" OnClick="imgPremio3_Click" />
                    </div>
                    <div class="card-body text-center p-4">
                        <h3 class="card-title fw-semibold mb-3">
                            <asp:Label ID="lblNombre3" runat="server" Text=""></asp:Label>
                        </h3>
                        <p class="card-text text-muted">
                            <asp:Label ID="lblDescripcion3" runat="server" Text=""></asp:Label>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
 