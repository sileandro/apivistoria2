using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblLaudo
    {
        public int LaudoId { get; set; }
        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string CnpjVistoria { get; set; }
        public string TipoVeiculo { get; set; }
        public string CnpjCpf { get; set; }
        public string StatusVestigioFranqueador { get; set; }
        public string StatusVestigioVistoria { get; set; }
        public string Segmento { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public int TipoServicoId { get; set; }
        public int EmpresaId { get; set; }
        public int PessoaId { get; set; }
        public int TipoVeiculoId { get; set; }
        public int? StatusVistoriaId { get; set; }
        public string Placa { get; set; }
        public string UfDaPlaca { get; set; }
        public string MunicipioDaPlaca { get; set; }
        public string Chassi { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public string AnoMod { get; set; }
        public string AnoFab { get; set; }
        public string Renavam { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroCambio { get; set; }
        public string NumeroLacre { get; set; }
        public string NumeroCrlv { get; set; }
        public string Hodometro { get; set; }
        public string Observacao { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public decimal? ValorServicoSegmento { get; set; }
        public decimal? ValorServicoCliente { get; set; }
        public decimal? ValorDesconto { get; set; }
        public DateTime? DthSolicitado { get; set; }
        public int? UsuarioIdVistoriador { get; set; }
        public DateTime? DthVistoriadorIniciado { get; set; }
        public DateTime? DthVistoriadorFinalizado { get; set; }
        public int? UsuarioIdConferente { get; set; }
        public DateTime? DthConferenteInciado { get; set; }
        public DateTime? DthConferenteFinalizado { get; set; }
        public int? UsuarioIdFinalizador { get; set; }
        public DateTime? DthFinalizado { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblCliente CnpjCpfNavigation { get; set; }
        public virtual TblSegmento SegmentoNavigation { get; set; }
        public virtual TblFranqueadorStatusVestigio TblFranqueadorStatusVestigio { get; set; }
        public virtual TblFranqueadorTipoVeiculo TblFranqueadorTipoVeiculo { get; set; }
        public virtual TblVistoriaStatusVestigio TblVistoriaStatusVestigio { get; set; }
        public virtual TblVistoriaTipoServico TblVistoriaTipoServico { get; set; }
        public virtual TblLaudoVestigio TblLaudoVestigio { get; set; }
    }
}
