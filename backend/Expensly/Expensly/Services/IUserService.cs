using Expensly.Library.DTOs;
using Expensly.Library.Models;

namespace Expensly.Services;

public interface IUserService
{
    Task<IEnumerable<UserDto>> Get();
    Task<UserDto?> GetById(int id);
    Task<UserDto> Create(User user);
    Task<UserDto?> Update(int id, UserDto user);
    Task Delete(int id);
}