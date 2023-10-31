using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaService
    {
        private CategoriaRepository repository = new CategoriaRepository();
        public DataTable MostrarCategorias()
        {
            DataTable tablaCategoria = new DataTable();
            tablaCategoria = repository.MostrarCategorias();
            return tablaCategoria;
        }

    }
}
