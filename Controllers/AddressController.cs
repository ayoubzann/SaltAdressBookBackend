using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using SaltAddressBookBackend.Models;

namespace SaltAddressBookBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private Db _db;

    public AddressController(Db db)
    {
        _db = db;
    }

    [HttpGet]
    public List<AddressResponse> GetAllAddresses()
    {
        var Addresses = _db.Addresses;

        var AddressResponse = _db.Addresses.Select(adr => new AddressResponse
        {
            ID = adr.ID,
            AddressLine = adr.AddressLine,
            Number = adr.Number,
            PostCode = adr.PostCode,
            City = adr.City,
            ApartmentNo = adr.ApartmentNo,
            Country = adr.Country,
            Person = adr.Person,
            PersonID = adr.PersonID
            
        }).ToList();

        return AddressResponse;

    }

    [HttpGet("{id}")]
    public IActionResult GetAddressById(int id)
    {
        var Address = _db.Addresses;


        var adr = _db.Addresses.Find(adr => id == adr.ID);

        if (adr == null)
        {
            return NotFound();
        }

        var response = new AddressResponse
        {
            ID = adr.ID,
            AddressLine = adr.AddressLine,
            Number = adr.Number,
            PostCode = adr.PostCode,
            City = adr.City,
            ApartmentNo = adr.ApartmentNo,
            Country = adr.Country,
            Person = adr.Person,
            PersonID = adr.PersonID
        };

        return Ok(response);
    }
}