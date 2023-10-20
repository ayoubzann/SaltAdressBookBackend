using Microsoft.AspNetCore.Mvc;
using SaltAddressBookBackend.Models;

namespace SaltAddressBookBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    private Db _db;

    public PersonController(Db db)
    {
        _db = db;
    }

    [HttpGet]
    public List<PersonResponse> GetAllPeople()
    {
        var Persons = _db.People;

        var PeopleResponse = _db.People.Select(p => new PersonResponse
        {
            ID = p.ID,
            FirstName = p.FirstName,
            LastName = p.LastName,
            Age = p.Age,
            Country = p.Country,
            Gender = p.Gender,
        }).ToList();

        return PeopleResponse;
    }

    [HttpGet("{id}")]
    public IActionResult GetPersonById(int id)
    {
        var Person = _db.People.Find(p => p.ID == id);

        if (Person != null)
        {
            return Ok(Person);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult CreatePerson(PersonRequest request)
    {
        var newID = _db.People.Count();

        var newPerson = new Person(){
            ID = newID,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Age = request.Age,
            Country = request.Country,
            Gender = request.Gender,
        };

        _db.People.Add(newPerson);

         return CreatedAtAction(nameof(GetPersonById), new { id = newID }, newPerson);

    }

}
