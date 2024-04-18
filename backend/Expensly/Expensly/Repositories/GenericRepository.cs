using Expensly.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expensly.Repositories;

public class GenericRepository<T>(ExpenslyContext context) : ControllerBase, IRepository<T> where T : class
{
    protected DbSet<T> dbSet = context.Set<T>();
    private ExpenslyContext _context => context;

    public async Task<T> Create(T entity)
    {
        await dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<T?> Find(int id)
    {
        var item = await dbSet.FindAsync(id);
        return item;
    }

    public async Task<IEnumerable<T>> Get()
    {
        var data = await dbSet.ToListAsync();
        return data;
    }

    public async Task Delete(int id)
    {
        var item = await dbSet.FindAsync(id);
        
        if (item is not null)
        {
            Delete(item);
        }
    }

    public void Delete(T entity)
    {
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            dbSet.Attach(entity);
        }

        dbSet.Remove(entity);
    }

    public async Task Update(int id, T entity)
    {
        dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
}