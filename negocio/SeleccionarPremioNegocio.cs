using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class SeleccionarPremioNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select A.Nombre, C.Descripcion, I.ImagenUrl From IMAGENES I inner Join ARTICULOS A ON I.IdArticulo = A.Id inner Join CATEGORIAS C ON A.Id = C.Id;");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
      
                    aux.Nombre = datos.Lector.GetSqlString(0).ToString();
                    aux.Descripcion = datos.Lector.GetSqlString(1).ToString();
                    aux.UrlImagen = datos.Lector.GetSqlString(2).ToString();
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