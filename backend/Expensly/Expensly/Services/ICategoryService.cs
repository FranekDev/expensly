using Expensly.Library.DTOs;
using Expensly.Library.Models;

namespace Expensly.Services;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDto>> Get();
    Task<CategoryDto?> GetById(int id);
    Task<CategoryDto> Create(Category category);
    Task<CategoryDto?> Update(int id, CategoryDto category);
    Task Delete(int id);
}