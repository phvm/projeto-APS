using Microsoft.EntityFrameworkCore;
using ServicoConta.Data;
using ServicoConta.Entidades;
using ServicoConta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoConta.Repositorios
{
    public class ContaRepositorio : IContaRepositorio
    {
        private readonly ContaContext _dataContext;
        public ContaRepositorio(ContaContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> ExisteConta(int id)
        {
            return await _dataContext.Contas.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> InserirCidadao(Cidadao cidadao)
        {
            await _dataContext.Contas.AddAsync(cidadao);
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> InserirProfissional(ProfissionalDeSaude conta)
        {
            await _dataContext.Contas.AddAsync(conta);
            return await _dataContext.SaveChangesAsync() > 0;
        }

        public async Task<Conta> Login(string cpf, string senha)
        {
            return await _dataContext.Contas.FirstOrDefaultAsync(x => x.CPF == cpf && x.Senha == senha);
        }

        public async Task<bool> VerificarConta(string cpf)
        {
            return await _dataContext.Contas.AnyAsync(x => x.CPF == cpf);
        }

        public async Task<Conta> FindById(int id)
        {
            return await _dataContext.Contas.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
