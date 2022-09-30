using Autofac;
using Infrastructure.Service;
using Library.Areas.Admin.Models;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Exam1_2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly IBookService _service;
        public HomeController(ILifetimeScope scope, IBookService service)
        {
            _scope = scope;
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BookCreate(){

            Book student = _scope.Resolve<Book>();
            return View(student);             
        }
        [HttpPost]
        public async  Task<IActionResult> BookCreate(Book book)
        {
            if(ModelState.IsValid)
            {
                book.ResolveDependency(_scope);
               await book.CreateStudent();
                ViewBag.Massage1 = "Form Created SuccessFully";
                return View();
            }
            else
            {
                ViewBag.Massage = "Please Input all Field";
                return View();
            }
            
        }

        public IActionResult GetData(HttpRequest request)
        {
            var ajaxmodel = new DataTableAjaxModel(request);
            var model = _scope.Resolve<BookList>();
            return Json(model.GetJson(ajaxmodel));

        }

 

    }
}
