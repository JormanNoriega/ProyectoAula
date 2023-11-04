using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoteService : ICrud <Lote>
    {
        private LoteRepository repository = new LoteRepository();

        public string InsertarDatos(Lote lote)
        {
            throw new NotImplementedException();
        }

        public List<Lote> MostrarDatos()
        {
            throw new NotImplementedException();
        }

        //public List<Lote> MostrarLotes(string CodProducto)
        //{
        //    DataTable tablaLotes = new DataTable();
        //    tablaLotes = repository.MostrarLotes(Convert.ToDecimal(CodProducto));
        //    return tablaLotes;
        //}


    }
}
