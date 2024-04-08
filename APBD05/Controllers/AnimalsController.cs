using APBD05.Interfaces;
using APBD05.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD05.Controllers;
[ApiController]
[Route("/animals/[controller]")]
public class AnimalsController(IMockDb<Animal> mockDb) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(mockDb.GetAll());
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
        mockDb.Add(animal);
        return Created();
    }
    
    [HttpPut]
    public IActionResult Edit(int id, Animal animal)
    {
        if (mockDb.GetById(id) == null)
        {
            return NotFound();
        }
        mockDb.Edit(id, animal);
        return NoContent();


    }
    
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        if (mockDb.GetById(id) == null)
        {
            return NotFound();
        }
        mockDb.Delete(id);
        return NoContent();
    }
}