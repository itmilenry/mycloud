using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mycloud.Models;
using System.Collections.Generic;
using System.Linq;

namespace mycloud.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var context = new Models.mycloudContext())
            {
                var model = await context.Products
                    .Include("Insulator")
                    .Include("Conductor")
                    .Include("Design")
                    .Include("Restriction")
                    .Include("Country")
                    .Include("CprClass")
                    .Include("VoltageClass")
                    .Include("CableRange")                    
                    .ToListAsync();
                return View(model);
            }
        }  




        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName")] Product product)
        {
            using ( var context = new Models.mycloudContext())
            {
                //context.Add(author);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}