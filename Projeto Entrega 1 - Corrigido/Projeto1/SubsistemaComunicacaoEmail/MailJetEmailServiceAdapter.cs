using Projeto1.Entidades;
using Projeto1.Interfaces;

namespace Projeto1.SubsistemaComunicacaoEmail
{
    public class MailJetEmailServiceAdapter : MailJetEmailService, INotificacaoServico
    {
        public void EnviarNotificacao(Agendamento agendamento)
        {
            string from = "matheusepitacio@gmail.com";
            string to = agendamento.Cidadao.Email;
            string subject = "Vacinação Registrada no Sistema";
            string body = $"Olá {agendamento.Cidadao.Nome}, estamos enviando este email para confirmar que você se vacinou recentemente.\n"
                + $"Vacina tomada: {agendamento.Vacina.Nome}\n"
                + $"Ponto de Vacinação: {agendamento.Ponto.Nome}\n"
                + $"Horário marcado: {agendamento.Horario.ToShortDateString()} {agendamento.Horario.ToShortTimeString()}";
            EnviarEmail(from, to, subject, body).Wait();
        }
    }
}
