using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorTipoVestigio
    {
        public TblFranqueadorTipoVestigio()
        {
            TblFranqueadorTipoServicoVestigio = new HashSet<TblFranqueadorTipoServicoVestigio>();
            TblFranqueadorTipoVeiculoVestigio = new HashSet<TblFranqueadorTipoVeiculoVestigio>();
        }

        public string CnpjFranqueador { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string Abreviacao { get; set; }
        public int GrupoVestigioId { get; set; }
        public int TipoVestigioId { get; set; }
        public int OrdemDaImpressao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorGrupoVestigio TblFranqueadorGrupoVestigio { get; set; }
        public virtual ICollection<TblFranqueadorTipoServicoVestigio> TblFranqueadorTipoServicoVestigio { get; set; }
        public virtual ICollection<TblFranqueadorTipoVeiculoVestigio> TblFranqueadorTipoVeiculoVestigio { get; set; }
    }
}
