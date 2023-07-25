using Microsoft.AspNetCore.Mvc;

namespace HospitalASystem.Controllers
{
    public class AdminController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
