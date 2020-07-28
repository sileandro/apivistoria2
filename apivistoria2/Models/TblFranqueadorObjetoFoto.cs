using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueadorObjetoFoto
    {
        public TblFranqueadorObjetoFoto()
        {
            TblSetupFoto = new HashSet<TblSetupFoto>();
        }

        public string Objeto { get; set; }
        public string CnpjFranqueador { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual TblObjetoFoto ObjetoNavigation { get; set; }
        public virtual ICollection<TblSetupFoto> TblSetupFoto { get; set; }
    }
}
