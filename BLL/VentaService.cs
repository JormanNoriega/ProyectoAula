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
            try
            {
                // Asegúrate de que las fechas estén considerando solo la parte de la fecha, ignorando la hora
                fechaInicio = fechaInicio.Date;
                fechaFin = fechaFin.Date;

                var ventasFiltradas = MostrarVentas()
                    .Where(v => v.fecha_venta.Date >= fechaInicio && v.fecha_venta.Date <= fechaFin)
                    .ToList();

                // Agrupar las ventas por día y sumar los totales
                var ventasPorDia = ventasFiltradas
                    .GroupBy(v => v.fecha_venta.Date)
                    .Select(group => new VentaPorDia
                    {
                        Fecha = group.Key,
                        TotalVentasPorDia = group.Sum(v => v.total_venta)
                    })
                    .OrderBy(vp => vp.Fecha)  // Ordenar por fecha si es necesario
                    .ToList();

                return ventasPorDia;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir, como problemas de acceso a la base de datos
                Console.WriteLine($"Error al obtener ventas por día: {ex.Message}");
                return new List<VentaPorDia>(); // Puedes devolver una lista vacía o manejar el error de otra manera
            }
        }

        public int ventasTotales()
        {
            // Obtener la lista de ventas para la fecha especificada
            var ventasEnFecha = MostrarVentas()
                .Where(v => v.fecha_venta.Date == DateTime.Now.Date)
                .ToList();
            // Obtener el número de ventas para esa fecha
            int numeroVentas = ventasEnFecha.Count;
            return numeroVentas;
        }

        public decimal totalVendido()
        {
            // Obtener la lista de ventas para la fecha actual
            var ventasEnFecha = MostrarVentas()
                .Where(v => v.fecha_venta.Date == DateTime.Now.Date)
                .ToList();
            // Obtener la suma total de ventas para la fecha actual
            decimal totalVentas = ventasEnFecha.Sum(v => v.total_venta);
            return totalVentas;
        }

        public List<Venta> MostrarVentasFiltradas(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                return MostrarVentas();
            }
            else
            {
                var ventasFiltradas = MostrarVentas().Where(v =>v.id_venta.ToString() == filtro).ToList();
                return ventasFiltradas;
            }
        }

    }
}
