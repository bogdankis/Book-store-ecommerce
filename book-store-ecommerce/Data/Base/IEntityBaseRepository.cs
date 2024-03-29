﻿using System.Linq.Expressions;

namespace book_store_ecommerce.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()  //defines type T as a class with a parameterless constructor
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);// expresion get objectts
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
