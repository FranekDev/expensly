using Expensly.Library.DTOs;
using Expensly.Library.Helpers.Static;
using Expensly.Library.Models;
using Expensly.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Expensly.Services;

public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    
    public async Task<IEnumerable<CategoryDto>> Get()
    {
        var data = await _unitOfWork.CategoryRepository.DbSet.Include(x => x.User).ToListAsync();
        var mappedData = data.Select(x => x.MapToDto());
        return mappedData;
    }

    public async Task<CategoryDto?> GetById(int id)
    {
        var category =  await _unitOfWork.CategoryRepository.DbSet
            .Include(x => x.User)
            .FirstOrDefaultAsync(u => u.Id == id);
        return category?.MapToDto();
    }

    public async Task<CategoryDto> Create(Category category)
    {
        var user = await _unitOfWork.UserRepository.Find(category.UserId);
        if (user is null)
        {
            throw new Exception("User not found");
        }
        
        var newCategory = await _unitOfWork.CategoryRepository.Create(category);
        await _unitOfWork.SaveAsync();
        
        return newCategory.MapToDto();
    }

    public async Task<CategoryDto?> Update(int id, CategoryDto category)
    {
        var categoryToUpdate = await _unitOfWork.CategoryRepository.Find(id);
        if (categoryToUpdate is null)
        {
            return null;
        }
        
        categoryToUpdate.Name = category.Name;
        categoryToUpdate.UpdatedAt = DateTime.Now;
        
        await _unitOfWork.CategoryRepository.Update(id, categoryToUpdate);
        await _unitOfWork.SaveAsync();
        
        return categoryToUpdate.MapToDto();
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.CategoryRepository.Delete(id);
        await _unitOfWork.SaveAsync();
    }
}