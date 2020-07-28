using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class EmpresaConsultaVeicular
    {
        public string NomeRazaoSocial { get; set; }
        public int EmpresaConsultaVeicularId { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
