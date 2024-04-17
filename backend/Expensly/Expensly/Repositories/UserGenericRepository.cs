using Expensly.Data;
using Expensly.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Expensly.Repositories;

public class UserRepository(ExpenslyContext context) : RepositoryBase<User>(context)
{
//     private ExpenslyContext _context => context;
//
//     public IEnumerable<User> GetUsers()
//         => _context.Users.ToList();
//
//     public User? GetUserById(int id)
//         => _context.Users.Find(id);
//
//     public void AddUser(User user)
//         => _context.Add(user);
//
//     public void DeleteUser(User user)
//         => _context.Users.Remove(user);
//     
//     public void Save()
//         => _context.SaveChanges();
}