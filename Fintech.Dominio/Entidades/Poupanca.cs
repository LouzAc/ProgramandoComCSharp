﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class Poupanca : Conta
    {
        public decimal TaxaRendimento { get; set; }
    }
}