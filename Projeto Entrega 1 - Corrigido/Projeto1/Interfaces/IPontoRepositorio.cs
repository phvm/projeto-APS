using Projeto1.Entidades;
using System.Collections.Generic;

namespace Projeto1.Interfaces
{
    public interface IPontoRepositorio
    {
        public ICollection<PontoDeVacinacao> GetAllPontos();
        public PontoDeVacinacao Get(int id);
        public Estoque FindVacinaByPontoAndId(int pontoId, int vacinaId);
        void Update(PontoDeVacinacao ponto);
    }
}
