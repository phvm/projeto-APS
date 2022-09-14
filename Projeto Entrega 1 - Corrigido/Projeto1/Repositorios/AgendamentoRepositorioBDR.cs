using Microsoft.EntityFrameworkCore;
using Projeto1.Data;
using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Repositorios
{
    public class AgendamentoRepositorioBDR : IAgendamentoRepositorio
    {
        private readonly DataContext _dataContext;

        public AgendamentoRepositorioBDR(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICollection<Agendamento> FindByPontoAndHorario(int pontoId, DateTime horario)
        {
            return _dataContext.Agendamentos.Where(x => x.Ponto.Id == pontoId && x.Horario.Date == horario.Date)
                .Include(x => x.Cidadao)
                .Include(x => x.ProfissionalResponsavel)
                .ToList();
        }

        public Agendamento Get(int agendamentoId)
        {
            return _dataContext.Agendamentos
                .Include(x => x.Cidadao)
                .Include(x => x.ProfissionalResponsavel)
                .Include(x => x.Ponto)
                .Include(x => x.Vacina)
                .FirstOrDefault(x => x.Id == agendamentoId);
        }

        public void Save(Agendamento agendamento)
        {
            _dataContext.Agendamentos.Add(agendamento);
            _dataContext.SaveChanges();
        }

        public void Update(Agendamento agendamento)
        {
            Agendamento entidade = Get(agendamento.Id);
            _dataContext.Entry(entidade).CurrentValues.SetValues(agendamento);

            _dataContext.SaveChanges();
        }
    }
}
