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
    public class ProductoRepository
    {
        private ProveedorRepository proveedorRepository = new ProveedorRepository();
        private CategoriaRepository categoriaRepository = new CategoriaRepository();
        private LaboratorioRepository laboratorioRepository = new LaboratorioRepository();

        public string RegistrarProducto(Producto producto)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarProducto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("p_cod_producto", OracleDbType.Decimal).Value = producto.cod_producto;
                comando.Parameters.Add("p_nomb_producto", OracleDbType.Varchar2).Value = producto.nomb_producto;
                comando.Parameters.Add("p_nit_proveedor", OracleDbType.Decimal).Value = producto.proveedor.nit_proveedor;
                comando.Parameters.Add("p_id_categoria", OracleDbType.Decimal).Value = producto.categoria.id_categoria;
                comando.Parameters.Add("p_id_laboratorio", OracleDbType.Decimal).Value = producto.laboratorio.id_laboratorio;
                comando.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = producto.descripcion;
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se agrego el Producto"+producto.nomb_producto;
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

        public List<Producto> MostrarProductos()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Producto> list = new List<Producto>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("Prc_ConsultarProductos", sqlCon);
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
            producto.cod_producto = Convert.ToDecimal(reader["Codigo_Producto"]);
            producto.nomb_producto = Convert.ToString(reader["Nombre_Producto"]);
            //proveedor
            decimal nit_proveedor = Convert.ToDecimal(reader["Nit_Proveedor"]);
            producto.proveedor = ObtenerProveedor(nit_proveedor);

            //categoria
            decimal id_categora = Convert.ToDecimal(reader["Id_Categoria"]);
            producto.categoria = Obtenercategoria(id_categora);

            //laboratorio
            decimal id_laboratorio = Convert.ToDecimal(reader["Id_laboratorio"]);
            producto.laboratorio = ObtenerLaboratorio(id_laboratorio);

            producto.descripcion = Convert.ToString(reader["Descripcion"]);
            producto.cantidadTotal = Convert.ToDecimal(reader["Cantidad_Total"]);
            return producto;
        }

        public string ActualizarProducto(Producto producto)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_actualizarproducto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("p_cod_producto", OracleDbType.Varchar2).Value = producto.cod_producto;
                comando.Parameters.Add("p_nomb_producto", OracleDbType.Varchar2).Value = producto.nomb_producto;
                comando.Parameters.Add("p_nit_proveedor", OracleDbType.Decimal).Value = producto.proveedor.nit_proveedor;
                comando.Parameters.Add("p_id_categoria", OracleDbType.Decimal).Value = producto.categoria.id_categoria;
                comando.Parameters.Add("p_id_laboratorio", OracleDbType.Decimal).Value = producto.laboratorio.id_laboratorio;
                comando.Parameters.Add("p_descripcion", OracleDbType.Varchar2).Value = producto.descripcion;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                return "Se actualizó el Producto " + producto.nomb_producto + " correctamente.";
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

        public string EliminarProducto(Producto producto)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_eliminarproducto", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_codigo_producto", OracleDbType.Decimal).Value = producto.cod_producto;
                comando.Parameters.Add("eliminacion_exitosa", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                sqlCon.Open();

                comando.ExecuteNonQuery();
                OracleDecimal eliminacionExitosa = (OracleDecimal)comando.Parameters["eliminacion_exitosa"].Value;
                if (eliminacionExitosa.ToInt32() == 1)
                {
                    return "Se eliminó el producto correctamente";
                }
                else
                {
                    return "No se puede eliminar el producto, tiene lotes asociados";
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

        private Proveedor ObtenerProveedor(decimal nitProveedor)
        {
            return proveedorRepository.MostrarProveedores().Find(p => p.nit_proveedor == nitProveedor);
        }
        private Categoria Obtenercategoria(decimal id_categora)
        {
            return categoriaRepository.MostrarCategorias().Find(p => p.id_categoria == id_categora);
        }
        private Laboratorio ObtenerLaboratorio(decimal nitProveedor)
        {
            return laboratorioRepository.MostrarLaboratorio().Find(p => p.id_laboratorio == nitProveedor);
        }


    }

}
