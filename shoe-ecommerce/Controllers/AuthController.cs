using Microsoft.AspNetCore.Mvc;

namespace shoe_ecommerce.Controllers;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}