using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Models
{
    public class AgendamentoViewModel
    {
        public AgendamentoViewModel()
        {
            Horario = DateTime.Today.AddDays(7);
        }
        public ICollection<PontoDeVacinacao> Pontos;
        public int PontoSelecionado;
        public ICollection<Vacina> Vacinas;
        public int VacinaSelecionada;
        public DateTime Horario;

    }
}
