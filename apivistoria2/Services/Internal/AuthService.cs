using apivistoria2.Data.Repositories;
using apivistoria2.Models;
using apivistoria2.Services.Internal.Interfaces;
using apivistoria2.Services.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apivistoria2.Services.Internal
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioService _usuarioService;
        public AuthService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public async Task<TblUsuario> Login(string user, string password)
        {
            try
            {
                var hash = Utils.PasswordEncrypt(password);
                return await _usuarioService.GetByCpfOrEmail(user, hash);
            }
            catch
            {
                return null;
            }
        }
    }
}
