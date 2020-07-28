using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaTipoVeiculoVestigioServico
    {
        public TblVistoriaTipoVeiculoVestigioServico()
        {
            TblVistoriaVestigio = new HashSet<TblVistoriaVestigio>();
        }

        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string CnpjVistoria { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string TipoVeiculo { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoriaTipoServicoVestigio TblVistoriaTipoServicoVestigio { get; set; }
        public virtual TblVistoriaTipoVeiculoVestigio TblVistoriaTipoVeiculoVestigio { get; set; }
        public virtual ICollection<TblVistoriaVestigio> TblVistoriaVestigio { get; set; }
    }
}
