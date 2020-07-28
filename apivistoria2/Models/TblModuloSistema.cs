using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblModuloSistema
    {
        public TblModuloSistema()
        {
            TblModuloSistemaFilho = new HashSet<TblModuloSistemaFilho>();
        }

        public string RefHtmlItemPai { get; set; }
        public int ModuloSistemaId { get; set; }
        public string Descricao { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblModuloSistemaFilho> TblModuloSistemaFilho { get; set; }
    }
}
