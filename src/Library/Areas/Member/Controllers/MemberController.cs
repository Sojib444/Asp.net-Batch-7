using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Member.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
