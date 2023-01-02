using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]


public class DevelopersController :ControllerBase {

    private List<Developer> _db;
    [HttpGet]
    public List<Developer> GteAllDevs() {
        return _db;
    }
    public DevelopersController()
    {
        _db = new List<Developer>();
    }
}