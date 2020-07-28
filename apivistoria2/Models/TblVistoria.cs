using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoria
    {
        public TblVistoria()
        {
            TblGrupoEconomico = new HashSet<TblGrupoEconomico>();
            TblUsuario = new HashSet<TblUsuario>();
            TblVistoriaGrupoVestigio = new HashSet<TblVistoriaGrupoVestigio>();
            TblVistoriaProvedor = new HashSet<TblVistoriaProvedor>();
            TblVistoriaSegmento = new HashSet<TblVistoriaSegmento>();
            TblVistoriaSetupFoto = new HashSet<TblVistoriaSetupFoto>();
            TblVistoriaTipoServico = new HashSet<TblVistoriaTipoServico>();
        }

        public string CnpjVistoria { get; set; }
        public string CnpjFranqueador { get; set; }
        public string ConsideracaoFinalImpressao { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueador CnpjFranqueadorNavigation { get; set; }
        public virtual TblPessoaJuridica CnpjVistoriaNavigation { get; set; }
        public virtual ICollection<TblGrupoEconomico> TblGrupoEconomico { get; set; }
        public virtual ICollection<TblUsuario> TblUsuario { get; set; }
        public virtual ICollection<TblVistoriaGrupoVestigio> TblVistoriaGrupoVestigio { get; set; }
        public virtual ICollection<TblVistoriaProvedor> TblVistoriaProvedor { get; set; }
        public virtual ICollection<TblVistoriaSegmento> TblVistoriaSegmento { get; set; }
        public virtual ICollection<TblVistoriaSetupFoto> TblVistoriaSetupFoto { get; set; }
        public virtual ICollection<TblVistoriaTipoServico> TblVistoriaTipoServico { get; set; }
    }
}
