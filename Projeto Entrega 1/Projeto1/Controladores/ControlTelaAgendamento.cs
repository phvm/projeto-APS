using Projeto1.Cadastros;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controladores
{
    public class ControlTelaAgendamento
    {
        private CadastroAgendamento _cadastroAgendamento;
        private CadastroConta _cadastroConta;
        private CadastroPonto _cadastroPonto;

        public ControlTelaAgendamento(CadastroAgendamento cadastroAgendamento, CadastroConta cadastroConta, CadastroPonto cadastroPonto)
        {
            _cadastroAgendamento = cadastroAgendamento;
            _cadastroConta = cadastroConta;
            _cadastroPonto = cadastroPonto;
        }

        public bool RealizarAgendamento(int contaId, int pontoId, int vacinaId, DateTime horario)
        {
            Conta cidadao = _cadastroConta.GetConta(contaId);
            PontoDeVacinacao ponto = _cadastroPonto.Get(pontoId);
            Vacina vacina = _cadastroPonto.FindVacinaByPontoAndId(pontoId, vacinaId);

            if (vacina.Estoque < 0) return false;

            _cadastroAgendamento.InserirAgendamento(cidadao, ponto, vacina, horario);
            _cadastroPonto.DecrementarEstoque(ponto, vacina);

            return true;
        }

    }
}
