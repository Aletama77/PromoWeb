﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
using System.Diagnostics;

namespace WebPromo6b
{
    public partial class DatosPersonales : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
   
            try
            {
                if (
                    string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtDireccion.Text) ||
                    string.IsNullOrEmpty(txtCiudad.Text) ||
                    string.IsNullOrEmpty(txtCodigoPostal.Text) ||
                    string.IsNullOrEmpty(txtDNI.Text)
                )
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Por favor complete todos los campos requeridos.');", true);

                    return;
                }

                int codigoPostal;
                if (!int.TryParse(txtCodigoPostal.Text, out codigoPostal))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", "alert('Código Postal inválido. Debe ser un número.');", true);
                    return;
                }

                Cliente nuevoCliente = new Cliente
                {
                    Documento = txtDNI.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Direccion = txtDireccion.Text,
                    Ciudad = txtCiudad.Text,
                    CP = codigoPostal                  
                };

                DatosPersonalesNegocio negocio = new DatosPersonalesNegocio();
                bool registrado = negocio.RegistrarCliente(nuevoCliente); // cuando registro el cliente, mi nuevoCliente obtiene la propiedad de ID (ver DatosPersonalesNegocio.cs)

                if (registrado)
                {
                    Session["IdClienteGanador"] = nuevoCliente.Id;
                    bool voucherTomado = negocio.MarcarVoucherComoTomadoPorCliente((string)Session["VoucherSeleccionado"], nuevoCliente.Id, DateTime.Now.ToString(), (int)Session["PremioSeleccionado"]);

                    if (voucherTomado)
                    {
                        Response.Redirect("Confirmacion.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('No se pudo tomar el voucher. Por favor, intente nuevamente.');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('No se pudo registrar el cliente. Por favor, intente nuevamente.');", true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }
    }
}