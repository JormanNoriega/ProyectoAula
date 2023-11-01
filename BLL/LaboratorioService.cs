using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LaboratorioService : ICrud
    {
        private LaboratorioRepository repository = new LaboratorioRepository();

        public void InsertarDatos()
        {
            throw new NotImplementedException();
        }

        public DataTable MostrarDatos()
        {
            DataTable tablaLaboratorios = new DataTable();
            tablaLaboratorios = repository.MostrarLaboratorios();
            return tablaLaboratorios;
        }


    }
}
