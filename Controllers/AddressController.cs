using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace SaltAddressBookBackend.Controllers;

public class AddressController : Controller {
    private Db _db;

    public AddressController(Db db)
    {
        _db = db;
    }

}