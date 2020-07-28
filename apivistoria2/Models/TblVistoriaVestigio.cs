using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaVestigio
    {
        public string CnpjFranqueador { get; set; }
        public string TipoVeiculo { get; set; }
        public string TipoServico { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string StatusVestigioVistoria { get; set; }
        public string CnpjVistoria { get; set; }
        public string Vestigio { get; set; }
        public int? CodigoInterno { get; set; }
        public bool NaoAplicavel { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoriaStatusVestigio TblVistoriaStatusVestigio { get; set; }
        public virtual TblVistoriaTipoVeiculoVestigioServico TblVistoriaTipoVeiculoVestigioServico { get; set; }
    }
}
