﻿namespace Expensly.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T> Create(T entity);
    Task<T?> Find(int id);
    Task<IEnumerable<T>> Get();
    Task Delete(int id);
    Task Update(int id, T entity);
}