using Expensly.Library.DTOs;
using Expensly.Library.Models;

namespace Expensly.Library.Helpers.Static;

public static class UserMapping
{
    public static UserDto MapToDto(this User user)
    {
        var dto = new UserDto()
        {
            Id = user.Id,
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email
        };
        
        return dto;
    }

    public static User MapToDomain(this UserDto user)
    {
        var domain = new User()
        {
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email
        };
        
        return domain;
    }
}