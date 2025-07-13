using Microsoft.EntityFrameworkCore;
using MVC_Antrenman.Models.Models;
using MVC_Antrenman.Repositories.Abstracts;

namespace MVC_Antrenman.Repositories.Concretes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : NorthwndContext
    {
        private readonly NorthwndContext _context;

        public BaseRepository(NorthwndContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(T entity)
        {
          await  _context.Set<T>().AddAsync(entity);
             _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            _context.Set<T>().Remove(_context.Set<T>().Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsyc()
        {
          return  await _context.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsycn(T body)
        {
            throw new NotImplementedException();
        }
    }
}
