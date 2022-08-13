using Microsoft.AspNetCore.Mvc;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controllers
{
    public class PontosController : Controller
    {
        private Fachada _fachada;

        public PontosController(Fachada fachada)
        {
            _fachada = fachada;
        }

        [HttpGet]
        public ActionResult TelaListarPontos()
        {
            ICollection<PontoDeVacinacao> pontos = _fachada.GetPontos();
            return View("TelaListarPontos", pontos);
        }
    }
}
