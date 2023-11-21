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

        public List<Venta> MostrarVentas()
        {
            return repository.MostrarVentas();
        }
        public List<DetalleVenta> MostrarDetallesVentas(decimal id_venta)
        {
            return repository.MostrarDetallesVentas(id_venta);
        }

        public List<VentaPorDia> ObtenerVentasAgrupadasPorDia(DateTime fechaInicio, DateTime fechaFin)
        {
            var ventasFiltradas = MostrarVentas()
                .Where(v => v.fecha_venta >= fechaInicio && v.fecha_venta <= fechaFin)
                .ToList();

            // Agrupar las ventas por día y sumar los totales
            var ventasPorDia = ventasFiltradas
                .GroupBy(v => v.fecha_venta.Date)
                .Select(group => new VentaPorDia
                {
                    Fecha = group.Key,
                    TotalVentasPorDia = group.Sum(v => v.total_venta)
                })
                .ToList();
            return ventasPorDia;
        }
    }
}
