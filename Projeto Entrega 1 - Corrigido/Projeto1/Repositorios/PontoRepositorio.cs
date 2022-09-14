using Microsoft.EntityFrameworkCore;
using Projeto1.Data;
using Projeto1.Entidades;
using Projeto1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Repositorios
{
    public class PontoRepositorio : IPontoRepositorio
    {
        private readonly DataContext _dataContext;

        public PontoRepositorio(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public PontoDeVacinacao Get(int id)
        {
            return _dataContext.Pontos.Include(x => x.Estoques).FirstOrDefault(x => x.Id == id);
        }

        public ICollection<PontoDeVacinacao> GetAllPontos()
        {
            return _dataContext.Pontos.Include(x => x.Estoques).ToList();
        }

        public Estoque FindVacinaByPontoAndId(int pontoId, int vacinaId)
        {
            PontoDeVacinacao ponto = _dataContext.Pontos.Include(x => x.Estoques).FirstOrDefault(x => x.Id == pontoId);
            if (ponto == null) return null;
            return ponto.Estoques.FirstOrDefault(x => x.Vacina.Id == vacinaId);
        }

        public void Update(PontoDeVacinacao ponto)
        {
            PontoDeVacinacao entidade = Get(ponto.Id);
            _dataContext.Entry(entidade).CurrentValues.SetValues(ponto);

            _dataContext.SaveChanges();
        }
    }
}
