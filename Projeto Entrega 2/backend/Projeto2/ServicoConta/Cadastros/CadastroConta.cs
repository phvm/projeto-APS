using ServicoConta.Entidades;
using ServicoConta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoConta.Cadastros
{
    public class CadastroConta
    {
        private IContaRepositorio ContaRepositorio;

        public CadastroConta(IContaRepositorio contaRepositorio)
        {
            ContaRepositorio = contaRepositorio;
        }

        public async Task<int> Login(string cpf, string senha)
        {
            Conta conta = await ContaRepositorio.Login(cpf, senha);

            return conta == null ? 0 : conta.Id;
        }

        public async Task<bool> InserirProfissional(string cpf, string senha, string nome, string email)
        {
            ProfissionalDeSaude conta = new ProfissionalDeSaude
            {
                CPF = cpf,
                Senha = senha,
                Nome = nome,
                Email = email
            };

            return await ContaRepositorio.InserirProfissional(conta);
        }

        public async Task<bool> VerificarConta(string cpf)
        {
            return await ContaRepositorio.VerificarConta(cpf);
        }

        public async Task<bool> InserirCidadao(string cpf, string senha, string nome, string email)
        {
            Cidadao cidadao = new Cidadao
            {
                CPF = cpf,
                Senha = senha,
                Nome = nome,
                Email = email
            };

            return await ContaRepositorio.InserirCidadao(cidadao);
        }

        public async Task<bool> ExisteConta(int id)
        {
            return await ContaRepositorio.ExisteConta(id);
        }
        
        public async Task<bool> ExisteAdmin(int id)
        {
            Conta conta = await ContaRepositorio.FindById(id);

            return  conta != null && conta is Admin;
        }
    }
}
