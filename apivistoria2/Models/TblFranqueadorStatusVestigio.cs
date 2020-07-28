using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorStatusVestigio
    {
        public TblFranqueadorStatusVestigio()
        {
            TblFranqueadorVestigio = new HashSet<TblFranqueadorVestigio>();
            TblLaudo = new HashSet<TblLaudo>();
        }

        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string StatusVestigioFranqueador { get; set; }
        public string CorHexa { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorTipoServico TblFranqueadorTipoServico { get; set; }
        public virtual ICollection<TblFranqueadorVestigio> TblFranqueadorVestigio { get; set; }
        public virtual ICollection<TblLaudo> TblLaudo { get; set; }
    }
}
