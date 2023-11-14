using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Venta
    {
        public decimal id_venta { get; set; }
        public DateTime fecha_venta { get; set; }
        public decimal total_venta { get; set; }

        public Venta() 
        { 
        }

        public Venta(decimal id_venta, DateTime fecha_venta, decimal total_venta)
        {
            this.id_venta = id_venta;
            this.fecha_venta = fecha_venta;
            this.total_venta = total_venta;
        }
    }
}
