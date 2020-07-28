using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblTipoVeiculo
    {
        public TblTipoVeiculo()
        {
            TblFranqueadorTipoVeiculo = new HashSet<TblFranqueadorTipoVeiculo>();
        }

        public string TipoVeiculo { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblFranqueadorTipoVeiculo> TblFranqueadorTipoVeiculo { get; set; }
    }
}
