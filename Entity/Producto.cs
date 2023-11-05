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
        public string descripcion { get; set;}
        public decimal cantidadTotal { get; set;}

        public Producto()
        {
        }

        public Producto(decimal cod_producto, string nomb_producto, Proveedor proveedor, Categoria categoria, Laboratorio laboratorio, string descripcion, int cantidadTotal)
        {
            this.cod_producto = cod_producto;
            this.nomb_producto = nomb_producto;
            this.proveedor = proveedor;
            this.categoria = categoria;
            this.laboratorio = laboratorio;
            this.descripcion = descripcion;
            this.cantidadTotal = cantidadTotal;
        }
    }
}
