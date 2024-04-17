using Expensly.Data;
using Expensly.Library.Models;

namespace Expensly.Repositories;

public class UnitOfWork(ExpenslyContext context) : IDisposable
{
    private ExpenslyContext _context = context;
    private GenericRepository<User> _userRepository;

    public GenericRepository<User> UserRepository
    {
        get
        {
            if (_userRepository == null)
            {
                _userRepository = new GenericRepository<User>(_context);
            }

            return _userRepository;
        }
    }

    public async Task Save()
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