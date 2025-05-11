using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace WebPromo6b
{
    public partial class Confirmacion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string codigoVoucher = string.Empty;
                Cliente clienteGanador = null;
                int premioSeleccionado = 0;

                if (Session["VoucherSeleccionado"] != null)
                {
                    codigoVoucher = Session["VoucherSeleccionado"].ToString();
                }

                if (Session["IdClienteGanador"] != null)
                {
                    DatosPersonalesNegocio DPNegocio = new DatosPersonalesNegocio();
                    clienteGanador = DPNegocio.ObtenerClientePorId((int)Session["IdClienteGanador"]);
                    lblNombre.Text = clienteGanador.Nombre;
                    lblApellido.Text = clienteGanador.Apellido;
                    lblEmail.Text = clienteGanador.Email;
                    lblDireccion.Text = clienteGanador.Direccion;
                    lblCiudad.Text = clienteGanador.Ciudad;
                    lblCodigoPostal.Text = clienteGanador.CP.ToString();
                    lblDNI.Text = clienteGanador.Documento;
                }

                if (Session["PremioSeleccionado"] != null)
                {
                    premioSeleccionado = Convert.ToInt32(Session["PremioSeleccionado"]);
                    if (premioSeleccionado > 0)
                    {
                        ConfirmacionNegocio confirmacionNegocio = new ConfirmacionNegocio();
                        Articulo articuloReclamado = confirmacionNegocio.ListarImagenesPorPremio(premioSeleccionado);
                        lblArticuloCodigo.Text = articuloReclamado.Codigo;
                        lblArticuloNombre.Text = articuloReclamado.Nombre;
                        lblArticuloDescripcion.Text = articuloReclamado.Descripcion;
                        lblArticuloPrecio.Text = articuloReclamado.Precio.ToString();

                        if (!string.IsNullOrEmpty(articuloReclamado.UrlImagen))
                        {
                            imgProducto1.ImageUrl = articuloReclamado.UrlImagen;
                            imgProducto1.Visible = true;
                        }
                        else
                        {
                            imgProducto1.Visible = false;
                        }

                        if (!string.IsNullOrEmpty(articuloReclamado.UrlImagen2))
                        {
                            imgProducto2.ImageUrl = articuloReclamado.UrlImagen2;
                            imgProducto2.Visible = true;
                        }
                        else
                        {
                            imgProducto2.Visible = false;
                        }

                        if (!string.IsNullOrEmpty(articuloReclamado.UrlImagen3))
                        {
                            imgProducto3.ImageUrl = articuloReclamado.UrlImagen3;
                            imgProducto3.Visible = true;
                        }
                        else
                        {
                            imgProducto3.Visible = false;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(codigoVoucher) && !string.IsNullOrEmpty(clienteGanador.Nombre))
                {
                    lblMensaje.Text = $"VOUCHER GANADOR ({codigoVoucher}). <br/>¡¡FELICITACIONES {clienteGanador.Nombre.ToUpper()}!!";
                }
                else
                {
                    lblMensaje.Text = "No se encontraron los datos del ganador.";
                    lblMensaje.CssClass = "text-warning";
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}