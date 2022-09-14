using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Interfaces;

namespace Projeto1
{
    public interface AbstractFactory 
    {
        IAgendamentoRepositorio CreateAgendamentoRepositorio();
        IContaRepositorio CreateContaRepositorio();
        IPontoRepositorio CreatePontoRepositorio();
        IVacinaRepositorio CreateVacinaRepositorio();
    }
}
