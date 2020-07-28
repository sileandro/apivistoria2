using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblTipoEndereco
    {
        public TblTipoEndereco()
        {
            TblEndereco = new HashSet<TblEndereco>();
        }

        public string TipoEndereco { get; set; }
        public int TipoEnderecoId { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblEndereco> TblEndereco { get; set; }
    }
}
