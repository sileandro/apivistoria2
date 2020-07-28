using apivistoria2.Data.Repositories;
using apivistoria2.Models;
using apivistoria2.Services.Internal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace apivistoria2.Services.Internal
{
    public class UsuarioService : Repository<TblUsuario>, IUsuarioService
    {
        private readonly AppDbContext _context;
        public UsuarioService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<TblUsuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<TblUsuario> GetByCpfOrEmail(string cpfEmail, string password)
        {
            try
            {
                var user = await _context.TblUsuario.Include(fisica => fisica.CpfNavigation)
                                                    .Where(r => (r.Cpf == cpfEmail || r.CpfNavigation.Email == cpfEmail) && r.Senha == password)
                                                    .ToListAsync<TblUsuario>();
                if (user != null)
                    return user[0];
                else return null;
            }
            catch
            {
                return null;
            }

        }
    }
}
