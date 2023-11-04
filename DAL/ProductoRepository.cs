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
    public class ProductoRepository
    {
        public List<Producto> MostrarProductos()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Producto> list = new List<Producto>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ConsultarProductos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(mapear(reader));
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

        private Producto mapear(OracleDataReader reader)
        {
            Producto producto = new Producto();
            producto.cod_producto = Convert.ToDecimal(reader["cod_producto"]);
            producto.nomb_producto = Convert.ToString(reader["nomb_producto"]);
            producto.proveedor = new Proveedor
            {
                nit_proveedor = Convert.ToDecimal(reader["nit_proveedor"]),
                nomb_proveedor = Convert.ToString(reader["nomb_proveedor"])
            };
            producto.categoria = new Categoria
            {
                id_categoria = Convert.ToDecimal(reader["id_categoria"]),
                nomb_categoria = Convert.ToString(reader["nomb_categoria"])
            };
            producto.laboratorio = new Laboratorio
            {
                id_laboratorio = Convert.ToDecimal(reader["id_laboratorio"]),
                nomb_laboratorio = Convert.ToString(reader["nomb_laboratorio"])
            };
            producto.descripcion = Convert.ToString(reader["descripcion"]);
            return producto;
        }




    }
}
