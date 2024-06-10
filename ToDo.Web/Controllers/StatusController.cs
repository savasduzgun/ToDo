using Microsoft.AspNetCore.Mvc;

namespace ToDo.Web.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
