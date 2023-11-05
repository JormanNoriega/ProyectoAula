using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Lote
    {
        public string cod_lote { get; set; }
        public Producto producto { get; set; }
        public DateTime vencimiento { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }

        public Lote()
        {
        }

        public Lote(string cod_lote, Producto producto, DateTime vencimiento, decimal cantidad, decimal precio_compra, decimal precio_venta)
        {
            this.cod_lote = cod_lote;
            this.producto = producto;
            this.vencimiento = vencimiento;
            this.cantidad = cantidad;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
        }
    }
}
