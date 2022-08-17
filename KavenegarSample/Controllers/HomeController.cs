using KavenegarSample.Services;
using KavenegarSample.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace KavenegarSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISMSService _smsService;

        public HomeController(ISMSService smsService)
        {
            _smsService = smsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SendPublicSMS()
        {
            var message = @"
                کاربر گرامی
                هم اکنون میتوانی از تخفیف های آخر هفته استفاده کنی.
            ";

            await _smsService.SendPublicSMS("09001377516", message);

            return Redirect("/");
        }

        public async Task<IActionResult> SendLookupSMS()
        {
            await _smsService.SendLookupSMS("09001377516", "ContactUsVerification", "محمد", Generator.RandomNumber());

            return Redirect("/");
        }
    }
}