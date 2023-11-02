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
    public class LaboratorioService : ICrud<Laboratorio>
    {
        private LaboratorioRepository repository = new LaboratorioRepository();

        public void InsertarDatos(Laboratorio laboratorio)
        {
            repository.RegistrarLaboratorio(laboratorio);
        }

        public DataTable MostrarDatos()
        {
            DataTable tablaLaboratorios = new DataTable();
            tablaLaboratorios = repository.MostrarLaboratorio();
            return tablaLaboratorios;
        }


    }
}
