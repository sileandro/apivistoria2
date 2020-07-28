using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class Agenda
    {
        public int EmpresaIdFranqueador { get; set; }
        public int EmpresaId { get; set; }
        public int PessoaId { get; set; }
        public DateTime DataDesejadaInicio { get; set; }
        public int AgendaId { get; set; }
        public int EnderecoId { get; set; }
        public int TipoServicoId { get; set; }
        public int StatusAgendaId { get; set; }
        public DateTime? DataDesejadaFim { get; set; }
        public DateTime? DataAgendada { get; set; }
        public string Descricao { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Veiculo { get; set; }
        public string NumeroSinistro { get; set; }
        public int? UsuarioIdRealizado { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }
    }
}
