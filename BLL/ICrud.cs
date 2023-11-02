using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public interface ICrud<T>
    {
        DataTable MostrarDatos();
        void InsertarDatos(T entidad);
    }
}
