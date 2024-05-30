using Microsoft.AspNetCore.Mvc;
using ToDo.Data;

namespace ToDo.Web.Controllers
{
    public class TagController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TagController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Tags.ToList());
        }
    }
}
