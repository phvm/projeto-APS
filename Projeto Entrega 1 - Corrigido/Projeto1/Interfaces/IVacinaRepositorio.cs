using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Interfaces
{
    public interface IVacinaRepositorio
    {
        Vacina FindVacinaById(int id);
    }
}
