using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblUsuario
    {
        public TblUsuario()
        {
            TblUsuarioModulo = new HashSet<TblUsuarioModulo>();
        }

        public int UsuarioId { get; set; }
        public string Cpf { get; set; }
        public string CnpjFranqueador { get; set; }
        public string CnpjVistoria { get; set; }
        public string CnpjResponsavel { get; set; }
        public string Perfil { get; set; }
        public int PerfilId { get; set; }
        public int EmpresaId { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public string Senha { get; set; }
        public string Token { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual TblPessoaJuridica CnpjResponsavelNavigation { get; set; }
        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
        public virtual TblPessoaFisica CpfNavigation { get; set; }
        public virtual TblPerfil PerfilNavigation { get; set; }
        public virtual ICollection<TblUsuarioModulo> TblUsuarioModulo { get; set; }
    }
}
