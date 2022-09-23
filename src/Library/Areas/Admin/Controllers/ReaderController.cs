using Autofac;
using Infrastructure.Service;
using Library.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReaderController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly IReaderService _service;
        public ReaderController(ILifetimeScope scope, IReaderService service)
        {
            _scope = scope;
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ReaderCreate()
        {

            Reader student = _scope.Resolve<Reader>();
            return View(student);
        }
        [HttpPost]
        public async Task<IActionResult> ReaderCreate(Reader reader)
        {
            if (ModelState.IsValid)
            {
                reader.ResolveDependency(_scope);
                await reader.CreateReader();
                ViewBag.Massage1 = "Form Created SuccessFully";
                return View();
            }
            else
            {
                ViewBag.Massage = "Please Input all Field";
                return View();
            }

        }
    }
}
