using Mailjet.Client;
using Mailjet.Client.TransactionalEmails;
using System.Threading.Tasks;

namespace Projeto1.SubsistemaComunicacaoEmail
{
    public class MailJetEmailService
    {
        public async Task EnviarEmail(string from, string to, string subject, string body)
        {
            string apiKey = ""; //COLOCAR AS KEYS AQUI
            string apiSecret = ""; //COLOCAR AS KEYS AQUI

            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(apiSecret)) return;

            MailjetClient client = new MailjetClient(apiKey,apiSecret);

            var email = new TransactionalEmailBuilder()
                    .WithFrom(new SendContact(from))
                    .WithSubject(subject)
                    .WithTextPart(body)
                    .WithTo(new SendContact(to))
                    .Build();
            await client.SendTransactionalEmailAsync(email);
        }
    }
}
