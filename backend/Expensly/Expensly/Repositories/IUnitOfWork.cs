using Expensly.Library.Models;

namespace Expensly.Repositories;

public interface IUnitOfWork
{
    GenericRepository<User> UserRepository { get; } 
    GenericRepository<Category> CategoryRepository { get; }
    Task SaveAsync();
}