using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaTipoServicoCliente
    {
        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string CnpjVistoria { get; set; }
        public string CnpjCpf { get; set; }
        public int TipoServicoPessoaValorId { get; set; }
        public decimal ValorServicoCliente { get; set; }
        public decimal? ValorServicoClienteRetorno { get; set; }
        public decimal? ValorServicoClienteCusto { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblCliente CnpjCpfNavigation { get; set; }
        public virtual TblVistoriaTipoServico TblVistoriaTipoServico { get; set; }
    }
}
