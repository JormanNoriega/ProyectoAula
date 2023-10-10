using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        private int codProducto {  get; set;}
        private string nombProducto { get; set;}
        private string laboratorio { get; set;}
        private string cartegoria { get; set;}
        private string publicoDirigido { get; set;}
        private string descripcion { get; set;}
        private List<LoteProducto> lotes {get; set;}

        public Producto(int codProducto, string nombProducto, string laboratorio, string cartegoria, string publicoDirigido, string descripcion)
        {
            this.codProducto = codProducto;
            this.nombProducto = nombProducto;
            this.laboratorio = laboratorio;
            this.cartegoria = cartegoria;
            this.publicoDirigido = publicoDirigido;
            this.descripcion = descripcion;
            this.lotes = new List<LoteProducto>();
        }
    }
}
