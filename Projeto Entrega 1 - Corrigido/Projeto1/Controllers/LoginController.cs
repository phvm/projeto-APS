using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Projeto1.Controllers
{
    public class LoginController : Controller
    {
        private readonly Fachada _fachada;

        public LoginController(Fachada fachada)
        {
            _fachada = fachada;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("TelaLogin");
        }

        [HttpPost]
        public ActionResult Login(string cpf,  string senha)
        {
            int contaId = _fachada.VerificarLogin(cpf, senha);

            if (contaId == -1)
            {
                return Json(new { success = false});
            }

            RegistrarSessao(contaId); 
            return Json(new { success = true });
        }

        private void RegistrarSessao(int contaId)
        {
            HttpContext.Session.SetInt32("ContaId", contaId);
        }

    }
}
