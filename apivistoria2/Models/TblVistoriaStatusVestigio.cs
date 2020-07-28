using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaStatusVestigio
    {
        public TblVistoriaStatusVestigio()
        {
            TblLaudo = new HashSet<TblLaudo>();
            TblVistoriaVestigio = new HashSet<TblVistoriaVestigio>();
        }

        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string CnpjVistoria { get; set; }
        public string StatusVestigioVistoria { get; set; }
        public string CorHexa { get; set; }
        public int StatusVestigioId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoriaTipoServico TblVistoriaTipoServico { get; set; }
        public virtual ICollection<TblLaudo> TblLaudo { get; set; }
        public virtual ICollection<TblVistoriaVestigio> TblVistoriaVestigio { get; set; }
    }
}
