using Expensly.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expensly.Repositories;

public class GenericRepository<T>(ExpenslyContext context) : ControllerBase, IRepository<T> where T : class
{
    protected DbSet<T> dbSet = context.Set<T>();
    private ExpenslyContext _context => context;

    public async Task<ActionResult<T>> Create(T entity)
    {
        await dbSet.AddAsync(entity);
        return Created();
    }

    public async Task<ActionResult<T?>> Find(int id)
    {
        var item = await dbSet.FindAsync(id);

        if (item is null)
        {
            return NotFound();
        }
        
        return Ok(item);
    }

    public async Task<ActionResult<IEnumerable<T>>> Get()
    {
        var data = await dbSet.ToListAsync();
        return Ok(data);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var item = await dbSet.FindAsync(id);
        
        if (item is null)
        {
            return NotFound();
        }

        Delete(item);
        
        return NoContent();
    }

    public void Delete(T entity)
    {
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            dbSet.Attach(entity);
        }

        dbSet.Remove(entity);
    }

    public async Task<IActionResult> Update(int id, T entity)
    {
        dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        return NoContent();
    }
}