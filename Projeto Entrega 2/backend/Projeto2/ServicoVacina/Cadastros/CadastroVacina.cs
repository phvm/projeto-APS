using ServicoVacina.Entidades;
using ServicoVacina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoVacina.Cadastros
{
    public class CadastroVacina
    {
        private readonly IVacinaRepositorio VacinaRepositorio;

        public CadastroVacina(IVacinaRepositorio vacinaRepositorio)
        {
            VacinaRepositorio = vacinaRepositorio;
        }

        public async Task<bool> VerificarVacina(string nome, string descricao)
        {
            return await VacinaRepositorio.VerificarVacina(nome, descricao);
        }

        public async Task<bool> AdicionarVacina(string nome, string descricao)
        {
            Vacina vacina = new Vacina
            {
                Nome = nome,
                Descricao = descricao,
                IsArquivado = false
            };

            return await VacinaRepositorio.AdicionarVacina(vacina);
        }

        public async Task<bool> ArquivarVacina(int id)
        {
            Vacina vacina = await VacinaRepositorio.Get(id);
            vacina.IsArquivado = true;

            return await VacinaRepositorio.AtualizarVacina(vacina);
        }

        public async Task<bool> ExisteVacina(int id)
        {
            return await VacinaRepositorio.ExisteVacina(id);
        }
    }
}
