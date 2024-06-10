using Microsoft.AspNetCore.Mvc;
using ToDo.Data;
using ToDo.Models;

namespace ToDo.Web.Controllers
{
    public class StatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() //tek görevi index.cshtml adlı dosyayı göndermek burada
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return Json(_context.Statuses.ToList());
        }
        [HttpPost]
        public IActionResult Add(Status status)
        {
            _context.Statuses.Add(status);
            _context.SaveChanges();
            return Ok(status); //sayfanın yenilenmesini istemediğimiz için view göndermeyiz
        }
        [HttpPost]
        public IActionResult Update(Status status)
        {
            _context.Statuses.Update(status);
            _context.SaveChanges();
            return Ok(status);
        }
        [HttpPost]
        public IActionResult Delete(Status status)
        {
            _context.Statuses.Remove(status);
            _context.SaveChanges();
            return Ok(status);
        }
    }
}
