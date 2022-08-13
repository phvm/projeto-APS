using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Interfaces
{
    public interface IPontoRepositorio
    {
        public ICollection<PontoDeVacinacao> GetAllPontos();
        public PontoDeVacinacao Get(int id);
        public Vacina FindVacinaByPontoAndId(int pontoId, int vacinaId);
        void Update(PontoDeVacinacao ponto);
    }
}
