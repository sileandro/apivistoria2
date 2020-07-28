using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblFranqueador
    {
        public TblFranqueador()
        {
            TblFranqueadorGrupoVestigio = new HashSet<TblFranqueadorGrupoVestigio>();
            TblFranqueadorObjetoFoto = new HashSet<TblFranqueadorObjetoFoto>();
            TblFranqueadorSegmento = new HashSet<TblFranqueadorSegmento>();
            TblFranqueadorTipoServico = new HashSet<TblFranqueadorTipoServico>();
            TblFranqueadorTipoVeiculo = new HashSet<TblFranqueadorTipoVeiculo>();
            TblUsuario = new HashSet<TblUsuario>();
            TblVistoria = new HashSet<TblVistoria>();
        }

        public string CnpjFranqueador { get; set; }
        public string CorHexa { get; set; }
        public string LogoCaminhoFisico { get; set; }
        public bool CadastroEhCompartilhado { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblPessoaJuridica CnpjFranqueadorNavigation { get; set; }
        public virtual ICollection<TblFranqueadorGrupoVestigio> TblFranqueadorGrupoVestigio { get; set; }
        public virtual ICollection<TblFranqueadorObjetoFoto> TblFranqueadorObjetoFoto { get; set; }
        public virtual ICollection<TblFranqueadorSegmento> TblFranqueadorSegmento { get; set; }
        public virtual ICollection<TblFranqueadorTipoServico> TblFranqueadorTipoServico { get; set; }
        public virtual ICollection<TblFranqueadorTipoVeiculo> TblFranqueadorTipoVeiculo { get; set; }
        public virtual ICollection<TblUsuario> TblUsuario { get; set; }
        public virtual ICollection<TblVistoria> TblVistoria { get; set; }
    }
}
