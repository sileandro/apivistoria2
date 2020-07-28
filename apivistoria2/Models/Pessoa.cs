using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class Pessoa
    {
        public string CpfCnpj { get; set; }
        public int? GrupoEconomicoPessoaId { get; set; }
    }
}
