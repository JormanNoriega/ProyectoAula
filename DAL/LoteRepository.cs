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
    public class LoteRepository
    {
        ProductoRepository productorepository = new ProductoRepository();

        public string RegistrarLote(Lote lote)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarLote", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("l_cod_lote", OracleDbType.Varchar2).Value = lote.cod_lote;
                comando.Parameters.Add("l_cod_producto", OracleDbType.Decimal).Value = lote.producto.cod_producto;
                comando.Parameters.Add("l_vencimiento", OracleDbType.Date).Value = lote.vencimiento;
                comando.Parameters.Add("l_cantidad", OracleDbType.Decimal).Value = lote.cantidad;
                comando.Parameters.Add("l_precio_compra", OracleDbType.Decimal).Value = lote.precio_compra;
                comando.Parameters.Add("l_precio_venta", OracleDbType.Decimal).Value = lote.precio_venta;
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se agrego el Lote " + lote.cod_lote;
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

        public List<Lote> MostrarLotes(decimal CodProducto)
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Lote> list = new List<Lote>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_MostrarLotes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("CodProductoBuscado", CodProducto));
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(mapear(reader));
                }
                reader.Close();
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
        private Lote mapear(OracleDataReader reader)
        {
            Lote lote = new Lote();
            lote.cod_lote = Convert.ToString(reader["cod_lote"]);
            decimal cod_producto = Convert.ToDecimal(reader["cod_producto"]);
            lote.producto = ObtenerProducto(cod_producto);
            lote.vencimiento = Convert.ToDateTime(reader["vencimiento"]);
            lote.cantidad = Convert.ToDecimal(reader["cantidad"]);
            lote.precio_compra = Convert.ToDecimal(reader["precio_compra"]);
            lote.precio_venta = Convert.ToDecimal(reader["precio_venta"]);
            return lote;
        }

        public Producto ObtenerProducto(decimal cod_producto)
        {
            return productorepository.MostrarProductos().Find(p => p.cod_producto == cod_producto);
        }


        public string ActualizarLote(Lote lote)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_actualizarlote", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("l_codigo_lote", OracleDbType.Varchar2).Value = lote.cod_lote;
                comando.Parameters.Add("l_cod_producto", OracleDbType.Decimal).Value = lote.producto.cod_producto;
                comando.Parameters.Add("l_vencimiento", OracleDbType.Date).Value = lote.vencimiento;
                comando.Parameters.Add("l_cantidad", OracleDbType.Decimal).Value = lote.cantidad;
                comando.Parameters.Add("l_precio_compra", OracleDbType.Decimal).Value = lote.precio_compra;
                comando.Parameters.Add("l_precio_venta", OracleDbType.Decimal).Value = lote.precio_venta;
                
                sqlCon.Open();
                comando.ExecuteNonQuery();
                return "Se actualizó el lote " + lote.cod_lote + " correctamente.";
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

        public string EliminarLote(Lote lote)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_eliminarlote", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("codigo_lote", OracleDbType.Varchar2).Value = lote.cod_lote;

                sqlCon.Open();
                comando.ExecuteNonQuery();

                return "Se eliminó el lote " + lote.cod_lote + " correctamente";
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
    }
}
