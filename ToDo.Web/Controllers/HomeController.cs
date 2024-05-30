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
        public HomeController(ApplicationDbContext context)  //Dependency Injection ile ApplicationDbContext in nesnesini çekmiþ oluruz. new lemiyoruz çünkü program ilk çalýþtýðýnda otomatikman program.cs bizim için new                                                         liyor ve kullanýma hazýr olan objeyi dependencey injection ile controller a gönderiyor ve bu nesneyi bütün yazýlýmýn genelinde kullanabiliyoruz.
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Tag tag = new Tag { Name = "Yazýlým" };
            //_context.Tags.Add(tag);

            //List<Tag> tags = new List<Tag>();
            //tags.Add(new Tag { Name = "Rutin" });
            //tags.Add(new Tag { Name = "Ödev" });
            //tags.Add(new Tag { Name = "Ev Ýþi" });

            //_context.Tags.AddRange(tags);  //Birden fazla veri eklemek için
            //_context.SaveChanges();

            return View();
        }

    }
}
