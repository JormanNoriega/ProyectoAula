using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace DAL
{
    public class DAL_Conexion
    {
        private OracleConnection Conexion = new OracleConnection("Data Source=BD_VitalFarmacos:1521/xepdb1;User Id=vital;Password=123;");
        public OracleConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public OracleConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
