using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class GrupoVestigio
    {
        public int EmpresaId { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public string GrupoVestigio1 { get; set; }
        public int GrupoVestigioId { get; set; }
        public int? OrdemPrint { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
