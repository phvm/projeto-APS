using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Cadastros
{
    public class CadastroVacina
    {
        private IVacinaRepositorio _vacinaReposotorio;

        public CadastroVacina(IVacinaRepositorio vacinaReposotorio)
        {
            _vacinaReposotorio = vacinaReposotorio;
        }

        public Vacina FindVacinaById(int id)
        {
            return _vacinaReposotorio.FindVacinaById(id);
        }
    }
}
