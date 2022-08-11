using Projeto1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entidades
{
    public class Agendamento
    {
        public int Id { get; set; }
        public Conta Cidadao { get; set; }
        public PontoDeVacinacao Ponto { get; set; }
        public Vacina Vacina { get; set; }
        public DateTime Horario { get; set; }
        public Conta ProfissionalResponsavel { get; set; }
        public AgendamentoStatus Status { get; set; }
    }
}
