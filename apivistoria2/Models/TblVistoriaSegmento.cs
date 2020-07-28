using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaSegmento
    {
        public TblVistoriaSegmento()
        {
            TblVistoriaTipoServicoSegmento = new HashSet<TblVistoriaTipoServicoSegmento>();
        }

        public string CnpjFranqueador { get; set; }
        public string Segmento { get; set; }
        public string CnpjVistoria { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
        public virtual TblFranqueadorSegmento TblFranqueadorSegmento { get; set; }
        public virtual ICollection<TblVistoriaTipoServicoSegmento> TblVistoriaTipoServicoSegmento { get; set; }
    }
}
