using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor
    {
        public decimal nit_proveedor {  get; set; }
        public string nomb_proveedor { get; set; }

        public Proveedor()
        {
        }

        public Proveedor(decimal nit_proveedor, string nomb_proveedor)
        {
            this.nit_proveedor = nit_proveedor;
            this.nomb_proveedor = nomb_proveedor;
        }
    }
}
