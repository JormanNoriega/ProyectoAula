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
        private LoteService LoteService = new LoteService();
        public string EliminarDatos(Producto producto)
        {
            return repository.EliminarProducto(producto);
        }

        public string ActualizarDatos(Producto producto)
        {
            return repository.ActualizarProducto(producto);
        }

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
            return MostrarDatos().Any(producto => producto.cod_producto == cod_producto);
        }

        public List<Producto> MostrarProductoFiltrado(string filtro)
        {
            if(string.IsNullOrEmpty(filtro))
            {
                return MostrarDatos();
            }
            else
            {
                var filtrados = MostrarDatos().Where(p => p.cod_producto.ToString() == filtro || p.nomb_producto.StartsWith(filtro)).ToList();
                return filtrados;
            }
        }

        public Producto BuscarProducto(string codProducto)
        {
            if (string.IsNullOrEmpty(codProducto))
            {
                return null;
            }
            else
            {
                var producto = MostrarDatos().FirstOrDefault(p => p.cod_producto.ToString() == codProducto);
                return producto;
            }
        }
    }
}
