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
        public HomeController(ApplicationDbContext context)  //Dependency Injection ile ApplicationDbContext in nesnesini �ekmi� oluruz. new lemiyoruz ��nk� program ilk �al��t���nda otomatikman program.cs bizim i�in new                                                         liyor ve kullan�ma haz�r olan objeyi dependencey injection ile controller a g�nderiyor ve bu nesneyi b�t�n yaz�l�m�n genelinde kullanabiliyoruz.
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Tag tag = new Tag { Name = "Yaz�l�m" };
            //_context.Tags.Add(tag);

            //List<Tag> tags = new List<Tag>();
            //tags.Add(new Tag { Name = "Rutin" });
            //tags.Add(new Tag { Name = "�dev" });
            //tags.Add(new Tag { Name = "Ev ��i" });

            //_context.Tags.AddRange(tags);  //Birden fazla veri eklemek i�in
            //_context.SaveChanges();

            return View();
        }

    }
}
