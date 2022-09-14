using Projeto1.Data;
using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Repositorios
{
    public class VacinaRepositorioBDR : IVacinaRepositorio
    {
        private readonly DataContext _dataContext;

        public VacinaRepositorioBDR(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Vacina FindVacinaById(int id)
        {
            return _dataContext.Vacinas.FirstOrDefault(x => x.Id == id);
        }
    }
}
