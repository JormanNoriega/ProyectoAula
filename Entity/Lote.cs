using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Lote
    {
        public string cod_lote { get; set; }
        public decimal cod_producto { get; set; }
        public DateTime vencimiento { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }

        public Lote()
        {
        }

        public Lote(string cod_lote, decimal cod_producto, DateTime vencimiento, decimal cantidad, decimal precio_compra, decimal precio_venta)
        {
            this.cod_lote = cod_lote;
            this.cod_producto = cod_producto;
            this.vencimiento = vencimiento;
            this.cantidad = cantidad;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
        }
    }
}
