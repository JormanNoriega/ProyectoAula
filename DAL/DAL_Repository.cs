using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DAL_Repository
    {
        //private DAL_Conexion conexion = new DAL_Conexion();
        //SqlDataReader leer;
        //SqlCommand comando = new SqlCommand();
        OracleDataReader Resultado;
        OracleConnection sqlCon = new OracleConnection();


        //METODO PARA BUSCAR PRODUCTO
        public DataTable BuscarProducto(decimal CodProducto)
        {
            
            DataTable tablaBusqueda = new DataTable();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BuscarProducto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("CodProductoBuscado", CodProducto));
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaBusqueda.Load(Resultado);
                return tablaBusqueda;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }
        }

        //METODOS PARA MOSTRAR TABLAS DE LA BD
        public DataTable MostrarProductos()
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ConsultarProductos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaProductos.Load(Resultado);
                return tablaProductos;
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

        public DataTable MostrarCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM Categorias", sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaCategorias.Load(Resultado);
                return tablaCategorias;
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

        public DataTable MostrarLaboratorios()
        {
            DataTable tablaLaboratorios = new DataTable();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM Laboratorios", sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaLaboratorios.Load(Resultado);
                return tablaLaboratorios;
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

        public DataTable MostrarProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM Proveedores", sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaProveedores.Load(Resultado);
                return tablaProveedores;
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

        //METODO PARA MOSTRAR LOTES DE UN PRODUCTO
        public DataTable MostrarLotes(decimal CodProducto)
        {
            DataTable tablaLotes = new DataTable();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("MostrarLotes", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new OracleParameter("CodProductoBuscado", CodProducto));
                comando.Parameters.Add(new OracleParameter("Resultados", OracleDbType.RefCursor, ParameterDirection.Output));
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaLotes.Load(Resultado);
                return tablaLotes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(sqlCon.State==ConnectionState.Open) sqlCon.Close();
            }
            
        }
        ////METODO PARA MOSTRAR PRODUCTOS FILTRADO
        //public DataTable MostrarProductoFiltrado(decimal CodProducto)
        //{
        //    DataTable tablaProductoFiltrado = new DataTable();
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "SELECT * FROM Productos WHERE CONVERT(NVARCHAR(50), CodProducto) LIKE CAST(@CodProducto AS NVARCHAR(50)) + '%'";
        //    comando.CommandType = CommandType.Text;
        //    comando.Parameters.Add("@CodProducto", SqlDbType.Decimal).Value = CodProducto;
        //    leer = comando.ExecuteReader();
        //    tablaProductoFiltrado.Load(leer);
        //    leer.Close();
        //    conexion.CerrarConexion();
        //    return tablaProductoFiltrado;
        //}

        ////METODOS PARA INSERTAR EN LA BD

        //public void InsertarProducto(decimal CodProducto, string NombProducto, decimal NitProveedor, int IdCategoria , int IdLaboratorio, string Descripcion)
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "INSERT INTO Productos (CodProducto,NombProducto,NitProveedor,IdCategoria,IdLaboratorio,Descripcion) VALUES(@CodProducto, @NombProducto, @NitProveedor, @IdCategoria, @IdLaboratorio, @Descripcion)";
        //    comando.CommandType = CommandType.Text;
        //    comando.Parameters.Add("@CodProducto", SqlDbType.Decimal).Value = CodProducto;
        //    comando.Parameters.Add("@NombProducto", SqlDbType.NVarChar, 50).Value = NombProducto;
        //    comando.Parameters.Add("@NitProveedor", SqlDbType.Decimal).Value = NitProveedor;
        //    comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = IdCategoria;
        //    comando.Parameters.Add("@IdLaboratorio", SqlDbType.Int).Value = IdLaboratorio;
        //    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 300).Value = Descripcion;
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    conexion.CerrarConexion();
        //}

        //public void InsertarLote(string CodLote, decimal CodProducto,DateTime Vencimiento, int Cantidad, decimal PrecioCompra, decimal PrecioVentan)
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "INSERT INTO Lotes (CodLote,CodProducto,Vencimiento,Cantidad,PrecioCompra,PrecioVenta) VALUES(@CodLote, @CodProducto, @Vencimiento, @Cantidad, @PrecioCompra, @PrecioVenta)";
        //    comando.CommandType = CommandType.Text;
        //    comando.Parameters.Add("@CodLote", SqlDbType.NVarChar,20).Value = CodLote;
        //    comando.Parameters.Add("@CodProducto", SqlDbType.Decimal).Value = CodProducto;
        //    comando.Parameters.Add("@Vencimiento", SqlDbType.Date).Value = Vencimiento;
        //    comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
        //    comando.Parameters.Add("@PrecioCompra", SqlDbType.Decimal).Value = PrecioCompra;
        //    comando.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = PrecioVentan;
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
