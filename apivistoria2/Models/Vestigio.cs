using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class Vestigio
    {
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaId { get; set; }
        public int TipoVestigioId { get; set; }
        public int StatusVestigioId { get; set; }
        public string Vestigio1 { get; set; }
        public int VestigioId { get; set; }
        public bool NaoAplicavel { get; set; }
        public int? CodigoInterno { get; set; }
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
