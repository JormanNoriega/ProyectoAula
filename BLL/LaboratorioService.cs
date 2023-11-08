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

        public string ActualizarDatos(Laboratorio entidad)
        {
            throw new NotImplementedException();
        }

        public string EliminarDatos(Laboratorio entidad)
        {
            throw new NotImplementedException();
        }

        public string InsertarDatos(Laboratorio laboratorio)
        {
            return repository.RegistrarLaboratorio(laboratorio);
        }

        public List<Laboratorio> MostrarDatos()
        {
            return repository.MostrarLaboratorio();
        }


    }
}
