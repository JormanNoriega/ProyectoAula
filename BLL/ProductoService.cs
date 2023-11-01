using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoService : ICrud
    {
        private ProductoRepository repository = new ProductoRepository();

        public void InsertarDatos()
        {
            throw new NotImplementedException();
        }

        public DataTable MostrarDatos()
        {
            DataTable tablaProductos = new DataTable();
            tablaProductos = repository.MostrarProductos();
            return tablaProductos;
        }


    }
}
