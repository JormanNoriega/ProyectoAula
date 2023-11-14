using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentaService
    {
        private VentaRepository repository = new VentaRepository();
        public string InsertarVenta(Venta venta,List<ProductoVendido> productosVendidos)
        {
            return repository.RegistrarVenta(venta, productosVendidos);
        }
    }
}
