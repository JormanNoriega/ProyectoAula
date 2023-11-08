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
        public string EliminarDatos(Producto entidad)
        {
            throw new NotImplementedException();
        }

        public string ActualizarDatos(Producto entidad)
        {
            throw new NotImplementedException();
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
    }
}
