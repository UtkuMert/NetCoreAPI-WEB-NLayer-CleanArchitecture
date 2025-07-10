using System.Linq.Expressions;

namespace App.Repositories
{
    /*
     buraya fazla bir sey eklenmez. Ornegin stock icin bir sey kullanilacaksa o
     ihtiyac duyuldugu yerde olusturulur.
     */
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T,bool>> predicate);
        ValueTask<T?> GetByIdAsync(int id);
        ValueTask AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
