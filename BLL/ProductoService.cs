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
    public class ProductoService : ICrud<Producto>
    {
        private ProductoRepository repository = new ProductoRepository();

        public string InsertarDatos(Producto producto)
        {
            return repository.RegistrarProducto(producto);
        }

        public List<Producto> MostrarDatos()
        {
            return repository.MostrarProductos();
        }

        public bool Existe(decimal cod_producto)
        {
            //foreach (var producto in MostrarDatos())
            //{
            //    if (producto.cod_producto == cod_producto)
            //    {
            //        return true;
            //    }
            //}
            //return false;
            return MostrarDatos().Any(producto => producto.cod_producto == cod_producto);
        }
    }
}
