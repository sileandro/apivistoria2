using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TipoVestigio
    {
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaId { get; set; }
        public int GrupoVestigioId { get; set; }
        public int TipoVeiculoId { get; set; }
        public int TipoServicoId { get; set; }
        public string TipoVestigio1 { get; set; }
        public int TipoVestigioId { get; set; }
        public string Abreviacao { get; set; }
        public int? OrdemPrint { get; set; }
        public bool Active { get; set; }
        public int UsuarioIdInsert { get; set; }
        public DateTime DthInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime? DthDelete { get; set; }
        public DateTime Dar { get; set; }
    }
}
