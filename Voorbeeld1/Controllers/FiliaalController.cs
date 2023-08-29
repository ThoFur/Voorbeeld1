using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Voorbeeld1.Models;

namespace Voorbeeld1.Controllers
{
    public class FiliaalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
