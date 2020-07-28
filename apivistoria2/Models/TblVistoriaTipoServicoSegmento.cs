using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblVistoriaTipoServicoSegmento
    {
        public string CnpjFranqueador { get; set; }
        public string TipoServico { get; set; }
        public string CnpjVistoria { get; set; }
        public string Segmento { get; set; }
        public int TipoServicoSegmentoValorId { get; set; }
        public decimal ValorServicoSegmento { get; set; }
        public decimal? ValorServicoSegmentoRetorno { get; set; }
        public decimal? ValorServicoSegmentoCusto { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblVistoriaSegmento TblVistoriaSegmento { get; set; }
        public virtual TblVistoriaTipoServico TblVistoriaTipoServico { get; set; }
    }
}
