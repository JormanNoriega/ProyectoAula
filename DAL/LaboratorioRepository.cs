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
    public class LaboratorioRepository
    {
        
        public string RegistrarLaboratorio(Laboratorio laboratorio)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarLaboratorio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = laboratorio.nomb_laboratorio;
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se agrego el laboratorio "+ laboratorio.nomb_laboratorio;
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

        public List<Laboratorio> MostrarLaboratorio()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Laboratorio> list = new List<Laboratorio>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT id_laboratorio AS Id, nomb_laboratorio AS Nombre FROM Laboratorios", sqlCon);
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

        private Laboratorio mapear(OracleDataReader reader)
        {
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.id_laboratorio = Convert.ToDecimal(reader["Id"]);
            laboratorio.nomb_laboratorio = Convert.ToString(reader["Nombre"]);
            return laboratorio;
        }
    }
}
