using apivistoria2.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace apivistoria2.Services.Internal.Interfaces
{
    public interface IBase<T> : IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
