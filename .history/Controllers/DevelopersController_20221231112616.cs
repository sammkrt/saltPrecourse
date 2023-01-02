using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]


public class DevelopersController :ControllerBase {

    private List<Developer> _db;
    [HttpGet]
    public List<Developer> GetAllDevelopers() {
        return _db;
    }
    
    public DevelopersController()
    {
        _db = new List<Developer>() {
            new Developer() { Id=1, Name="Samet", Email="samet.krt@gmail.com"},
            new Developer() { Id=2, Name="Rase", Email="rase.krt@gmail.com"},
        };
    }
    [HttpGet("{id}")]

    public Developer? GetDeveloperById(int id) {
        return _db.Find(d => d.Id == id);
    }

    [HttpPost]
    public IActionResult CreateNewDeveloper(Developer developerToAdd)
    {
        var nextId = _db.Count + 1;
        developerToAdd.Id = nextId;
        _db.Add(developerToAdd);

        return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId }, developerToAdd);
    }
}