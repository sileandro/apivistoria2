using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblPessoaJuridica
    {
        public TblPessoaJuridica()
        {
            TblEndereco = new HashSet<TblEndereco>();
            TblUsuario = new HashSet<TblUsuario>();
        }

        public string Cnpj { get; set; }
        public int EmpresaId { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Abreviacao { get; set; }
        public string Ie { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblPessoa CnpjNavigation { get; set; }
        public virtual TblFranqueador TblFranqueador { get; set; }
        public virtual TblProvedor TblProvedor { get; set; }
        public virtual TblVistoria TblVistoria { get; set; }
        public virtual ICollection<TblEndereco> TblEndereco { get; set; }
        public virtual ICollection<TblUsuario> TblUsuario { get; set; }
    }
}
