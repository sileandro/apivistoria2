using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblProvedorParametro
    {
        public TblProvedorParametro()
        {
            TblVistoriaProvedorParametro = new HashSet<TblVistoriaProvedorParametro>();
        }

        public string CnpjProvedor { get; set; }
        public string ParametroDeEntrada { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblProvedor CnpjProvedorNavigation { get; set; }
        public virtual ICollection<TblVistoriaProvedorParametro> TblVistoriaProvedorParametro { get; set; }
    }
}
