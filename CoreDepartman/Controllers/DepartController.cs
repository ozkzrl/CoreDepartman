using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
           var values=c.Departmanlars.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departmanlar d)
        {
            c.Departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil( int id)
        {
            var values=c.Departmanlars.Find(id);
            c.Departmanlars.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DepartmanGetir(int id)
        {
            var values = c.Departmanlars.Find(id);
            return View("DepartmanGetir",values);

        }
        public IActionResult DepartmanGuncelle(Departmanlar d)
        {
            var dep = c.Departmanlars.Find(d.id);
            dep.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
