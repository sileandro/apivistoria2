using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblUf
    {
        public TblUf()
        {
            TblEndereco = new HashSet<TblEndereco>();
        }

        public string Uf { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblEndereco> TblEndereco { get; set; }
    }
}
