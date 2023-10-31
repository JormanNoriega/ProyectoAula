using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public decimal cod_producto {  get; set;}
        public string nomb_producto { get; set;}
        public Proveedor proveedor { get; set;}
        public Categoria categoria { get; set;}
        public Laboratorio laboratorio { get; set;}
        public string descipcion { get; set;}

        public Producto()
        {
        }

        public Producto(decimal cod_producto, string nomb_producto, Proveedor proveedor, Categoria categoria, Laboratorio laboratorio, string descipcion)
        {
            this.cod_producto = cod_producto;
            this.nomb_producto = nomb_producto;
            this.proveedor = proveedor;
            this.categoria = categoria;
            this.laboratorio = laboratorio;
            this.descipcion = descipcion;
        }
    }
}
