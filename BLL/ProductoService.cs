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
    public class ProductoService : ICrud <Producto>
    {
        private ProductoRepository repository = new ProductoRepository();

        public void InsertarDatos(Producto producto)
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
