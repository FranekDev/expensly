using Microsoft.AspNetCore.Mvc;

namespace Expensly.Repositories;

public interface IRepository<T> where T : class
{
    Task<ActionResult<T>> Create(T entity);
    Task<ActionResult<T?>> Find(int id);
    Task<ActionResult<IEnumerable<T>>> Get();
    Task<IActionResult> Delete(int id);
    Task<IActionResult> Update(int id, T entity);
}