<%@ Page Title="Seleccionar Premio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SeleccionPremio.aspx.cs" Inherits="WebPromo6b.SeleccionPremio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex flex-column gap-3 align-items-center h-100 justify-content-center mt-5">
    <h1 class="text-center mt-1 fs-1">Elegí tu premio</h1>


        <div class="container d-flex justify-content-center mt-4">

            <div class="row justify-content-center">
                <!-- Fila centrada -->
                <!-- Imagen 1 -->
                <div class="col-md-3 text-center">
                    <!-- Columnas más estrechas para centrar mejor -->
                    <img src="ruta-de-tu-imagen1.jpg" alt="Descripción 1" class="img-fluid rounded shadow" />
                </div>

                <!-- Imagen 2 -->
                <div class="col-md-3 text-center">
                    <img src="ruta-de-tu-imagen2.jpg" alt="Descripción 2" class="img-fluid rounded shadow" />
                </div>

                <!-- Imagen 3 -->
                <div class="col-md-3 text-center">
                    <img src="ruta-de-tu-imagen3.jpg" alt="Descripción 3" class="img-fluid rounded shadow" />
                </div>
            </div>
        </div>



    </div>

</asp:Content>
 