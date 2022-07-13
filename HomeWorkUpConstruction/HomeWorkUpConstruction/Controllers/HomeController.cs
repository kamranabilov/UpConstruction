using HomeWorkUpConstruction.DAL;
using HomeWorkUpConstruction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkUpConstruction.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Blog()
        {
            List<Blog> blogs = _context.Blogs.Include(x=>x.Branch).ToList();
            return View(blogs);
        }

        public IActionResult BlogDetail(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            Blog blog = _context.Blogs.Include(x=>x.Comments).FirstOrDefault(i => i.Id == id);
            return View(blog);
        }
       
    }
}
