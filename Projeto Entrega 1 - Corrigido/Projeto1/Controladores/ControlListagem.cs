using Projeto1.Cadastros;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controladores
{
    public class ControlListagem
    {
        private CadastroAgendamento _cadastroAgendamento;

        public ControlListagem(CadastroAgendamento cadastroAgendamento)
        {
            _cadastroAgendamento = cadastroAgendamento;
        }

        public ICollection<Agendamento> ConsultarAgendamentos(int pontoId, DateTime horario)
        {
            return _cadastroAgendamento.ListarAgendamentos(pontoId, horario);
        }
    }
}
