using System.ComponentModel.DataAnnotations;

namespace SaltAddressBookBackend.Models;
public class AddressRequest
{
    public int ID { get; set; }


    [Required(AllowEmptyStrings = false, ErrorMessage = "You need to provide an adress-line")]
    public string AddressLine { get; set; }


    [Required(AllowEmptyStrings = false, ErrorMessage = "You need to provide an adress number and/or letter")]
    public string Number { get; set; }


    [Required(AllowEmptyStrings = false, ErrorMessage = "You need to provide the postcode you live in")]
    public int PostCode { get; set; }


    [Required(AllowEmptyStrings = false, ErrorMessage = "You need to provide the city you live in")]
    public string City { get; set; }


    public int? ApartmentNo { get; set; }


    [Required(ErrorMessage = "You need to select the country where the address is")]
    public Countries Country { get; set; }

    public Person Person {get; set;}
    public int PersonID {get; set;}

}