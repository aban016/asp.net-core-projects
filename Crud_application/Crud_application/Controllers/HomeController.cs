using Crud_application.Model;
using Microsoft.AspNetCore.Mvc;

namespace Crud_application.Controllers
{
    public class HomeController : Controller
    {
        private myContext  db;

        public HomeController(myContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Students std)
        {
            db.tbl_students.Add(std);
            db.SaveChanges();
            return RedirectToAction("ShowList");
        }

        [HttpGet]
        public IActionResult ShowList()
        {
            var data = db.tbl_students.ToList();
            return View(data);
        }

        public IActionResult Delete(int id)
        {
            var row = db.tbl_students.Find(id);
            db.tbl_students.Remove(row);
            db.SaveChanges();
            return RedirectToAction("ShowList");
        }

        
        public IActionResult Update(int id)
        {
            var row = db.tbl_students.Find(id);
            return View(row);
        }
        [HttpPost]
        public IActionResult Update(Students std)
        {
            db.tbl_students.Update(std);
            db.SaveChanges();
            return RedirectToAction("ShowList");
        }
    }
}
