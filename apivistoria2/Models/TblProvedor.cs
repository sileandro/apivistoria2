using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblProvedor
    {
        public TblProvedor()
        {
            TblProvedorParametro = new HashSet<TblProvedorParametro>();
            TblVistoriaProvedor = new HashSet<TblVistoriaProvedor>();
        }

        public string CnpjProvedor { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblPessoaJuridica CnpjProvedorNavigation { get; set; }
        public virtual ICollection<TblProvedorParametro> TblProvedorParametro { get; set; }
        public virtual ICollection<TblVistoriaProvedor> TblVistoriaProvedor { get; set; }
    }
}
