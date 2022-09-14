using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Interfaces
{
    public interface IContaRepositorio
    {
        Conta FindContaByCpfAndSenha(string cpf, string senha);
        Conta Get(int id);
    }
}
