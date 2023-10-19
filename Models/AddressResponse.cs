using System.ComponentModel.DataAnnotations;

namespace SaltAddressBookBackend.Models;
public class AddressResponse
{
    public int ID { get; set; }
    public string AddressLine { get; set; }
    public string Number { get; set; }
    public int PostCode { get; set; }
    public string City { get; set; }
    public int? ApartmentNo { get; set; }
    public Countries Country { get; set; }
    public Person Person { get; set; }
    public int PersonID {get; set;}
}