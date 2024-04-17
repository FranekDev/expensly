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
    public Task<ActionResult<IEnumerable<User>>> Get()
        => _unitOfWork.UserRepository.Get();
    
    [HttpPost]
    [ProducesResponseType(typeof(User), StatusCodes.Status201Created)]
    public Task<ActionResult<User>> Create([FromBody] User user)
    {
        var newUser = _unitOfWork.UserRepository.Create(user);
        return newUser;
    }
}