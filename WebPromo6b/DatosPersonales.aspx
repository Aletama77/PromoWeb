<%@ Page Title="Datos Personales" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosPersonales.aspx.cs" Inherits="WebPromo6b.DatosPersonales" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container py-5">
        <div class="row justify-content-center">
            <div class="col-lg-8 col-md-10 col-sm-12">
                <div class="card shadow-sm rounded">
                    <div class="card-body p-3 p-md-4">
                        <h1 class="text-center mb-4 fw-bold">Ingrese sus datos para reclamar el voucher</h1>
                        
                        <hr class="my-4">
                        
                        <div class="">
                            <div class="row mb-3">
                                <div class="col-md-6">
                                    <label for="txtNombre" class="form-label">Nombre</label>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control form-control-lg" placeholder="Ingrese su nombre" required="true"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="txtApellido" class="form-label">Apellido</label>
                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control form-control-lg" placeholder="Ingrese su apellido" required="true"></asp:TextBox>
                                </div>
                            </div>
                            
                            <div class="row mb-3">
                                <div class="col-md-6">
                                    <label for="txtDireccion" class="form-label">Dirección</label>
                                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control form-control-lg" placeholder="Calle y número" required="true"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="txtCiudad" class="form-label">Ciudad</label>
                                    <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control form-control-lg" placeholder="Ingrese su ciudad" required="true"></asp:TextBox>
                                </div>
                            </div>
                            
                            <div class="row mb-4">
                                <div class="col-md-6">
                                    <label for="txtCodigoPostal" class="form-label">Código Postal</label>
                                    <asp:TextBox ID="txtCodigoPostal" runat="server" CssClass="form-control form-control-lg" placeholder="Ej: 1425" required="true"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="txtDNI" class="form-label">DNI</label>
                                    <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control form-control-lg" placeholder="XXXXXXXX" required="true" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>

                                                        
                            <div class="row mb-3">
                                <div class="col-md-6">
                                    <label for="txtEmail" class="form-label">Email</label>
                                    <div class="input-group">
                                        <span class="input-group-text"><i class="bi bi-envelope"></i>@</span>
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control form-control-lg" placeholder="nombre@ejemplo.com" required="true" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            
                            <hr class="my-4">
                            
                            <div class="d-flex justify-content-center align-items-center">
                                <asp:Button ID="btnEnviar" runat="server" Text="Reclamar" 
                                            CssClass="btn btn-success text-white shadow-sm p-2 px-4 fs-4" 
                                            OnClick="btnEnviar_Click" 
                                            UseSubmitBehavior="false" />
                            </div>

                            <div class="text-center text-muted mt-3">
                                <b class="fs-5">Todos los campos son obligatorios.</b>
                                <p>Al reclamar se asume que se aceptan todos los términos y condiciones.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>