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
                string consulta = "INSERT INTO CLIENTES (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP) SELECT SCOPE_IDENTITY()";

                baseDeDatos.setearConsulta(consulta);

                baseDeDatos.setearParametro("@Documento", cliente.Documento);
                baseDeDatos.setearParametro("@Nombre", cliente.Nombre);
                baseDeDatos.setearParametro("@Apellido", cliente.Apellido);
                baseDeDatos.setearParametro("@Email", cliente.Email);
                baseDeDatos.setearParametro("@Direccion", cliente.Direccion);
                baseDeDatos.setearParametro("@Ciudad", cliente.Ciudad);
                baseDeDatos.setearParametro("@CP", cliente.CP);


                object resultado = baseDeDatos.ejecutarConsultaScalar();

                if (resultado != null)
                {
                    // las consultas scalar ejecutan la misma consulta y devuelven la primer columna de la primer fila, esto para devolver el ID del cliente
                    cliente.Id = Convert.ToInt32(resultado); // remplazo el ID del cliente enviado como param para que luego se le envie a MarcarVoucherComoTomadoPorCliente (ver DatosPersonales.aspx.cs)
                    Debug.WriteLine("Cliente registrado con ID: " + cliente.Id);
                    return true;
                }
                else
                {
                    Debug.WriteLine("No se pudo obtener el ID del cliente registrado");
                    return false;
                }
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

        public bool MarcarVoucherComoTomadoPorCliente (string CodigoVoucher, int IdCliente, string FechaCanje, int IdArticulo)
        {
            try
            {
                // no hace falta primero verificar si el voucher esta tomado porque si se llega a realizar esta query significa que ya se hizo esa validacion, por ende aca solo lo actualizo
                string consulta = "UPDATE VOUCHERS SET IdCliente = @IdCliente, FechaCanje = @FechaCanje, IdArticulo = @IdArticulo WHERE CodigoVoucher = @CodigoVoucher";

                baseDeDatos.setearConsulta(consulta);

                baseDeDatos.setearParametro("@CodigoVoucher", CodigoVoucher);
                baseDeDatos.setearParametro("@IdCliente", IdCliente);
                baseDeDatos.setearParametro("@FechaCanje", FechaCanje);
                baseDeDatos.setearParametro("@IdArticulo", IdArticulo);

                int filasAfectadas = baseDeDatos.ejecutarAccion();
                Debug.WriteLine("Filas afectadas: " + filasAfectadas);

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al tomar Voucher: " + ex.ToString());
                return false;
            }
            finally
            {
                baseDeDatos.cerrarConexion();
            }
        }


        public Cliente ObtenerClientePorId(int IdCliente)
        {
            Cliente cliente = null;

            try
            {
                string consulta = "SELECT Nombre, Apellido, Email, Documento, Direccion, Ciudad, CP FROM CLIENTES WHERE Id = @IdCliente";

                baseDeDatos.setearConsulta(consulta);
                baseDeDatos.setearParametro("@IdCliente", IdCliente);
                baseDeDatos.ejecutarLectura();

                if (baseDeDatos.Lector.Read())
                {
                    cliente = new Cliente();

                    cliente.Id = IdCliente;
                    cliente.Nombre = baseDeDatos.Lector["Nombre"].ToString();
                    cliente.Apellido = baseDeDatos.Lector["Apellido"].ToString();
                    cliente.Email = baseDeDatos.Lector["Email"].ToString();
                    cliente.Documento = baseDeDatos.Lector["Documento"].ToString();
                    cliente.Direccion = baseDeDatos.Lector["Direccion"].ToString();
                    cliente.Ciudad = baseDeDatos.Lector["Ciudad"].ToString();
                    cliente.CP = Convert.ToInt32(baseDeDatos.Lector["CP"]);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error al obtener cliente: " + ex.ToString());
            }
            finally
            {
                baseDeDatos.cerrarConexion();
            }

            return cliente; 
        }
    }
}