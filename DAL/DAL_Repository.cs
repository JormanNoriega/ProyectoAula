using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace DAL
{
    public class DAL_Repository
    {
        private DAL_Conexion conexion = new DAL_Conexion();
        DataTable tabla = new DataTable();
        OracleCommand comando = new OracleCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable(); // Inicializa un nuevo objeto DataTable

            using (OracleConnection connection = conexion.AbrirConexion())
            {
                using (OracleCommand command = new OracleCommand("SELECT * FROM Productos", connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        //public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "InsetarProductos";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.AddWithValue("@nombre", nombre);
        //    comando.Parameters.AddWithValue("@descrip", desc);
        //    comando.Parameters.AddWithValue("@Marca", marca);
        //    comando.Parameters.AddWithValue("@precio", precio);
        //    comando.Parameters.AddWithValue("@stock", precio);
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    conexion.CerrarConexion();
        //}
        //public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "EditarProductos";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.AddWithValue("@nombre", nombre);
        //    comando.Parameters.AddWithValue("@descrip", desc);
        //    comando.Parameters.AddWithValue("@Marca", marca);
        //    comando.Parameters.AddWithValue("@precio", precio);
        //    comando.Parameters.AddWithValue("@stock", precio);
        //    comando.Parameters.AddWithValue("@id", id);
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    conexion.CerrarConexion();
        //}
        //public void Eliminar(int id)
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "EliminarProducto";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Parameters.AddWithValue("@idpro", id);
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    conexion.CerrarConexion();
        //}
    }
}
