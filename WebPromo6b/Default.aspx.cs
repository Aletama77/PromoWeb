using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace WebPromo6b
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reclamarVoucherButton_Click(object sender, EventArgs e)
        {
            if(voucherTextBox.Text != "")
            {
                string CodigoVoucher = voucherTextBox.Text.Trim();
                VoucherNegocio negocioVoucher = new VoucherNegocio();


                try
                {
                    List<Vouchers> listaVouchers = negocioVoucher.listar(CodigoVoucher);

                    bool voucherDisponible = false;

                    foreach(Vouchers vouchers in listaVouchers)
                    {
                        if(vouchers.IdCliente == 0)
                        {
                            voucherDisponible = true;
                        }
                    }

                    if(voucherDisponible == true)
                    {
                        
                        //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('VOUCHER APLICADO');", true);
                        Response.Redirect("SeleccionPremio.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('VOUCHER INVALIDO');", true);
                    }
                    
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('Error: {ex.Message}');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Por favor, ingresa un código.');", true);
            }


        }
    }
}
