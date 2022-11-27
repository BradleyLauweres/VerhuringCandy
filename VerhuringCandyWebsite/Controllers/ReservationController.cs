using Microsoft.AspNetCore.Mvc;

namespace VerhuringCandyWebsite.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        
        }
    }
}
