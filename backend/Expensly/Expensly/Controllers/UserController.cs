using Expensly.Library.DTOs;
using Expensly.Library.Helpers.Static;
using Expensly.Library.Models;
using Expensly.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Expensly.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(UnitOfWork unitOfWork) : ControllerBase
{
    private UnitOfWork _unitOfWork = unitOfWork;

    [HttpGet]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<UserDto>>> Get()
    {
        var data = await _unitOfWork.UserRepository.Get();
        var mappedData = data.Select(x => x.MapToDto());
        return Ok(mappedData);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status302Found)]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> GetById(int id)
    {
        var user = await _unitOfWork.UserRepository.Find(id);
        if (user is null)
        {
            return NotFound();
        }
        
        return user.MapToDto();
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(User), StatusCodes.Status201Created)]
    public ActionResult<User> Create([FromBody] User user)
    {
        var newUser = _unitOfWork.UserRepository.Create(user);
        return Created("", newUser);
    }
}