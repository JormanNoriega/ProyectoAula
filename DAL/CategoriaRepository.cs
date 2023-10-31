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
        public DataTable MostrarCategorias()
        {
            OracleDataReader Resultado;
            OracleConnection sqlCon = new OracleConnection();
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
    }
}
