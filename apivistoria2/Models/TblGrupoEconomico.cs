using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblGrupoEconomico
    {
        public string CnpjVistoria { get; set; }
        public string GrupoEconomico { get; set; }
        public int GrupoEconomicoPessoaId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
    }
}
