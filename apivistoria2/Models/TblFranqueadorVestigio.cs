using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorVestigio
    {
        public string CnpjFranqueador { get; set; }
        public string TipoVeiculo { get; set; }
        public string TipoServico { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string StatusVestigioFranqueador { get; set; }
        public string Vestigio { get; set; }
        public int VestigioId { get; set; }
        public int? CodigoInterno { get; set; }
        public bool NaoAplicavel { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorStatusVestigio TblFranqueadorStatusVestigio { get; set; }
        public virtual TblFranqueadorTipoVeiculoVestigioServico TblFranqueadorTipoVeiculoVestigioServico { get; set; }
    }
}
