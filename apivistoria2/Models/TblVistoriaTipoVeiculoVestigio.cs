﻿using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaTipoVeiculoVestigio
    {
        public TblVistoriaTipoVeiculoVestigio()
        {
            TblVistoriaTipoVeiculoVestigioServico = new HashSet<TblVistoriaTipoVeiculoVestigioServico>();
        }

        public string CnpjVistoria { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string TipoVeiculo { get; set; }
        public string CnpjFranqueador { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblFranqueadorTipoVeiculo TblFranqueadorTipoVeiculo { get; set; }
        public virtual TblVistoriaTipoVestigio TblVistoriaTipoVestigio { get; set; }
        public virtual ICollection<TblVistoriaTipoVeiculoVestigioServico> TblVistoriaTipoVeiculoVestigioServico { get; set; }
    }
}
