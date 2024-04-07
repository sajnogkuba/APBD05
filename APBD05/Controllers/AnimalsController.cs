using APBD05.Intercaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD05.Controllers;
[ApiController]
[Route("/animals")]
public class AnimalsController(IMockDb<Animal> mockDb) : ControllerBase
{
    private IMockDb<Animal> _mockDb = mockDb;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_mockDb.GetAll());
    }
}