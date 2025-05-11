using System;
using System.Collections.Generic;
using System.Linq;
using dominio;

namespace negocio
{
    public class ConfirmacionNegocio
    {
        public Articulo ListarImagenesPorPremio(int premioSeleccionado)
        {
            Articulo articulo = null;
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                // obtengo el articulo del Session["PremioSeleccionado"]
                string consultaArticulo = @"SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS WHERE Id = @IdPremio";

                datos.setearConsulta(consultaArticulo);
                datos.setearParametro("@IdPremio", premioSeleccionado);
                datos.ejecutarLectura();


                if (datos.Lector.Read())
                {
                    articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                }

                if (articulo != null)
                {
                    // y por ultimo todas las imagenes
                    datos.cerrarConexion();
                    
                    string consultaImagenes = "SELECT Id, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo";
                    datos.setearConsulta(consultaImagenes);
                    datos.setearParametro("@IdArticulo", articulo.Id);
                    datos.ejecutarLectura();

                    List<string> imagenes = new List<string>();

                    while (datos.Lector.Read()) imagenes.Add((string)datos.Lector["ImagenUrl"]);

                    if (imagenes.Count > 0)
                    {
                        // agregue UrlImagen2 y UrlImagen3 para poder tener a mano todas las imagenes
                        articulo.UrlImagen = imagenes[0];
                        articulo.UrlImagen2 = imagenes[1];
                        articulo.UrlImagen3 = imagenes[2];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return articulo;
        }

    }
}