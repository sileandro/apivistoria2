using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class PessoaEndereco
    {
        public int PessoaId { get; set; }
        public int EnderecoId { get; set; }
        public int PessoaEnderecoId { get; set; }
        public DateTime Dar { get; set; }
    }
}
