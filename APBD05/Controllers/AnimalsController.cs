using APBD05.Interfaces;
using APBD05.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APBD05.Controllers;
[ApiController]
[Route("/animals/[controller]")]
public class AnimalsController(IMockDb<Animal> mockDb) : ControllerBase
{
    private IMockDb<Animal> _mockDb = mockDb;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_mockDb.GetAll());
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var animal = mockDb.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }

        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult Add(Animal animal)
    {
        _mockDb.Add(animal);
        return Created();
    }
    
    [HttpPut]
    public IActionResult Edit(int id, Animal animal)
    {
        _mockDb.Edit(id, animal);
        return NoContent();
    }
}