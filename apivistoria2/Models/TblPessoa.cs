using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblPessoa
    {
        public string CnpjCpf { get; set; }

        public virtual TblCliente TblCliente { get; set; }
        public virtual TblPessoaFisica TblPessoaFisica { get; set; }
        public virtual TblPessoaJuridica TblPessoaJuridica { get; set; }
    }
}
