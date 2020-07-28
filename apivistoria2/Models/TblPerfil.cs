using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblPerfil
    {
        public TblPerfil()
        {
            TblPerfilModulo = new HashSet<TblPerfilModulo>();
            TblUsuario = new HashSet<TblUsuario>();
        }

        public string Perfil { get; set; }
        public int PerfilId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual ICollection<TblPerfilModulo> TblPerfilModulo { get; set; }
        public virtual ICollection<TblUsuario> TblUsuario { get; set; }
    }
}
