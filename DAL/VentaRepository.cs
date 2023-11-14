using Entity;
using Oracle.ManagedDataAccess.Client;
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

        public string RegistrarVenta(Venta venta, List<ProductoVendido> productos_vendidos)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarVenta", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("p_fecha_venta", OracleDbType.Date).Value = venta.fecha_venta;
                comando.Parameters.Add("p_total_venta", OracleDbType.Decimal).Value = venta.total_venta;
                comando.Parameters.Add(new OracleParameter("p_productos_vendidos", OracleDbType.Object) { Value = productos_vendidos });
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se Registro la venta";
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

        public List<Venta> MostrarVentas()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Venta> list = new List<Venta>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ConsultarVentas", sqlCon);
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

        public List<DetalleVenta> MostrarDetallesVentas()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<DetalleVenta> list = new List<DetalleVenta>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ConsultarDetallesVentas", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
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
            return detalleVenta;
        }
    }
}
