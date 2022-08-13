using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Cadastros
{
    public class CadastroConta
    {
        private readonly IContaRepositorio ContaRepositorio;

        public CadastroConta(IContaRepositorio contaRepositorio)
        {
            ContaRepositorio = contaRepositorio;
        }

        public Conta GetConta(int id)
        {
            return ContaRepositorio.Get(id);
        }

        public Conta EncontrarConta(string cpf, string senha)
        {
            return ContaRepositorio.FindContaByCpfAndSenha(cpf, senha);
        }
    }
}
