﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public interface ICrud<T>
    {
        List<T> MostrarDatos();
        string InsertarDatos(T entidad);
        string EliminarDatos(T entidad);
        string ActualizarDatos(T entidad);
    }
}
