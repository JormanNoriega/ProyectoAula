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
        public DataTable MostrarProveedores()
        {
            OracleDataReader Resultado;
            OracleConnection sqlCon = new OracleConnection();
            DataTable tablaProveedores = new DataTable();
            try
            {
                sqlCon = DAL_Conexion.getInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT nit_proveedor AS Nit, Nomb_Proveedor AS Nombre FROM Proveedores", sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                tablaProveedores.Load(Resultado);
                return tablaProveedores;
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

        public void RegistrarProveedor(Proveedor proveedor)
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
