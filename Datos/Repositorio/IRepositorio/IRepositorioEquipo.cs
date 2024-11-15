﻿using System;
using Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio.IRepositorio
{
    public interface IRepositorioEquipo : IRepositorio<Equipo>
    {

        void Actualizar(Equipo equipo);

    }
}
