using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class ListagemAgendamentosViewModel
    {
        public ListagemAgendamentosViewModel()
        {
            Agendamentos = new List<Agendamento>();
            Horario = DateTime.Today;
        }
        public ICollection<PontoDeVacinacao>Pontos { get; set; }
        public int PontoId { get; set; }
        public DateTime Horario { get; set; }
        public ICollection<Agendamento> Agendamentos { get; set; }
    }
}
