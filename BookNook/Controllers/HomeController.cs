using Microsoft.AspNetCore.Mvc;

namespace BookNook.Controllers;

public class HomeController : Controller
{
    // GET
    public string Index()
    {
        return "Hello World!";
    }
}