using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorSegmento
    {
        public TblFranqueadorSegmento()
        {
            TblVistoriaSegmento = new HashSet<TblVistoriaSegmento>();
        }

        public string CnpjFranqueador { get; set; }
        public string Segmento { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual TblSegmento SegmentoNavigation { get; set; }
        public virtual ICollection<TblVistoriaSegmento> TblVistoriaSegmento { get; set; }
    }
}
