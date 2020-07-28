using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaProvedorParametro
    {
        public string CnpjProvedor { get; set; }
        public string CnpjVistoria { get; set; }
        public string ParametroDeEntrada { get; set; }
        public string ValorDeEntrada { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoriaProvedor Cnpj { get; set; }
        public virtual TblProvedorParametro TblProvedorParametro { get; set; }
    }
}
