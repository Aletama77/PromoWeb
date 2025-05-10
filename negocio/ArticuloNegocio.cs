using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.UrlImagen from ARTICULOS a");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (String)datos.Lector["Codigo"];
                    aux.Nombre = (String)datos.Lector["Nombre"];
                    aux.Descripcion = (String)datos.Lector["Descripcion"];
                    aux.Precio = (float)datos.Lector["Precio"];
                    aux.UrlImagen = (int)datos.Lector["UrlImagen"];
                    lista.Add(aux);
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
