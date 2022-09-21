using ServicoVacina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoVacina.Interfaces
{
    public interface IVacinaRepositorio
    {
        Task<bool> ExisteVacina(int id);
        Task<bool> AdicionarVacina(Vacina vacina);
        Task<bool> AtualizarVacina(Vacina vacina);
        Task<bool> VerificarVacina(string nome, string descricao);
        Task<Vacina> Get(int id);
    }
}
