using System.Text.Json.Serialization;
using Expensly.Library.Models;

namespace Expensly.Library.DTOs;

public record CategoryDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public UserDto? User { get; init; }
}