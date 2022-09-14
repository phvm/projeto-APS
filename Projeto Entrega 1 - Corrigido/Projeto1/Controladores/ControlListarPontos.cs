using Projeto1.Cadastros;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controladores
{
    public class ControlListarPontos
    {
        private CadastroPonto _cadastroPonto;

        public ControlListarPontos(CadastroPonto cadastroPonto)
        {
            _cadastroPonto = cadastroPonto;
        }

        public ICollection<PontoDeVacinacao> GetPontos()
        {
            return _cadastroPonto.GetAllPontos();
        }
    }
}
