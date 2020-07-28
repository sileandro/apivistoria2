using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblSegmento
    {
        public TblSegmento()
        {
            TblCliente = new HashSet<TblCliente>();
            TblFranqueadorSegmento = new HashSet<TblFranqueadorSegmento>();
            TblLaudo = new HashSet<TblLaudo>();
        }

        public string Segmento { get; set; }
        public int PessoaSegmentoId { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblCliente> TblCliente { get; set; }
        public virtual ICollection<TblFranqueadorSegmento> TblFranqueadorSegmento { get; set; }
        public virtual ICollection<TblLaudo> TblLaudo { get; set; }
    }
}
