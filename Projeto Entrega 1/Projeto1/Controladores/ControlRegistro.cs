using Projeto1.Cadastros;
using Projeto1.Entidades;
using Projeto1.SubsistemaComunicacaoEmail;

namespace Projeto1.Controladores
{
    public class ControlRegistro
    {
        private readonly CadastroConta _cadastroConta;
        private readonly CadastroAgendamento _cadastroAgendamento;
        private readonly SubsistemaComunicacaoFachada _subsistemaComunicacaoFachada;

        public ControlRegistro(CadastroConta cadastroConta, CadastroAgendamento cadastroAgendamento)
        {
            _cadastroConta = cadastroConta;
            _cadastroAgendamento = cadastroAgendamento;
            _subsistemaComunicacaoFachada = new SubsistemaComunicacaoFachada();
        }

        public void RegistrarVacinacao(int agendamentoId, int profissionalId)
        {
            Conta profissional = _cadastroConta.GetConta(profissionalId);
            Agendamento agendamento = _cadastroAgendamento.GetAgendamento(agendamentoId);

            agendamento.ProfissionalResponsavel = profissional;
            agendamento.Status = Enums.AgendamentoStatus.Concluido;

            _cadastroAgendamento.Update(agendamento);

            _subsistemaComunicacaoFachada.EnviarEmail(agendamento);
        }
    }
}
