using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class StatusAgenda
    {
        public int EmpresaIdFranqueador { get; set; }
        public string Descricao { get; set; }
        public int StatusAgendaId { get; set; }
        public int EmpresaId { get; set; }
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
