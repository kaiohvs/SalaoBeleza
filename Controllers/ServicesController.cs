using Microsoft.AspNetCore.Mvc;

namespace SalaoBeleza.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Haircut()
        {
            return View();
        }

        public IActionResult Manicure()
        {
            return View();
        }

        public IActionResult SkinTreatment()
        {
            return View();
        }
        public IActionResult Pedicure()
        {
            return View();
        }
        public IActionResult HairStraightening()
        {
            return View();
        }
        public IActionResult HairTreatment()
        {
            return View();
        }
    }
}
