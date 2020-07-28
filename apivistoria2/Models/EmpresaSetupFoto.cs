using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class EmpresaSetupFoto
    {
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaId { get; set; }
        public int SetupFotoId { get; set; }
        public int EmpresaSetupFotoId { get; set; }
        public bool EhObrigatorio { get; set; }
        public bool FoiCriadoEmMobile { get; set; }
        public bool PodeImprimir { get; set; }
        public int OrdemDaCaptura { get; set; }
        public int? OrdemDaImpressao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
