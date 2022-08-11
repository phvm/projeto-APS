using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entidades
{
    public class Conta
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool IsAdministrador { get; set; }
        public bool IsProfissionalDeSaude { get; set; }
        public bool IsCidadao { get; set; } 
    }
}
