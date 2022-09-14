using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Cadastros
{
    public class CadastroPonto
    {
        private readonly IPontoRepositorio _pontoRepositorio;

        public CadastroPonto(IPontoRepositorio pontoRepositorio)
        {
            _pontoRepositorio = pontoRepositorio;
        }

        public ICollection<PontoDeVacinacao> GetAllPontos()
        {
            return _pontoRepositorio.GetAllPontos();
        }

        public PontoDeVacinacao Get(int pontoId)
        {
            return _pontoRepositorio.Get(pontoId);
        }


        public void DecrementarEstoque(PontoDeVacinacao ponto, Vacina vacina)
        {
            ponto.Estoques.FirstOrDefault(x => x.Vacina.Id == vacina.Id).Quantidade--;

            _pontoRepositorio.Update(ponto);
        }
    }
}
