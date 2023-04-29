using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_intro.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int[] nums = { 4, 6, 8, 9, 11, 13, 14 };
            return View(nums);
        }
    }
}