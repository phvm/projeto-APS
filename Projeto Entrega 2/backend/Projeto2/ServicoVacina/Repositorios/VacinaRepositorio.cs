using Microsoft.EntityFrameworkCore;
using ServicoVacina.Data;
using ServicoVacina.Entidades;
using ServicoVacina.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoVacina.Repositorios
{
    public class VacinaRepositorio : IVacinaRepositorio
    {
        private readonly VacinaContext _vacinaContext;

        public VacinaRepositorio(VacinaContext vacinaContext)
        {
            _vacinaContext = vacinaContext;
        }

        public async Task<bool> AdicionarVacina(Vacina vacina)
        {
            await _vacinaContext.Vacinas.AddAsync(vacina);

            return await _vacinaContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> AtualizarVacina(Vacina vacina)
        {
            var v = await _vacinaContext.Vacinas.FindAsync(vacina.Id);

            if (v == null) return false;

            _vacinaContext.Entry(v).CurrentValues.SetValues(vacina);

            return await _vacinaContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExisteVacina(int id)
        {
            return await _vacinaContext.Vacinas.FindAsync(id) != null;
        }

        public async Task<Vacina> Get(int id)
        {
            return await _vacinaContext.Vacinas.FindAsync(id);
        }

        public async Task<bool> VerificarVacina(string nome, string descricao)
        {
            return await _vacinaContext.Vacinas.AnyAsync(x => x.Nome == nome && x.Descricao == descricao);
        }
    }
}
