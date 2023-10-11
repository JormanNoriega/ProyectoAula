using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class LoteProducto
    {
        public string codLote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        private double precioCompra { get; set; }
        private double precioVenta { get; set; }
        public int cantidad { get; set; }

        public LoteProducto()
        {
        }

        public LoteProducto(string codLote, DateTime fechaVencimiento, double precioCompra, double precioVenta, int cantidad)
        {
            this.codLote = codLote;
            FechaVencimiento = fechaVencimiento;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
        }
    }
}
