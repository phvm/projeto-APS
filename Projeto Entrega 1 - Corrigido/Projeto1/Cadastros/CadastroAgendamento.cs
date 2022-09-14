using Projeto1.Entidades;
using Projeto1.Enums;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Cadastros
{
    public class CadastroAgendamento
    {
        private IAgendamentoRepositorio _agendamentoRepositorio;

        public CadastroAgendamento(IAgendamentoRepositorio agendamentoRepositorio)
        {
            _agendamentoRepositorio = agendamentoRepositorio;
        }

        public ICollection<Agendamento> ListarAgendamentos(int pontoId, DateTime horario)
        {
            return _agendamentoRepositorio.FindByPontoAndHorario(pontoId, horario);
        }

        public void InserirAgendamento(Conta cidadao, PontoDeVacinacao ponto, Vacina vacina, DateTime horario)
        {
            Agendamento agendamento = new Agendamento
            {
                Cidadao = cidadao,
                Ponto = ponto,
                Vacina = vacina,
                Horario = horario,
                Status = AgendamentoStatus.Agendado
            };

            _agendamentoRepositorio.Save(agendamento);
        }

        public void Update(Agendamento agendamento)
        {
            _agendamentoRepositorio.Update(agendamento);
        }

        public Agendamento GetAgendamento(int agendamentoId)
        {
            return _agendamentoRepositorio.Get(agendamentoId);
        }
    }
}
