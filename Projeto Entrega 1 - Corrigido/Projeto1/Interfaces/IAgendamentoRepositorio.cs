using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Interfaces
{
    public interface IAgendamentoRepositorio
    {
        ICollection<Agendamento> FindByPontoAndHorario(int pontoId, DateTime horario);

        void Save(Agendamento agendamento);
        Agendamento Get(int agendamentoId);

        void Update(Agendamento agendamento);
    }
}
