using Expensly.Library.DTOs;
using Expensly.Library.Models;
using Expensly.Services;
using Microsoft.AspNetCore.Mvc;

namespace Expensly.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    private readonly ICategoryService _categoryService = categoryService;
    
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CategoryDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<CategoryDto>>> Get()
    {
        var data = await _categoryService.Get();
        return Ok(data);
    }

    [HttpPost]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoryDto>> Create([FromBody] Category category)
    {
        try
        {
            var newCategory = await _categoryService.Create(category);
            var createdCategory = await _categoryService.GetById(newCategory.Id);

            return CreatedAtAction(nameof(Create), new { id = newCategory.Id }, createdCategory);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CategoryDto>> GetById(int id)
    {
        var category = await _categoryService.GetById(id);
        if (category is null)
        {
            return NotFound();
        }
        
        return Ok(category);
    }
    
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        var category = await _categoryService.GetById(id);
        if (category is null)
        {
            return NotFound();
        }
        
        await _categoryService.Delete(id);
        return NoContent();
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CategoryDto), StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CategoryDto>> Update(int id, [FromBody] CategoryDto category)
    {
        var categoryToUpdate = await _categoryService.Update(id, category);
        if (categoryToUpdate is null)
        {
            return NotFound();
        }
        
        var updatedCategory = await _categoryService.GetById(id);
        return Ok(updatedCategory);
    }
}