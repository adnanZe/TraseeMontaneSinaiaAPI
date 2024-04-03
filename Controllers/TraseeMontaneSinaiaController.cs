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
}
