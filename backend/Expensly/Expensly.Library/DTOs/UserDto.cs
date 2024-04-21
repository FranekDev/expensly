using Expensly.Library.Models;

namespace Expensly.Library.DTOs;

public record UserDto
{
    public int Id { get; init; }
    
    public string UserName { get; init; }
    
    public string FirstName { get; init; }
    
    public string LastName { get; init; }
    
    public string Email { get; init; }
}