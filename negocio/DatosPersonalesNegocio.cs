using System;
using System.Collections.Generic;
using dominio;
using System.Data;
using System.Diagnostics;

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
                string consulta = "INSERT INTO CLIENTES (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)";

                baseDeDatos.setearConsulta(consulta);

                baseDeDatos.setearParametro("@Documento", cliente.Documento);
                baseDeDatos.setearParametro("@Nombre", cliente.Nombre);
                baseDeDatos.setearParametro("@Apellido", cliente.Apellido);
                baseDeDatos.setearParametro("@Email", cliente.Email);
                baseDeDatos.setearParametro("@Direccion", cliente.Direccion);
                baseDeDatos.setearParametro("@Ciudad", cliente.Ciudad);
                baseDeDatos.setearParametro("@CP", cliente.CP);
                

                int filasAfectadas = baseDeDatos.ejecutarAccion();
                Debug.WriteLine("Filas afectadas: " + filasAfectadas);

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al registrar cliente: " + ex.ToString());
                Debug.WriteLine($"Documento: {cliente.Documento}, Nombre: {cliente.Nombre}, Email: {cliente.Email}");
                return false;
            }
            finally
            {
                baseDeDatos.cerrarConexion();
            }
        }
    }
}