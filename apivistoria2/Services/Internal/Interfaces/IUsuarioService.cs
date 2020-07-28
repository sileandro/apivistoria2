using apivistoria2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apivistoria2.Services.Internal.Interfaces
{
    public interface IUsuarioService : IBase<TblUsuario>
    {
        Task<TblUsuario> GetByCpfOrEmail(string cpfEmail, string password);
    }
}
