using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorGrupoVestigio
    {
        public TblFranqueadorGrupoVestigio()
        {
            TblFranqueadorTipoVestigio = new HashSet<TblFranqueadorTipoVestigio>();
        }

        public string CnpjFranqueador { get; set; }
        public string GrupoVestigio { get; set; }
        public int GrupoVestigioId { get; set; }
        public int OrdemDeImpressao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual ICollection<TblFranqueadorTipoVestigio> TblFranqueadorTipoVestigio { get; set; }
    }
}
