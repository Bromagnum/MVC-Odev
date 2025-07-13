using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Repositories.Abstracts
{
    public interface IBaseRepository<T> where T : NorthwndContext
    {
        Task<List<T>> GetAllAsyc();
        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsycn(T body);

        Task DeleteAsync(int id);




    }
}
