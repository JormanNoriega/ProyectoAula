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
    public class LoteService : ICrud <Lote>
    {
        private LoteRepository repository = new LoteRepository();

        public string EliminarDatos(Lote lote)
        {
            return repository.EliminarLote(lote);
        }

        public string ActualizarDatos(Lote lote)
        {
            return repository.ActualizarLote(lote);
        }

        public string InsertarDatos(Lote lote)
        {
            return repository.RegistrarLote(lote);
        }

        public List<Lote> MostrarDatos()
        {
            throw new NotImplementedException();
        }

        //Lista de Lotes Registrados a un producto en especifico
        public List<Lote> MostrarLotesPorProducto(decimal cod_producto)
        {
            return repository.MostrarLotes(cod_producto);
        }

        //Obtener el producto correspondiente al lote
        public Producto productoSeleccionado(decimal cod_producto)
        {
            return repository.ObtenerProducto(cod_producto);
        }

        //Filtrado de lotes por nombre y codigo de prodcuto
        public List<Lote> MostrarLoteFiltrado(string filtro,decimal cod_producto)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                return MostrarLotesPorProducto(cod_producto);
            }
            else
            {
                var filtrados = MostrarLotesPorProducto(cod_producto).Where(p => p.cod_lote.StartsWith(filtro)).ToList();
                return filtrados;
            }
        }

        
    }
}
