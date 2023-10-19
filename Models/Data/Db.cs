using System.Collections.Generic;

namespace SaltAddressBookBackend.Models;

public class Db
{
    public Db()
    {
        People = new List<Person>
        {
            new Person
            {
                ID = 0,
                FirstName = "Ayoub",
                LastName = "Zannachi",
                Age = 21,
                Gender = Gender.Male,
                Country = Countries.Norway
            },
            new Person
            {
                ID = 1,
                FirstName = "Lauren",
                LastName = "Zayas Holmen",
                Age = 22,
                Gender = Gender.Female,
                Country = Countries.Sweden
            },
            new Person
            {
                ID = 2,
                FirstName = "Alero",
                LastName = "Ingunn Oritseweyimi",
                Age = 24,
                Gender = Gender.NonBinary,
                Country = Countries.Norway
            }
        };

        Addresses = new List<Address>
        {
            new Address
            {
                ID = 0,
                AddressLine = "Drammensveien",
                Number = "116 F",
                PostCode = 0273,
                City = "Oslo",
                Country = Countries.Norway,
                Person = People[0],
                PersonID = People[0].ID

            },
            new Address
            {
                ID = 1,
                AddressLine = "Tante Ulrikkes vei",
                Number = "79",
                PostCode = 0987,
                City = "Oslo",
                Country = Countries.Norway,
                Person = People[0],
                PersonID = People[0].ID
            },
            new Address
            {
                ID = 2,
                AddressLine = "Uppsalavegen",
                Number = "2 C",
                PostCode = 01123,
                City = "Uppsala",
                Country = Countries.Sweden,
                Person = People[1],
                PersonID = People[1].ID
            },
            new Address
            {
                ID = 3,
                AddressLine = "Rue de Cirque",
                Number = "14 C",
                PostCode = 919911,
                City = "Paris",
                Country = Countries.France,
                Person = People[2],
                PersonID = People[2].ID
            }
        };

       
    }

    public List<Person> People { get; set; }
    public List<Address> Addresses { get; set; }
}
