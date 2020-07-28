using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorTipoVeiculo
    {
        public TblFranqueadorTipoVeiculo()
        {
            TblFranqueadorTipoVeiculoVestigio = new HashSet<TblFranqueadorTipoVeiculoVestigio>();
            TblLaudo = new HashSet<TblLaudo>();
            TblSetupFoto = new HashSet<TblSetupFoto>();
            TblVistoriaTipoVeiculoVestigio = new HashSet<TblVistoriaTipoVeiculoVestigio>();
        }

        public string TipoVeiculo { get; set; }
        public string CnpjFranqueador { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual TblTipoVeiculo TipoVeiculoNavigation { get; set; }
        public virtual ICollection<TblFranqueadorTipoVeiculoVestigio> TblFranqueadorTipoVeiculoVestigio { get; set; }
        public virtual ICollection<TblLaudo> TblLaudo { get; set; }
        public virtual ICollection<TblSetupFoto> TblSetupFoto { get; set; }
        public virtual ICollection<TblVistoriaTipoVeiculoVestigio> TblVistoriaTipoVeiculoVestigio { get; set; }
    }
}
