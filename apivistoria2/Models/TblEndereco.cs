using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblEndereco
    {
        public string Cnpj { get; set; }
        public string TipoEndereco { get; set; }
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public short? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool? EhPrincipal { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblPessoaJuridica CnpjNavigation { get; set; }
        public virtual TblTipoEndereco TipoEnderecoNavigation { get; set; }
        public virtual TblUf UfNavigation { get; set; }
    }
}
