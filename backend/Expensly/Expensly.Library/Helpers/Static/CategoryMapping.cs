using Expensly.Library.DTOs;
using Expensly.Library.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace Expensly.Library.Helpers.Static;

public static class CategoryMapping
{
    public static CategoryDto MapToDto(this Category category)
    {
        var dto = new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            User = category.User?.MapToDto()
        };

        return dto;
    }

    public static Category MapToDomain(this CategoryDto category)
    {
        var domain = new Category
        {
            Name = category.Name,
            User = category.User?.MapToDomain()
        };

        return domain;
    }
}