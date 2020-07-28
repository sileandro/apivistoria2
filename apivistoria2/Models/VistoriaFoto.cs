using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class VistoriaFoto
    {
        public int VistoriaFotoId { get; set; }
        public int VistoriaId { get; set; }
        public int? EmpresaSetupFotoId { get; set; }
        public string CaminhoFisico { get; set; }
        public string ObservacaoFoto { get; set; }
        public bool? Active { get; set; }
        public int UsuarioId { get; set; }
        public DateTime? DthDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public bool? PodeImprimir { get; set; }
        public bool? EhFotoExtra { get; set; }
        public DateTime Dar { get; set; }
    }
}
