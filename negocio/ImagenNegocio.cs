using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<string> listar()
        {
            List<string> lista = new List<string>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select UrlImagen from IMAGENES");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    lista.Add((string)datos.Lector["UrlImagen"]);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
