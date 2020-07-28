using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblCliente
    {
        public TblCliente()
        {
            TblLaudo = new HashSet<TblLaudo>();
            TblVistoriaTipoServicoCliente = new HashSet<TblVistoriaTipoServicoCliente>();
        }

        public string CnpjCpf { get; set; }
        public string Segmento { get; set; }

        public virtual TblPessoa CnpjCpfNavigation { get; set; }
        public virtual TblSegmento SegmentoNavigation { get; set; }
        public virtual ICollection<TblLaudo> TblLaudo { get; set; }
        public virtual ICollection<TblVistoriaTipoServicoCliente> TblVistoriaTipoServicoCliente { get; set; }
    }
}
