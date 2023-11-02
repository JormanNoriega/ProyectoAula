using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProveedorService : ICrud<Proveedor>
    {
        private ProveedorRepository repository = new ProveedorRepository();

        public void InsertarDatos(Proveedor proveedor)
        {
            repository.RegistrarProveedor(proveedor);
        }

        public DataTable MostrarDatos()
        {
            DataTable tablaProveedores = new DataTable();
            tablaProveedores = repository.MostrarProveedores();
            return tablaProveedores;
        }


    }
}
