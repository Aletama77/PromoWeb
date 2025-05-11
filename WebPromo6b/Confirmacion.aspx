<%@ Page Title="Confirmacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirmacion.aspx.cs" Inherits="WebPromo6b.Confirmacion" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container py-5">
        <div class="row justify-content-center">
            <div class="col-lg-10 col-md-12">
                <div class="card shadow-sm rounded">
                    <div class="card-body p-3 p-md-4">
                        <h1 class="text-center mb-4 fw-bold">
                            <asp:Label ID="lblMensaje" runat="server" CssClass="text-success"></asp:Label>
                        </h1>
                        
                        <hr class="my-4">
                        
                        <div class="text-center mb-4">                            
                            <h3 class="text-center">Su premio fue confirmado !!</h3>
                            <p class="lead">A continuación puede ver el producto seleccionado</p>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card mb-4">
                                    <div class="card-header" style="background-color: black; color: white;">
                                        <h5 class="mb-0">Sus Productos</h5>
                                    </div>
                                    <div class="card-body">
                                                <div class="card mb-3">
                                                    <div class="row g-0">
                                                        <div class="col-md-4 d-flex justify-content-center align-items-center">
                                                            <div class="d-flex flex-row align-items-center justify-content-center gap-3">
                                                                <asp:Image ID="imgProducto1" runat="server"
                                                                    Visible="true" CssClass="img-fluid mb-4" Width="100" />
                                                                <asp:Image ID="imgProducto2" runat="server"
                                                                    Visible="true" CssClass="img-fluid mb-4" Width="100" />
                                                                <asp:Image ID="imgProducto3" runat="server"
                                                                    Visible="true" CssClass="img-fluid mb-4" Width="100" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-8">
                                                            <div class="card-body">
                                                                <p class="card-text">Código: <asp:Label ID="lblArticuloCodigo" runat="server"></asp:Label></p>
                                                                <p class="card-text">Nombre: <asp:Label ID="lblArticuloNombre" runat="server"></asp:Label></p>
                                                                <p class="card-text">Descripcion: <asp:Label ID="lblArticuloDescripcion" runat="server"></asp:Label></p>
                                                                <p class="card-text"><strong>Precio: $<asp:Label ID="lblArticuloPrecio" runat="server" TextMode="Decimal"></asp:Label></strong></p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        
                        <div class="card mb-4">
                            <div class="card-header" style="background-color: black; color: white;">
                                <h5 class="mb-0">Datos de Envío</h5>
                            </div>
                        </div>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label class="form-label fw-bold fs-5">Nombre:</label>
                                        <asp:Label ID="lblNombre" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label class="form-label fw-bold fs-5">Apellido:</label>
                                        <asp:Label ID="lblApellido" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3 fs-5">
                                        <label class="form-label fw-bold">Dirección:</label>
                                        <asp:Label ID="lblDireccion" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label class="form-label fw-bold fs-5">Ciudad:</label>
                                        <asp:Label ID="lblCiudad" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label class="form-label fw-bold fs-5">Código Postal:</label>
                                        <asp:Label ID="lblCodigoPostal" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                    <div class="col-md-6 mb-3">
                                        <label class="form-label fw-bold fs-5">DNI:</label>
                                        <asp:Label ID="lblDNI" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6 mb-3">
                                        <label class="form-label fw-bold fs-5">Email:</label>
                                        <asp:Label ID="lblEmail" runat="server" CssClass="form-control-plaintext fs-5"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        
                        <div class="text-center mt-4">
                            <p class="mb-3">
                                <i class="bi bi-check-circle-fill me-2"></i>Se ha enviado un correo de confirmación a su dirección de email
                            </p>
                        <asp:Button ID="btnVolver" runat="server" Text="Finalizar"  
                                    CssClass="btn text-white shadow-sm p-2 px-4 fs-4"  
                                    style="background-color: black; color: white; border: 1px solid white;"  
                                    OnClick="btnVolver_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>