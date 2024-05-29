using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.Data;
using ToDo.Models;
using ToDo.Web.Models;

namespace ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var result = _context.Tags.ToList();
            return View(result);
        }


    }
}
