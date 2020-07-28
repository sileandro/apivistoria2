using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class VistoriaFotoAvaria
    {
        public int VistoriaFotoAvariaId { get; set; }
        public int VistoriaId { get; set; }
        public int TipoVestigioId { get; set; }
        public int VestigioId { get; set; }
        public int UsuarioId { get; set; }
        public int? EmpresaSetupFotoId { get; set; }
        public DateTime DatahoraFotoAvaria { get; set; }
        public string ObservacaoFotoAvaria { get; set; }
        public decimal? ValorSugeridoFotoAvaria { get; set; }
        public string CaminhoFisico { get; set; }
        public bool? Active { get; set; }
        public DateTime? DthDelete { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime Dar { get; set; }
    }
}
