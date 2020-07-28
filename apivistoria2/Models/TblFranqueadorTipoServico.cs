using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorTipoServico
    {
        public TblFranqueadorTipoServico()
        {
            TblFranqueadorStatusVestigio = new HashSet<TblFranqueadorStatusVestigio>();
            TblFranqueadorTipoServicoVestigio = new HashSet<TblFranqueadorTipoServicoVestigio>();
            TblVistoriaTipoServico = new HashSet<TblVistoriaTipoServico>();
        }

        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public int TipoServicoId { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual ICollection<TblFranqueadorStatusVestigio> TblFranqueadorStatusVestigio { get; set; }
        public virtual ICollection<TblFranqueadorTipoServicoVestigio> TblFranqueadorTipoServicoVestigio { get; set; }
        public virtual ICollection<TblVistoriaTipoServico> TblVistoriaTipoServico { get; set; }
    }
}
