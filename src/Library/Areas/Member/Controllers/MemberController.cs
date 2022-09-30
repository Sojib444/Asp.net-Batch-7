using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
