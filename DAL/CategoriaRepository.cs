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
    public class CategoriaRepository
    {
        public string RegistrarCategoria(Categoria categoria)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarCategoria", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = categoria.nomb_categoria;
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se agregó la categoría " + categoria.nomb_categoria;
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

        public List<Categoria> mostrarTodos()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Categoria> list = new List<Categoria> ();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM Categorias", sqlCon);
                comando.CommandType = CommandType.Text;
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

        private Categoria mapear(OracleDataReader reader)
        {
            Categoria categoria = new Categoria ();
            categoria.id_categoria = Convert.ToDecimal(reader["id_categoria"]);
            categoria.nomb_categoria = Convert.ToString(reader["nomb_categoria"]);
            return categoria;
        }

        //public DataTable MostrarCategorias()
        //{
        //    OracleDataReader Resultado;
        //    OracleConnection sqlCon = new OracleConnection();
        //    DataTable tablaCategorias = new DataTable();

        //    try
        //    {
        //        sqlCon = DAL_Conexion.getInstancia().CrearConexion();
        //        OracleCommand comando = new OracleCommand("SELECT * FROM Categorias", sqlCon);
        //        comando.CommandType = CommandType.Text;
        //        sqlCon.Open();
        //        Resultado = comando.ExecuteReader();
        //        tablaCategorias.Load(Resultado);
        //        return tablaCategorias;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
        //    }
        //}
    }
}
