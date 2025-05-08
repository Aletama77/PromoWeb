using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace negocio
{
    public class VoucherNegocio
    {
        public List<Vouchers> listar(string codVoucher)
        {
            List<Vouchers> lista = new List<Vouchers>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT CodigoVoucher, IdCliente FROM Vouchers WHERE CodigoVoucher = @codvoucher ");
                datos.setearParametro("@codvoucher", codVoucher); // asigno por ref el codigo ingresado a la variable de la consulta
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Vouchers aux = new Vouchers();
                    aux.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];
                    aux.IdCliente = datos.Lector["IdCliente"] == DBNull.Value ? 0 : (int)datos.Lector["IdCliente"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el Articulo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion(); // esto no estoy seguro si cierra aca
            }
        }
    }
}
