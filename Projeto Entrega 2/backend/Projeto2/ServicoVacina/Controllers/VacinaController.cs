using Microsoft.AspNetCore.Mvc;
using ServicoVacina.Cadastros;
using ServicoVacina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServicoVacina.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacinaController : ControllerBase
    {
        private CadastroVacina cadastroVacina;
        private HttpClient httpClient;

        public VacinaController(IVacinaRepositorio vacinaRepositorio)
        {
            cadastroVacina = new CadastroVacina(vacinaRepositorio);
            httpClient = new HttpClient();
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(int adminId, string nome, string descricao)
        {
            if (!(await CheckIsAdmin(adminId))) return Unauthorized();

            if (await cadastroVacina.VerificarVacina(nome, descricao)) return Conflict(); 

            bool s = await cadastroVacina.AdicionarVacina(nome, descricao);

            if (s) return Ok();

            return StatusCode(500);
        }

        [HttpPost("arquivar")]
        public async Task<IActionResult> ArquivarVacina(int adminId, int vacinaId)
        {
            if (!(await CheckIsAdmin(adminId))) return Unauthorized();

            bool existe = await cadastroVacina.ExisteVacina(vacinaId);

            if (!existe) return NotFound();

            bool s = await cadastroVacina.ArquivarVacina(vacinaId);

            if (s) return Ok();

            return StatusCode(500);
        }

        private async Task<bool> CheckIsAdmin(int adminId)
        {
            string url = $"http://host.docker.internal:3000/conta/ExisteAdmin?id={adminId}";

            var response = await httpClient.GetAsync(url);
            return response.IsSuccessStatusCode;
        }
    }
}
