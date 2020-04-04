using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using market.Models;

namespace market.Controllers
{
    public class HomeController : Controller
    {
        ClothesContext db;
        public HomeController(ClothesContext context)
        {
            db = context;
            Console.WriteLine(db);
        }
        public IActionResult Index()
        {
            return View(db.Cloth);
        }
        public IActionResult ClothManager()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddItem([Bind("name,description,material,price,imageSrc")] Clothes cloth)
        {
            db.Cloth.Add(cloth);
            db.SaveChanges();
            return RedirectToAction(nameof(ClothManager));
        }
        public async Task<IActionResult> ShowItem(int? id)
        {
            var item = await db.Cloth.FindAsync(id);
            ViewData["id"] = id;
            ViewData["name"] = item.name;
            ViewData["description"] = item.description;
            ViewData["material"] = item.material;
            ViewData["price"] = item.price;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
