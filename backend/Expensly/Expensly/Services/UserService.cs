using Expensly.Library.DTOs;
using Expensly.Library.Helpers.Static;
using Expensly.Library.Models;
using Expensly.Repositories;

namespace Expensly.Services;

public class UserService(IUnitOfWork unitOfWork) : IUserService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    
    public async Task<IEnumerable<UserDto>> Get()
    {
        var data = await _unitOfWork.UserRepository.Get();
        var mappedData = data.Select(x => x.MapToDto());
        return mappedData;
    }

    public async Task<UserDto?> GetById(int id)
    {
        var user = await _unitOfWork.UserRepository.Find(id);
        return user?.MapToDto();
    }

    public async Task<UserDto> Create(User user)
    {
        var createdUser = await _unitOfWork.UserRepository.Create(user);
        await _unitOfWork.SaveAsync();
        return createdUser.MapToDto();
    }
    
    public async Task<UserDto?> Update(int id, UserDto user)
    {
        var userToUpdate = await _unitOfWork.UserRepository.Find(id);
        if (userToUpdate is null)
        {
            return null;
        }
        
        userToUpdate.UserName = user.UserName;
        userToUpdate.FirstName = user.FirstName;
        userToUpdate.LastName = user.LastName;
        userToUpdate.Email = user.Email;
        userToUpdate.UpdatedAt = DateTime.Now;
        
        await _unitOfWork.UserRepository.Update(id, userToUpdate);
        await _unitOfWork.SaveAsync();
        
        return userToUpdate.MapToDto();
    }
    
    public async Task Delete(int id)
    {
        await _unitOfWork.UserRepository.Delete(id);
        await _unitOfWork.SaveAsync();
    }
}