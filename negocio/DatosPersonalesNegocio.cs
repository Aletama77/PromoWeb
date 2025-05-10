using System;
using System.Collections.Generic;
using dominio;
using System.Data;

namespace negocio
{
    public class DatosPersonalesNegocio
    {
        AccesoDatos baseDeDatos;
        public DatosPersonalesNegocio() {
            baseDeDatos = new AccesoDatos();
        }   
        public bool RegistrarCliente(Cliente cliente)
        {
            try
            {
                string consulta = "INSERT INTO CLIENTES (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP, Telefono) VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP, @Telefono)";

                baseDeDatos.setearConsulta(consulta);

                baseDeDatos.setearParametro("@Documento", cliente.Documento);
                baseDeDatos.setearParametro("@Nombre", cliente.Nombre);
                baseDeDatos.setearParametro("@Apellido", cliente.Apellido);
                baseDeDatos.setearParametro("@Email", cliente.Email);
                baseDeDatos.setearParametro("@Direccion", cliente.Direccion);
                baseDeDatos.setearParametro("@Ciudad", cliente.Ciudad);
                baseDeDatos.setearParametro("@CP", cliente.CodigoPostal);
                baseDeDatos.setearParametro("@Telefono", cliente.Telefono);

                int filasAfectadas = baseDeDatos.ejecutarAccion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                baseDeDatos.cerrarConexion();
            }
        }
    }
}