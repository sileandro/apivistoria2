using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaGrupoVestigio
    {
        public TblVistoriaGrupoVestigio()
        {
            TblVistoriaTipoVestigio = new HashSet<TblVistoriaTipoVestigio>();
        }

        public string CnpjVistoria { get; set; }
        public string GrupoVestigio { get; set; }
        public int OrdemDeImpressao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
        public virtual ICollection<TblVistoriaTipoVestigio> TblVistoriaTipoVestigio { get; set; }
    }
}
