using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServicoConta.Cadastros;
using ServicoConta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoConta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        private CadastroConta cadastroConta;
        public ContaController(IContaRepositorio contaRepositorio)
        {
            cadastroConta = new CadastroConta(contaRepositorio);
        }
       
        [HttpPost("login")]
        public async Task<IActionResult> Login(string cpf, string senha)
        {
            int contaId = await cadastroConta.Login(cpf, senha);
            if (contaId > 0)
            {
                return Ok(contaId);
            }
            return NotFound();
        }

        [HttpGet("existeConta")]
        public async Task<IActionResult> ExisteConta(int id)
        {
            bool existe = await cadastroConta.ExisteConta(id);

            return Ok(existe);
        }

        [HttpPost("registrarCidadao")]
        public async Task<IActionResult> RegistrarCidadao(string cpf, string senha, string nome, string email)
        {
            if (await cadastroConta.VerificarConta(cpf)) return Conflict();

            bool sucesso = await cadastroConta.InserirCidadao(cpf, senha, nome, email);

            if (sucesso) return Ok();

            return StatusCode(500);
        }

        [HttpPost("registrarProfissionalDeSaude")]
        public async Task<IActionResult> RegistrarProfissionalDeSaude(string cpf, string senha, string nome, string email)
        {
            if (await cadastroConta.VerificarConta(cpf)) return Conflict();

            bool sucesso = await cadastroConta.InserirProfissional(cpf, senha, nome, email);

            if (sucesso) return Ok();

            return StatusCode(500);
        }

        [HttpGet("existeAdmin")]
        public async Task<IActionResult> ExisteAdmin(int id)
        {
            bool isAdmin = await cadastroConta.ExisteAdmin(id);

            if (isAdmin) return StatusCode(200);

            return StatusCode(404);
        }
    }
}
