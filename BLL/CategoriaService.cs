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

        public string InsertarDatos(Categoria categoria)
        {
            return repository.RegistrarCategoria(categoria);
        }

        public List<Categoria> MostrarDatos()
        {
            return repository.MostrarCategorias();
        }
    }
}
