using Projeto1.Cadastros;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Controladores
{
    public class ControlLogin
    {
        private readonly CadastroConta _cadastroConta;

        public ControlLogin(CadastroConta cadastroConta)
        {
            _cadastroConta = cadastroConta;
        }

        public int Verificar(string cpf, string senha)
        {
            Conta conta = _cadastroConta.EncontrarConta(cpf, senha);

            if (conta != null) return conta.Id;
            return -1;
        }
    }
}
