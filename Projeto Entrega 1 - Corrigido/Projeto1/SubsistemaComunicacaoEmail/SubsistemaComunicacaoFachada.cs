using Projeto1.Entidades;
using Projeto1.Interfaces;

namespace Projeto1.SubsistemaComunicacaoEmail
{
    public class SubsistemaComunicacaoFachada
    {
        private INotificacaoServico notificacaoService;

        public SubsistemaComunicacaoFachada()
        {
            notificacaoService = new MailJetEmailServiceAdapter();
        }

        public void EnviarEmail(Agendamento agendamento)
        {
            notificacaoService.EnviarNotificacao(agendamento);
        }
    }
}
