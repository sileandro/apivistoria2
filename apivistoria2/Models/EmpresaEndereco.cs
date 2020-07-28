using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class EmpresaEndereco
    {
        public int EmpresaId { get; set; }
        public int EnderecoId { get; set; }
        public int EmpresaEnderecoId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
