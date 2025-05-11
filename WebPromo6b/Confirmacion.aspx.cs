using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPromo6b
{
    public partial class Confirmacion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
                string numeroVoucher = string.Empty;
                string nombreGanador = string.Empty;

                if (Session["VoucherSeleccionado"] != null)
                {
                    numeroVoucher = Session["VoucherSeleccionado"].ToString();
                }

                if (Session["NombreGanador"] != null)
                {
                    nombreGanador = Session["NombreGanador"].ToString();
                }

                if (!string.IsNullOrEmpty(numeroVoucher) && !string.IsNullOrEmpty(nombreGanador))
                {
                    lblMensaje.Text = $"VOUCHER GANADOR (N° {numeroVoucher}). <br/>¡¡FELICITACIONES {nombreGanador.ToUpper()}!!";
                    imgCelebracion.Visible = true;
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