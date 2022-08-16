using Microsoft.AspNetCore.Mvc;

namespace KavenegarSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SendPublicSMS()
        {
            return Redirect("/");
        }

        public async Task<IActionResult> SendLookupSMS()
        {
            return Redirect("/");
        }
    }
}