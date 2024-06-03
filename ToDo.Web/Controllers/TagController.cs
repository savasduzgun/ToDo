using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using ToDo.Models;

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
        public IActionResult Delete(int id)
        {
            Tag tag = _context.Tags.Find(id);
            if (tag != null)
            {
                _context.Tags.Remove(tag);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteAjax(Tag tag) 
        {
            _context.Tags.Remove(tag);
            _context.SaveChanges();
            return Ok("İşlem başarılı");
        }
    }
}
