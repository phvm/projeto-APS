using Projeto1.Cadastros;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controladores
{
    public class ControlRegistro
    {
        private readonly CadastroConta _cadastroConta;
        private readonly CadastroAgendamento _cadastroAgendamento;

        public ControlRegistro(CadastroConta cadastroConta, CadastroAgendamento cadastroAgendamento)
        {
            _cadastroConta = cadastroConta;
            _cadastroAgendamento = cadastroAgendamento;
        }

        public void RegistrarVacinacao(int agendamentoId, int profissionalId)
        {
            Conta profissional = _cadastroConta.GetConta(profissionalId);
            Agendamento agendamento = _cadastroAgendamento.GetAgendamento(agendamentoId);

            agendamento.ProfissionalResponsavel = profissional;
            agendamento.Status = Enums.AgendamentoStatus.Concluido;

            _cadastroAgendamento.Update(agendamento);

            //TODO ENVIAR EMAIL
        }
    }
}
