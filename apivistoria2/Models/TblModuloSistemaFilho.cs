using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblModuloSistemaFilho
    {
        public TblModuloSistemaFilho()
        {
            TblPerfilModulo = new HashSet<TblPerfilModulo>();
            TblUsuarioModulo = new HashSet<TblUsuarioModulo>();
        }

        public string RefHtmlItemPai { get; set; }
        public string RefHtmlItemFilho { get; set; }
        public string Descricao { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblModuloSistema RefHtmlItemPaiNavigation { get; set; }
        public virtual ICollection<TblPerfilModulo> TblPerfilModulo { get; set; }
        public virtual ICollection<TblUsuarioModulo> TblUsuarioModulo { get; set; }
    }
}
