using Entity;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentaRepository
    {
        ProductoRepository productorepository = new ProductoRepository();
        LoteRepository loteRepository = new LoteRepository();
        public string RegistrarVenta(Venta venta, List<ProductoVendido> productos_vendidos)
        {
            OracleConnection sqlCon = new OracleConnection();

            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Inicia una transacción para garantizar la consistencia de la base de datos
                using (OracleTransaction transaction = sqlCon.BeginTransaction())
                {
                    try
                    {
                        // Insertar la venta y obtener el ID de la venta
                        OracleCommand comando = new OracleCommand("INSERT INTO VENTAS(fecha_venta, total_venta) VALUES (:fecha_venta, :total_venta) RETURNING id_venta INTO :venta_id", sqlCon);
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add(":fecha_venta", OracleDbType.Date).Value = venta.fecha_venta;
                        comando.Parameters.Add(":total_venta", OracleDbType.Decimal).Value = venta.total_venta;

                        OracleParameter paramVentaId = new OracleParameter(":venta_id", OracleDbType.Decimal, ParameterDirection.ReturnValue);
                        comando.Parameters.Add(paramVentaId);
                        comando.ExecuteNonQuery();

                        int idVenta = ((OracleDecimal)paramVentaId.Value).ToInt32();

                        // Realizar la validación del stock antes de continuar
                        if (!ValidarStockSuficiente(productos_vendidos,sqlCon))
                        {
                            // No hay suficiente stock para la venta, realiza un rollback y retorna un mensaje de error
                            transaction.Rollback();
                            return "No hay suficiente stock para completar la venta.";
                        }

                        // Actualizar el stock en la tabla de lotes
                        foreach (ProductoVendido producto in productos_vendidos)
                        {
                            ActualizarStock(producto.cod_producto, producto.cantidad, producto.cod_lote ,sqlCon);
                        }

                        // Insertar los detalles de la venta
                        foreach (ProductoVendido producto in productos_vendidos)
                        {
                            OracleCommand comandoDetalle = new OracleCommand("INSERT INTO DETALLES_VENTAS(id_venta, cod_producto, cantidad, total_venta, cod_lote) VALUES (:id_venta, :cod_producto, :cantidad, :total_venta, :cod_lote)", sqlCon);
                            comandoDetalle.CommandType = CommandType.Text;
                            comandoDetalle.Parameters.Add(":id_venta", OracleDbType.Decimal).Value = idVenta;
                            comandoDetalle.Parameters.Add(":cod_producto", OracleDbType.Decimal).Value = producto.cod_producto;
                            comandoDetalle.Parameters.Add(":cantidad", OracleDbType.Decimal).Value = producto.cantidad;
                            comandoDetalle.Parameters.Add(":total_venta", OracleDbType.Decimal).Value = producto.valor;
                            comandoDetalle.Parameters.Add(":cod_lote", OracleDbType.Varchar2).Value = producto.cod_lote;
                            comandoDetalle.ExecuteNonQuery();
                        }
                        // Confirmar la transacción
                        transaction.Commit();
                        return "Se registró la venta con ID " + idVenta;
                    }
                    catch (Exception ex)
                    {
                        // Si hay un error, realiza un rollback y lanza la excepción
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        private void ActualizarStock(decimal cod_producto, decimal cantidad, string cod_lote, OracleConnection sqlCon)
        {
            string updateQuery = "UPDATE LOTES SET CANTIDAD = CANTIDAD - :cantidad WHERE COD_PRODUCTO = :cod_producto AND COD_LOTE = :cod_lote";
            using (OracleCommand cmd = new OracleCommand(updateQuery, sqlCon))
            {
                cmd.Parameters.Add(":cantidad", OracleDbType.Decimal).Value = cantidad;
                cmd.Parameters.Add(":cod_producto", OracleDbType.Decimal).Value = cod_producto;
                cmd.Parameters.Add(":cod_lote", OracleDbType.Varchar2).Value = cod_lote;
                cmd.ExecuteNonQuery();
            }
        }

        private bool ValidarStockSuficiente(List<ProductoVendido> productos_vendidos, OracleConnection sqlCon)
        {
            foreach (ProductoVendido producto in productos_vendidos)
            {
                string query = "SELECT cantidad FROM LOTES WHERE COD_PRODUCTO = :cod_producto AND COD_LOTE = :cod_lote";
                using (OracleCommand comando = new OracleCommand(query, sqlCon))
                {
                    comando.Parameters.Add(":cod_producto", OracleDbType.Decimal).Value = producto.cod_producto;
                    comando.Parameters.Add(":cod_lote", OracleDbType.Varchar2).Value = producto.cod_lote;

                    object result = comando.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal stockActualEnBaseDeDatos = Convert.ToDecimal(result);
                        if (stockActualEnBaseDeDatos < producto.cantidad)
                        {
                            return false; // No hay suficiente stock para la venta
                        }
                    }
                }
            }
            return true; // Hay suficiente stock para todos los productos en la venta
        }

        public List<Venta> MostrarVentas()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Venta> list = new List<Venta>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("Prc_ConsultarVentas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(mapearVentas(reader));
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        public List<DetalleVenta> MostrarDetallesVentas(decimal id_venta)
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<DetalleVenta> list = new List<DetalleVenta>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("Prc_ConsultarDetallesVenta", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("p_id_venta", id_venta));
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(mapearDetallesVentas(reader));
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }

        private Venta mapearVentas(OracleDataReader reader)
        {
            Venta venta = new Venta();
            venta.id_venta = Convert.ToDecimal(reader["Id_Venta"]);
            venta.fecha_venta = Convert.ToDateTime(reader["Fecha_venta"]);
            venta.total_venta = Convert.ToDecimal(reader["total_venta"]);
            return venta;
        }

        private DetalleVenta mapearDetallesVentas(OracleDataReader reader)
        {
            DetalleVenta detalleVenta = new DetalleVenta();
            detalleVenta.id_detalle_venta = Convert.ToDecimal(reader["Id_Detalle_Venta"]);
            decimal id_venta = Convert.ToDecimal(reader["Id_venta"]);
            detalleVenta.venta = ObtenerVenta(id_venta);
            decimal cod_producto = Convert.ToDecimal(reader["Cod_producto"]);
            detalleVenta.producto = ObtenerProducto(cod_producto);
            string cod_lote =Convert.ToString(reader["Cod_lote"]);
            detalleVenta.lote = ObtenerLote(cod_producto, cod_lote);
            detalleVenta.cantidad = Convert.ToDecimal(reader["Cantidad"]);
            detalleVenta.total_venta = Convert.ToDecimal(reader["Total_Venta"]);
            return detalleVenta;
        }

        private Venta ObtenerVenta(decimal id_venta)
        {
            return MostrarVentas().Find(p => p.id_venta == id_venta);
        }
        public Producto ObtenerProducto(decimal cod_producto)
        {
            return productorepository.MostrarProductos().Find(p => p.cod_producto == cod_producto);
        }
        public Lote ObtenerLote(decimal cod_producto,string cod_lote)
        {
            return loteRepository.MostrarLotes(cod_producto).Find(p => p.cod_lote == cod_lote);
        }
    }
}
