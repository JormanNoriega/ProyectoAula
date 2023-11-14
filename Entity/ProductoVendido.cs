using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoVendido
    {
        public decimal cod_producto { get; set; } 
        public string nomb_producto { get; set; } 
        public decimal cantidad { get; set; } 
        public string cod_lote { get; set; } 
        public decimal valor { get; set; }

        public ProductoVendido()
        {
        }

        public ProductoVendido(decimal cod_producto, string nomb_producto, decimal cantidad, string cod_lote, decimal valor)
        {
            this.cod_producto = cod_producto;
            this.nomb_producto = nomb_producto;
            this.cantidad = cantidad;
            this.cod_lote = cod_lote;
            this.valor = valor;
        }
    }
}
