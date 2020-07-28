using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TipoServicoSegmentoValor
    {
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaId { get; set; }
        public int TipoServicoId { get; set; }
        public int PessoaSegmentoId { get; set; }
        public int TipoServicoSegmentoValorId { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorRetorno { get; set; }
        public bool Active { get; set; }
        public int UsuarioIdInsert { get; set; }
        public DateTime DthInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime? DthDelete { get; set; }
        public DateTime Dar { get; set; }
    }
}
