using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoService
    {
        private ProductoRepository repository = new ProductoRepository();
        public DataTable MostrarProductos()
        {
            DataTable tablaProductos = new DataTable();
            tablaProductos = repository.MostrarProductos();
            return tablaProductos;
        }


    }
}
