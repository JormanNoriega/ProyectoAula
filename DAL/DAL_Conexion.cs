using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Conexion
    {
        private static DAL_Conexion conexion = null;

        public DAL_Conexion()
        {
        }
        
        public OracleConnection CrearConexion()
        {
            OracleConnection cadena = new OracleConnection();
            try
            {
                cadena.ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                          (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=C##vital;Password=vital;";    
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static DAL_Conexion getInstancia()
        {
            if (conexion == null)
            {
                conexion = new DAL_Conexion();
            }
            return conexion;
        }

    }
}
