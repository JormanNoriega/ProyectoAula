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

        public string InsertarDatos(Proveedor proveedor)
        {
            return repository.RegistrarProveedor(proveedor);
        }

        public List<Proveedor> MostrarDatos()
        {
            return repository.MostrarProveedores();
        }


    }
}
