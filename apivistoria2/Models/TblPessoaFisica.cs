using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblPessoaFisica
    {
        public TblPessoaFisica()
        {
            TblUsuario = new HashSet<TblUsuario>();
        }

        public string Cpf { get; set; }
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
        public string Logradouro { get; set; }
        public short? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblPessoa CpfNavigation { get; set; }
        public virtual ICollection<TblUsuario> TblUsuario { get; set; }
    }
}
