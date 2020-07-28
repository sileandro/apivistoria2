using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class VistoriaLogAcao
    {
        public int VistoriaId { get; set; }
        public int UsuarioIdLogAcao { get; set; }
        public string LogAcao { get; set; }
        public int VistoriaLogAcaoId { get; set; }
        public DateTime DthLogAcao { get; set; }
        public DateTime Dar { get; set; }
    }
}
