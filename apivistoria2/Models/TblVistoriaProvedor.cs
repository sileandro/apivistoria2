using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaProvedor
    {
        public TblVistoriaProvedor()
        {
            TblVistoriaProvedorParametro = new HashSet<TblVistoriaProvedorParametro>();
        }

        public string CnpjProvedor { get; set; }
        public string CnpjVistoria { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblProvedor CnpjProvedorNavigation { get; set; }
        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
        public virtual ICollection<TblVistoriaProvedorParametro> TblVistoriaProvedorParametro { get; set; }
    }
}
