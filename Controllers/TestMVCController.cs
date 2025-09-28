using Microsoft.AspNetCore.Mvc;

namespace TestCICD.Controllers
{
    public class TestMVCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
