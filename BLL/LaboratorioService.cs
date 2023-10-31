using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LaboratorioService
    {
        private LaboratorioRepository repository = new LaboratorioRepository();
        public DataTable MostrarLaboratorios()
        {
            DataTable tablaLaboratorios = new DataTable();
            tablaLaboratorios = repository.MostrarLaboratorios();
            return tablaLaboratorios;
        }


    }
}
