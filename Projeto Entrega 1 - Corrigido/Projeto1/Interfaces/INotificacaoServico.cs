using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Interfaces
{
    interface INotificacaoServico
    {
        public void EnviarNotificacao(Agendamento agendamento);
    }
}
