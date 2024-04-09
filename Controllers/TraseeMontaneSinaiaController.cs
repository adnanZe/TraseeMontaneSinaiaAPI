using Microsoft.AspNetCore.Mvc;
using TraseeMontaneSinaiaAPI.Models;
using TraseeMontaneSinaiaAPI.Services;

namespace TraseeMontaneSinaiaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TraseeMontaneController : ControllerBase
{
    public TraseeMontaneController() { }

    // GET all action
    [HttpGet]
    public ActionResult<List<TraseuMontan>> GetAll() => TraseeMontaneServices.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<TraseuMontan> Get(int id)
    {
        var traseuMontan = TraseeMontaneServices.Get(id);

        if (traseuMontan is null)
            return NotFound();

        return traseuMontan;
    }

    // POST action
    [HttpPost]
    public IActionResult Add(TraseuMontan traseuMontan)
    {
        TraseeMontaneServices.Add(traseuMontan);
        return CreatedAtAction(nameof(Add), new { id = traseuMontan.Id }, traseuMontan);
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, TraseuMontan traseuMontan)
    {
        if (id != traseuMontan.Id)
            return BadRequest();

        var existingTraseuMontan = TraseeMontaneServices.Get(id);
        if (existingTraseuMontan is null)
            return NotFound();

        TraseeMontaneServices.Update(traseuMontan);

        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var traseuMontan = TraseeMontaneServices.Get(id);

        if (traseuMontan is null)
            return NotFound();

        TraseeMontaneServices.Delete(id);

        return NoContent();
    }
}
