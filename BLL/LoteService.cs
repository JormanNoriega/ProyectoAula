using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoteService
    {
        private LoteRepository repository = new LoteRepository();
        public DataTable MostrarLotes(string CodProducto)
        {
            DataTable tablaLotes = new DataTable();
            tablaLotes = repository.MostrarLotes(Convert.ToDecimal(CodProducto));
            return tablaLotes;
        }


    }
}
