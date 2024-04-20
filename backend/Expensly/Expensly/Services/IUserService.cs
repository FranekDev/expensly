using Expensly.Library.DTOs;

namespace Expensly.Services;

public interface IUserService
{
    Task<IEnumerable<UserDto>> Get();
    Task<UserDto?> GetById(int id);
    Task<UserDto> Create(UserDto user);
    Task<UserDto?> Update(int id, UserDto user);
    Task Delete(int id);
}