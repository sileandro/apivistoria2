﻿using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class PessoaTipoServico
    {
        public int PessoaId { get; set; }
        public int TipoServicoId { get; set; }
        public int PessoaTipoServicoId { get; set; }
        public decimal Valor { get; set; }
        public bool Active { get; set; }
        public int UsuarioIdInsert { get; set; }
        public DateTime DthInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime? DthDelete { get; set; }
        public DateTime Dar { get; set; }
    }
}
