using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProveedorService
    {
        private ProveedorRepository repository = new ProveedorRepository();

        public DataTable MostrarProveedores()
        {
            DataTable tablaProveedores = new DataTable();
            tablaProveedores = repository.MostrarProveedores();
            return tablaProveedores;
        }

    }
}
