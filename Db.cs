using SaltAddressBookBackend.Models;

namespace SaltAddressBookBackend;
public class Db
{
    public Db()
    {
        People = new List<Person>
        {
            new Person
            {
                FirstName = "Ayoub",
                LastName = "Zannachi",
                Age = 21,
                Gender = Gender.Male,
                Country = Countries.Norway,
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressLine = "Drammensveien",
                        Number = "116 F",
                        PostCode = 0273,
                        City = "Oslo",
                        Country = Countries.Norway
                    },
                    new Address
                    {
                        AddressLine = "Tante Ulrikkes vei",
                        Number = "79",
                        PostCode = 0987,
                        City = "Oslo",
                        Country = Countries.Norway
                    }
                }
            },
            new Person
            {
                FirstName = "Lauren",
                LastName = "Zayas Holmen",
                Age = 22,
                Gender = Gender.Female,
                Country = Countries.Sweden,
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressLine = "Uppsalavegen",
                        Number = "2 C",
                        PostCode = 01123,
                        City = "Uppsala",
                        Country = Countries.Sweden
                    }
                }
            },
            new Person
            {
                FirstName = "Alero",
                LastName = "Ingunn Oritseweyimi",
                Age = 24,
                Gender = Gender.NonBinary,
                Country = Countries.Norway,
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressLine = "Rue de Cirque",
                        Number = "14 C",
                        PostCode = 919911,
                        City = "Paris",
                        Country = Countries.France
                    }
                }
            }
        };
    }

    public List<Person> People { get; set; }
}
