using APBD05.Interfaces;
using APBD05.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD05.Controllers;
[ApiController]
[Route("/visits/[controller]")]
public class VisitsController(IMockDbVisit mockDbVisit) : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetByAnimal(int id)
    {
        var animal = MockDbVisit._mockDbAnimals.GetById(id);
        var visits = mockDbVisit.GetByAnimal(animal!);
        if (visits.Count == 0)
        {
            return NotFound();
        }

        return Ok(visits);
    }
    [HttpPost]
    public IActionResult Add(Visit visit)
    {
        mockDbVisit.Add(visit);
        return Created();
    }
}