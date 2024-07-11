using Microsoft.AspNetCore.Mvc;

namespace ToDo.Web.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
