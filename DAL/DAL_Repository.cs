using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Repository
    {
        private DAL_Conexion conexion = new DAL_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        //METODO PARA BUSCAR PRODUCTO
        public DataTable BuscarProducto(decimal CodProducto)
        {
            DataTable Busqueda = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Productos WHERE CodProducto = @CodProductoBuscado";
            comando.Parameters.Add("@CodProductoBuscado", SqlDbType.Decimal).Value = CodProducto;
            leer = comando.ExecuteReader();
            Busqueda.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return Busqueda;
        }

        //METODOS PARA MOSTRAR TABLAS DE LA BD
        public DataTable MostrarProductos()
        {
            DataTable tablaProductos = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = @"SELECT p.CodProducto AS 'Codigo De Producto',p.NombProducto AS 'Nombre De Producto',f.NombProveedor AS 'Proveedor',c.NombCategoria AS 'Categoria',l.NombLaboratorio AS 'Laboratorio',COALESCE(SUM(lt.cantidad),0) AS 'Cantidad Total' FROM Productos AS p 
                                    INNER JOIN Proveedores AS f ON p.NitProveedor = f.NitProveedor 
                                    INNER JOIN Categorias AS c ON p.IdCategoria = c.IdCategoria
                                    INNER JOIN Laboratorios AS l ON p.IdLaboratorio = l.IdLaboratorio
                                    LEFT JOIN Lotes AS lt ON p.CodProducto = lt.CodProducto OR lt.CodProducto IS NULL
                                    GROUP BY p.CodProducto, p.NombProducto, f.NombProveedor, c.NombCategoria, l.NombLaboratorio";

            leer = comando.ExecuteReader();
            tablaProductos.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tablaProductos;
        }

        public DataTable MostrarCategorias()
        {
            DataTable tablaCategorias = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Categorias";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaCategorias.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tablaCategorias;
        }

        public DataTable MostrarLaboratorios()
        {
            DataTable tablaLaboratorios = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Laboratorios";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaLaboratorios.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tablaLaboratorios;
        }

        public DataTable MostrarProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Proveedores";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaProveedores.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tablaProveedores;
        }

        //METODOS PARA INSERTAR EN LA BD

        public void InsertarProducto(decimal CodProducto, string NombProducto, decimal NitProveedor, int IdCategoria , int IdLaboratorio, string Descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Productos (CodProducto,NombProducto,NitProveedor,IdCategoria,IdLaboratorio,Descripcion) VALUES(@CodProducto, @NombProducto, @NitProveedor, @IdCategoria, @IdLaboratorio, @Descripcion)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@CodProducto", SqlDbType.Decimal).Value = CodProducto;
            comando.Parameters.Add("@NombProducto", SqlDbType.NVarChar, 50).Value = NombProducto;
            comando.Parameters.Add("@NitProveedor", SqlDbType.Decimal).Value = NitProveedor;
            comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = IdCategoria;
            comando.Parameters.Add("@IdLaboratorio", SqlDbType.Int).Value = IdLaboratorio;
            comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 300).Value = Descripcion;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarLote(string CodLote, decimal CodProducto,DateTime Vencimiento, int Cantidad, decimal PrecioCompra, decimal PrecioVentan)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Lotes (CodLote,CodProducto,Vencimiento,Cantidad,PrecioCompra,PrecioVenta) VALUES(@CodLote, @CodProducto, @Vencimiento, @Cantidad, @PrecioCompra, @PrecioVenta)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@CodLote", SqlDbType.NVarChar,20).Value = CodLote;
            comando.Parameters.Add("@CodProducto", SqlDbType.Decimal).Value = CodProducto;
            comando.Parameters.Add("@Vencimiento", SqlDbType.Date).Value = Vencimiento;
            comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;
            comando.Parameters.Add("@PrecioCompra", SqlDbType.Decimal).Value = PrecioCompra;
            comando.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = PrecioVentan;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }





        public void Editar(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", precio);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpro", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
