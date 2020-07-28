using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class EmpresaConsultaVeicularParametroEntrada
    {
        public int EmpresaConsultaVeicularId { get; set; }
        public string ParametroDeEntrada { get; set; }
        public int EmpresaConsultaVeicularChaveId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
