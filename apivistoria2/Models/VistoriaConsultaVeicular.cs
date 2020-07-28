using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class VistoriaConsultaVeicular
    {
        public int VistoriaId { get; set; }
        public int EmpresaConsultaVeicularId { get; set; }
        public DateTime DthInsert { get; set; }
        public int VistoriaConsultaVeicularId { get; set; }
        public DateTime DthSolicitado { get; set; }
        public int UsuarioIdSolicitado { get; set; }
        public string RetornoConsultaVeicular { get; set; }
        public bool? Active { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public DateTime? DthUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime? DthDelete { get; set; }
        public string UlrPrint { get; set; }
        public string CambioBaseNacional { get; set; }
        public string ChassiBaseNacional { get; set; }
        public string CombustivelBaseNacional { get; set; }
        public string CorBaseNacional { get; set; }
        public string MunicipioBaseNacional { get; set; }
        public string NumeroMotorBaseNacional { get; set; }
        public string UfBaseNacional { get; set; }
        public string AnoFabBaseNacional { get; set; }
        public string AnoModBaseNacional { get; set; }
        public string MarcaBaseNacional { get; set; }
        public string ModeloBaseNacional { get; set; }
        public string PlacaBaseNacional { get; set; }
        public string RenavamBaseNacional { get; set; }
        public DateTime Dar { get; set; }
        public string CapacidadeCarga { get; set; }
        public string Categoria { get; set; }
        public string Cilindrada { get; set; }
        public string Potencia { get; set; }
        public string TipoEspecie { get; set; }
    }
}
