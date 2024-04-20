using Expensly.Library.DTOs;
using Expensly.Library.Helpers.Static;
using Expensly.Library.Models;
using Expensly.Repositories;
using Expensly.Services;
using Microsoft.AspNetCore.Mvc;

namespace Expensly.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    private IUserService _userService = userService;

    [HttpGet]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<UserDto>>> Get()
    {
        var data = await _userService.Get();
        return Ok(data);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status302Found)]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> GetById(int id)
    {
        var user = await _userService.GetById(id);
        if (user is null)
        {
            return NotFound();
        }
        
        return Ok(user);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(User), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(User), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<int>> Create([FromBody] UserDto user)
    {
        var createdUser = await _userService.Create(user);
        return CreatedAtAction(nameof(GetById), new { id = createdUser.Id }, createdUser);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(User), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> Update(int id, [FromBody] UserDto user)
    {
        var updatedUser = await _userService.Update(id, user);
        if (updatedUser is null)
        {
            return NotFound();
        }
        
        return Ok(updatedUser);
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        await _userService.Delete(id);
        return NoContent();
    }
}