using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MustacheEnt.DAL;
using MustacheEnt.Models;
using MustacheEnt.ViewModel;

namespace MustacheEnt.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            BlogViewModel BlogVM = new BlogViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                MenuPage = "Blog",
                Blogs = _context.Blogs.OrderBy(x=>x.Id).ToList()
            };
            return View(BlogVM);
        }

        public IActionResult BlogSinglePost(int id)
        {
            Blog blog = _context.Blogs.FirstOrDefault(x => x.Id == id);
            if (blog == null)
            {
                return RedirectToAction("Index");
            }

            BlogViewModel blogVM = new BlogViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                MenuPage = "Blog",
                SingleBlog = blog
            };
            return View(blogVM);
        }
    }
}