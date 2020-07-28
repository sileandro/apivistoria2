using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblPerfilModulo
    {
        public string RefHtmlItemPai { get; set; }
        public string RefHtmlItemFilho { get; set; }
        public string Perfil { get; set; }
        public bool PodeInserir { get; set; }
        public bool PodeAtualizar { get; set; }
        public bool PodeSelecionar { get; set; }
        public bool PodeRemover { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblPerfil PerfilNavigation { get; set; }
        public virtual TblModuloSistemaFilho RefHtmlItem { get; set; }
    }
}
