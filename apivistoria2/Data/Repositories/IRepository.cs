using System.Threading.Tasks;

namespace apivistoria2.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
