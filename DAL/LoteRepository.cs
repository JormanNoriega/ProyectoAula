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
        public List<Lote> MostrarLotes(decimal CodProducto)
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Lote> list = new List<Lote>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("MostrarLotes", sqlCon);
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
            return lote;
        }

    }
}
