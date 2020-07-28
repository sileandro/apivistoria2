using apivistoria2.Models;
using System;
using System.Threading.Tasks;

namespace apivistoria2.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(T entity)
        {
            try
            {
                _context.Add(entity);
                //int id = 0;
                if (await _context.SaveChangesAsync() > 0)
                {
                    return 1;
                }
                return 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<int> Update(T entity)
        {
            try
            {
                _context.Update(entity);
                //int id = 0;
                if (await _context.SaveChangesAsync() > 0)
                {
                    return 1;
                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Delete(T entity)
        {
            try
            {
                _context.Remove(entity);
                return (await _context.SaveChangesAsync()) != 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}