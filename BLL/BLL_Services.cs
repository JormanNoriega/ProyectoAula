using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Services
    {
        private DAL_Repository repository = new DAL_Repository();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = repository.Mostrar();
            return tabla;
        }
        public void InsertarPRod(string nombre, string desc, string marca, string precio, string stock)
        {
            repository.Insertar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EditarProd(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            repository.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }
        public void EliminarPRod(string id)
        {
            repository.Eliminar(Convert.ToInt32(id));
        }
    }
}
