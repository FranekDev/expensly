using Expensly.Data;
using Expensly.Library.Models;

namespace Expensly.Repositories;

public class UnitOfWork(ExpenslyContext context) : IUnitOfWork, IDisposable
{
    private ExpenslyContext _context = context;
    public GenericRepository<User> UserRepository { get; } = new(context);

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    private bool _disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}