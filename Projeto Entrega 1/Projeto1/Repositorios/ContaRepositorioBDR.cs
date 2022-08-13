using Projeto1.Data;
using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Repositorios
{
    public class ContaRepositorioBDR : IContaRepositorio
    {
        private readonly DataContext _dataContext;
        public ContaRepositorioBDR(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Conta FindContaByCpfAndSenha(string cpf, string senha)
        {
            //esse metodo aqui nao e nada seguro
            return _dataContext.Contas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);
        }

        public Conta Get(int id)
        {
            return _dataContext.Contas.FirstOrDefault(x => x.Id == id);
        }
    }
}
