using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using ToDo.Models;
using ToDo.Models.ViewModels;

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
            //TagListVM vm = new TagListVM();
            //vm.Tags = _context.Tags.ToList();
            //return View(vm);

            return View(new TagListVM { Tags = _context.Tags.ToList() });
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

        [HttpPost]
        public IActionResult Add(Tag tag) 
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        { 
            return View(_context.Tags.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Tag tag)
        {
            _context.Tags.Update(tag);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
