using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto1.Entidades;
using Projeto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly Fachada _fachada;

        public AgendamentoController(Fachada fachada)
        {
            _fachada = fachada;
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var pontos = _fachada.GetPontos();
            ListagemAgendamentosViewModel model = new ListagemAgendamentosViewModel();
            model.Pontos = pontos;
            model.Agendamentos = new List<Agendamento>();

            return View("TelaListagem", model);
        }

        [HttpPost]
        public ActionResult Listar(ListagemAgendamentosViewModel model)
        {
            var pontos = _fachada.GetPontos();
            ICollection<Agendamento> agendamentos = _fachada.ListarAgendamentos(model.PontoId, model.Horario);
            model.Agendamentos = agendamentos;
            model.Pontos = pontos;

            return View("TelaListagem", model);
        }

        [HttpGet]
        public ActionResult Agendar()
        {
            AgendamentoViewModel model = new AgendamentoViewModel();
            model.Pontos = _fachada.GetPontos();
            model.Vacinas = new List<Vacina>();
            return View("TelaAgendamento", model);
        }

        [HttpGet]
        public ActionResult Filtrar(int pontoId)
        {
            var vacinas = _fachada.GetPontos().FirstOrDefault(x => x.Id == pontoId)?.Estoques.ToDictionary(x => x.Vacina.Id, x => x.Vacina.Nome) ?? null;
            return Json(new { vacinas });
        }

        [HttpPost]
        public ActionResult Agendar(int pontoId, int vacinaId, DateTime horario)
        {
            int? contaId = HttpContext.Session.GetInt32("ContaId");

            if (contaId.HasValue)
            {
                bool success = _fachada.Agendar(contaId.Value, pontoId, vacinaId, horario);

                return Json(new { success });
            }
            return Json(new { success = false });
            
        }    

        [HttpPost]
        public ActionResult RegistrarVacinacao(int agendamentoId)
        {
            int? contaId = HttpContext.Session.GetInt32("ContaId");

            if (contaId.HasValue)
            {
                _fachada.RegistrarVacinacao(agendamentoId, contaId.Value);

                return Json(new { autorizado = true });
            }
            return Json(new { autorizado = false });
        }
    }
}
