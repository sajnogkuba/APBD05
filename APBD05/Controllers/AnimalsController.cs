using APBD05.Interfaces;
using APBD05.Models;
using Microsoft.AspNetCore.Mvc;

namespace APBD05.Controllers;
[ApiController]
[Route("/animals/[controller]")]
public class AnimalsController(IMockDbAnimals mockDbAnimals) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(mockDbAnimals.GetAll());
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var animal = mockDbAnimals.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }

        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult Add(Animal animal)
    {
        mockDbAnimals.Add(animal);
        return Created();
    }
    
    [HttpPut]
    public IActionResult Edit(int id, Animal animal)
    {
        if (mockDbAnimals.GetById(id) == null)
        {
            return NotFound();
        }
        mockDbAnimals.Edit(id, animal);
        return NoContent();


    }
    
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        if (mockDbAnimals.GetById(id) == null)
        {
            return NotFound();
        }
        mockDbAnimals.Delete(id);
        return NoContent();
    }
}