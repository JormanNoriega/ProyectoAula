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

            //producto.proveedor = new Proveedor
            //{
            //    nit_proveedor = Convert.ToDecimal(reader["Nit_Proveedor"]),
            //    nomb_proveedor = Convert.ToString(reader["Nombre_Proveedor"])
            //};
            //producto.categoria = new Categoria
            //{
            //    id_categoria = Convert.ToDecimal(reader["Id_Categoria"]),
            //    nomb_categoria = Convert.ToString(reader["Nombre_Categoria"])
            //};
            //producto.laboratorio = new Laboratorio
            //{
            //    id_laboratorio = Convert.ToDecimal(reader["Id_laboratorio"]),
            //    nomb_laboratorio = Convert.ToString(reader["Nombre_Laboratorio"])
            //};
            //producto.descripcion = Convert.ToString(reader["Descripcion"]);
            //producto.cantidadTotal = Convert.ToDecimal(reader["Cantidad_Total"]);
            //return producto;
            ////Mapero de Proveedores (Usa Objetos ya existentes)
            //decimal nit_proveedor = Convert.ToDecimal(reader["Nit_Proveedor"]);
            //producto.proveedor = ObtenerProveedor(nit_proveedor);
            //if (proveedoresCache.ContainsKey(nit_proveedor))
            //{
            //    producto.proveedor = ObtenerProveedor(nit_proveedor);
            //}
            //else
            //{
            //    //producto.proveedor = new Proveedor
            //    //{
            //    //    nit_proveedor = nit_proveedor,
            //    //    nomb_proveedor = Convert.ToString(reader["Nombre_Proveedor"])
            //    //};
            //}
            ////Mapeo De Categorias
            //decimal id_categora = Convert.ToDecimal(reader["Id_Categoria"]);
            //if (categoriasCache.ContainsKey(id_categora))
            //{
            //    producto.categoria = categoriasCache[id_categora];
            //}
            //else
            //{
            //    //producto.categoria = new Categoria
            //    //{
            //    //    id_categoria = id_categora,
            //    //    nomb_categoria = Convert.ToString(reader["Nombre_Categoria"])
            //    //};
            //}
            ////Mapeo de Laboratorios
            //decimal id_laboratorio = Convert.ToDecimal(reader["Id_laboratorio"]);
            //if (laboratoriosCache.ContainsKey(id_laboratorio))
            //{
            //    producto.laboratorio = laboratoriosCache[id_laboratorio];
            //}
            //else
            //{
            //    //producto.laboratorio = new Laboratorio
            //    //{
            //    //    id_laboratorio = id_laboratorio,
            //    //    nomb_laboratorio = Convert.ToString(reader["Nombre_Laboratorio"])
            //    //};
            //}
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
