using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TipoVeiculo
    {
        public int EmpresaIdFranqueador { get; set; }
        public string TipoVeiculo1 { get; set; }
        public int TipoVeiculoId { get; set; }
        public bool? Active { get; set; }
        public DateTime Dar { get; set; }
    }
}
