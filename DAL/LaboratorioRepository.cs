using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LaboratorioRepository
    {
        public DataTable MostrarLaboratorios()
        {
            OracleDataReader Resultado;
            OracleConnection sqlCon = new OracleConnection();
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


    }
}
