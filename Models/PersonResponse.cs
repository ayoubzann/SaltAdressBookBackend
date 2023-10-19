using System.ComponentModel.DataAnnotations;

namespace SaltAddressBookBackend.Models;
public class PersonResponse
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Countries Country { get; set; }
    public List<Address>? Addresses {get; set;}
}