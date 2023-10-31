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
        public DataTable MostrarLotes(decimal CodProducto)
        {
            OracleDataReader Resultado;
            OracleConnection sqlCon = new OracleConnection();
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
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

        }
    }
}
