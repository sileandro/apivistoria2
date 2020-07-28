using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblObjetoFoto
    {
        public TblObjetoFoto()
        {
            TblFranqueadorObjetoFoto = new HashSet<TblFranqueadorObjetoFoto>();
        }

        public string Objeto { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblFranqueadorObjetoFoto> TblFranqueadorObjetoFoto { get; set; }
    }
}
