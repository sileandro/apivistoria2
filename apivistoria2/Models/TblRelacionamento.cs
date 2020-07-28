using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblRelacionamento
    {
        public string Relacionamento { get; set; }
        public int PessoaTipoRelacionamentoId { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
