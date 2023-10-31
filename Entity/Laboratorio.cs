using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Laboratorio
    {
        public decimal id_laboratorio {  get; set; }
        public string nomb_laboratorio {  get; set; }

        public Laboratorio()
        {
        }

        public Laboratorio(decimal id_laboratorio, string nomb_laboratorio)
        {
            this.id_laboratorio = id_laboratorio;
            this.nomb_laboratorio = nomb_laboratorio;
        }
    }
}
