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
    public class CategoriaService:ICrud<Categoria>
    {
        private CategoriaRepository repository = new CategoriaRepository();

        public void InsertarDatos(Categoria categoria)
        {
            repository.RegistrarCategoria(categoria);
        }

        public DataTable MostrarDatos()
        {
            DataTable tablaCategoria = new DataTable();
            tablaCategoria = repository.MostrarCategorias();
            return tablaCategoria;
        }


    }
}
