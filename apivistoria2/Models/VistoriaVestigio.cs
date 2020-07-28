using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class VistoriaVestigio
    {
        public int VistoriaId { get; set; }
        public int VestigioId { get; set; }
        public int VistoriaVestigioId { get; set; }
        public bool? Active { get; set; }
        public DateTime DthInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime? DthDelete { get; set; }
        public int UsuarioIdInsert { get; set; }
        public DateTime Dar { get; set; }
    }
}
