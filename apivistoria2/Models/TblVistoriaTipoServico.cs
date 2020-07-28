using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaTipoServico
    {
        public TblVistoriaTipoServico()
        {
            TblLaudo = new HashSet<TblLaudo>();
            TblVistoriaStatusVestigio = new HashSet<TblVistoriaStatusVestigio>();
            TblVistoriaTipoServicoCliente = new HashSet<TblVistoriaTipoServicoCliente>();
            TblVistoriaTipoServicoSegmento = new HashSet<TblVistoriaTipoServicoSegmento>();
            TblVistoriaTipoServicoVestigio = new HashSet<TblVistoriaTipoServicoVestigio>();
        }

        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string CnpjVistoria { get; set; }
        public int EmpresaId { get; set; }
        public int EmpresaIdFranqueador { get; set; }
        public int TipoServicoId { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoria CnpjVistoriaNavigation { get; set; }
        public virtual TblFranqueadorTipoServico TblFranqueadorTipoServico { get; set; }
        public virtual ICollection<TblLaudo> TblLaudo { get; set; }
        public virtual ICollection<TblVistoriaStatusVestigio> TblVistoriaStatusVestigio { get; set; }
        public virtual ICollection<TblVistoriaTipoServicoCliente> TblVistoriaTipoServicoCliente { get; set; }
        public virtual ICollection<TblVistoriaTipoServicoSegmento> TblVistoriaTipoServicoSegmento { get; set; }
        public virtual ICollection<TblVistoriaTipoServicoVestigio> TblVistoriaTipoServicoVestigio { get; set; }
    }
}
