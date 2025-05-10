using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace WebPromo6b
{
    public partial class SeleccionPremio : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Solo cargar en la primera vez
            {
                try
                {
                    SeleccionarPremioNegocio negocio = new SeleccionarPremioNegocio();
                    List<Articulo> listaArticulos = negocio.listar();

                    if (listaArticulos != null && listaArticulos.Count >= 3) // Verificamos que haya al menos 3 artículos
                    {
                        // Asignamos los primeros 3 artículos (o los índices que prefieras)
                        Articulo articulo1 = listaArticulos[0];
                        Articulo articulo2 = listaArticulos[3];
                        Articulo articulo3 = listaArticulos[7];

                        // Asignamos imágenes
                        imgPremio1.ImageUrl = articulo1.UrlImagen;
                        imgPremio2.ImageUrl = articulo2.UrlImagen;
                        imgPremio3.ImageUrl = articulo3.UrlImagen;

                        // Asignamos nombres
                        lblNombre1.Text = articulo1.Nombre;
                        lblNombre2.Text = articulo2.Nombre;
                        lblNombre3.Text = articulo3.Nombre;

                        // Asignamos descripciones
                        lblDescripcion1.Text = articulo1.Descripcion;
                        lblDescripcion2.Text = articulo2.Descripcion;
                        lblDescripcion3.Text = articulo3.Descripcion;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar el error adecuadamente
                    Session["Error"] = ex.Message;
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void imgPremio1_Click(object sender, ImageClickEventArgs e)
        {
            // Acción al hacer clic en el primer premio
            Session["PremioSeleccionado"] = 1; // Guardar el ID del premio
            Response.Redirect("DatosPersonales.aspx");
        }

        protected void imgPremio2_Click(object sender, ImageClickEventArgs e)
        {
            // Acción al hacer clic en el segundo premio
            Session["PremioSeleccionado"] = 2;
            Response.Redirect("DatosPersonales.aspx");
        }

        protected void imgPremio3_Click(object sender, ImageClickEventArgs e)
        {
            // Acción al hacer clic en el tercer premio
            Session["PremioSeleccionado"] = 3;
            Response.Redirect("DatosPersonales.aspx");
        }
    }
}