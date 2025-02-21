using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class MusiciansController : ControllerBase
{
    private static List<Musician> Musicians = new List<Musician>
    {
        new Musician { Id = 1, Name = "Ahmet Çalgi", Role = "Famous Instrumentalist", Description = "Always plays wrong notes, but very entertaining" },
        new Musician { Id = 2, Name = "Zeynep Melodi", Role = "Popular Melody Writer", Description = "Songs are misunderstood but very popular" },
        new Musician { Id = 3, Name = "Cemil Akor", Role = "Crazy Chordist", Description = "Changes chords frequently, but incredibly talented" }
    };

    // Get all musicians
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Musicians);
    }

    // Get musician by ID
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var musician = Musicians.FirstOrDefault(m => m.Id == id);
        if (musician == null) return NotFound("Musician not found");
        return Ok(musician);
    }

    // Search musician by name (using FromQuery)
    [HttpGet("search")]
    public IActionResult Search([FromQuery] string name)
    {
        var result = Musicians.Where(m => m.Name.ToLower().Contains(name.ToLower())).ToList();
        if (!result.Any()) return NotFound("No musicians found");
        return Ok(result);
    }

    // Add a new musician
    [HttpPost]
    public IActionResult Create([FromBody] Musician musician)
    {
        if (musician == null || string.IsNullOrWhiteSpace(musician.Name)) return BadRequest("Invalid musician data");
        musician.Id = Musicians.Max(m => m.Id) + 1;
        Musicians.Add(musician);
        return CreatedAtAction(nameof(GetById), new { id = musician.Id }, musician);
    }

    // Update entire musician data
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Musician musician)
    {
        var existingMusician = Musicians.FirstOrDefault(m => m.Id == id);
        if (existingMusician == null) return NotFound("Musician not found");
        
        existingMusician.Name = musician.Name;
        existingMusician.Role = musician.Role;
        existingMusician.Description = musician.Description;
        return NoContent();
    }

    // Update musician role only
    [HttpPatch("{id}")]
    public IActionResult UpdateRole(int id, [FromBody] string newRole)
    {
        var musician = Musicians.FirstOrDefault(m => m.Id == id);
        if (musician == null) return NotFound("Musician not found");
        musician.Role = newRole;
        return NoContent();
    }

    // Delete a musician
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var musician = Musicians.FirstOrDefault(m => m.Id == id);
        if (musician == null) return NotFound("Musician not found");
        Musicians.Remove(musician);
        return NoContent();
    }
}

public class Musician
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public string Description { get; set; }
}
