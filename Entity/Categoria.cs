using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Categoria
    {
        public decimal id_categoria { get; set; }
        public string nomb_categoria { get; set; }

        public Categoria()
        {
        }

        public Categoria(decimal id_categoria, string nomb_categoria)
        {
            this.id_categoria = id_categoria;
            this.nomb_categoria = nomb_categoria;
        }
    }
}
