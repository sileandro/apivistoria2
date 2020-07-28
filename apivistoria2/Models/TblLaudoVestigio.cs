using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class TblLaudoVestigio
    {
        public int LaudoId { get; set; }
        public string GrupoVestigio { get; set; }
        public string TipoVestigio { get; set; }
        public string StatusVestigioFranqueador { get; set; }
        public string StatusVestigioVistoria { get; set; }
        public string Vestigio { get; set; }
        public int UsuarioIdInsert { get; set; }
        public int? UsuarioIdUpdate { get; set; }
        public int? UsuarioIdDelete { get; set; }
        public DateTime DthInsert { get; set; }
        public DateTime? DthUpdate { get; set; }
        public DateTime? DthDelete { get; set; }

        public virtual TblLaudo Laudo { get; set; }
    }
}
