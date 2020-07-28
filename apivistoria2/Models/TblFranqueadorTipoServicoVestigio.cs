using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorTipoServicoVestigio
    {
        public TblFranqueadorTipoServicoVestigio()
        {
            TblFranqueadorTipoVeiculoVestigioServico = new HashSet<TblFranqueadorTipoVeiculoVestigioServico>();
        }

        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorTipoServico TblFranqueadorTipoServico { get; set; }
        public virtual TblFranqueadorTipoVestigio TblFranqueadorTipoVestigio { get; set; }
        public virtual ICollection<TblFranqueadorTipoVeiculoVestigioServico> TblFranqueadorTipoVeiculoVestigioServico { get; set; }
    }
}
