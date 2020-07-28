using System;
using System.Collections.Generic;

namespace apivistoria2.Models
{
    public partial class UsuarioModuloSistema
    {
        public int UsuarioId { get; set; }
        public int ModuloSistemaId { get; set; }
        public int UsuarioModuloSistemaId { get; set; }
        public bool PodeInserir { get; set; }
        public bool PodeAtualizar { get; set; }
        public bool PodeSelecionar { get; set; }
        public bool PodeRemover { get; set; }
        public bool Active { get; set; }
        public DateTime Dar { get; set; }
    }
}
