using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaSetupFoto
    {
        public string TipoVeiculo { get; set; }
        public string CnpjFranqueador { get; set; }
        public string Objeto { get; set; }
        public string CnpjVistoria { get; set; }
        public bool EhObrigatorio { get; set; }
        public bool FoiCriadoEmMobile { get; set; }
        public int OrdemDaCaptura { get; set; }
        public int? OrdemDaImpressao { get; set; }
        public bool PodeImprimir { get; set; }
        public int EmpresaId { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaSetupFotoId { get; set; }
        public int SetupFotoId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
        public virtual TblSetupFoto TblSetupFoto { get; set; }
    }
}
