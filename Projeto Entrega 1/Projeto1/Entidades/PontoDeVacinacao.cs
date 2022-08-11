﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Entidades
{
    public class PontoDeVacinacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public ICollection<Vacina> Vacinas { get; set; }
    }
}
