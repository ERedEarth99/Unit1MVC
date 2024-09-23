using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit1MVC.Models;

namespace Unit1MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var displays = new List<Display>
            {
            new Display { Title = "CE", ImageFileName = "A1.png" },
            new Display { Title = "TA", ImageFileName = "A2.png" },
            new Display { Title = "SF", ImageFileName = "P1.png" },
            new Display { Title = "CT", ImageFileName = "P2.png" }
        };
            return View(displays);
        }
    }
}
