using ServicoConta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoConta.Interfaces
{
    public interface IContaRepositorio
    {
        Task<Conta> Login(string cpf, string senha);

        Task<bool> VerificarConta(string cpf);

        Task<bool> InserirCidadao(Cidadao cidadao);

        Task<bool> InserirProfissional(ProfissionalDeSaude conta);

        Task<bool> ExisteConta(int id);

        Task<Conta> FindById(int id);
    }
}
