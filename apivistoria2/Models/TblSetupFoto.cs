using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblSetupFoto
    {
        public TblSetupFoto()
        {
            TblVistoriaSetupFoto = new HashSet<TblVistoriaSetupFoto>();
        }

        public string TipoVeiculo { get; set; }
        public string CnpjFranqueador { get; set; }
        public string Objeto { get; set; }
        public int SetupFotoId { get; set; }
        public int TipoVeiculoId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorObjetoFoto TblFranqueadorObjetoFoto { get; set; }
        public virtual TblFranqueadorTipoVeiculo TblFranqueadorTipoVeiculo { get; set; }
        public virtual ICollection<TblVistoriaSetupFoto> TblVistoriaSetupFoto { get; set; }
    }
}
