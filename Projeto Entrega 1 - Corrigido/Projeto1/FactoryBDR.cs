using Projeto1.Interfaces;
using System;
using Projeto1.Repositorios;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto1.Data;

namespace Projeto1
{
    public class FactoryBDR : AbstractFactory
    {
        private DataContext _context;
        public FactoryBDR(DataContext context)
        {
            _context = context;
        }

        public IAgendamentoRepositorio CreateAgendamentoRepositorio()
        {
            return new AgendamentoRepositorioBDR(_context);
        }

        public IContaRepositorio CreateContaRepositorio()
        {
            return new ContaRepositorioBDR(_context);
        }

        public IPontoRepositorio CreatePontoRepositorio()
        {
            return new PontoRepositorio(_context);
        }

        public IVacinaRepositorio CreateVacinaRepositorio()
        {
            return new VacinaRepositorioBDR(_context);
        }
    }
}
