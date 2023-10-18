using System.ComponentModel.DataAnnotations;

namespace SaltAddressBookBackend.Models;

public enum Gender
{
    Male,
    Female,
    NonBinary,
    Other

}
public class Person
{

    public int ID { get; set; }


    [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
    public string FirstName { get; set; }


    [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
    public string LastName { get; set; }


    [Required(ErrorMessage = "Age is required")]
    public int Age { get; set; }


    [Required(ErrorMessage = "Please select a gender")]
    public Gender Gender { get; set; }


    [Required(ErrorMessage = "Select your country of citizenship")]
    public Countries Country { get; set; }

    public List<Address>? Addresses {get; set;}
}