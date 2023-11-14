using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleVenta
    {
        public decimal id_detalle_venta {  get; set; }
        public Venta venta { get; set; }
        public Producto producto { get; set; }
        public decimal cantidad { get; set; }
        public Lote lote { get; set; }

        public DetalleVenta()
        {
        }

        public DetalleVenta(decimal id_detalle_venta, Venta venta, Producto producto, decimal cantidad, Lote lote)
        {
            this.id_detalle_venta = id_detalle_venta;
            this.venta = venta;
            this.producto = producto;
            this.cantidad = cantidad;
            this.lote = lote;
        }
    }
}
