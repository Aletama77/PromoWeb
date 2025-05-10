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

                    if (listaArticulos != null && listaArticulos.Count > 0)
                    {
   
                        Articulo articulo = listaArticulos[0];
                        Articulo articulo2 = listaArticulos[4];
                        Articulo articulo3 = listaArticulos[7];


                        //articulo.Nombre.Text = articulo.Nombre;
                        //articulo.Descripcion.Text = articulo.Descripcion;


                        imgLogo.ImageUrl = articulo.UrlImagen;
                        Image1.ImageUrl = articulo2.UrlImagen;
                        Image2.ImageUrl = articulo3.UrlImagen;

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

    }
}