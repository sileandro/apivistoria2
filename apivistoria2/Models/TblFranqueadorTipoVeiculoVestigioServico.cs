using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorTipoVeiculoVestigioServico
    {
        public TblFranqueadorTipoVeiculoVestigioServico()
        {
            TblFranqueadorVestigio = new HashSet<TblFranqueadorVestigio>();
        }

        public string TipoVeiculo { get; set; }
        public string CnpjFranqueador { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string TipoServico { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorTipoServicoVestigio TblFranqueadorTipoServicoVestigio { get; set; }
        public virtual TblFranqueadorTipoVeiculoVestigio TblFranqueadorTipoVeiculoVestigio { get; set; }
        public virtual ICollection<TblFranqueadorVestigio> TblFranqueadorVestigio { get; set; }
    }
}
