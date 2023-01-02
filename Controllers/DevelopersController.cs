using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
using webapiDotNetTrainingGround;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]

public class DevelopersController : ControllerBase
{

    private static Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }
    public class Db
    {
        public Db()
        {
            Developers = new List<Developer>() {
                new Developer() {Id = 1, Name = "Marcus", Email = "marcus@salt.dev" },
                new Developer() {Id = 2, Name = "Beatrice", Email = "bea@salt.dev" },
            };
        }
        public List<Developer> Developers { get; set; }
    }
    [HttpGet]
    public List<Developer> GetAllDevelopers()
    {
        return _db.Developers;
    }

    [HttpGet("{id}")]
    public Developer? GetDeveloperById(int id)
    {
        return _db.Developers.Find(d => d.Id == id);
    }

    /* Asagidaki kodun aciklamasi:
    Bu kod, fonksiyonun döndürdüğü "IActionResult" nesnesinin türünü belirtmek için "CreatedAtAction" methodunu kullanır. Bu method, veritabanına eklenen nesnenin bilgilerini içeren bir "201 Created" HTTP yanıtı döndürür.

    Methodun ilk parametresi olarak, veritabanına eklenen nesnenin bilgilerine erişmek için kullanılacak fonksiyonun adı verilir. Bu örnekte, bu fonksiyon "GetDeveloperById" fonksiyonudur.

    Methodun ikinci parametresi olarak, veritabanına eklenen nesnenin URL'sinde kullanılacak değişkenler belirtilir. Bu örnekte, tek bir değişken olan "id" değişkeni verilir ve bu değişkenin değeri, veritabanına eklenen nesnenin "Id" özelliğine eşittir.

    Methodun üçüncü parametresi olarak, veritabanına eklenen nesnenin bilgileri verilir. Bu örnekte, bu bilgiler "developerToAdd" değişkeninde saklanmaktadır.
    */

    [HttpPost]
    public IActionResult CreateNewDeveloper(CreateDeveloperRequest request)
    {
        // map from request to model
        var nextId = _db.Developers.Count + 1;
        var newDev = new Developer()
        {
            Id = nextId,
            Name = request.Name,
            Email = request.Email,
        };
        _db.Developers.Add(newDev);

        return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId }, newDev);
    }

}




