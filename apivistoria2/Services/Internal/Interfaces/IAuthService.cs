using apivistoria2.Models;
using System.Threading.Tasks;

namespace apivistoria2.Services.Internal.Interfaces
{
    public interface IAuthService
    {
        Task<TblUsuario> Login(string user, string password);
    }
}
