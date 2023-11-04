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
    public class ProveedorRepository
    {
        public string RegistrarProveedor(Proveedor proveedor)
        {
            OracleConnection sqlCon = new OracleConnection();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("prc_InsertarProveedor", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nit", OracleDbType.Decimal).Value = proveedor.nit_proveedor;
                comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = proveedor.nomb_proveedor;
                sqlCon.Open();
                comando.ExecuteReader();
                return "Se agrego el proveedor " + proveedor.nomb_proveedor;
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

        public List<Proveedor> MostrarProveedores()
        {
            OracleDataReader reader;
            OracleConnection sqlCon = new OracleConnection();
            List<Proveedor> list = new List<Proveedor>();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT nit_proveedor AS Nit, Nomb_Proveedor AS Nombre FROM Proveedores", sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                reader = comando.ExecuteReader();
                while(reader.Read())
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
        private Proveedor mapear(OracleDataReader reader)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.nit_proveedor = Convert.ToDecimal(reader["Nit"]);
            proveedor.nomb_proveedor = Convert.ToString(reader["Nombre"]);
            return proveedor;
        }
    }
}
