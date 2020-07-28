using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaTipoVestigio
    {
        public TblVistoriaTipoVestigio()
        {
            TblVistoriaTipoServicoVestigio = new HashSet<TblVistoriaTipoServicoVestigio>();
            TblVistoriaTipoVeiculoVestigio = new HashSet<TblVistoriaTipoVeiculoVestigio>();
        }

        public string CnpjVistoria { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string Abreviacao { get; set; }
        public int OrdemDaImpressao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoriaGrupoVestigio TblVistoriaGrupoVestigio { get; set; }
        public virtual ICollection<TblVistoriaTipoServicoVestigio> TblVistoriaTipoServicoVestigio { get; set; }
        public virtual ICollection<TblVistoriaTipoVeiculoVestigio> TblVistoriaTipoVeiculoVestigio { get; set; }
    }
}
