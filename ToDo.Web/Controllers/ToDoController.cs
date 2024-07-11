using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Web.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToDoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll() 
        {
            //var result = _context.Todos.Include(t=>t.Status).Include(t=>t.Tags).ToList();

            var result2 = _context.Todos.Select(t=> new Todo
            { 
                Id = t.Id,
                Name = t.Name,
                Status = t.Status, 
                Description = t.Description,
                Tags = t.Tags 
            });
            return Json(new {data = result2});

        }
    }
}
